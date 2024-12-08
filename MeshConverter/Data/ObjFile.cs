using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeshConverter.Data
{
    public class ObjFile
    {
        public string FilePath { get; private set; }

        public int VertexCount { get; private set; }

        public int FaceCount { get; private set; }


        public ObjFile(string filePath)
        {
            this.FilePath = filePath;
        }


        public void Load()
        {
            string[] lines = File.ReadAllLines(this.FilePath);

            int vertexCount = 0;
            int faceCount = 0;
            foreach (string line in lines)
            {
                if (!String.IsNullOrEmpty(line))
                {
                    switch (line[0])
                    {
                        case 'v':
                            vertexCount++;
                            break;
                        case 'f':
                            faceCount++;
                            break;
                    }
                }
            }

            this.VertexCount = vertexCount;
            this.FaceCount = faceCount;
        }


        public static ObjFile Load(string filePath)
        {
            ObjFile f = new ObjFile(filePath);
            f.Load();
            return f;
        }
    }
}
