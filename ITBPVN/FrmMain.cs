using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;
using BPVN.LuckyDraw.DAL;
using BPVN.LuckyDraw.Model;
using System.Collections.Generic;

namespace BPVN.LuckyDraw
{
	public partial class FrmMain : Form
	{
		private static FrmShow frmShow;

		private SystemConfig systemConfig;

		private Employee employeeDal = new Employee();
		private Award awardDal = new Award();
        private Detail detailDal = new Detail();
		private Hashtable TabPageUpdateMap;

        private List<AwardRecords> awordRecords = new List<AwardRecords>();

        private int _addto = 0;

		public FrmMain()
		{
			InitializeComponent();

            if (ckbActiveAward.Checked)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }

            if (checkBox1.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }

			this.systemConfig = SystemConfig.ReadConfig();

			frmShow = FrmShow.Create();
			frmShow.VisibleChanged += new EventHandler(frmShow_VisibleChanged);
			frmShow.LotteryCompleted = new FrmShow.LotteryCompeletedDelegate(FrmShow_LotteryCompeleted);

			TabPageUpdateMap = new Hashtable();
			TabPageUpdateMap.Add(tpShow, null);
			TabPageUpdateMap.Add(tpEmployeeList, ctrlEmployeeList1);
			TabPageUpdateMap.Add(tpPrizewinnerList, ctrlPrizewinnerList1);
			TabPageUpdateMap.Add(tpAward, ctrlAward1);
			TabPageUpdateMap.Add(tpSetting, ctrlSetting1);
            TabPageUpdateMap.Add(tpDetail, ctrlDetail1);
            BindGroup();
			BindAward();

			LoadSetting();
            UpdateStateData(false, true,false);
            tabControl1.SelectedTab = tpShow;

		}

		/// <summary>

		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnFrmShow_Click(object sender, EventArgs e)
		{
			if (!CheckUserInput()) {
				return;
			}

			if (frmShow.Visible) {
				frmShow.Hide();
			} else {
				frmShow.Group = cbxGroup.Text;
				frmShow.Award = cbxAward.Text;
				frmShow.Amount = Convert.ToInt32(nudAmount.Value);
				frmShow.Show();
			}
		}

		private void frmShow_VisibleChanged(object sender, EventArgs e)
		{
			if (frmShow.Visible) {
                btnFrmShow.Text = "Hides the lottery interface\n\rẨn giao diện(&H)";
			} else {
                btnFrmShow.Text = "Shows the lottery interface\n\rHiển thị giao diện(&S)";
			}
		}

		private void FrmShow_LotteryCompeleted()
		{
            //int index = cbxAward.SelectedIndex;
            //if (++index < cbxAward.Items.Count) {
            //    cbxAward.SelectedIndex = index;
            //} else {
        
            //}

            UpdateStateData(false, false,false);
		}

		/// <summary>

		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnApply_Click(object sender, EventArgs e)
		{
			if (!CheckUserInput()) {
				return;
			}

			frmShow.Group = cbxGroup.Text;
			frmShow.Award = cbxAward.Text;
            if (Convert.ToInt32(nudAmount.Value) > Convert.ToInt32(txtBalanceQty.Text))
            {
                MessageBox.Show("Số lượng quay lớn hơn số lượng giải thưởng. Mời quay lại!");
            }
			frmShow.Amount = Convert.ToInt32(nudAmount.Value);
		}

		/// <summary>

		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Bạn có chắc muốn thoát chương trình？", "Lời nhắn", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) {
				e.Cancel = true;
				return;
			}

			SaveSetting();
		}

		private void tabControl1_Selected(object sender, TabControlEventArgs e)
		{
			if (e.TabPage == tpShow) {
				BindGroup();
				BindAward();
				return;
			}

			IUpdatable update = TabPageUpdateMap[e.TabPage] as IUpdatable;
			if (update != null) {
				update.UpdateView();
			}
		}

		private void cbxGroup_SelectedIndexChanged(object sender, EventArgs e)
		{
			if( cbxGroup.SelectedItem != null) {
				frmShow.Group = cbxGroup.SelectedItem.ToString();
			}
		}

		private void cbxAward_SelectedIndexChanged(object sender, EventArgs e)
		{
			frmShow.Award = cbxAward.SelectedItem.ToString();
            UpdateStateData(false, true,false);
		}

		private void nudAmount_ValueChanged(object sender, EventArgs e)
		{
			frmShow.Amount = Convert.ToInt32(nudAmount.Value);
		}

		private bool CheckUserInput()
		{
			if (String.IsNullOrEmpty(cbxGroup.Text)) {
				MessageBox.Show("Vui lòng chọn số", "Thông báo!");
				return false;
			}

			if (String.IsNullOrEmpty(cbxAward.Text)) {
				MessageBox.Show("Vui lòng chọn giải thưởng rút thăm may mắn này", "Thông báo!");
				return false;
			}

			return true;
		}

		private void BindGroup()
		{
			string group = (cbxGroup.SelectedItem == null) ? String.Empty : cbxGroup.SelectedItem.ToString();

			cbxGroup.DataSource = employeeDal.GetAllGroups();

			if (cbxGroup.Items.Contains(group)) {
				cbxGroup.SelectedItem = group;
			}
		}

		private void BindAward()
		{
			string award = (cbxAward.SelectedItem == null) ? String.Empty : cbxAward.SelectedItem.ToString();

			cbxAward.DataSource = awardDal.GetAllAwards();

			if (cbxAward.Items.Contains(award)) {
				cbxAward.SelectedItem = award;
			}

            awordRecords = awardDal.GetAllAwards(true);
		}

		private void LoadSetting()
		{
			tabControl1.SelectedIndex = systemConfig.CurrentTabPage;

			if (cbxGroup.Items.Contains(systemConfig.Group)) {
				cbxGroup.SelectedItem = systemConfig.Group;
			}

			if (cbxAward.Items.Contains(systemConfig.Award)) {
				cbxAward.SelectedItem = systemConfig.Award;
			}

			if (systemConfig.Amount >= 1 && systemConfig.Amount <= 10) {
				nudAmount.Value = systemConfig.Amount;
			}
		}

		private void SaveSetting()
		{
			systemConfig.CurrentTabPage = tabControl1.SelectedIndex;
			
			if (cbxGroup.SelectedItem != null) {
				systemConfig.Group = cbxGroup.SelectedItem.ToString();
			}

			if (cbxAward.SelectedItem != null) {
				systemConfig.Award = cbxAward.SelectedItem.ToString();
			}

			systemConfig.Amount = Convert.ToInt32(nudAmount.Value);

			systemConfig.Save();
		}

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefSign();
        }

        private void RefSign()
        {
            List<EmployeeInfo> einfo = FrmPrizewinnerPanel.GetPrizewinners();
            int xindex = 0;
            int xcount = 0;
            if (einfo != null) { xcount = einfo.Count; }


            Font ft = new System.Drawing.Font("Times New Roman", 12, FontStyle.Bold);

            for (int row = 0; row < tablelp.RowCount; row++)
            {
                for (int col = 0; col < tablelp.ColumnCount; col++)
                {
                    Control ctl = tablelp.GetControlFromPosition(col, row);
                    if (ctl != null)
                    {
                        ctl.Dispose();
                        ctl = null;
                    }
                    if (xcount > 0 && xindex < xcount)
                    {
                        Button btnx = new Button();
                        btnx.Name = "btnnn" + einfo[xindex].EmployeeId;
                        btnx.Text = einfo[xindex].EmployeeId + "  " + einfo[xindex].Name;
                        btnx.Tag = einfo[xindex].EmployeeId;
                        btnx.Height = 10;
                        btnx.Width = 30;
                        btnx.Dock = DockStyle.Fill;
                        btnx.Visible = true;
                        btnx.Font = ft;
                        btnx.Click += new EventHandler(btnx_Click);
                        if (einfo[xindex].Sign)
                        {
                            btnx.BackColor = System.Drawing.Color.Blue;
                        }
                        tablelp.Controls.Add(btnx, col, row);
                        xindex++;
                    }
                }
            }           

        }

        void btnx_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            string sid = ((Button)sender).Tag.ToString();
            FrmPrizewinnerPanel.Sign(sid);
            RefSign();
        }

        private void UpdateStateData(bool isNext,bool isSelectChange,bool isAddto)
        {
            txtTotal.Text = "";
            txtAwordQty.Text = "";
            txtBalanceQty.Text = "";

            string xgroup = cbxGroup.Text;
            if (cbxAward.SelectedItem == null)
            {
                return;
            }

            string xaward = cbxAward.SelectedItem.ToString();

            if (awordRecords != null)
            {
                if (awordRecords.Count > 0)
                {
                    foreach (AwardRecords ar in awordRecords)
                    {
                        if (ar.Name == xaward)
                        {
                            txtTotal.Text = ar.Tcount.ToString();
                            int xxx = 0;
                            if (ckbNoSign.Checked)
                            {
                                txtAwordQty.Text = (new Prizewinner().GetPrizewinnersByGroupAndAwardCount(xgroup, xaward, true)).ToString();
                            }
                            else
                            {
                                txtAwordQty.Text = (new Prizewinner().GetPrizewinnersByGroupAndAwardCount(xgroup, xaward, false)).ToString();
                            }                            
                            int.TryParse(txtAwordQty.Text, out xxx);
                            txtBalanceQty.Text = (ar.Tcount - xxx).ToString();
                           if(ar.Tcount - xxx <= 0)
                            {
                                MessageBox.Show("Số giải thưởng đã hết. Vui lòng quay giải thưởng khác.");
                            }
                            int yyy =0;
                            int.TryParse(txtBalanceQty.Text,out yyy);

                            if (isAddto && _addto > 0 && chkAutoAddto.Checked)
                            {
                                nudAmount.Value = _addto;
                            }
                            else if (isAddto && _addto == 0)
                            {
                                isSelectChange = true;
                            }                            
                            
                            if (isSelectChange && yyy > 0 && yyy < ar.Oncecount)
                            {
                                nudAmount.Value = yyy;
                            }
                            else if (isSelectChange)
                            {
                                nudAmount.Value = ar.Oncecount;
                            }
                            else if (isNext && yyy > 0 && yyy < ar.Oncecount)
                            {
                                nudAmount.Value =yyy;
                            }

                            if (isNext && ckbAutoChange.Checked && yyy <= 0)
                            {
                                int index = cbxAward.SelectedIndex;
                                if (++index < cbxAward.Items.Count)
                                {
                                    cbxAward.SelectedIndex = index;
                                }
                                else
                                {
                                    ckbCompleted.Checked = true;
                                }
                            }
                            
                            break;
                        }
                    }
                }
            }
        }

        public static void RefreshSign()
        {
            foreach (Form fm in Application.OpenForms)
            {
                if (fm.GetType().ToString() == "BPVN.Luckey_draw.FrmMain")
                {
                    ((FrmMain)fm).RefSign();
                }
            }
        }

        public static void UpdateStateDataOuter(int addto)
        {
            foreach (Form fm in Application.OpenForms)
            {
                if (fm.GetType().ToString() == "BPVN.Luckey_draw.FrmMain")
                {
                    ((FrmMain)fm)._addto = addto;
                    ((FrmMain)fm).UpdateStateData(true,false,true);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (frmShow != null)
            {
                if (frmShow.Visible)
                {

                    bool xshow=false;
                    Form xform = null;
                    foreach (Form fm in Application.OpenForms)
                    {
                        if (fm.GetType().ToString() == "BPVN.Luckey_draw.FrmPrizewinnerPanel")
                        {
                            if (((FrmPrizewinnerPanel)fm).Visible)
                            {
                                xshow = true;
                                xform = fm;
                                break;
                            }
                        }
                    }

                    if (xshow)
                    {
                        xform.Activate();
                    }
                    else
                    {
                        frmShow.Activate();
                    }
                }
            }                
        }

        private void ckbActiveAward_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbActiveAward.Checked)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;

            }
        }

        private void ckbCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (frmShow != null)
            {
                if (frmShow.Visible)
                {
                    frmShow.setBtnState(!ckbCompleted.Checked);
                }
            }  
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = (sender as CheckBox).Checked;
        }

        private void ckbNoSign_CheckedChanged(object sender, EventArgs e)
        {
            UpdateStateData(false, true,false);
        }

        private void ckbAutoChange_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void SetAmount(int iaward)
        {
            try
            {
                nudAmount.Value = iaward;
            }
            catch { }
        }

        private void ctrlAward1_Load(object sender, EventArgs e)
        {

        }

        private void tablelp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void ctrlSetting1_Load(object sender, EventArgs e)
        {

        }
    }
}
