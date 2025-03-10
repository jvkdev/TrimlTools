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
                    progressStatus.Value = Math.Min(status.CurrentProgress, progressStatus.Maximum);
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

		private class MoveOrCopyArgs
		{
			public StatusIndicator Status { get; set; }

            public string[] FromPaths { get; set; }

            public string ToFolder { get; set; }

			public bool Move { get; set; } = false;

			public string NameSuffix { get; set; }

            public bool IncludeSubFolders { get; set; } = false;

            public int MaxFilesPerFolder { get; set; } = -1;

            public bool RandomlySelectFilesToCopy { get; set; } = false;

            public float MaxTriangleCountOrRatio { get; set; } = -1;

            public bool ImageGeneration { get; set; }
        }

        private enum CopyStage
        {
            Count,
            Copy
        }

		private void btnCopy_Click(object sender, EventArgs e)
		{
			btnCopy.Enabled = false;

			MoveOrCopyArgs copyArgs = new MoveOrCopyArgs
			{
				Status = status,
				FromPaths = browserLeft.SelectedFilePaths,
				ToFolder = browserRight.CurrentPath,
				//Move = radioMove.Checked,
				NameSuffix = checkAddNameSuffix.Checked ? textNameSuffix.Text : "",
				IncludeSubFolders = checkIncludeSubFolders.Checked,
				ImageGeneration = checkImageGeneration.Checked
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
			MoveOrCopyArgs args = e.Argument as MoveOrCopyArgs;

			args.Status.ResetAndStart();

			HashSet<string> fromPaths = new HashSet<string>(args.FromPaths);

			int totalCount = 0;
			foreach (string f in fromPaths)
			{
				totalCount += MoveOrCopyRecursive(f, args.ToFolder, args, CopyStage.Count);
			}

			foreach (string f in fromPaths)
			{
				totalCount += MoveOrCopyRecursive(f, args.ToFolder, args, CopyStage.Copy);
			}

			e.Result = args;
		}

		private void CopyWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			MoveOrCopyArgs args = e.Result as MoveOrCopyArgs;

			if (args.Move)
			{
				browserLeft.BrowseToPath(browserLeft.CurrentPath, refresh: true);
			}
			browserRight.BrowseToPath(browserRight.CurrentPath, refresh: true);
			status.SetCompleted();
			btnCopy.Enabled = true;
		}


		private static int MoveOrCopyRecursive(string fromPath, string toFolder, MoveOrCopyArgs args, CopyStage stage)
		{
			int count = 0;
			if (args.Status.CancelRequested)
			{
				return count;
			}

			args.Status.Text = Path.GetFileName(fromPath);
			if (stage == CopyStage.Count) { args.Status.MaxProgress++; }

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
				if (args.MaxFilesPerFolder <= 0)
				{
					filesToCopy = originalFiles;
				}
				else
				{
					Random rnd = new Random();

					while (filesToCopy.Count < args.MaxFilesPerFolder && originalFiles.Count > 0)
					{
						int i = args.RandomlySelectFilesToCopy
							? rnd.Next(originalFiles.Count - 1)
							: 0;
						filesToCopy.Add(originalFiles[i]);
						originalFiles.RemoveAt(i);
					}
				}

                filesToCopy.Sort();

				foreach (string file in filesToCopy)
				{
					count += MoveOrCopyRecursive(file, newDirPath, args, stage: stage);
					if (args.MaxFilesPerFolder > 0 && ++filesCopied >= args.MaxFilesPerFolder) { break; }
				}

				if (args.IncludeSubFolders)
				{
					foreach (string dir in Directory.GetDirectories(fromPath))
					{
						count += MoveOrCopyRecursive(dir, newDirPath, args, stage: stage);
					}
				}

            }
            else if (File.Exists(fromPath))
            {
                count++;

				if (stage == CopyStage.Copy)
				{
					string newFilePath = Path.Combine(toFolder,
						Path.GetFileNameWithoutExtension(fromPath) + args.NameSuffix + Path.GetExtension(fromPath));

					if (args.ImageGeneration)
					{
						ObjFile objFile = ObjFile.Load(fromPath);
						//Bitmap bmp = objFile.Preview(600, 600, ObjFile.PreviewDirection.Front) as Bitmap;
						//bmp.Save(objFile.FilePath + ".png", System.Drawing.Imaging.ImageFormat.Png);

						Bitmap bmp = objFile.GetMultiAnglePreviewImage(128, 128);
						bmp.Save(newFilePath + ".png", System.Drawing.Imaging.ImageFormat.Png);
					}
					else if (!args.Move && args.MaxTriangleCountOrRatio > 10)
					{
						MeshDecimatorTool.Commands.ReduceObjMesh(fromPath, newFilePath, args.MaxTriangleCountOrRatio);
					}
					else if (!File.Exists(newFilePath) && stage == CopyStage.Copy)
					{
						int retriesLeft = 5;
						while (retriesLeft-- > 0)
						{
							try
							{
								if (args.Move)
								{
									File.Move(fromPath, newFilePath);
								}
								else
								{
									File.Copy(fromPath, newFilePath);
								}
								break;
							}
							catch (Exception ex)
							{
								System.Threading.Thread.Sleep(100);
								if (retriesLeft == 0)
								{
									throw ex;
								}
							}
						}
					}
					args.Status.CurrentProgress++;
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

		private void radioCopy_CheckedChanged(object sender, EventArgs e)
		{
			bool move = radioMove.Checked;

			checkAddNameSuffix.Visible = !move;
			checkMeshReduction.Visible = !move;
			checkIncludeSubFolders.Visible = !move;
			checkLimitFilesPerFolder.Visible = !move;

			btnCopy.Text = move ? "Move >" : "Copy >";
		}
	}
}

