using System;
using System.Windows.Forms;
using BPVN.LuckyDraw.DAL;

namespace BPVN.LuckyDraw.Controls
{
	public partial class CtrlAward : UserControl
	{
		private Award awardDal = new Award();

		public CtrlAward()
		{
			InitializeComponent();
		}

		private void CtrlAward_Load(object sender, EventArgs e)
		{
			if (this.DesignMode) {
				return;
			}

			BindAward();
		}

		private void BindAward()
		{

            dgvAward.DataSource = awardDal.GetAllAwards(true);
            dgvAward_SelectionChanged(dgvAward, new EventArgs());
			//lbAward.DataSource = awardDal.GetAllAwards(true);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(txtAward.Text)) {
				MessageBox.Show("Vui lòng nhập tên giải thưởng!。", "Lời nhắn");
				return;
			}

			try {
				if (awardDal.IsExist(txtAward.Text)) {
                    if (MessageBox.Show("Giải Thưởng đã tồn tại!，Bạn muốn cập nhật？", "Lời nhắn", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    {
                        return;
                    }
				}

                int tcount = 0;
                int.TryParse(nudtcount.Value.ToString(), out tcount);

                int oncecount = 0;
                int.TryParse(nudonce.Value.ToString(), out oncecount);

                int seq = 0;
                int.TryParse(nudSort.Value.ToString(), out seq);

                awardDal.AddAward(txtAward.Text, tcount, oncecount,seq);
				BindAward();
				//txtAward.Text = "";
                txtAward.Focus();

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Lời nhắn");
			}
		}

		private void tsmiDelAward_Click(object sender, EventArgs e)
		{
            if (dgvAward.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Lựa chọn giải thưởng cần xóa!。", "lời nhắn");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa giải thưởng", "Lời nhắn", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }


            foreach (DataGridViewRow dgvr in dgvAward.SelectedRows)
            {
                string sname = dgvr.Cells["txtName"].Value.ToString();
                awardDal.RemoveAward(sname);
            }

            BindAward();
		}

		private void txtAward_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				btnAdd.PerformClick();
			}
		}

        private void dgvAward_SelectionChanged(object sender, EventArgs e)
        {
            //
            if (dgvAward.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvr = dgvAward.SelectedRows[0];
                txtAward.Text = dgvr.Cells["txtName"].Value.ToString();
                nudtcount.Value = Convert.ToDecimal(dgvr.Cells["txtTcount"].Value);
                nudonce.Value = Convert.ToDecimal(dgvr.Cells["txtOncecount"].Value);
                nudSort.Value = Convert.ToDecimal(dgvr.Cells["txtSeq"].Value);


            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
	}
}
