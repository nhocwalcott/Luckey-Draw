namespace BPVN.LuckyDraw.Controls
{
	partial class CtrlPrizewinnerList
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.dgvPrizewinnerList = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boolsign = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvPrizewinnerListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSetYes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetNo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDeletePrizewinner = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxAward = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.cbxGroup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrizewinnerList)).BeginInit();
            this.dgvPrizewinnerListContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrizewinnerList
            // 
            this.dgvPrizewinnerList.AllowUserToAddRows = false;
            this.dgvPrizewinnerList.AllowUserToOrderColumns = true;
            this.dgvPrizewinnerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPrizewinnerList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPrizewinnerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtId,
            this.txtEmpId,
            this.txtName,
            this.txtDept,
            this.txtPost,
            this.txtAward,
            this.boolsign});
            this.dgvPrizewinnerList.ContextMenuStrip = this.dgvPrizewinnerListContextMenu;
            this.dgvPrizewinnerList.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvPrizewinnerList.Location = new System.Drawing.Point(0, 0);
            this.dgvPrizewinnerList.Name = "dgvPrizewinnerList";
            this.dgvPrizewinnerList.RowTemplate.Height = 23;
            this.dgvPrizewinnerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrizewinnerList.Size = new System.Drawing.Size(613, 520);
            this.dgvPrizewinnerList.TabIndex = 6;
            this.dgvPrizewinnerList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPrizewinnerList_DataBindingComplete);
            // 
            // txtId
            // 
            this.txtId.DataPropertyName = "Id";
            this.txtId.HeaderText = "ID";
            this.txtId.Name = "txtId";
            this.txtId.Visible = false;
            this.txtId.Width = 43;
            // 
            // txtEmpId
            // 
            this.txtEmpId.DataPropertyName = "EmployeeId";
            this.txtEmpId.HeaderText = "Mã nhân viên";
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.ReadOnly = true;
            this.txtEmpId.Width = 97;
            // 
            // txtName
            // 
            this.txtName.DataPropertyName = "Name";
            this.txtName.HeaderText = "Họ Tên";
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Width = 68;
            // 
            // txtDept
            // 
            this.txtDept.DataPropertyName = "Department";
            this.txtDept.HeaderText = "Bộ phận";
            this.txtDept.Name = "txtDept";
            this.txtDept.ReadOnly = true;
            this.txtDept.Width = 72;
            // 
            // txtPost
            // 
            this.txtPost.DataPropertyName = "Post";
            this.txtPost.HeaderText = "Chức vụ";
            this.txtPost.Name = "txtPost";
            this.txtPost.ReadOnly = true;
            this.txtPost.Width = 72;
            // 
            // txtAward
            // 
            this.txtAward.DataPropertyName = "Award";
            this.txtAward.HeaderText = "Giải Thưởng";
            this.txtAward.Name = "txtAward";
            this.txtAward.ReadOnly = true;
            this.txtAward.Width = 90;
            // 
            // boolsign
            // 
            this.boolsign.DataPropertyName = "sign";
            this.boolsign.FalseValue = "0";
            this.boolsign.HeaderText = "Đã nhận /Chưa nhận";
            this.boolsign.Name = "boolsign";
            this.boolsign.ReadOnly = true;
            this.boolsign.TrueValue = "1";
            this.boolsign.Width = 114;
            // 
            // dgvPrizewinnerListContextMenu
            // 
            this.dgvPrizewinnerListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSetYes,
            this.tsmiSetNo,
            this.toolStripMenuItem1,
            this.tsmiDeletePrizewinner});
            this.dgvPrizewinnerListContextMenu.Name = "dgvPrizewinnerListContextMenu";
            this.dgvPrizewinnerListContextMenu.Size = new System.Drawing.Size(210, 76);
            // 
            // tsmiSetYes
            // 
            this.tsmiSetYes.Name = "tsmiSetYes";
            this.tsmiSetYes.Size = new System.Drawing.Size(209, 22);
            this.tsmiSetYes.Text = "Thiết lập đã nhận giải";
            this.tsmiSetYes.Click += new System.EventHandler(this.tsmiSetYes_Click);
            // 
            // tsmiSetNo
            // 
            this.tsmiSetNo.Name = "tsmiSetNo";
            this.tsmiSetNo.Size = new System.Drawing.Size(209, 22);
            this.tsmiSetNo.Text = "Thiết lập không nhận giải";
            this.tsmiSetNo.Click += new System.EventHandler(this.tsmiSetNo_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(206, 6);
            // 
            // tsmiDeletePrizewinner
            // 
            this.tsmiDeletePrizewinner.Name = "tsmiDeletePrizewinner";
            this.tsmiDeletePrizewinner.Size = new System.Drawing.Size(209, 22);
            this.tsmiDeletePrizewinner.Text = "Xóa(&D)";
            this.tsmiDeletePrizewinner.Click += new System.EventHandler(this.tsmiDeletePrizewinner_Click);
            // 
            // cbxAward
            // 
            this.cbxAward.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAward.FormattingEnabled = true;
            this.cbxAward.Location = new System.Drawing.Point(657, 93);
            this.cbxAward.Name = "cbxAward";
            this.cbxAward.Size = new System.Drawing.Size(90, 21);
            this.cbxAward.TabIndex = 10;
            this.cbxAward.SelectedIndexChanged += new System.EventHandler(this.cbxAward_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(657, 120);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 44);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Xóa(&C)";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(657, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Giải thưởng:";
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(657, 170);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(90, 44);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Xuất DL(&E)";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // cbxGroup
            // 
            this.cbxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGroup.FormattingEnabled = true;
            this.cbxGroup.Location = new System.Drawing.Point(652, 29);
            this.cbxGroup.Name = "cbxGroup";
            this.cbxGroup.Size = new System.Drawing.Size(90, 21);
            this.cbxGroup.TabIndex = 10;
            this.cbxGroup.SelectedIndexChanged += new System.EventHandler(this.cbxGroup_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(645, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Danh sách tham dự:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(657, 230);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(59, 15);
            this.lblCount.TabIndex = 12;
            this.lblCount.Text = "Số lượng:";
            // 
            // CtrlPrizewinnerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPrizewinnerList);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxAward);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.cbxGroup);
            this.Controls.Add(this.btnClear);
            this.Name = "CtrlPrizewinnerList";
            this.Size = new System.Drawing.Size(790, 520);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrizewinnerList)).EndInit();
            this.dgvPrizewinnerListContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvPrizewinnerList;
		private System.Windows.Forms.ComboBox cbxAward;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.ComboBox cbxGroup;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ContextMenuStrip dgvPrizewinnerListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeletePrizewinner;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetYes;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetNo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAward;
        private System.Windows.Forms.DataGridViewCheckBoxColumn boolsign;
	}
}
