using System.ComponentModel;
using System.Windows.Forms;
using BPVN.LuckyDraw.Controls;

namespace BPVN.LuckyDraw
{
	partial class FrmPrizewinnerPanel
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlPrizewinnerTable1 = new BPVN.LuckyDraw.Controls.CtrlPrizewinnerTable();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ctrlPrizewinnerTable1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.571428F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.42857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 326F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1406, 780);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Yellow;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1400, 38);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Danh sách người may mắn";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.UseCompatibleTextRendering = true;
            // 
            // ctrlPrizewinnerTable1
            // 
            this.ctrlPrizewinnerTable1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlPrizewinnerTable1.BodyCellHeight = 85;
            this.ctrlPrizewinnerTable1.BorderColor = System.Drawing.Color.Transparent;
            this.ctrlPrizewinnerTable1.CellLineColor = System.Drawing.Color.Transparent;
            this.ctrlPrizewinnerTable1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlPrizewinnerTable1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPrizewinnerTable1.ForeColor = System.Drawing.Color.Gold;
            this.ctrlPrizewinnerTable1.HeaderCellHeight = 60;
            this.ctrlPrizewinnerTable1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPrizewinnerTable1.HeaderForeColor = System.Drawing.Color.Gold;
            this.ctrlPrizewinnerTable1.Location = new System.Drawing.Point(3, 41);
            this.ctrlPrizewinnerTable1.Name = "ctrlPrizewinnerTable1";
            this.tableLayoutPanel1.SetRowSpan(this.ctrlPrizewinnerTable1, 2);
            this.ctrlPrizewinnerTable1.Size = new System.Drawing.Size(1400, 736);
            this.ctrlPrizewinnerTable1.TabIndex = 0;
            this.ctrlPrizewinnerTable1.Load += new System.EventHandler(this.ctrlPrizewinnerTable1_Load);
            // 
            // FrmPrizewinnerPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::BPVN.LuckyDraw.Properties.Resources.bk2;
            this.ClientSize = new System.Drawing.Size(1426, 800);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmPrizewinnerPanel";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmPrizewinnnerPanel_KeyUp);
            this.Resize += new System.EventHandler(this.FrmPrizewinnerPanel_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CtrlPrizewinnerTable ctrlPrizewinnerTable1;
    }
}