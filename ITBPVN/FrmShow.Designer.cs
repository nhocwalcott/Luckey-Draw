namespace BPVN.LuckyDraw
{
	partial class FrmShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShow));
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblLotteryBox = new System.Windows.Forms.Label();
            this.btnLottery = new BPVN.LuckyDraw.Controls.MyButton();
            this.SuspendLayout();
            // 
            // lblSubtitle
            // 
            resources.ApplyResources(this.lblSubtitle, "lblSubtitle");
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.ForeColor = System.Drawing.Color.Red;
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Click += new System.EventHandler(this.lblSubtitle_Click);
            // 
            // lblLotteryBox
            // 
            this.lblLotteryBox.AllowDrop = true;
            resources.ApplyResources(this.lblLotteryBox, "lblLotteryBox");
            this.lblLotteryBox.BackColor = System.Drawing.Color.Transparent;
            this.lblLotteryBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblLotteryBox.Name = "lblLotteryBox";
            this.lblLotteryBox.UseCompatibleTextRendering = true;
            this.lblLotteryBox.Click += new System.EventHandler(this.lblLotteryBox_Click);
            // 
            // btnLottery
            // 
            this.btnLottery.BackColor = System.Drawing.Color.Orange;
            resources.ApplyResources(this.btnLottery, "btnLottery");
            this.btnLottery.ForeColor = System.Drawing.Color.Red;
            this.btnLottery.GlowColor = System.Drawing.Color.Gold;
            this.btnLottery.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btnLottery.Name = "btnLottery";
            this.btnLottery.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnLottery.TabStop = false;
            this.btnLottery.UseCompatibleTextRendering = true;
            this.btnLottery.UseMnemonic = false;
            this.btnLottery.Click += new System.EventHandler(this.btnLottery_Click);
            // 
            // FrmShow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnLottery);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblLotteryBox);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmShow";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmShow_FormClosing);
            this.Load += new System.EventHandler(this.FrmShow_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmShow_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblLotteryBox;
		private System.Windows.Forms.Label lblSubtitle;
		private BPVN.LuckyDraw.Controls.MyButton btnLottery;
	}
}

