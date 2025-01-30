using MeshConverter.Data;
using MeshConverter.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeshConverter.Controls
{
	public partial class MeshBrowser : UserControl
	{
		private Timer longClickTimer = new Timer();
		private int lastMouseDownRow = -1;


		public string CurrentPath { get; private set; }

		public string[] SelectedFilePaths { get; private set; }


		public int MinFolderTriangleCount { get; private set; } = 0;

		public int MinSelectedTriangleCount { get; private set; } = 0;



		public MeshBrowser()
		{
			InitializeComponent();

			longClickTimer.Interval = 200;
			longClickTimer.Tick += LongClickTimer_Tick;

			gridMeshes.AutoGenerateColumns = false;

			//gridMeshes.ColumnStateChanged += GridMeshes_ColumnStateChanged;
		}



		//private void GridMeshes_ColumnStateChanged(object sender, DataGridViewColumnStateChangedEventArgs e)
		//{
		//	DataGridView dataGridView = (DataGridView)sender;
		//	//Only update for full row selection mode.
		//	if (dataGridView.SelectionMode == DataGridViewSelectionMode.FullRowSelect)
		//	{
		//		e.Column.HeaderCell.Style.SelectionBackColor = dataGridView.ColumnHeadersDefaultCellStyle.BackColor;
		//	}
		//}

		public event EventHandler SelectionChanged;



		private void MeshBrowser_Load(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(textPath.Text))
			{
				BrowseToPath(textPath.Text, refresh: true);
			}
		}


		private void textPath_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				BrowseToPath(textPath.Text, refresh: true);
			}
		}


		public void BrowseToPath(string path, bool refresh = false)
		{
			if (CurrentPath == path && !refresh) { return; }

			if (textPath.Text != path)
			{
				textPath.Text = path;
			}

			if (Directory.Exists(path))
			{

				CurrentPath = path;

				LoadBrowseButtons(path);

				LoadMeshes(path);
			}
		}



		private void LoadBrowseButtons(string path)
		{
			foreach (Control c in flowFolders.Controls)
			{
				if (c is BrowseButton br)
				{
					br.Click -= BrowseButton_Click;
				}
			}
			flowFolders.Controls.Clear();

			//BrowseButton browseUp = new BrowseButton(Path.GetDirectoryName(path));
			//browseUp.Text = "..";
			//browseUp.Click += BrowseButton_Click;
			//flowFolders.Controls.Add(browseUp);

			string[] dirs = Directory.GetDirectories(path);
			foreach (string dir in dirs)
			{
				BrowseButton browseButton = new BrowseButton(dir);
				browseButton.Click += BrowseButton_Click;
				flowFolders.Controls.Add(browseButton);
			}
			flowFolders.Controls.Add(textNewFolder);
		}

		private void BrowseButton_Click(object sender, EventArgs e)
		{
			if (sender is BrowseButton br)
			{
				BrowseToPath(br.Url);
			}
		}


		private static Bitmap emptyImage = null;


		private void LoadMeshes(string path)
		{
			if (emptyImage == null)
			{
				emptyImage = new Bitmap(1, 1);
				Graphics graphics = Graphics.FromImage(emptyImage);
				graphics.Clear(Color.Transparent);
			}

			DataTable meshTable = new DataTable();
			meshTable.Columns.Add("Icon", typeof(Image));
			meshTable.Columns.Add("PreviewFront", typeof(Image));
			meshTable.Columns.Add("PreviewRight", typeof(Image));
			meshTable.Columns.Add("PreviewTop", typeof(Image));
			meshTable.Columns.Add("FilePath");
			meshTable.Columns.Add("FileName");
			meshTable.Columns.Add("FileSize");
			meshTable.Columns.Add("VertexCount", typeof(int));
			meshTable.Columns.Add("FaceCount", typeof(int));

			string[] dirs = Directory.GetDirectories(path);

			{
				DataRow row = meshTable.NewRow();

				row["Icon"] = Properties.Resources.FolderClosedBlue128;
				row["PreviewFront"] = emptyImage;
				row["PreviewRight"] = emptyImage;
				row["PreviewTop"] = emptyImage;

				row["FilePath"] = Path.GetDirectoryName(path);
				row["FileName"] = Path.GetFileName("..");

				meshTable.Rows.Add(row);
			}

			foreach (string dirPath in dirs)
			{
				DataRow row = meshTable.NewRow();

				row["Icon"] = Properties.Resources.FolderClosedBlue128;
				row["PreviewFront"] = emptyImage;
				row["PreviewRight"] = emptyImage;
				row["PreviewTop"] = emptyImage;

				row["FilePath"] = dirPath;
				row["FileName"] = Path.GetFileName(dirPath);

				meshTable.Rows.Add(row);
			}



			string[] files = Directory.GetFiles(path, "*.obj");

			foreach (string filePath in files)
			{
				DataRow row = meshTable.NewRow();

				row["Icon"] = Properties.Resources.ModelThreeD;
				row["PreviewFront"] = Properties.Resources.ModelThreeD;
				row["PreviewRight"] = Properties.Resources.ModelThreeD;
				row["PreviewTop"] = Properties.Resources.ModelThreeD;

				row["FilePath"] = filePath;
				row["FileName"] = Path.GetFileName(filePath);

				meshTable.Rows.Add(row);
			}

			gridMeshes.DataSource = meshTable;

			LoadMeshMetaDataAsync(meshTable);
		}


		private void LoadMeshMetaDataAsync(DataTable meshTable)
		{
			BackgroundWorker loadMeshMetaDataWorker = new BackgroundWorker();
			loadMeshMetaDataWorker.DoWork += LoadMeshMetaDataWorker_DoWork;
			loadMeshMetaDataWorker.RunWorkerCompleted += LoadMeshMetaDataWorker_RunWorkerCompleted;
			loadMeshMetaDataWorker.RunWorkerAsync(new object[] { meshTable });
		}

		private void LoadMeshMetaDataWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			object[] args = e.Argument as object[];
			DataTable meshTable = args[0] as DataTable;

			foreach (DataRow row in meshTable.Rows)
			{
				string filePath = row["FilePath"] as string;

				if (!String.IsNullOrEmpty(filePath) && File.Exists(filePath))
				{
					string metaDataFilePath = filePath + ".meta";

					MeshMetaData md = null;

					if (File.Exists(metaDataFilePath))
					{
						//md = XmlTools.Deserialize<MeshMetaData>(metaDataFilePath, "");
					}

					if (md == null)
					{
						md = new MeshMetaData();

						ObjFile objFile = ObjFile.Load(filePath);
						//Bitmap bmp = objFile.Preview(600, 600, ObjFile.PreviewDirection.Front) as Bitmap;
						//bmp.Save(objFile.FilePath + ".png", System.Drawing.Imaging.ImageFormat.Png);

						if (objFile.FaceCount > 0)
						{
							md.PreviewLeft = objFile.Preview(128, 128, ObjFile.PreviewDirection.Left);
							md.PreviewFront = objFile.Preview(128, 128, ObjFile.PreviewDirection.Front);
							md.PreviewRight = objFile.Preview(128, 128, ObjFile.PreviewDirection.Right);
							md.PreviewTop = objFile.Preview(128, 128, ObjFile.PreviewDirection.Top);
						}
						else
						{
							md.PreviewLeft = md.PreviewFront = md.PreviewRight = md.PreviewTop = Properties.Resources.ModelThreeD;
						}

						md.FileSize = objFile.FileSize;
						md.VertexCount = objFile.VertexCount;
						md.FaceCount = objFile.FaceCount;
					}

					row["Icon"] = md.PreviewLeft;
					row["PreviewFront"] = md.PreviewFront;
					row["PreviewRight"] = md.PreviewRight;
					row["PreviewTop"] = md.PreviewTop;

					row["FileSize"] = md.FileSize.ToSizeString();
					row["VertexCount"] = md.VertexCount;
					row["FaceCount"] = md.FaceCount;
				}
			}

			e.Result = args;
		}

		private void LoadMeshMetaDataWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			object[] result = e.Result as object[];
			DataTable meshTable = result[0] as DataTable;

			int minFaceCount = int.MaxValue;
			foreach (DataRow row in meshTable.Rows)
			{
				int faceCount = (int)((row["FaceCount"] ?? 0) == DBNull.Value ? 0 : row["FaceCount"]);
				minFaceCount = Math.Min(minFaceCount, faceCount);
			}

			minFaceCount = Math.Min(minFaceCount, 10000);
		}


		private void btnBrowse_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			dialog.SelectedPath = textPath.Text;

			dialog.ShowDialog();

			BrowseToPath(dialog.SelectedPath);
		}

		private void browseUp_Click(object sender, EventArgs e)
		{
			BrowseToPath(Path.GetDirectoryName(CurrentPath));
		}

		private void textNewFolder_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				try
				{
					string newFolderName = Path.Combine(CurrentPath, textNewFolder.Text);

					Directory.CreateDirectory(newFolderName);

					textNewFolder.Text = "";
					BrowseToPath(CurrentPath, refresh: true);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void gridMeshes_SelectionChanged(object sender, EventArgs e)
		{
			List<string> selectedFilePaths = new List<string>();

			int minTriangle = int.MaxValue;

			foreach (DataGridViewCell cell in gridMeshes.SelectedCells)
			{
				var gridRow = cell.OwningRow;
				DataRow dataRow = (gridRow.DataBoundItem as DataRowView).Row;

				if (dataRow != null)
				{
					selectedFilePaths.Add((dataRow["FilePath"] ?? "").ToString());

					int triangles = (int)((dataRow["FaceCount"] ?? 0) == DBNull.Value ? 0 : dataRow["FaceCount"]);
					if (triangles < minTriangle) { minTriangle = triangles; }
				}
			}

			this.SelectedFilePaths = selectedFilePaths.ToArray();
			this.MinSelectedTriangleCount = minTriangle;

			if (SelectionChanged != null)
			{
				SelectionChanged(this, new EventArgs());
			}
		}

		private void gridMeshes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			RowClick(e.RowIndex, doubleClick: true);
		}

		private void RowClick(int rowIndex, bool doubleClick = false)
		{
			if (rowIndex >= 0 && rowIndex < gridMeshes.Rows.Count)
			{
				var gridRow = gridMeshes.Rows[rowIndex];
				DataRow dataRow = (gridRow.DataBoundItem as DataRowView).Row;

				if (dataRow != null)
				{
					string path = (dataRow["FilePath"] ?? "").ToString();

					if (!String.IsNullOrEmpty(path))
					{
						if (Directory.Exists(path))
						{
							BrowseToPath(path);
						}
						else if (File.Exists(path) && doubleClick)
						{
							System.Diagnostics.Process.Start(path);
						}
					}
				}
			}
		}


		private void gridMeshes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			RowClick(lastMouseDownRow);
		}


		private void LongClickTimer_Tick(object sender, EventArgs e)
		{
			longClickTimer.Stop();

			//RowClick(lastMouseDownRow);
		}

		private void gridMeshes_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			lastMouseDownRow = (int)e.RowIndex;
			longClickTimer.Start();
		}

		private void gridMeshes_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
		{
			longClickTimer.Stop();
			lastMouseDownRow = -1;
		}

		private void gridMeshes_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
		{
			longClickTimer.Stop();
			lastMouseDownRow = -1;
		}
	}
}
