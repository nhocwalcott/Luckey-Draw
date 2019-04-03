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
    public partial class CtrlDetail1 : UserControl, IUpdatable
    {
        private Award awardDal = new Award();
        private Detail detailDal = new Detail();
        public CtrlDetail1()
        {
            InitializeComponent();
        }
        private void CtrlDetail_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }

            BindAward();
        }

        private void BindAward()
        {
            dgvDetail.DataSource = detailDal.GetAllDetail();
            string award = (drbId_award.SelectedItem == null) ? "Tất cả" : drbId_award.SelectedItem.ToString();

            drbId_award.Items.Clear();
            drbId_award.Items.Add("Tất cả");

             List<string> awards = awardDal.GetAllAwards();
        
            foreach (string item in awards)
            {
                drbId_award.Items.Add(item);
            }

            if (drbId_award.Items.Contains(award))
            {
                drbId_award.SelectedItem = award;
            }
            else
            {
                drbId_award.SelectedIndex = 0;
            }
        }
        public void UpdateView()
        {
            BindAward();
            
        }
        private void RefreshPrizewinnner()
        {
           
            string award = drbId_award.SelectedItem == null ? String.Empty : drbId_award.SelectedItem.ToString();
            if (award == "Tất cả")
            {
                award = String.Empty;
            }
        }
        
        private void btnAdd_click(object sender, EventArgs e) {
            string award = "";
            award = drbId_award.Text;
            string name = "";
            name = textBox1.Text;
            string qty = "";
            qty = textBox2.Text;
            detailDal.AddDetail(name,award,qty);
            
        }
      
    }
}
