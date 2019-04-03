using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BPVN.LuckyDraw.Controls
{
	internal enum MoveDirection
	{ 
		LeftToRight,
		RightToLeft
	}

	public class CtrlScrollLabel : Label
	{
		private Timer timer;
		private int pos;
		private MoveDirection moveDirection;
        private CtrlSetting ctrlSetting1;
        private CtrlScrollText ctrlScrollText1;
        private IContainer components;
		private int speed;

		public CtrlScrollLabel()
		{
			this.pos = 0;
			this.moveDirection = MoveDirection.LeftToRight;
			this.speed = 1;

			this.timer = new Timer();
			this.timer.Interval = 10000;
			this.timer.Tick += new EventHandler(timer_Tick);
		}

		[Browsable(true), DefaultValue(100), Description("Khoảng thời gian mỗi lần di chuyển.（Đơn vị：ms）")]
		public int Interval {
			get { return this.timer.Interval; }
			set { this.timer.Interval = value; }
		}

		[Browsable(true), DefaultValue(1), Description("Tốc độ di chuyển.（Đơn vị：Pixel）")]
		public int Speed {
			get { return this.speed; }
			set {
				if (value < 1) {
					throw new ArgumentOutOfRangeException("Speed", "Speed Phải lớn hơn 1.");
				}

				if (value != this.speed) {
					this.speed = value;
				}
			}
		}

		public bool IsMoving {
			get { return this.timer.Enabled; }
		}

		/// <summary>
	
		/// </summary>
		public void Start()
		{
			timer.Start();
		}

		/// <summary>
	
		/// </summary>
		public void Stop()
		{
			timer.Stop();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			if (moveDirection == MoveDirection.RightToLeft) {
				pos -= this.speed;
			} else {
				pos += this.speed;
			}

			this.Invalidate();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			using (StringFormat format = new StringFormat()) {
				

				using (SolidBrush brush = new SolidBrush(this.ForeColor)) {

					SizeF size = e.Graphics.MeasureString(this.Text, this.Font);
					int textWidth = Convert.ToInt32(Math.Ceiling(size.Width));

					if (pos + textWidth >= this.Width) {
						pos = this.Width - textWidth;
						moveDirection = MoveDirection.RightToLeft;
					} else if(pos <= 0) {
						pos = 0;
						moveDirection = MoveDirection.LeftToRight;
					}

					Rectangle rect = new Rectangle(pos, 0, textWidth, this.ClientRectangle.Height);
					e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
					e.Graphics.DrawString(this.Text, this.Font, brush, rect, format);
				}
			}
			
		}

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ctrlSetting1 = new BPVN.LuckyDraw.Controls.CtrlSetting();
            this.ctrlScrollText1 = new BPVN.LuckyDraw.Controls.CtrlScrollText(this.components);
            this.SuspendLayout();
            // 
            // ctrlSetting1
            // 
            this.ctrlSetting1.Location = new System.Drawing.Point(0, 0);
            this.ctrlSetting1.Name = "ctrlSetting1";
            this.ctrlSetting1.Size = new System.Drawing.Size(790, 360);
            this.ctrlSetting1.TabIndex = 0;
            // 
            // ctrlScrollText1
            // 
            this.ctrlScrollText1.Interval = 10000;
            this.ctrlScrollText1.Location = new System.Drawing.Point(0, 0);
            this.ctrlScrollText1.Name = "ctrlScrollText1";
            this.ctrlScrollText1.Size = new System.Drawing.Size(361, 111);
            this.ctrlScrollText1.TabIndex = 0;
            this.ctrlScrollText1.Load += new System.EventHandler(this.ctrlScrollText1_Load);
            this.ResumeLayout(false);

        }

        private void ctrlScrollText1_Load(object sender, EventArgs e)
        {

        }
    }
}
