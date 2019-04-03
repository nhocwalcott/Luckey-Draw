using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace BPVN.LuckyDraw.Controls
{
    public partial class CtrlScrollText : UserControl
    {

        private Timer timer;
        private int pos;
        private int speed;
        private string _text;

        public CtrlScrollText()
        {
            InitializeComponent();
            init();
        }

        public CtrlScrollText(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            init();
        }

        private void init()
        {
            this.pos = 0;
            this.speed = 1;

            this.timer = new Timer();
            this.timer.Interval = 10000;
            this.timer.Tick += new EventHandler(timer_Tick);
        }

        [Browsable(true), DefaultValue(300), Description("Khoảng thời gian mỗi lần di chuyển.（Đơn vị：ms）")]
        public int Interval
        {
            get { return this.timer.Interval; }
            set { this.timer.Interval = value; }
        }

        [Browsable(true), DefaultValue(1), Description("Tốc độ.（Đơn vị：Pixel）")]
        public int Speed
        {
            get { return this.speed; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Speed", "Speed Phải lớn hơn 1.");
                }

                if (value != this.speed)
                {
                    this.speed = value;
                }
            }
        }

        [Browsable(true), DefaultValue("Danh sách "), Description("Danh sách")]
        public new string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        public bool IsMoving
        {
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
            pos += this.speed;

            this.Invalidate();            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (StringFormat format = new StringFormat())
            {

                using (SolidBrush brush = new SolidBrush(this.ForeColor))
                {

                    SizeF size = e.Graphics.MeasureString(this.Text, this.Font);
                    int textHeight = Convert.ToInt32(Math.Ceiling(size.Height));
                    int textWidth = Convert.ToInt32(Math.Ceiling(size.Width));

                    pos = this.Height - textHeight;

                    Rectangle rect = new Rectangle(pos, 0, textWidth, textHeight);
                    e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                    e.Graphics.DrawString(this._text, this.Font, brush, rect, format);
                }
            }
        }
    }
}
