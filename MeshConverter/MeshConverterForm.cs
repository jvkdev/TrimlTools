using MeshConverter.Controls;
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

namespace MeshConverter
{
    public partial class MeshConverterForm : Form
    {


        public MeshConverterForm()
        {
            InitializeComponent();

            browserLeft.SelectionChanged += BrowserLeft_SelectionChanged;
        }


        private void MeshExplorer_Load(object sender, EventArgs e)
        {
            //BrowseToPath(textPath.Text);
        }

        private void textReductionTargetTriangle_TextChanged(object sender, EventArgs e)
        {
            textReductionFileSuffix.Text = "_" + textReductionTargetTriangle.Text;
        }


        private void BrowserLeft_SelectionChanged(object sender, EventArgs e)
        {
            textReductionTargetTriangle.Text = browserLeft.MinSelectedTriangleCount.ToString();
        }

        private void btnMeshReductionGo_Click(object sender, EventArgs e)
        {
            float.TryParse(textReductionTargetTriangle.Text, out float quality);
            if (quality <= 0.0f) { quality = 1.0f; }

            foreach (string f in browserLeft.SelectedFilePaths)
            {
                string newFilePath = Path.Combine(browserRight.CurrentPath,
                    Path.GetFileNameWithoutExtension(f) + textReductionFileSuffix.Text + Path.GetExtension(f));


                MeshDecimatorTool.Commands.ReduceObjMesh(f, newFilePath, quality);
            }

            browserRight.BrowseToPath(browserRight.CurrentPath, refresh: true);
        }
    }
}
