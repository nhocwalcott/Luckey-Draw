using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using BPVN.LuckyDraw.Model;

namespace BPVN.LuckyDraw.Controls
{
    public partial class CtrlPrizewinnerTable : UserControl
    {
        private Color borderColor;		
        private Color cellLineColor;	

        private int headerCellHeight;	
        private Font headerFont;		
        private Color headerForeColor;	

        private int bodyCellHeight;		

        private List<string> columns;	

        private List<EmployeeInfo> prizewinners;

        public CtrlPrizewinnerTable()
        {
            InitializeComponent();
            this.prizewinners = new List<EmployeeInfo>();

           
                this.columns = new List<string>();

                this.columns.Add("Mã thẻ");
                this.columns.Add("Tên");

                this.columns.Add("Mã thẻ");
                this.columns.Add("Tên");
          
                        
            

            this.borderColor = Color.Black;
            this.cellLineColor = Color.Black;

            this.headerCellHeight = 6; // 2019-1-16 30-Giá trị ban đầu là 8
            this.headerFont = new Font("Times New Roman", 6, FontStyle.Regular);
            this.headerForeColor = Color.Black;

            this.bodyCellHeight = 15;// 2019-1-16 30-Giá trị ban đầu là 20

            
        }

        [Browsable(false)]
        public List<EmployeeInfo> Prizewinners
        {
            get { return this.prizewinners; }
        }

        [Browsable(true), Category("CtrlPrizewinnerTable"), Description("Màu đường viền của  mẫu")]
        public Color BorderColor
        {
            get { return this.borderColor; }
            set
            {
                this.borderColor = value;
            }
        }

        [Browsable(true), Category("CtrlPrizewinnerTable"), Description("Font Header")]
        public Font HeaderFont
        {
            get { return headerFont; }
            set
            {
                this.headerFont = value;
            }
        }

        [Browsable(true), Category("CtrlPrizewinnerTable"), Description("Màu Header.")]
        public Color HeaderForeColor
        {
            get { return this.headerForeColor; }
            set
            {

                if (value == null)
                {
                    throw new ArgumentNullException("HeaderForeColor");
                }

                this.headerForeColor = value;
            }
        }
        //  2019-1-16 30-Giá trị ban đầu là DefaultValue(20)
        [DefaultValue(15), Browsable(true), Category("CtrlPrizewinnerTable"), Description("Header cell height：pixels")]
        public int HeaderCellHeight
        {
            get { return this.headerCellHeight; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("HeaderCellHeight", "HeaderCellHeight Giá trị phải lớn hơn 0.");
                }

                this.headerCellHeight = value;
            }
        }

        [Browsable(true), Category("CtrlPrizewinnerTable"), Description("Màu đường viền của ổ")]
        public Color CellLineColor
        {
            get { return this.cellLineColor; }
            set
            {

                if (value == null)
                {
                    throw new ArgumentNullException("CellLineColor");
                }

                this.cellLineColor = value;
            }
        }

        [DefaultValue(10), Browsable(true), Category("CtrlPrizewinnerTable"), Description("Body cell height：pixels")]
        public int BodyCellHeight
        {
            get { return this.bodyCellHeight; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("BodyCellHeight", "BodyCellHeight Giá trị phải lớn hơn 0");
                }

                this.bodyCellHeight = value;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            DrawHeader(g);

            DrawBody(g);

            DrawBorder(g);

            g.Dispose();
        }

        /// <summary>
     
        /// </summary>
        /// <param name="graph"></param>
        private void DrawHeader(Graphics graph)
        {
            DrawHeaderLine(graph);
            DrawHeaderContent(graph);
        }

        /// <summary>
    
        /// </summary>
        /// <param name="graph"></param>
        private void DrawHeaderLine(Graphics graph)
        {
            int headerCellWidth = this.Width / 4;
            using (Pen pen = new Pen(this.cellLineColor))
            {

                for (int i = 1; i < 4; i++)
                {
                    int left = headerCellWidth * i;
                    graph.DrawLine(pen, new Point(left, 0), new Point(left, headerCellHeight));
                }

                //graph.DrawLine(pen, new Point(0, headerHeight), new Point(this.Width, headerHeight));
            }
        }

        /// <summary>
     
        /// </summary>
        /// <param name="graph"></param>
        private void DrawHeaderContent(Graphics graph)
        {
            int headerCellWidth;
            using (StringFormat format = new StringFormat())
            {
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                using (Brush brush = new SolidBrush(this.headerForeColor))
                {
                    
                    if (prizewinners.Count > 25) {
                        headerCellWidth = this.Width / 4;
                        for (int i = 0; i < 4; i++)
                        {
                            switch (i)
                            {
                                case 0:
                                    Rectangle rect1 = new Rectangle(headerCellWidth * 0, 0, headerCellWidth, headerCellHeight);
                                    graph.DrawString(columns[i], headerFont, brush, rect1, format);
                                    break;
                                case 1:
                                    Rectangle rect2 = new Rectangle(headerCellWidth * 1, 0, headerCellWidth, headerCellHeight);
                                    graph.DrawString(columns[i], headerFont, brush, rect2, format);
                                    break;
                                case 2:
                                    Rectangle rect3 = new Rectangle(headerCellWidth * 2, 0, headerCellWidth, headerCellHeight);
                                    graph.DrawString(columns[i], headerFont, brush, rect3, format);
                                    break;
                                case 3:
                                    Rectangle rect4 = new Rectangle(headerCellWidth * 3, 0, headerCellWidth, headerCellHeight);
                                    graph.DrawString(columns[i], headerFont, brush, rect4, format);
                                    break;

                            }
                        }
                    }
                    else {
                        headerCellWidth = this.Width / 2;
                        for (int i = 0; i < 2; i++)
                        {
                            switch (i)
                            {
                                case 0:
                                    Rectangle rect1 = new Rectangle(headerCellWidth * 0, 0, headerCellWidth, headerCellHeight);
                                    graph.DrawString(columns[i], headerFont, brush, rect1, format);
                                    break;
                                case 1:
                                    Rectangle rect2 = new Rectangle(headerCellWidth * 1, 0, headerCellWidth, headerCellHeight);
                                    graph.DrawString(columns[i], headerFont, brush, rect2, format);
                                    break;
                               

                            }
                        }
                    }
                    
                }
            }
        }

        /// <summary>
  
        /// </summary>
        /// <param name="graph"></param>
        private void DrawBody(Graphics graph)
        {
            DrawBodyLine(graph);
            DrawBodyContent(graph);
        }

        /// <summary>
   
        /// </summary>
        /// <param name="graph"></param>
        private void DrawBodyLine(Graphics graph)
        {
            using (Pen pen = new Pen(this.borderColor))
            {
                for (int i = 1; i < this.columns.Count; i++)
                {
                    int left = (this.Width / this.columns.Count) * i;
                    graph.DrawLine(pen, new Point(left, this.headerCellHeight), new Point(left, this.Height));
                }

                for (int y = headerCellHeight; y < this.Height; y += this.bodyCellHeight)
                {
                    graph.DrawLine(pen, new Point(0, y), new Point(this.Width, y));
                }
            }
        }

        /// <summary>

        /// </summary>
        /// <param name="graph"></param>
        // Mặc định của row=20. sửa ngày 16/01/2019
        private void DrawBodyContent(Graphics graph)
        {
            if (prizewinners.Count < 1)
            {
                return;
            }

            int cellWidth;		

            using (StringFormat format = new StringFormat())
            {
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                int y = headerCellHeight - 10;

                int index = 0;

                int rows = (this.Height - this.headerCellHeight) / this.bodyCellHeight;
                rows = 50;
                for (int i = 0; i < rows; i++)
                {
                    int x = 0;

                    bool isDone = false;
                    if (index >= prizewinners.Count)
                    {
                        isDone = true;
                        break;
                    }

                    Color color1 = Color.FromArgb(0xFF, 0xE7, 0x6B);
                    Color color2 = Color.FromArgb(0xF7, 0xC3, 0x10);
                    if (prizewinners.Count > 25)
                    {
                        if (index >= prizewinners.Count/2)
                        {
                            isDone = true;
                            break;
                        }

                        cellWidth = this.Width / 4;
                        for (int j = 0; j < 4; j++)
                        {
                            Rectangle rect;
                            switch (j)
                            {
                                case 0:
                                    rect = new Rectangle(x, y, cellWidth, bodyCellHeight / 2);
                                    using (Brush brush = GetLinearGradientBrush(graph, prizewinners[index].EmployeeId, this.Font, color1, color2))
                                    {
                                        DrawContent(graph, prizewinners[index].EmployeeId, this.Font, brush, rect, format, prizewinners[index].Sign);
                                    }
                                    break;
                                case 1:
                                    rect = new Rectangle(x, y, cellWidth, bodyCellHeight / 2);
                                    using (Brush brush = GetLinearGradientBrush(graph, prizewinners[index].Name, this.Font, color1, color2))
                                    {
                                        DrawContent(graph, prizewinners[index].Name, this.Font, brush, rect, format, prizewinners[index].Sign);
                                    }
                                    break;
                                case 2:
                                    rect = new Rectangle(x, y, cellWidth, bodyCellHeight / 2);
                                    using (Brush brush = GetLinearGradientBrush(graph, prizewinners[(index + prizewinners.Count / 2)].EmployeeId, this.Font, color1, color2))
                                    {
                                        DrawContent(graph, prizewinners[index + (prizewinners.Count / 2)].EmployeeId, this.Font, brush, rect, format, prizewinners[index+ (prizewinners.Count / 2)].Sign);
                                    }
                                    break;
                                case 3:
                                    rect = new Rectangle(x, y, cellWidth, bodyCellHeight / 2);
                                    using (Brush brush = GetLinearGradientBrush(graph, prizewinners[(index + prizewinners.Count / 2)].Name, this.Font, color1, color2))
                                    {
                                        DrawContent(graph, prizewinners[index + (prizewinners.Count / 2)].Name, this.Font, brush, rect, format, prizewinners[index+ (prizewinners.Count / 2)].Sign);
                                    }
                                    break;

                            }

                            switch (j)
                            {
                                case 0:
                                    x += cellWidth;
                                    break;
                                case 1:
                                    x += cellWidth;
                                    break;
                                case 2:
                                    x += cellWidth;
                                    break;
                                case 3:
                                    x += cellWidth;
                                    break;

                            }

                        }
                    }
                    else if(prizewinners.Count<=25)
                    {
                        cellWidth = this.Width / 2;
                        for (int j = 0; j < 2; j++)
                        {
                            Rectangle rect;
                            switch (j)
                            {
                                case 0:
                                    rect = new Rectangle(x, y, cellWidth, bodyCellHeight / 2);
                                    using (Brush brush = GetLinearGradientBrush(graph, prizewinners[index].EmployeeId, this.Font, color1, color2))
                                    {
                                        DrawContent(graph, prizewinners[index].EmployeeId, this.Font, brush, rect, format, prizewinners[index].Sign);
                                    }
                                    break;
                                case 1:
                                    rect = new Rectangle(x, y, cellWidth, bodyCellHeight / 2);
                                    using (Brush brush = GetLinearGradientBrush(graph, prizewinners[index].Name, this.Font, color1, color2))
                                    {
                                        DrawContent(graph, prizewinners[index].Name, this.Font, brush, rect, format, prizewinners[index].Sign);
                                    }
                                    break;
                           
                            }

                            switch (j)
                            {
                                case 0:
                                    x += cellWidth;
                                    break;
                                case 1:
                                    x += cellWidth;
                                    break;
                  

                            }

                        }
                    }
                    
                    // Ket thuc for

                    index++;

                    if (isDone)
                    {
                        break;
                    }

                    y += (bodyCellHeight / 2) - 5;// 40;// (bodyCellHeight - 10);
                }// so dong toi da

            }	// using(StringFormat format = new StringFormat())
        }

        /// <summary>
  
        /// </summary>
        /// <param name="graph"></param>
        private void DrawBorder(Graphics graph)
        {
            graph.DrawRectangle(new Pen(this.borderColor), new Rectangle(0, 0, this.Width - 1, this.Height - 1)); // this.borderColor
        }

        private void DrawContent(Graphics graph, string text, Font font, Brush brush, Rectangle rect, StringFormat format, bool Sign)
        {
            if (Sign)
            {
                Color color1 = Color.Blue;

                Brush bsh = new LinearGradientBrush(rect, color1, color1, 0.0);
                graph.FillRectangle(bsh, rect);
                //graph.DrawRectangle(new Pen(brush), rect);
            }
            graph.DrawString(text, font, brush, rect, format);


        }

        private Brush GetLinearGradientBrush(Graphics graph, string text, Font font, Color color1, Color color2)
        {
            Size size = graph.MeasureString(text, font).ToSize();
            Point point1 = new Point(0, 0);
            Point point2 = new Point(0, size.Height);
            return new LinearGradientBrush(point1, point2, color1, color2);
        }
    }
}
