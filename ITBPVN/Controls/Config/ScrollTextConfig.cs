using System;
using System.Drawing;
using BPVN.LuckyDraw.Utils;

namespace BPVN.LuckyDraw
{
	public class ScrollTextConfig : Config
	{
		private const string SECTION = "ScrollText";

		private string text;
		private Font font;
		private Color color;
		private Point location;
		private Size size;
		private bool visible;

		private ScrollTextConfig()
		{
			this.text = ReadString(SECTION, "Text", "");
			this.font = ReadFont();
			this.color = Color.FromArgb(Convert.ToInt32(ReadString(SECTION, "Color", "FFFFFF00"), 16));

			int x = Convert.ToInt32(ReadString(SECTION, "X", "0"));
			int y = Convert.ToInt32(ReadString(SECTION, "Y", "0"));
			this.location = new Point(x, y);

			int width = Convert.ToInt32(ReadString(SECTION, "Width", "0"));
			int height = Convert.ToInt32(ReadString(SECTION, "Height", "0"));
			this.size = new Size(width, height);

			this.visible = ReadString(SECTION, "Visible", "true").ToLower() == "true";
		}

		public static ScrollTextConfig ReadConfig()
		{
			return new ScrollTextConfig();
		}

		public override void Save()
		{
			WriteString(SECTION, "Text", this.text);
			WriteFont();
			WriteString(SECTION, "Color", this.color.ToArgb().ToString("X"));
			WriteString(SECTION, "X", this.location.X.ToString());
			WriteString(SECTION, "Y", this.location.Y.ToString());
			WriteString(SECTION, "Width", this.size.Width.ToString());
			WriteString(SECTION, "Height", this.size.Height.ToString());
			WriteString(SECTION, "Visible", this.visible ? "true" : "false");
		}

		public string Text
		{
			get { return this.text; }
			set {
				this.text = value;
			}
		}

		#region Font

		public Font Font
		{
			get { return this.font; }
			set
			{

				if (value == null) {
					throw new ArgumentNullException("Font", "Font Not null");
				}

				this.font = value;
			}
		}

		private Font ReadFont()
		{
			string name = ReadString(SECTION, "FontName", "Font name");

			float size = Convert.ToSingle(ReadString(SECTION, "FontSize", "40"));

			FontStyle style = AppUtility.BuildFontStyle(ReadString(SECTION, "FontStyle", ""));

			return new Font(name, size, style);
		}

		private void WriteFont()
		{
			WriteString(SECTION, "FontName", this.font.Name);
			WriteString(SECTION, "FontSize", this.font.Size.ToString());
			WriteString(SECTION, "FontStyle", this.font.Style.ToString());
		}

		#endregion

		public Color Color
		{
			get { return this.color; }
			set
			{
				if (value == null) {
					throw new ArgumentNullException("Color", "Color Không thể trống。");
				}

				this.color = value;
			}
		}

		/// <summary>
	
		/// </summary>
		public Point Location
		{
			get { return this.location; }
			set
			{
				if (value == null) {
					throw new ArgumentNullException("Location", "Location Không thể null。");
				}

				this.location = value;
			}
		}

		/// <summary>

		/// </summary>
		public Size Size {
			get { return this.size; }
			set {
				if (value == null) {
					throw new ArgumentNullException("Size", "Size Không thể null。");
				}

				this.size = value;
			}
		}

		/// <summary>

		/// </summary>
		public bool Visible {
			get { return this.visible; }
			set { this.visible = value; }
		}
	}
}
