namespace BPVN.LuckyDraw.Controls
{
	partial class CtrlAward
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
            this.lbAwardContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDelAward = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAward = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudtcount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudonce = new System.Windows.Forms.NumericUpDown();
            this.dgvAward = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOncecount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.nudSort = new System.Windows.Forms.NumericUpDown();
            this.lbAwardContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudtcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudonce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSort)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAwardContextMenu
            // 
            this.lbAwardContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelAward});
            this.lbAwardContextMenu.Name = "lbAwardContextMenu";
            this.lbAwardContextMenu.Size = new System.Drawing.Size(111, 26);
            // 
            // tsmiDelAward
            // 
            this.tsmiDelAward.Name = "tsmiDelAward";
            this.tsmiDelAward.Size = new System.Drawing.Size(110, 22);
            this.tsmiDelAward.Text = "Xóa(&D)";
            this.tsmiDelAward.Click += new System.EventHandler(this.tsmiDelAward_Click);
            // 
            // txtAward
            // 
            this.txtAward.Location = new System.Drawing.Point(687, 34);
            this.txtAward.Name = "txtAward";
            this.txtAward.Size = new System.Drawing.Size(145, 20);
            this.txtAward.TabIndex = 5;
            this.txtAward.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAward_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(687, 239);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 29);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm mới(&A)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(560, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên giải thưởng:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cơ cấu giải:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nudtcount
            // 
            this.nudtcount.Location = new System.Drawing.Point(687, 98);
            this.nudtcount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudtcount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudtcount.Name = "nudtcount";
            this.nudtcount.Size = new System.Drawing.Size(75, 20);
            this.nudtcount.TabIndex = 9;
            this.nudtcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudtcount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số người thắng lượt:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nudonce
            // 
            this.nudonce.Location = new System.Drawing.Point(687, 139);
            this.nudonce.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudonce.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudonce.Name = "nudonce";
            this.nudonce.Size = new System.Drawing.Size(75, 20);
            this.nudonce.TabIndex = 11;
            this.nudonce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudonce.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgvAward
            // 
            this.dgvAward.AllowUserToAddRows = false;
            this.dgvAward.AllowUserToDeleteRows = false;
            this.dgvAward.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAward.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAward.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvAward.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAward.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtName,
            this.txtTcount,
            this.txtOncecount,
            this.txtSeq});
            this.dgvAward.ContextMenuStrip = this.lbAwardContextMenu;
            this.dgvAward.Location = new System.Drawing.Point(14, 3);
            this.dgvAward.Name = "dgvAward";
            this.dgvAward.ReadOnly = true;
            this.dgvAward.RowTemplate.Height = 23;
            this.dgvAward.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAward.Size = new System.Drawing.Size(482, 471);
            this.dgvAward.TabIndex = 12;
            this.dgvAward.SelectionChanged += new System.EventHandler(this.dgvAward_SelectionChanged);
            // 
            // txtName
            // 
            this.txtName.DataPropertyName = "name";
            this.txtName.HeaderText = "Tên giải thưởng";
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Width = 97;
            // 
            // txtTcount
            // 
            this.txtTcount.DataPropertyName = "tcount";
            this.txtTcount.HeaderText = "Cơ cấu giải";
            this.txtTcount.Name = "txtTcount";
            this.txtTcount.ReadOnly = true;
            this.txtTcount.Width = 78;
            // 
            // txtOncecount
            // 
            this.txtOncecount.DataPropertyName = "oncecount";
            this.txtOncecount.HeaderText = "Số người thắng lượt";
            this.txtOncecount.Name = "txtOncecount";
            this.txtOncecount.ReadOnly = true;
            this.txtOncecount.Width = 98;
            // 
            // txtSeq
            // 
            this.txtSeq.DataPropertyName = "seq";
            this.txtSeq.HeaderText = "Số lượt quay";
            this.txtSeq.Name = "txtSeq";
            this.txtSeq.ReadOnly = true;
            this.txtSeq.Width = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(586, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Số lượt quay:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nudSort
            // 
            this.nudSort.Location = new System.Drawing.Point(687, 187);
            this.nudSort.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudSort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSort.Name = "nudSort";
            this.nudSort.Size = new System.Drawing.Size(75, 20);
            this.nudSort.TabIndex = 14;
            this.nudSort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CtrlAward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAward);
            this.Controls.Add(this.nudSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudtcount);
            this.Controls.Add(this.nudonce);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAward);
            this.Name = "CtrlAward";
            this.Size = new System.Drawing.Size(877, 520);
            this.Load += new System.EventHandler(this.CtrlAward_Load);
            this.lbAwardContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudtcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudonce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.TextBox txtAward;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ContextMenuStrip lbAwardContextMenu;
		private System.Windows.Forms.ToolStripMenuItem tsmiDelAward;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudtcount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudonce;
        private System.Windows.Forms.DataGridView dgvAward;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTcount;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtOncecount;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSeq;
	}
}
