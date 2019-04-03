using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using BPVN.LuckyDraw.Utils;

namespace BPVN.LuckyDraw
{
	public class TitleConfig : Config
	{
		private const string SECTION = "Title";

		private string text;
		private Font font;
		private Color color;
		private Point location;
		private bool visible;

		private TitleConfig()
		{
			this.text = ReadString(SECTION, "Text", "");
			this.font = ReadFont();
			this.color = Color.FromArgb( Convert.ToInt32( ReadString(SECTION, "Color", "FFFFFF00" ), 16 ) );
			
			int x = Convert.ToInt32( ReadString(SECTION, "X", "0") );
			int y = Convert.ToInt32( ReadString(SECTION, "Y", "0") );
			this.location = new Point(280, 566);

			this.visible = ReadString(SECTION, "Visible", "true").ToLower() == "true";
		}

		public static TitleConfig ReadConfig()
		{
			return new TitleConfig();
		}

		public override void Save()
		{
			WriteString(SECTION, "Text", this.text);
			WriteFont();
			WriteString(SECTION, "Color", this.color.ToArgb().ToString("X"));
			WriteString(SECTION, "X", this.location.X.ToString());
			WriteString(SECTION, "Y", this.location.Y.ToString());
			WriteString(SECTION, "Visible", this.visible ? "true" : "false");
		}

		public string Text {
			get {
				return this.text;
			}

			set {
				this.text = value;
			}
		}

		#region Font

		public Font Font {
			get { return this.font; }
			set {
				
				if (value == null) {
					throw new ArgumentNullException("Font", "Font not null");
				}

				this.font = value;
			}
		}

		private Font ReadFont()
		{
			string name = ReadString(SECTION, "FontName", "Font Name");

			float size = Convert.ToSingle(ReadString(SECTION, "FontSize", "40"));

			FontStyle style = AppUtility.BuildFontStyle(ReadString(SECTION, "FontStyle", ""));

			return new Font( name, size, style );
		}

		private void WriteFont()
		{
			WriteString(SECTION, "FontName", this.font.Name);
			WriteString(SECTION, "FontSize", this.font.Size.ToString());
			WriteString(SECTION, "FontStyle", this.font.Style.ToString());
		}

		#endregion

		public Color Color {
			get { return this.color; }
			set {
				if (value == null) {
					throw new ArgumentNullException("Color", "Color not null");
				}

				this.color = value;
			}
		}

		/// <summary>
	
		/// </summary>
		public Point Location {
			get { return this.location; }
			set {
				if (value == null) {
					throw new ArgumentNullException("Location", "Location not null.");
				}

				this.location = value;
			}
		}

		/// <summary>
	
		/// </summary>
		public bool Visible
		{
			get { return this.visible; }
			set { this.visible = value; }
		}
	}
}
