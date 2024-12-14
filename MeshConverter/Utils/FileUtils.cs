using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeshConverter.Utils
{
	public static class FileUtils
	{
		public enum SizeUnits
		{
			Auto = -1, Byte = 0, KB = 1, MB = 2, GB = 3, TB = 4, PB = 5, EB = 6, ZB = 7, YB = 8
		}

		/// <summary>
		/// Format size in bytes to KB, MB etc
		/// 
		/// https://stackoverflow.com/a/22733709
		/// https://stackoverflow.com/a/62698159
		/// </summary>
		/// <param name="bytes"></param>
		/// <param name="unit"></param>
		/// <returns></returns>
		public static string ToSizeString(this long bytes, SizeUnits unit = SizeUnits.Auto)
		{
			var baseVal = 1024;
			if (bytes < baseVal) { return $"{bytes} B"; }

			var exp = unit == SizeUnits.Auto ? (int)(Math.Log(bytes) / Math.Log(baseVal)) : (int)unit;

			string s = ($"{bytes / Math.Pow(baseVal, exp):### ### ###} {("KMGTPE")[exp - 1]}B").TrimStart();

			return s;
		}
	}
}
