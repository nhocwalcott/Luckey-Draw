using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BPVN.LuckyDraw.Model;
using BPVN.LuckyDraw.DAL;

namespace BPVN.LuckyDraw
{
	public partial class FrmPrizewinnerPanel : Form
	{
		private static FrmPrizewinnerPanel form = null;

		public FrmPrizewinnerPanel()
		{
			InitializeComponent();
		}

		public string Title {
			get { return this.lblTitle.Text; }
			set { this.lblTitle.Text = value; }
		}
		
        private void FrmPrizewinnnerPanel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Space)
            {
                int addtocount = 0;
                List<EmployeeInfo> EiAword = Prizewinners;
                if (EiAword != null)
                {
                    if (EiAword.Count > 0)
                    {
                        addtocount = EiAword.Count - EiAword.FindAll(t => t.Sign == true).Count;
                    }
                }
                this.Close();
                FrmMain.RefreshSign();
                FrmMain.UpdateStateDataOuter(addtocount);
            }
        }

		private void FrmPrizewinnerPanel_Resize(object sender, EventArgs e)
		{
			int x = (this.Width - lblTitle.Width) / 2;
			lblTitle.Location = new Point(x, lblTitle.Location.Y);
		}
		
		public List<EmployeeInfo> Prizewinners
		{
			get { return ctrlPrizewinnerTable1.Prizewinners; }
		}

        public void SignInner(string empid)
        {
            if (Prizewinners != null)
            {
                foreach (EmployeeInfo eli in Prizewinners)
                {
                    if (eli.EmployeeId == empid)
                    {
                        try
                        {
                            new Prizewinner().UpdateSignPrizewinnerByEmpID(empid, !eli.Sign);
                            eli.Sign = !eli.Sign;
                        }
                        catch //(Exception ex)
                        {

                        }                        
                        
                        this.Invalidate();
                        break;
                    }
                }                
            }
        }

		public static void Show(List<EmployeeInfo> prizewinners, string title, Point location)
		{
			if (prizewinners == null) {
				throw new ArgumentNullException("prizewinners", "Tham số không được để trống.");
			}

			//if (form == null) {
				form = new FrmPrizewinnerPanel();
			//}

			form.Prizewinners.Clear();
			form.Prizewinners.AddRange(prizewinners);
			form.Title = title;
			form.StartPosition = FormStartPosition.Manual;
			form.Location = location;
            //form.TopMost = true;
			//form.ShowDialog();
            form.Show();
         
            FrmMain.RefreshSign();
		}

		public static void Show(List<EmployeeInfo> prizewinners, string title)
		{
			Show(prizewinners, title, new Point(0, 0));
		}

        public static void Sign(string empid)
        {

            try
            {
                if (form != null)
                {
                    form.SignInner(empid);
                }
            }
            catch
            { }


        }

        public static List<EmployeeInfo> GetPrizewinners()
        {

            try
            {
                if (form != null)
                {
                    if (form.Visible)
                    {
                        return form.Prizewinners;
                    }
                }

            }
            catch
            { }

            return new List<EmployeeInfo>();
        }

        private void ctrlPrizewinnerTable1_Load(object sender, EventArgs e)
        {

        }

	}
}
