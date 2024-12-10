using MeshConverter.Controls;
using MeshConverter.Data;
using MeshConverter.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeshConverter
{
	public partial class MeshConverterForm : Form
	{
		private Timer uiTimer = new Timer();

		public MeshConverterForm()
		{
			InitializeComponent();

			uiTimer.Interval = 100;
			uiTimer.Tick += UiTimer_Tick;

			browserLeft.SelectionChanged += BrowserLeft_SelectionChanged;
			browserRight.SelectionChanged += BrowserRight_SelectionChanged;
		}

		private void MeshExplorer_Load(object sender, EventArgs e)
		{
			//BrowseToPath(textPath.Text);
		}

		private void UiTimer_Tick(object sender, EventArgs e)
		{
			if (status != null)
			{
				if (status.InProgress)
				{
					labelStatusText.Text = status.Text;
					if (progressStatus.Value > status.MaxProgress) { progressStatus.Value = 0; }
					progressStatus.Maximum = status.MaxProgress;
					progressStatus.Value = status.CurrentProgress;
				}
				else
				{
					uiTimer.Stop();
				}
				tableStatus.Visible = status.InProgress;
			}
		}

		private void textReductionTargetTriangle_TextChanged(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(textReductionTargetTriangle.Text))
			{
				textNameSuffix.Text = "_" + textReductionTargetTriangle.Text;
			}
			else
			{
				textNameSuffix.Text = "";
			}
		}


		private void BrowserLeft_SelectionChanged(object sender, EventArgs e)
		{

		}

		private void BrowserRight_SelectionChanged(object sender, EventArgs e)
		{
			if (browserRight.MinSelectedTriangleCount > 0)
			{
				textReductionTargetTriangle.Text = browserRight.MinSelectedTriangleCount.ToString();
			}
			else
			{
				textReductionTargetTriangle.Text = "";
			}
		}


		private StatusIndicator status = new StatusIndicator();

		private class CopyArgs
		{
			public StatusIndicator Status { get; set; }

			public string[] FromPaths { get; set; }

			public string ToFolder { get; set; }

			public string NameSuffix { get; set; }

			public bool IncludeSubFolders { get; set; } = false;

			public int MaxFilesPerFolder { get; set; } = -1;

			public bool RandomlySelectFilesToCopy { get; set; } = false;

			public float MaxTriangleCountOrRatio { get; set; } = -1;
		}

		private enum CopyStage
		{
			Count,
			Copy
		}

		private void btnMeshReductionGo_Click(object sender, EventArgs e)
		{
			btnCopy.Enabled = false;

			CopyArgs copyArgs = new CopyArgs
			{
				Status = status,
				FromPaths = browserLeft.SelectedFilePaths,
				ToFolder = browserRight.CurrentPath,
				NameSuffix = checkAddNameSuffix.Checked ? textNameSuffix.Text : "",
				IncludeSubFolders = checkIncludeSubFolders.Checked
			};

			bool includeSubFolders = checkIncludeSubFolders.Checked;
			int maxFilesPerFolder = -1;
			float maxTriangleCount = -1;

			if (checkLimitFilesPerFolder.Checked)
			{
				int.TryParse(textMaxFilesPerFolder.Text, out maxFilesPerFolder);
				copyArgs.RandomlySelectFilesToCopy = checkRandomFiles.Checked;
			}

			if (checkMeshReduction.Checked)
			{
				float.TryParse(textReductionTargetTriangle.Text, out maxTriangleCount);
				if (maxTriangleCount == 0.0f) { maxTriangleCount = 1.0f; }
			}

			copyArgs.MaxFilesPerFolder = maxFilesPerFolder;
			copyArgs.MaxTriangleCountOrRatio = maxTriangleCount;

			BackgroundWorker copyWorker = new BackgroundWorker();
			copyWorker.DoWork += CopyWorker_DoWork;
			copyWorker.RunWorkerCompleted += CopyWorker_RunWorkerCompleted;
			copyWorker.RunWorkerAsync(copyArgs);
			uiTimer.Start();
		}



		private static void CopyWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			CopyArgs copyArgs = e.Argument as CopyArgs;

			copyArgs.Status.ResetAndStart();

			HashSet<string> fromPaths = new HashSet<string>(copyArgs.FromPaths);

			int totalCount = 0;
			foreach (string f in fromPaths)
			{
				totalCount += CopyRecursive(f, copyArgs.ToFolder, copyArgs, CopyStage.Count);
			}

			foreach (string f in fromPaths)
			{
				totalCount += CopyRecursive(f, copyArgs.ToFolder, copyArgs, CopyStage.Copy);
			}
		}

		private void CopyWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			browserRight.BrowseToPath(browserRight.CurrentPath, refresh: true);
			status.SetCompleted();
			btnCopy.Enabled = true;
		}


		private static int CopyRecursive(string fromPath, string toFolder, CopyArgs copyArgs, CopyStage stage)
		{
			int count = 0;
			if (copyArgs.Status.CancelRequested)
			{
				return count;
			}

			copyArgs.Status.Text = Path.GetFileName(fromPath);
			if (stage == CopyStage.Count) { copyArgs.Status.MaxProgress++; }

			if (Directory.Exists(fromPath))
			{
				string newDirPath = Path.Combine(toFolder, Path.GetFileName(fromPath));
				if (!Directory.Exists(newDirPath) && stage == CopyStage.Copy)
				{
					Directory.CreateDirectory(newDirPath);
				}
				int filesCopied = 0;

				List<string> originalFiles = new List<string>(Directory.GetFiles(fromPath));
				List<string> filesToCopy = new List<string>();
				if (copyArgs.MaxFilesPerFolder <= 0)
				{
					filesToCopy = originalFiles;
				}
				else
				{
					Random rnd = new Random();

					while (filesToCopy.Count < copyArgs.MaxFilesPerFolder && originalFiles.Count > 0)
					{
						int i = copyArgs.RandomlySelectFilesToCopy
							? rnd.Next(originalFiles.Count - 1)
							: 0;
						filesToCopy.Add(originalFiles[i]);
						originalFiles.RemoveAt(i);
					}
				}

				filesToCopy.Sort();

				foreach (string file in filesToCopy)
				{
					count += CopyRecursive(file, newDirPath, copyArgs, stage: stage);
					if (++filesCopied >= copyArgs.MaxFilesPerFolder) { break; }
				}

				if (copyArgs.IncludeSubFolders)
				{
					foreach (string dir in Directory.GetDirectories(fromPath))
					{
						count += CopyRecursive(dir, newDirPath, copyArgs, stage: stage);
					}
				}

			}
			else if (File.Exists(fromPath))
			{
				count++;

				if (stage == CopyStage.Copy)
				{
					string newFilePath = Path.Combine(toFolder,
						Path.GetFileNameWithoutExtension(fromPath) + copyArgs.NameSuffix + Path.GetExtension(fromPath));

					if (copyArgs.MaxTriangleCountOrRatio > 10)
					{
						MeshDecimatorTool.Commands.ReduceObjMesh(fromPath, newFilePath, copyArgs.MaxTriangleCountOrRatio);
					}
					else if (!File.Exists(newFilePath) && stage == CopyStage.Copy)
					{
						File.Copy(fromPath, newFilePath);
					}
					copyArgs.Status.CurrentProgress++;
				}
			}

			return count;
		}

		private void checkAddNameSuffix_CheckedChanged(object sender, EventArgs e)
		{
			labelNameSuffix.Visible = textNameSuffix.Visible = checkAddNameSuffix.Checked;
		}

		private void checkMeshReduction_CheckedChanged(object sender, EventArgs e)
		{
			labelTriangles.Visible = textReductionTargetTriangle.Visible = checkMeshReduction.Checked;
		}

		private void checkLimitFilesPerFolder_CheckedChanged(object sender, EventArgs e)
		{
			labelMaxPerFolder.Visible = textMaxFilesPerFolder.Visible = checkLimitFilesPerFolder.Checked;
			checkRandomFiles.Visible = checkLimitFilesPerFolder.Checked;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			status.Cancel();
		}
	}
}

