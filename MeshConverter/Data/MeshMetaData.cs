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
        public Image Preview { get; set; }

		public long FileSize { get; set; }

		public int VertexCount { get; set; }

        public int FaceCount { get; set; }
    }
}
