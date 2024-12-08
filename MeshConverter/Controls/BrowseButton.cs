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
    public partial class BrowseButton : Button
    {
        public string Url { get; set; }


        public BrowseButton()
        {
            InitializeComponent();
        }

        public BrowseButton(string url)
        {
            this.Url = url;

            InitializeComponent();

            try
            {
                this.Text = Path.GetFileName(url);
            }
            catch (Exception ex)
            {
                Text = (ex.Message ?? "").Substring(0, Math.Min((ex.Message ?? "").Length, 20));
            }
        }
    }
}
