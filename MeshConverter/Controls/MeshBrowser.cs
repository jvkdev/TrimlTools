using MeshConverter.Data;
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

namespace MeshConverter.Controls
{
    public partial class MeshBrowser : UserControl
    {
        public string CurrentPath { get; private set; }

        public string[] SelectedFilePaths { get; private set; }


        public int MinSelectedTriangleCount { get; private set; } = 0;


        public MeshBrowser()
        {
            InitializeComponent();

            gridMeshes.AutoGenerateColumns = false;
        }


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

            CurrentPath = path;

            LoadBrowseButtons(path);

            LoadMeshes(path);
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



        private void LoadMeshes(string path)
        {
            DataTable meshTable = new DataTable();
            meshTable.Columns.Add("Icon", typeof(Image));
            meshTable.Columns.Add("FilePath");
            meshTable.Columns.Add("FileName");
            meshTable.Columns.Add("Points", typeof(int));
            meshTable.Columns.Add("Triangles", typeof(int));

            string[] dirs = Directory.GetDirectories(path);

            foreach (string dirPath in dirs)
            {
                DataRow row = meshTable.NewRow();

                row["Icon"] = Properties.Resources.FolderClosedBlue;
                row["FilePath"] = dirPath;
                row["FileName"] = Path.GetFileName(dirPath);

                meshTable.Rows.Add(row);
            }



            string[] files = Directory.GetFiles(path, "*.obj");

            foreach (string filePath in files)
            {
                DataRow row = meshTable.NewRow();

                row["Icon"] = Properties.Resources.ModelThreeD;
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
                        md.PointCount = objFile.VertexCount;
                        md.TriangleCount = objFile.FaceCount;
                    }

                    row["Points"] = md.PointCount;
                    row["Triangles"] = md.TriangleCount;
                }
            }
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

                    int triangles = (int)((dataRow["Triangles"] ?? 0) == DBNull.Value ? 0 : dataRow["Triangles"]);
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
            if (e.RowIndex >= 0)
            {
                var gridRow = gridMeshes.Rows[e.RowIndex];
                DataRow dataRow = (gridRow.DataBoundItem as DataRowView).Row;

                if (dataRow != null)
                {
                    string path = (dataRow["FilePath"] ?? "").ToString();

                    if (!String.IsNullOrEmpty(path) && Directory.Exists(path))
                    {
                        BrowseToPath(path);
                    }
                }
            }
        }
    }
}
