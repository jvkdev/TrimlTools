using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeshConverter.Data
{
	public class ObjFace
	{

	}

	public class ObjFile
	{
		public string FilePath { get; private set; }

		public long FileSize { get; private set; }

		public int VertexCount { get; private set; }

		public int FaceCount { get; private set; }

		public List<Vector3> Vertices { get; private set; } = new List<Vector3>();

		public List<Vector2> VerticeUVCoordinates { get; private set; } = new List<Vector2>();

		public List<Vector3> VerticeNormals { get; private set; } = new List<Vector3>();

		public List<List<int>> FaceIndices { get; private set; } = new List<List<int>>();

		public List<List<int>> FaceUVIndices { get; private set; } = new List<List<int>>();

		public List<List<int>> FaceNormalIndices { get; private set; } = new List<List<int>>();


		public ObjFile(string filePath)
		{
			this.FilePath = filePath;
		}


		public void Load()
		{
			Vertices.Clear();
			FaceIndices.Clear();
			FaceUVIndices.Clear();
			FaceNormalIndices.Clear();

			if (!String.IsNullOrEmpty(FilePath) && File.Exists(FilePath))
			{
				this.FileSize = new FileInfo(this.FilePath).Length;

				string[] lines = File.ReadAllLines(this.FilePath);

				foreach (string line in lines)
				{
					if (!String.IsNullOrEmpty(line))
					{
						string[] parts = line.Split(' ');

						if (parts.Length > 0)
						{
							switch (parts[0])
							{
								case "v":
									if (parts.Length >= 4 &&
										float.TryParse(parts[1], NumberStyles.Number, CultureInfo.InvariantCulture, out float x) &&
										float.TryParse(parts[2], NumberStyles.Number, CultureInfo.InvariantCulture, out float y) &&
										float.TryParse(parts[3], NumberStyles.Number, CultureInfo.InvariantCulture, out float z))
									{
										Vertices.Add(new Vector3(x, y, z));
									}
									break;
								case "f":
									if (parts.Length >= 4)
									{
										List<int> indices = new List<int>();
										List<int> uvIndices = new List<int>();
										List<int> normalIndices = new List<int>();

										for (int i = 1; i < parts.Length; i++)
										{
											string[] faceDef = parts[i].Split('/');
											if (faceDef.Length == 3)
											{
												if (int.TryParse(faceDef[0], out int ind)) { indices.Add(ind); }
												if (int.TryParse(faceDef[1], out int uv)) { uvIndices.Add(uv); }
												if (int.TryParse(faceDef[2], out int norm)) { normalIndices.Add(norm); }
											}
										}

										if (indices.Count >= 3)
										{
											FaceIndices.Add(indices);

											if (uvIndices.Count >= 3) { FaceUVIndices.Add(uvIndices); }
											if (normalIndices.Count >= 3) { FaceNormalIndices.Add(normalIndices); }
										}
									}
									break;
							}
						}
					}
				}

				this.VertexCount = Vertices.Count;
				this.FaceCount = FaceIndices.Count;
			}
		}

		public enum PreviewDirection { Front, Left, Right, Top };

		public Image Preview(int width, int height, PreviewDirection direction)
		{
			Bitmap bmp = new Bitmap(width, height);
			Graphics g = Graphics.FromImage(bmp);

			int border = width / 10;
			int innerWidth = width - (border * 2);
			int innerHeight = height - (border * 2);

			g.Clear(Color.Transparent);

			float minX = float.MaxValue, maxX = float.MinValue, minY = float.MaxValue, maxY = float.MinValue, minZ = float.MaxValue, maxZ = float.MinValue;
			foreach (var v in Vertices)
			{
				minX = Math.Min(minX, v.X);
				minY = Math.Min(minY, v.Y);
				minZ = Math.Min(minZ, v.Z);

				maxX = Math.Max(maxX, v.X);
				maxY = Math.Max(maxY, v.Y);
				maxZ = Math.Max(maxZ, v.Z);
			}

			float lengthX = maxX - minX;
			float lengthY = maxY - minY;
			float lengthZ = maxZ - minZ;

			float scale2dX = innerWidth / lengthX;
			float scale2dY = innerHeight / lengthY;

			switch (direction)
			{
				default:
				case PreviewDirection.Front:
					scale2dX = innerWidth / lengthX;
					scale2dY = innerHeight / lengthY;
					break;
				case PreviewDirection.Left:
					scale2dX = innerWidth / lengthZ;
					scale2dY = innerHeight / lengthY;
					break;
				case PreviewDirection.Right:
					scale2dX = innerWidth / lengthZ;
					scale2dY = innerHeight / lengthY;
					break;
				case PreviewDirection.Top:
					scale2dX = innerWidth / lengthX;
					scale2dY = innerHeight / lengthZ;
					break;
			}

			float offset3dX = 0;
			float offset3dY = 0;
			float offset3dZ = 0;

			if (minX != 0) { offset3dX = minX * -1; }
			if (minY != 0) { offset3dY = minY * -1; }
			if (minZ != 0) { offset3dZ = minZ * -1; }

			float scale = Math.Min(scale2dX, scale2dY);

			int offset2dX = 0;
			int offset2dY = 0;

			bool zUp = direction == PreviewDirection.Top;

			float pixelLengthX = lengthX * scale;
			float pixelLengthY = lengthY * scale;
			float pixelLengthZ = lengthZ * scale;

			switch (direction)
			{
				default:
				case PreviewDirection.Front:
					offset2dX = (int)(innerWidth - pixelLengthX) / 2;
					offset2dY = (int)(innerHeight - pixelLengthY) / 2;
					break;
				case PreviewDirection.Left:
					offset2dX = (int)(innerWidth - pixelLengthZ) / 2;
					offset2dY = (int)(innerHeight - pixelLengthY) / 2;
					break;
				case PreviewDirection.Right:
					offset2dX = (int)(innerWidth - pixelLengthZ) / 2;
					offset2dY = (int)(innerHeight - pixelLengthY) / 2;
					break;
				case PreviewDirection.Top:
					offset2dX = (int)(innerWidth - pixelLengthX) / 2;
					offset2dY = (int)(innerHeight - pixelLengthZ) / 2;
					break;
			}

			foreach (var f in FaceIndices)
			{
				GraphicsPath path = new GraphicsPath();
				for (int i = 0; i < f.Count; i++)
				{
					try
					{
						int first = i;
						int second = i + 1;
						if (second >= f.Count) { second = 0; }

						var v1 = Vertices[f[first] - 1];
						var v2 = Vertices[f[second] - 1];

						int x1 = 0;
						int x2 = 0;
						int y1 = 0;
						int y2 = 0;

						switch (direction)
						{
							default:
							case PreviewDirection.Front:
								x1 = border + offset2dX + (int)((offset3dX + v1.X) * scale);
								x2 = border + offset2dX + (int)((offset3dX + v2.X) * scale);

								y1 = border + innerHeight - offset2dY - (int)((offset3dY + v1.Y) * scale);
								y2 = border + innerHeight - offset2dY - (int)((offset3dY + v2.Y) * scale);
								break;
							case PreviewDirection.Left:
								x1 = border + offset2dX + (int)((offset3dZ + v1.Z) * scale);
								x2 = border + offset2dX + (int)((offset3dZ + v2.Z) * scale);

								y1 = border + innerHeight - offset2dY - (int)((offset3dY + v1.Y) * scale);
								y2 = border + innerHeight - offset2dY - (int)((offset3dY + v2.Y) * scale);
								break;
							case PreviewDirection.Right:
								x1 = border + innerHeight - offset2dX - (int)((offset3dZ + v1.Z) * scale);
								x2 = border + innerHeight - offset2dX - (int)((offset3dZ + v2.Z) * scale);

								y1 = border + innerHeight - offset2dY - (int)((offset3dY + v1.Y) * scale);
								y2 = border + innerHeight - offset2dY - (int)((offset3dY + v2.Y) * scale);
								break;
							case PreviewDirection.Top:
								x1 = border + offset2dX + (int)((offset3dX + v1.X) * scale);
								x2 = border + offset2dX + (int)((offset3dX + v2.X) * scale);

								y1 = border + innerHeight - offset2dY - (int)((offset3dZ + v1.Z) * scale);
								y2 = border + innerHeight - offset2dY - (int)((offset3dZ + v2.Z) * scale);
								break;
						}

						path.AddLine(new Point(x1, y1), new Point(x2, y2));
					}
					catch (Exception ex)
					{

					}
				}

				g.FillPath(Brushes.AliceBlue, path);
				g.DrawPath(Pens.LightBlue, path);
			}

			return bmp;
		}



		public static ObjFile Load(string filePath)
		{
			ObjFile f = new ObjFile(filePath);
			f.Load();
			return f;
		}
	}
}
