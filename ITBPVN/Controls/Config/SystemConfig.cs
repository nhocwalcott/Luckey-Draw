using System;

namespace BPVN.LuckyDraw
{
	public class SystemConfig : Config
	{
		private static SystemConfig instance;

		private const string SECTION = "System";

		private int currentTabPage;
		private string backgroundImage;
		private int speed;				// tốc độ quay số

		private string group;
		private string award;
		private int amount;
        private bool hcenter;

		private SystemConfig()
		{
			this.currentTabPage = Convert.ToInt32(ReadString(SECTION, "TabPage", "0"));
			this.backgroundImage = ReadString(SECTION, "BkImage", "");
            this.speed = Convert.ToInt32(ReadString(SECTION, "Speed", "10"));
			this.group = ReadString(SECTION, "Group", "");
			this.award = ReadString(SECTION, "Award", "");
			this.amount = Convert.ToInt32( ReadString(SECTION, "Amount", "1") );
            this.hcenter = Convert.ToBoolean(ReadString(SECTION, "Hcenter","False"));
		}

		public static SystemConfig ReadConfig()
		{
			if (instance == null) {
				instance = new SystemConfig();
			}

			return instance;
		}

		public int CurrentTabPage {
			get { return this.currentTabPage; }
			set {

				if (value < 0) {
					throw new ArgumentOutOfRangeException("CurrentTabPage", "CurrentTabPage không được nhỏ hơn 0");
				}

				this.currentTabPage = value;
			}
		}

		/// <summary>
	
		/// </summary>
		public string BackgroundImage {
			get { return this.backgroundImage; }
			set {
				
				if (String.IsNullOrEmpty(value)) {
					throw new ArgumentException("BackgroundImage", "BackgroundImage Không thể là chuỗi rỗng");
				}

				if (!System.IO.File.Exists(value)) {
					throw new ArgumentException("BackgroundImage", "BackgroundImage Không phải là đường dẫn hợp lệ");
				}

				this.backgroundImage = value;
			}
		}

		/// <summary>
	
		/// </summary>
		public int Speed {
			get { return this.speed; }
			set {
				if (value < 1) {
					throw new ArgumentOutOfRangeException("Speed", "Speed Không được nhỏ hơn 1。");
				}

				this.speed = value;
			}
		}

		/// <summary>
		
		/// </summary>
		public string Group {
			get { return this.group; }
			set {
				this.group = value ?? String.Empty;
			}
		}

		/// <summary>
		
		/// </summary>
		public string Award {
			get { return this.award; }
			set {
				this.award = value ?? String.Empty;
			}
		}

		/// <summary>
		
		/// </summary>
		public int Amount {
			get { return this.amount; }
			set {

				if (value < 1) {
					throw new ArgumentOutOfRangeException("Amount", "Amount Không được nhỏ hơn 1。");
				}

				this.amount = value;
			}
		}

        public bool Hcenter
        {
            get { return this.hcenter; }
            set
            {
                try
                {
                    bool xvalue = bool.Parse(value.ToString());
                }
                catch
                {
                    throw new ArgumentException("Hcenter", "Hcenter Phải chuyển đổi thành Boolean。");

                }

                this.hcenter = value;
            }
        }

		public override void Save()
		{
			WriteString(SECTION, "TabPage", this.currentTabPage.ToString());
			WriteString(SECTION, "BkImage", this.backgroundImage);
			WriteString(SECTION, "Speed", this.speed.ToString());
			WriteString(SECTION, "Group", this.group);
			WriteString(SECTION, "Award", this.award);
			WriteString(SECTION, "Amount", this.amount.ToString());
            WriteString(SECTION, "Hcenter", this.hcenter.ToString());
		}

	}
}
