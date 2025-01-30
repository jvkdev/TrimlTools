using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeshConverter.Data
{
    public class MeshMetaData
    {
        public Image PreviewLeft { get; set; }

        public Image PreviewFront { get; set; }

        public Image PreviewRight { get; set; }

        public Image PreviewTop { get; set; }

        public long FileSize { get; set; }

        public int VertexCount { get; set; }

        public int FaceCount { get; set; }

        public string PredictedCategory { get; set; }

        public double CategoryCertainty { get; set; }
    }
}
