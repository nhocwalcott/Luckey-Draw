namespace BPVN.LuckyDraw
{
	partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnFrmShow = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpShow = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ckbCompleted = new System.Windows.Forms.CheckBox();
            this.ckbActiveAward = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tablelp = new System.Windows.Forms.TableLayoutPanel();
            this.btnApply = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAutoAddto = new System.Windows.Forms.CheckBox();
            this.ckbNoSign = new System.Windows.Forms.CheckBox();
            this.ckbAutoChange = new System.Windows.Forms.CheckBox();
            this.txtBalanceQty = new System.Windows.Forms.TextBox();
            this.txtAwordQty = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.cbxAward = new System.Windows.Forms.ComboBox();
            this.cbxGroup = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.tpEmployeeList = new System.Windows.Forms.TabPage();
            this.ctrlEmployeeList1 = new BPVN.LuckyDraw.Controls.CtrlEmployeeList();
            this.tpPrizewinnerList = new System.Windows.Forms.TabPage();
            this.ctrlPrizewinnerList1 = new BPVN.LuckyDraw.Controls.CtrlPrizewinnerList();
            this.tpAward = new System.Windows.Forms.TabPage();
            this.ctrlAward1 = new BPVN.LuckyDraw.Controls.CtrlAward();
            this.tpSetting = new System.Windows.Forms.TabPage();
            this.ctrlSetting1 = new BPVN.LuckyDraw.Controls.CtrlSetting();
            this.ctrlDetail1 = new BPVN.LuckyDraw.Controls.CtrlDetail1();
            this.tpDetail = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tpShow.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.tpEmployeeList.SuspendLayout();
            this.tpPrizewinnerList.SuspendLayout();
            this.tpAward.SuspendLayout();
            this.tpSetting.SuspendLayout();
            this.tpDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFrmShow
            // 
            this.btnFrmShow.Location = new System.Drawing.Point(6, 550);
            this.btnFrmShow.Name = "btnFrmShow";
            this.btnFrmShow.Size = new System.Drawing.Size(163, 47);
            this.btnFrmShow.TabIndex = 0;
            this.btnFrmShow.Text = "Hiển thị giao diện quay thưởng(&S)";
            this.btnFrmShow.UseVisualStyleBackColor = true;
            this.btnFrmShow.Click += new System.EventHandler(this.btnFrmShow_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpShow);
            this.tabControl1.Controls.Add(this.tpEmployeeList);
            this.tabControl1.Controls.Add(this.tpPrizewinnerList);
            this.tabControl1.Controls.Add(this.tpAward);
            this.tabControl1.Controls.Add(this.tpSetting);
            this.tabControl1.Controls.Add(this.tpDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 35);
            this.tabControl1.Location = new System.Drawing.Point(6, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(972, 643);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tpShow
            // 
            this.tpShow.Controls.Add(this.btnRefresh);
            this.tpShow.Controls.Add(this.checkBox1);
            this.tpShow.Controls.Add(this.ckbCompleted);
            this.tpShow.Controls.Add(this.ckbActiveAward);
            this.tpShow.Controls.Add(this.groupBox2);
            this.tpShow.Controls.Add(this.btnApply);
            this.tpShow.Controls.Add(this.groupBox1);
            this.tpShow.Controls.Add(this.btnFrmShow);
            this.tpShow.Controls.Add(this.btnExit);
            this.tpShow.Location = new System.Drawing.Point(4, 39);
            this.tpShow.Name = "tpShow";
            this.tpShow.Padding = new System.Windows.Forms.Padding(6);
            this.tpShow.Size = new System.Drawing.Size(964, 600);
            this.tpShow.TabIndex = 0;
            this.tpShow.Text = "Chương trình chính";
            this.tpShow.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(586, 550);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(125, 48);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Manually refreshed\n\r(Làm mới)";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(519, 690);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 19);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Front\n\r";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ckbCompleted
            // 
            this.ckbCompleted.Location = new System.Drawing.Point(177, 712);
            this.ckbCompleted.Name = "ckbCompleted";
            this.ckbCompleted.Size = new System.Drawing.Size(323, 23);
            this.ckbCompleted.TabIndex = 13;
            this.ckbCompleted.Text = "Tự động làm mới";
            this.ckbCompleted.UseVisualStyleBackColor = true;
            this.ckbCompleted.CheckedChanged += new System.EventHandler(this.ckbCompleted_CheckedChanged);
            // 
            // ckbActiveAward
            // 
            this.ckbActiveAward.Checked = true;
            this.ckbActiveAward.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbActiveAward.Location = new System.Drawing.Point(177, 683);
            this.ckbActiveAward.Name = "ckbActiveAward";
            this.ckbActiveAward.Size = new System.Drawing.Size(359, 37);
            this.ckbActiveAward.TabIndex = 9;
            this.ckbActiveAward.Text = "Tự động kích hoạt nền";
            this.ckbActiveAward.UseVisualStyleBackColor = true;
            this.ckbActiveAward.CheckedChanged += new System.EventHandler(this.ckbActiveAward_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tablelp);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(6, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(952, 422);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách trúng thưởng theo lượt quay";
            // 
            // tablelp
            // 
            this.tablelp.AutoScroll = true;
            this.tablelp.ColumnCount = 5;
            this.tablelp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablelp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablelp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablelp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablelp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablelp.Location = new System.Drawing.Point(3, 18);
            this.tablelp.Name = "tablelp";
            this.tablelp.RowCount = 10;
            this.tablelp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablelp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablelp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablelp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablelp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablelp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablelp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablelp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablelp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.975062F));
            this.tablelp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.22444F));
            this.tablelp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablelp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablelp.Size = new System.Drawing.Size(946, 401);
            this.tablelp.TabIndex = 7;
            this.tablelp.Paint += new System.Windows.Forms.PaintEventHandler(this.tablelp_Paint);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(715, 550);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(132, 48);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Áp dụng thiết lập(&A)";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAutoAddto);
            this.groupBox1.Controls.Add(this.ckbNoSign);
            this.groupBox1.Controls.Add(this.ckbAutoChange);
            this.groupBox1.Controls.Add(this.txtBalanceQty);
            this.groupBox1.Controls.Add(this.txtAwordQty);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudAmount);
            this.groupBox1.Controls.Add(this.cbxAward);
            this.groupBox1.Controls.Add(this.cbxGroup);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(952, 111);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thiết lập chương trình";
            // 
            // chkAutoAddto
            // 
            this.chkAutoAddto.Checked = true;
            this.chkAutoAddto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoAddto.Location = new System.Drawing.Point(677, 61);
            this.chkAutoAddto.Name = "chkAutoAddto";
            this.chkAutoAddto.Size = new System.Drawing.Size(215, 35);
            this.chkAutoAddto.TabIndex = 15;
            this.chkAutoAddto.Text = "Tự động nhâp danh sách";
            this.chkAutoAddto.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkAutoAddto.UseVisualStyleBackColor = true;
            // 
            // ckbNoSign
            // 
            this.ckbNoSign.Checked = true;
            this.ckbNoSign.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbNoSign.Location = new System.Drawing.Point(13, 17);
            this.ckbNoSign.Name = "ckbNoSign";
            this.ckbNoSign.Size = new System.Drawing.Size(297, 27);
            this.ckbNoSign.TabIndex = 14;
            this.ckbNoSign.Text = "Loại trừ nhân viên đã lĩnh thưởng";
            this.ckbNoSign.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ckbNoSign.UseVisualStyleBackColor = true;
            this.ckbNoSign.CheckedChanged += new System.EventHandler(this.ckbNoSign_CheckedChanged);
            // 
            // ckbAutoChange
            // 
            this.ckbAutoChange.Checked = true;
            this.ckbAutoChange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAutoChange.Location = new System.Drawing.Point(677, 20);
            this.ckbAutoChange.Name = "ckbAutoChange";
            this.ckbAutoChange.Size = new System.Drawing.Size(206, 24);
            this.ckbAutoChange.TabIndex = 12;
            this.ckbAutoChange.Text = "Tự động chuyển giải thưởng khác";
            this.ckbAutoChange.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ckbAutoChange.UseVisualStyleBackColor = true;
            this.ckbAutoChange.CheckedChanged += new System.EventHandler(this.ckbAutoChange_CheckedChanged);
            // 
            // txtBalanceQty
            // 
            this.txtBalanceQty.Location = new System.Drawing.Point(1104, 73);
            this.txtBalanceQty.Name = "txtBalanceQty";
            this.txtBalanceQty.ReadOnly = true;
            this.txtBalanceQty.Size = new System.Drawing.Size(116, 21);
            this.txtBalanceQty.TabIndex = 11;
            // 
            // txtAwordQty
            // 
            this.txtAwordQty.Location = new System.Drawing.Point(1104, 45);
            this.txtAwordQty.Name = "txtAwordQty";
            this.txtAwordQty.ReadOnly = true;
            this.txtAwordQty.Size = new System.Drawing.Size(116, 21);
            this.txtAwordQty.TabIndex = 10;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(1104, 17);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(116, 21);
            this.txtTotal.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(966, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số giải còn lại:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(962, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số người trúng thưởng:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(955, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng số giải:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nudAmount
            // 
            this.nudAmount.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudAmount.Location = new System.Drawing.Point(507, 70);
            this.nudAmount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(97, 26);
            this.nudAmount.TabIndex = 5;
            this.nudAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.ValueChanged += new System.EventHandler(this.nudAmount_ValueChanged);
            // 
            // cbxAward
            // 
            this.cbxAward.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAward.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbxAward.FormattingEnabled = true;
            this.cbxAward.Location = new System.Drawing.Point(167, 70);
            this.cbxAward.Name = "cbxAward";
            this.cbxAward.Size = new System.Drawing.Size(257, 23);
            this.cbxAward.Sorted = true;
            this.cbxAward.TabIndex = 3;
            this.cbxAward.SelectedIndexChanged += new System.EventHandler(this.cbxAward_SelectedIndexChanged);
            // 
            // cbxGroup
            // 
            this.cbxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGroup.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxGroup.FormattingEnabled = true;
            this.cbxGroup.Location = new System.Drawing.Point(13, 70);
            this.cbxGroup.Name = "cbxGroup";
            this.cbxGroup.Size = new System.Drawing.Size(117, 24);
            this.cbxGroup.TabIndex = 2;
            this.cbxGroup.SelectedIndexChanged += new System.EventHandler(this.cbxGroup_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(477, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 46);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số người trúng trong lượt quay:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lựa chọn giải thưởng:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lựa chọn danh sách:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(852, 550);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 48);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Thoát(&E)";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tpEmployeeList
            // 
            this.tpEmployeeList.Controls.Add(this.ctrlEmployeeList1);
            this.tpEmployeeList.Location = new System.Drawing.Point(4, 39);
            this.tpEmployeeList.Name = "tpEmployeeList";
            this.tpEmployeeList.Padding = new System.Windows.Forms.Padding(6);
            this.tpEmployeeList.Size = new System.Drawing.Size(964, 600);
            this.tpEmployeeList.TabIndex = 1;
            this.tpEmployeeList.Text = "Danh sách tham dự";
            this.tpEmployeeList.UseVisualStyleBackColor = true;
            // 
            // ctrlEmployeeList1
            // 
            this.ctrlEmployeeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlEmployeeList1.Location = new System.Drawing.Point(6, 6);
            this.ctrlEmployeeList1.Name = "ctrlEmployeeList1";
            this.ctrlEmployeeList1.Size = new System.Drawing.Size(952, 588);
            this.ctrlEmployeeList1.TabIndex = 0;
            // 
            // tpPrizewinnerList
            // 
            this.tpPrizewinnerList.Controls.Add(this.ctrlPrizewinnerList1);
            this.tpPrizewinnerList.Location = new System.Drawing.Point(4, 39);
            this.tpPrizewinnerList.Name = "tpPrizewinnerList";
            this.tpPrizewinnerList.Padding = new System.Windows.Forms.Padding(6);
            this.tpPrizewinnerList.Size = new System.Drawing.Size(964, 600);
            this.tpPrizewinnerList.TabIndex = 2;
            this.tpPrizewinnerList.Text = "Danh sách trúng thưởng";
            this.tpPrizewinnerList.UseVisualStyleBackColor = true;
            // 
            // ctrlPrizewinnerList1
            // 
            this.ctrlPrizewinnerList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlPrizewinnerList1.Location = new System.Drawing.Point(6, 6);
            this.ctrlPrizewinnerList1.Name = "ctrlPrizewinnerList1";
            this.ctrlPrizewinnerList1.Size = new System.Drawing.Size(952, 588);
            this.ctrlPrizewinnerList1.TabIndex = 0;
            // 
            // tpAward
            // 
            this.tpAward.Controls.Add(this.ctrlAward1);
            this.tpAward.Location = new System.Drawing.Point(4, 39);
            this.tpAward.Name = "tpAward";
            this.tpAward.Padding = new System.Windows.Forms.Padding(6);
            this.tpAward.Size = new System.Drawing.Size(964, 600);
            this.tpAward.TabIndex = 3;
            this.tpAward.Text = "Thiết lập giải thưởng";
            this.tpAward.UseVisualStyleBackColor = true;
            // 
            // ctrlAward1
            // 
            this.ctrlAward1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlAward1.Location = new System.Drawing.Point(6, 6);
            this.ctrlAward1.Name = "ctrlAward1";
            this.ctrlAward1.Size = new System.Drawing.Size(952, 588);
            this.ctrlAward1.TabIndex = 0;
            this.ctrlAward1.Load += new System.EventHandler(this.ctrlAward1_Load);
            // 
            // tpSetting
            // 
            this.tpSetting.Controls.Add(this.ctrlSetting1);
            this.tpSetting.Location = new System.Drawing.Point(4, 39);
            this.tpSetting.Name = "tpSetting";
            this.tpSetting.Padding = new System.Windows.Forms.Padding(6);
            this.tpSetting.Size = new System.Drawing.Size(964, 600);
            this.tpSetting.TabIndex = 4;
            this.tpSetting.Text = "Thiết lập hệ thống";
            this.tpSetting.UseVisualStyleBackColor = true;
            // 
            // ctrlSetting1
            // 
            this.ctrlSetting1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlSetting1.Location = new System.Drawing.Point(6, 6);
            this.ctrlSetting1.Name = "ctrlSetting1";
            this.ctrlSetting1.Size = new System.Drawing.Size(952, 588);
            this.ctrlSetting1.TabIndex = 0;
            this.ctrlSetting1.Load += new System.EventHandler(this.ctrlSetting1_Load);
            // 
            // ctrlDetail1
            // 
            this.ctrlDetail1.Location = new System.Drawing.Point(0, 0);
            this.ctrlDetail1.Name = "ctrlDetail1";
            this.ctrlDetail1.Size = new System.Drawing.Size(935, 371);
            this.ctrlDetail1.TabIndex = 1;
            // 
            // ctrlDetail
            // 
            this.tpDetail.Controls.Add(this.ctrlDetail1);
            this.tpDetail.Location = new System.Drawing.Point(4, 39);
            this.tpDetail.Name = "ctrlDetail";
            this.tpDetail.Size = new System.Drawing.Size(964, 600);
            this.tpDetail.TabIndex = 5;
            this.tpDetail.Text = "Thiết lập quà tặng";
            this.tpDetail.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(6, 12, 6, 6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Chương  trình quay thưởng cuối năm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpShow.ResumeLayout(false);
            this.tpShow.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.tpEmployeeList.ResumeLayout(false);
            this.tpPrizewinnerList.ResumeLayout(false);
            this.tpAward.ResumeLayout(false);
            this.tpSetting.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnFrmShow;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tpShow;
		private System.Windows.Forms.TabPage tpEmployeeList;
		private System.Windows.Forms.TabPage tpPrizewinnerList;
		private System.Windows.Forms.TabPage tpSetting;
        private System.Windows.Forms.TabPage tpDetail;
        private BPVN.LuckyDraw.Controls.CtrlPrizewinnerList ctrlPrizewinnerList1;
		private BPVN.LuckyDraw.Controls.CtrlEmployeeList ctrlEmployeeList1;
		private BPVN.LuckyDraw.Controls.CtrlAward ctrlAward1;
		private BPVN.LuckyDraw.Controls.CtrlSetting ctrlSetting1;
        private BPVN.LuckyDraw.Controls.CtrlDetail1 ctrlDetail1;
        private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbxGroup;
		private System.Windows.Forms.ComboBox cbxAward;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TableLayoutPanel tablelp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBalanceQty;
        private System.Windows.Forms.TextBox txtAwordQty;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.CheckBox ckbAutoChange;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox ckbActiveAward;
        private System.Windows.Forms.CheckBox ckbCompleted;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox ckbNoSign;
        private System.Windows.Forms.CheckBox chkAutoAddto;
        internal System.Windows.Forms.TabPage tpAward;
    }
}