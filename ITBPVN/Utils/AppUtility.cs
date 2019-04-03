using System;
using System.Drawing;
using System.Reflection;

namespace BPVN.LuckyDraw.Utils
{
	public class AppUtility
	{
		public static string GetAppPath()
		{
			string path = AppDomain.CurrentDomain.BaseDirectory;

			if (!path.EndsWith(@"\")) {
				return path + @"\";
			}

			return path;
		}

		public static FontStyle BuildFontStyle(string style)
		{
			if (String.IsNullOrEmpty(style)) {
				return FontStyle.Regular;
			}

			if (style.Contains(FontStyle.Regular.ToString())) {
				return FontStyle.Regular;
			}

			FontStyle fontStyle = FontStyle.Regular;
			if (style.Contains(FontStyle.Bold.ToString())) {
				fontStyle |= FontStyle.Bold;
			}

			if (style.Contains(FontStyle.Italic.ToString())) {
				fontStyle |= FontStyle.Italic;
			}

			return fontStyle;
		}

	}
}
