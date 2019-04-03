using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using BPVN.LuckyDraw.DAL;
using BPVN.LuckyDraw.Model;

namespace BPVN.LuckyDraw.Controls
{
	public partial class CtrlEmployeeList : UserControl, IUpdatable
	{
		private Employee empDal = new Employee();
		private string newGroup;

		public CtrlEmployeeList()
		{
			InitializeComponent();
		}

		public void UpdateView()
		{
			RefreshGroup(cbxGroup.SelectedItem);
		}

		/// <summary>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnImport_Click(object sender, EventArgs e)
        {
            string group;
            if (InputBox.Show(out group, "Lời nhắn", "Hãy Nhập toàn bộ danh sách", false) != DialogResult.OK)
            {
                return;
            }

            if (GetEmpDal().GroupIsExists(group) &&
                MessageBox.Show(string.Format("Đã tồn tại", group), "Lời nhắn", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            newGroup = group;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "xls(*.xls)|*.xls";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                btnImport.Enabled = false;
                btnEmpty.Enabled = false;
                ctrlProgress1.Visible = true;
                ctrlProgress1.Value = 0;

                
                BackgroundWorker worker = new BackgroundWorker();
                worker.WorkerReportsProgress = true;
                worker.DoWork += new DoWorkEventHandler(worker_DoWork);
                worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
                worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
                worker.RunWorkerAsync(new string[] { group, openFileDialog.FileName });
            }
        }

        private Employee GetEmpDal()
        {
            return empDal;
        }

        protected void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			RefreshGroup(newGroup);
			
			btnImport.Enabled = true;
			btnEmpty.Enabled = true;
			ctrlProgress1.Visible = false;
		}

		protected void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			ctrlProgress1.Value = e.ProgressPercentage;
		}

		protected void worker_DoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorker worker = sender as BackgroundWorker;
			List<EmployeeInfo> emps = new List<EmployeeInfo>();

			string[] argments = e.Argument as string[];
			string group = argments[0];
			string file = argments[1];

			try {

				using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read)) {

					IWorkbook workBook = new HSSFWorkbook(fs);
					ISheet sheet = workBook.GetSheetAt(0);

					for (int i = sheet.FirstRowNum; i <= sheet.LastRowNum; i++) {

						string empid = sheet.GetRow(i).GetCell(0).StringCellValue;
						string name = sheet.GetRow(i).GetCell(1).StringCellValue;
						string dept = sheet.GetRow(i).GetCell(2).StringCellValue;
						string post = sheet.GetRow(i).GetCell(3).StringCellValue;

						if (String.IsNullOrEmpty(empid) || String.IsNullOrEmpty(name)) {
							continue;
						}

						emps.Add(new EmployeeInfo { EmployeeId = empid, Name = name, Department = dept, Post = post });

					}

				}

				empDal.AddEmployee(emps, group, delegate(int percent) { worker.ReportProgress(percent); });

			} catch (NullReferenceException) {
				MessageBox.Show("Excel Định dạng chưa đúng!", "lời nhắn");
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString(), "Lời nhắn");
			}
		}

		private void tsmiDeleteEmployee_Click(object sender, EventArgs e)
		{
			if (dgvEmployeeList.SelectedRows.Count <= 0) {
				MessageBox.Show("Chọn nhân viên cần xóa.", "Lời nhắn");
				return;
			}

			if (MessageBox.Show("Bạn có chắc chắn muốn xóa NV？", "Lời nhắn", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) {
				return;
			}

			try {

				foreach (DataGridViewRow row in dgvEmployeeList.SelectedRows) {
					empDal.RemoveEmployeeById(row.Cells["txtId"].Value.ToString());
				}

				RefreshEmployee();

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Lời nhắn");
			}
		}

		private void btnEmpty_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn cần chắc chắn muốn xóa nhóm nhân viên hiện tại？", "Lời nhắn", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) {
				return;
			}

			try {

				string group = cbxGroup.SelectedItem == null ? String.Empty : cbxGroup.SelectedItem.ToString();
				empDal.RemoveEmployeeByGroup(group);

				dgvEmployeeList.DataSource = null;

				MessageBox.Show("Xóa thành công！", "Lời nhắn");

				RefreshGroup("");

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Lời nhắn");
			}
		}

		private void cbxGroup_SelectedIndexChanged(object sender, EventArgs e)
		{
			RefreshEmployee();
		}

		/// <summary>
		
		/// </summary>
		private void RefreshGroup(object group) 
		{
			List<string> groups = empDal.GetAllGroups();

			cbxGroup.Items.Clear();
			foreach (string item in groups) {
				cbxGroup.Items.Add(item);
			}

			if (group != null && cbxGroup.Items.Contains(group)) {
				cbxGroup.SelectedItem = group;
			} else if (cbxGroup.Items.Count > 0) {
				cbxGroup.SelectedIndex = 0;
			}
		}

		private void RefreshEmployee()
		{
			RebuildColumns();

			string group = cbxGroup.SelectedItem == null ? String.Empty : cbxGroup.SelectedItem.ToString();
			dgvEmployeeList.DataSource = empDal.GetEmployeeByGroup(group);
			lblCount.Text = "Số lượng:" + dgvEmployeeList.Rows.Count.ToString();
		}


		private void RebuildColumns()
		{
			dgvEmployeeList.Columns.Clear();

			DataGridViewTextBoxColumn txtId = new DataGridViewTextBoxColumn();
			txtId.DataPropertyName = "Id";
			txtId.HeaderText = "ID";
			txtId.Name = "txtId";
			txtId.ReadOnly = true;
			txtId.Visible = false;

			DataGridViewTextBoxColumn txtEmpId = new DataGridViewTextBoxColumn();
			txtEmpId.DataPropertyName = "EmployeeId";
            txtEmpId.HeaderText = "Mã NV";
			txtEmpId.Name = "txtEmpId";
			txtEmpId.ReadOnly = true;

			DataGridViewTextBoxColumn txtName = new DataGridViewTextBoxColumn();
			txtName.DataPropertyName = "Name";
            txtName.HeaderText = "Tên NV";
			txtName.Name = "txtName";
			txtName.ReadOnly = true;

			DataGridViewTextBoxColumn txtDept = new DataGridViewTextBoxColumn();
			txtDept.DataPropertyName = "Department";
            txtDept.HeaderText = "Bộ phận";
			txtDept.Name = "txtDept";
			txtDept.ReadOnly = true;
			txtDept.Width = 150;

			DataGridViewTextBoxColumn txtPost = new DataGridViewTextBoxColumn();
			txtPost.DataPropertyName = "Post";
			txtPost.HeaderText = "Chức vụ";
			txtPost.Name = "txtPost";
			txtPost.ReadOnly = true;
			txtPost.Width = 150;

            DataGridViewCheckBoxColumn txtSign = new DataGridViewCheckBoxColumn();
            txtSign.DataPropertyName = "Sign";
            txtSign.HeaderText = "Sign";
            txtSign.Name = "txtSign";
            txtSign.ReadOnly = true;
            txtSign.Width = 50;
            txtSign.Visible = false;

			dgvEmployeeList.Columns.AddRange(txtId, txtEmpId, txtName, txtDept, txtPost,txtSign);
		}
	}
}
