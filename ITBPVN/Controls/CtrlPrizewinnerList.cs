using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using BPVN.LuckyDraw.DAL;
using BPVN.LuckyDraw.Utils;
using BPVN.LuckyDraw.Model;

namespace BPVN.LuckyDraw.Controls
{
	public partial class CtrlPrizewinnerList : UserControl, IUpdatable 
	{
		private Prizewinner prizeDal = new Prizewinner();
		private Award awardDal = new Award();

		public CtrlPrizewinnerList()
		{
			InitializeComponent();
		}

		/// <summary>
	
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnExport_Click(object sender, EventArgs e)
		{
			if (dgvPrizewinnerList.Rows.Count == 0) {
				MessageBox.Show("Không có thông tin người thắng giải!.", "Lời nhắn");
				return;
			}

			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "xls(*.xls)|*.xls";
			saveFileDialog.RestoreDirectory = true;
			if (saveFileDialog.ShowDialog() == DialogResult.OK) {

				try {
					
					ExportToExcel(saveFileDialog.FileName);

					MessageBox.Show("Xuất thành công！", "Lời nhắn");

				} catch (Exception ex) {
					MessageBox.Show(ex.Message, "Sai");
				}
			}
		}

		private void cbxGroup_SelectedIndexChanged(object sender, EventArgs e)
		{
			RefreshPrizewinnner();
		}

		private void cbxAward_SelectedIndexChanged(object sender, EventArgs e)
		{
			RefreshPrizewinnner();

			//btnClear.Enabled = (dgvPrizewinnerList.Rows.Count > 0);
			btnClear.Enabled = !(cbxAward.SelectedItem.ToString() == "Tất cả");
			btnExport.Enabled = (dgvPrizewinnerList.Rows.Count > 0);
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			if (dgvPrizewinnerList.SelectedRows.Count <= 0) {
				MessageBox.Show("Không có thông tin nhân viên thắng cuộc rõ ràng.", "Lời nhắn");
				return;
			}

			if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên thắng cuộc?", "Lời nhắn", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
				string group = cbxGroup.SelectedItem == null ? String.Empty : cbxGroup.SelectedItem.ToString();
				string award = cbxAward.SelectedItem == null ? String.Empty : cbxAward.SelectedItem.ToString();
				
				prizeDal.RemovePrizewinnerByGroupAndAward(group, award);

				RefreshPrizewinnner();
			}
		}

		private void tsmiDeletePrizewinner_Click(object sender, EventArgs e)
		{
			if (dgvPrizewinnerList.SelectedRows.Count <= 0) {
				MessageBox.Show("Vui lòng chọn người chiến thắng cần xóa.", "Lời nhắn");
				return;
			}

			if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên thắng giải?", "Lời nhắn", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) {
				return;
			}

			try {

				foreach (DataGridViewRow row in dgvPrizewinnerList.SelectedRows) {
					prizeDal.RemovePrizewinnerById(row.Cells["txtId"].Value.ToString());
				}

				RefreshPrizewinnner();

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Lời nhắn");
			}
		}

		private void RefreshPrizewinnner()
		{
			string group = cbxGroup.SelectedItem == null ? String.Empty : cbxGroup.SelectedItem.ToString();
			string award = cbxAward.SelectedItem == null ? String.Empty : cbxAward.SelectedItem.ToString();
			if (award == "Tất cả") {
				award = String.Empty;
			}

			dgvPrizewinnerList.DataSource = prizeDal.GetPrizewinnersByGroupAndAward(group, award);
			lblCount.Text = String.Format("Số lượng:{0}", dgvPrizewinnerList.Rows.Count.ToString());
		}

		public void UpdateView()
		{
			BindGroup();
			BindAward();
		}

		/// <summary>

		/// </summary>
		private void BindGroup()
		{
			string selected = cbxGroup.SelectedItem == null ? String.Empty : cbxGroup.SelectedItem.ToString();

			cbxGroup.DataSource = prizeDal.GetGroups();

			if (cbxGroup.Items.Contains(selected)) {
				cbxGroup.SelectedItem = selected;
			}
		}

		/// <summary>

		/// </summary>
		private void BindAward()
		{
			string award = (cbxAward.SelectedItem == null) ? "Tất cả" : cbxAward.SelectedItem.ToString();

			cbxAward.Items.Clear();
			cbxAward.Items.Add("Tất cả");
			
			List<string> awards = awardDal.GetAllAwards();
			foreach (string item in awards) {
				cbxAward.Items.Add(item);
			}

			if (cbxAward.Items.Contains(award)) {
				cbxAward.SelectedItem = award;
			} else {
				cbxAward.SelectedIndex = 0;
			}
		}

		/// <summary>

		/// </summary>
		/// <param name="filename"></param>
		private void ExportToExcel(string filename)
		{
			using (FileStream fs = new FileStream(AppUtility.GetAppPath() + @"templates\prizewinner.xls", FileMode.Open, FileAccess.Read, FileShare.Read)) {

				IWorkbook workBook = new HSSFWorkbook(fs);
				ISheet sheet = workBook.GetSheetAt(0);

	
				sheet.GetRow(1).GetCell(1).SetCellValue(cbxGroup.SelectedItem.ToString());

				int i = 3;
				foreach (DataGridViewRow row in dgvPrizewinnerList.Rows) {
					IRow erow = sheet.CreateRow(i++);
					erow.CreateCell(0).SetCellValue(row.Cells["txtEmpId"].Value.ToString());
					erow.CreateCell(1).SetCellValue(row.Cells["txtName"].Value.ToString());
					erow.CreateCell(2).SetCellValue(row.Cells["txtDept"].Value.ToString());
					erow.CreateCell(3).SetCellValue(row.Cells["txtPost"].Value.ToString());
					erow.CreateCell(4).SetCellValue(row.Cells["txtAward"].Value.ToString());
                    erow.CreateCell(5).SetCellValue(row.Cells["boolsign"].Value.ToString());
				}

				using (FileStream fs2 = new FileStream(filename, FileMode.Create, FileAccess.Write)) {
					workBook.Write(fs2);
					fs2.Flush();
				}

			}	
		}

        private void dgvPrizewinnerList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //
            foreach (DataGridViewRow dgvr in dgvPrizewinnerList.Rows)
            {
                DataGridViewCheckBoxCell dcbc = (DataGridViewCheckBoxCell)dgvr.Cells["boolsign"];

                if (dcbc.Value != null && (bool)dcbc.Value == true)
                {
                    dgvr.DefaultCellStyle.BackColor = System.Drawing.Color.BlueViolet;

                }
            }

            dgvPrizewinnerList.ClearSelection();
        }

        private void tsmiSetYes_Click(object sender, EventArgs e)
        {
            SetAwordYesOrNo(true);
        }

        private void tsmiSetNo_Click(object sender, EventArgs e)
        {
            SetAwordYesOrNo(false);
        }

        private void SetAwordYesOrNo(bool YesOrNo)
        {
            if (dgvPrizewinnerList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn người thắng giải cần xóa!", "Lời nhắc");
                return;
            }

            if (MessageBox.Show("Đảm bảo nhân viên được chọn là["+(YesOrNo?"Đã nhận giải":"Không được chấp nhận")+"]？", "Lời nhắc", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }

            try
            {

                foreach (DataGridViewRow row in dgvPrizewinnerList.SelectedRows)
                {
                    prizeDal.UpdateSignPrizewinnerById(row.Cells["txtId"].Value.ToString(),YesOrNo);
                }

                RefreshPrizewinnner();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lời nhắc");
            }


        }


	}
}
