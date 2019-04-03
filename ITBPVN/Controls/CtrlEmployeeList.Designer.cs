namespace BPVN.LuckyDraw.Controls
{
	partial class CtrlEmployeeList
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
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmployeeListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDeleteEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxGroup = new System.Windows.Forms.ComboBox();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.ctrlProgress1 = new BPVN.LuckyDraw.Controls.CtrlProgress();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.dgvEmployeeListContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.AllowUserToAddRows = false;
            this.dgvEmployeeList.AllowUserToDeleteRows = false;
            this.dgvEmployeeList.AllowUserToOrderColumns = true;
            this.dgvEmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmployeeList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtId,
            this.txtEmpId,
            this.txtName,
            this.txtDept,
            this.txtPost});
            this.dgvEmployeeList.ContextMenuStrip = this.dgvEmployeeListContextMenu;
            this.dgvEmployeeList.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvEmployeeList.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.RowTemplate.Height = 23;
            this.dgvEmployeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeList.Size = new System.Drawing.Size(663, 520);
            this.dgvEmployeeList.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.DataPropertyName = "Id";
            this.txtId.HeaderText = "ID";
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Visible = false;
            this.txtId.Width = 43;
            // 
            // txtEmpId
            // 
            this.txtEmpId.DataPropertyName = "EmployeeId";
            this.txtEmpId.HeaderText = "Mã Nhân Viên";
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.ReadOnly = true;
            // 
            // txtName
            // 
            this.txtName.DataPropertyName = "Name";
            this.txtName.HeaderText = "Tên Nhân Viên";
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Width = 104;
            // 
            // txtDept
            // 
            this.txtDept.DataPropertyName = "Department";
            this.txtDept.HeaderText = "Bộ Phận";
            this.txtDept.Name = "txtDept";
            this.txtDept.ReadOnly = true;
            this.txtDept.Width = 73;
            // 
            // txtPost
            // 
            this.txtPost.DataPropertyName = "Post";
            this.txtPost.HeaderText = "Chức Vụ";
            this.txtPost.Name = "txtPost";
            this.txtPost.ReadOnly = true;
            this.txtPost.Width = 73;
            // 
            // dgvEmployeeListContextMenu
            // 
            this.dgvEmployeeListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeleteEmployee});
            this.dgvEmployeeListContextMenu.Name = "dgvEmployeeListContextMenu";
            this.dgvEmployeeListContextMenu.Size = new System.Drawing.Size(116, 26);
            // 
            // tsmiDeleteEmployee
            // 
            this.tsmiDeleteEmployee.Name = "tsmiDeleteEmployee";
            this.tsmiDeleteEmployee.Size = new System.Drawing.Size(115, 22);
            this.tsmiDeleteEmployee.Text = "Xóa(&D)";
            this.tsmiDeleteEmployee.Click += new System.EventHandler(this.tsmiDeleteEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(670, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Danh sách tham dự:";
            // 
            // cbxGroup
            // 
            this.cbxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGroup.FormattingEnabled = true;
            this.cbxGroup.Items.AddRange(new object[] {
            "Tất cả"});
            this.cbxGroup.Location = new System.Drawing.Point(672, 35);
            this.cbxGroup.Name = "cbxGroup";
            this.cbxGroup.Size = new System.Drawing.Size(90, 21);
            this.cbxGroup.TabIndex = 14;
            this.cbxGroup.SelectedIndexChanged += new System.EventHandler(this.cbxGroup_SelectedIndexChanged);
            // 
            // btnEmpty
            // 
            this.btnEmpty.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpty.Location = new System.Drawing.Point(670, 115);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(90, 43);
            this.btnEmpty.TabIndex = 13;
            this.btnEmpty.Text = "Xóa(&E)";
            this.btnEmpty.UseVisualStyleBackColor = true;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(670, 175);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(61, 15);
            this.lblCount.TabIndex = 12;
            this.lblCount.Text = "Số lượng:";
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(670, 66);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(90, 41);
            this.btnImport.TabIndex = 9;
            this.btnImport.Text = "Thêm mới(&I)";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // ctrlProgress1
            // 
            this.ctrlProgress1.Location = new System.Drawing.Point(110, 200);
            this.ctrlProgress1.Name = "ctrlProgress1";
            this.ctrlProgress1.Size = new System.Drawing.Size(443, 120);
            this.ctrlProgress1.TabIndex = 7;
            this.ctrlProgress1.Value = 0;
            this.ctrlProgress1.Visible = false;
            // 
            // CtrlEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxGroup);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.ctrlProgress1);
            this.Controls.Add(this.dgvEmployeeList);
            this.Controls.Add(this.btnEmpty);
            this.Controls.Add(this.lblCount);
            this.Name = "CtrlEmployeeList";
            this.Size = new System.Drawing.Size(790, 520);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.dgvEmployeeListContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvEmployeeList;
		private CtrlProgress ctrlProgress1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbxGroup;
		private System.Windows.Forms.Button btnEmpty;
		private System.Windows.Forms.Label lblCount;
		private System.Windows.Forms.Button btnImport;
		private System.Windows.Forms.ContextMenuStrip dgvEmployeeListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPost;
	}
}
