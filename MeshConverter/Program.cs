using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeshConverter
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			//ClassificationTest();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MeshConverterForm());
		}


		private static void ClassificationTest()
		{
			string[] files = Directory.GetFiles(@"C:\Users\gusla\OneDrive - Configura Sverige AB\Documents\Projects\2025\Neural Networks for 3D Mesh Model Classification\configura\img\train",
							"*.png",
							SearchOption.AllDirectories);

			int hits = 0;
			int totalCount = files.Length;

			decimal totalAvgLoss = 0;

			TimeSpan totalTime = new TimeSpan();
			TimeSpan inferenceTime = new TimeSpan();

			bool first = true;
			foreach (string f in files)
			{
				DateTime t0 = DateTime.Now;

				byte[] bytes = File.ReadAllBytes(f);

				string targetLabel = Path.GetFileName(Path.GetDirectoryName(f));

				DateTime t1 = DateTime.Now;
				var allPredictions = MLModel3.PredictAllLabels(new MLModel3.ModelInput() { ImageSource = bytes, Label = targetLabel }).ToArray();

				DateTime t2 = DateTime.Now;

				decimal totalLoss = 0;
				foreach (var pair in allPredictions)
				{
					if (pair.Key == targetLabel)
					{
						totalLoss += (decimal)(1 - pair.Value);
					}
					else
					{
						totalLoss += (decimal)pair.Value;
					}
				}

				if (allPredictions[0].Key == targetLabel)
				{
					hits++;
				}

				decimal avgLoss = totalLoss / allPredictions.Count();

				totalAvgLoss += avgLoss;

				DateTime t3 = DateTime.Now;

				//if (!first)
				//{
				totalTime += new TimeSpan(t3.Ticks - t0.Ticks);
				inferenceTime += new TimeSpan(t2.Ticks - t1.Ticks);
				//}
				first = false;
			}


			decimal globalAvgLoss = totalAvgLoss / totalCount;

			decimal lossCorrectRatio = 1 - globalAvgLoss;

			decimal correctRatio = (decimal)hits / (decimal)totalCount;

			TimeSpan timePerInference = new TimeSpan(totalTime.Ticks / totalCount);
		}
	}
}
