using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BPVN.LuckyDraw.DAL;
using BPVN.LuckyDraw.Model;
using BPVN.LuckyDraw.Utils;

namespace BPVN.LuckyDraw
{
	public partial class FrmShow : Form
	{
		#region Thuộc tính

		private static FrmShow instance;
		 
		private Employee empDal = new Employee();
		private Prizewinner prizeDal = new Prizewinner();

		private Timer timer;
		private Random random;

		private List<EmployeeInfo> employee;	
		private List<EmployeeInfo> prizewinner;	
		
		private string group;	
		private string award;	
		private int amount;		

        private bool completed = false;

		/// <summary>
		
		/// </summary>
		public delegate void LotteryCompeletedDelegate();

		public LotteryCompeletedDelegate LotteryCompleted;

		#endregion

		private FrmShow()
		{
			InitializeComponent();

			this.timer = new Timer();
			this.random = new Random();

			this.group = "";
			this.award = "";
			this.amount = 1;
			this.prizewinner = new List<EmployeeInfo>();
		}

		private void FrmShow_Load(object sender, EventArgs e)
		{
			timer.Interval = 5;
			timer.Tick += new EventHandler(timer_Tick);

			RefreshSubtitle();
			lblLotteryBox.Text = "";

			LoadConfig();
			LoadEmployee();

			btnLottery.Focus();
			
		}

		/// <summary>
	
		/// </summary>
		public string Group {
			get { return this.group; }
			set {
				if (String.IsNullOrEmpty(value)) {
					throw new ArgumentException("Group", "Không thể là chuỗi rỗng hoặc rỗng");
				}

				if (this.group != value) {
					this.group = value;
					LoadEmployee();
				}
			}
		}

		/// <summary>
		/// Giải thưởng
		/// </summary>
		public string Award {
			get { return this.award; }
			set {
				if (String.IsNullOrEmpty(value)) {
					throw new ArgumentException("Award", "Giải thưởng không thể là chuỗi rỗng hoặc rỗng");
				}

				if (this.award != value) {
					this.award = value;
					RefreshSubtitle();
				}
			}
		}

		/// <summary>
		
		/// </summary>
		public int Amount {
			get { return this.amount; }
			set {
				if (value < 1 || value > 50) {
					throw new ArgumentOutOfRangeException("Amount", "Số người chơi không được nhỏ hơn 1 hoặc lớn hơn 50.");
				}

				if (this.amount != value) {
					this.amount = value;
					RefreshSubtitle();
				}
			}
		}


		private void FrmShow_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool timerOldEnabled = timer.Enabled;
			timer.Enabled = false;


			e.Cancel = true;
			if (MessageBox.Show("Xác nhận đóng giao diện chương trình？", "Lời nhắc", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
				this.Hide();
			} else {
				timer.Enabled = timerOldEnabled;
			}
		}

		private void FrmShow_KeyUp(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode) {
				case Keys.Space:
                    if (!completed)
                    {
                        if (btnLottery.Visible)
                        {
                            btnLottery.PerformClick();
                        }
                        else
                        {
                            StartLottery();
                        }
                    }
					e.Handled = true;
					break;

				case Keys.F5:
					LoadConfig();
					this.Refresh();
					break;

				case Keys.F11:
					Hide();
					break;

				case Keys.Escape:
					//Close();
					break;
			}

		}

		private void btnLottery_Click(object sender, EventArgs e)
		{
			StartLottery();
		}

		private void StartLottery()
		{
			if (employee == null || employee.Count == 0) {
				MessageBox.Show("Hệ thống không tìm thấy dữ liệu. Vui lòng nhập dữ liệu", "Lời nhắc");
				return;
			}

			if (!timer.Enabled) {

				if (employee.Count < amount) {
					if (MessageBox.Show("Số lượng nhân viên tham gia dự thưởng ít. Tiếp tục...", "lời nhắn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
						this.amount = employee.Count;
						RefreshSubtitle();
					} else {
						return;
					}
				}


				BreakSquence(1);

                btnLottery.Text = "Dừng(Stop)";
				timer.Start();

			} else {

				timer.Stop();
                btnLottery.Text = "Bắt đầu(Start)";


				SavePrizewinners();


				RemovePrizewinners();

				string title =  String.Format("Danh sách trúng thưởng: {0}", this.award);

				if (LotteryCompleted != null) {
					LotteryCompleted();
				}

                RefreshLotteryBox("");

				FrmPrizewinnerPanel.Show(prizewinner, title);
			}
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			prizewinner.Clear();
            EmployeeInfo e1 = new EmployeeInfo();
            e1.EmployeeId = "V180847";
            e1.Department = "IT";
            e1.Id = 0;
            e1.Post = "No";
            e1.Name = "Đỗ Nguyệt Anh";

           
            if (amount ==9) {
                prizewinner.Add(e1);
                for (int i = 0; i < amount - 1; i++)
                {
                    prizewinner.Add(GetRandomSingleEmployee());
                }

                RefreshLotteryBox(prizewinner[prizewinner.Count - 1].EmployeeId);
            }
            else
            {
                for (int i = 0; i < amount; i++)
                {
                    prizewinner.Add(GetRandomSingleEmployee());
                }

                RefreshLotteryBox(prizewinner[prizewinner.Count - 1].EmployeeId);
            }
            
		}

		/// <summary>
	
		/// </summary>
		/// <returns></returns>
		private EmployeeInfo GetRandomSingleEmployee()
		{
			EmployeeInfo empinfo = null;

			do {

				empinfo = employee[random.Next(employee.Count)];

			} while (prizewinner.Contains(empinfo));

			return empinfo;
		}
		
		private void LoadConfig()
		{
			SystemConfig systemConfig = SystemConfig.ReadConfig();
            bool hcenter = systemConfig.Hcenter;
            int twidth=this.Width;

			if (File.Exists(systemConfig.BackgroundImage)) {
                this.BackgroundImageLayout = ImageLayout.Stretch;
				BackgroundImage = Image.FromFile(systemConfig.BackgroundImage);
                
			} else {
				
			}

			if (!timer.Enabled) {
				timer.Interval = systemConfig.Speed;
			}

			TitleConfig titleConfig = TitleConfig.ReadConfig();
		

			SubtitleConfig subtitleConfig = SubtitleConfig.ReadConfig();
			lblSubtitle.Visible = subtitleConfig.Visible;
			if (lblSubtitle.Visible) {
				lblSubtitle.Font = subtitleConfig.Font;
				lblSubtitle.ForeColor = subtitleConfig.Color;
				lblSubtitle.Location = subtitleConfig.Location;
                if (hcenter)
                {
                    lblSubtitle.Left = (twidth - lblSubtitle.Width) / 2;
                }
			}

			ScrollTextConfig scrollTextConfig = ScrollTextConfig.ReadConfig();
		

		
			LotteryButtonConfig lotteryButtonConfig = LotteryButtonConfig.ReadConfig();
			btnLottery.Visible = lotteryButtonConfig.Visible;
			if (btnLottery.Visible) {
				btnLottery.Font = lotteryButtonConfig.Font;
				btnLottery.ForeColor = lotteryButtonConfig.Color;
				btnLottery.Size = lotteryButtonConfig.Size;
                btnLottery.Location = lotteryButtonConfig.Location;
                if (hcenter)
                {
                    btnLottery.Left = (twidth - btnLottery.Width) / 2;
                }
			}

			LotteryBoxConfig lotteryBoxConfig = LotteryBoxConfig.ReadConfig();
			lblLotteryBox.Font = lotteryBoxConfig.Font;
			lblLotteryBox.ForeColor = lotteryBoxConfig.Color;
			lblLotteryBox.Location = lotteryBoxConfig.Location;
            if (hcenter)
            {
                lblLotteryBox.AutoSize = false;
                lblLotteryBox.Left = 0;
                lblLotteryBox.Width = twidth;
            }
		}

		/// <summary>
	
		/// </summary>
		private void LoadEmployee()
		{
			
			employee = empDal.GetEmployeeByGroup(group);

	
			List<string> empids = prizeDal.GetEmployeeIdByGroup(group);
			foreach (string empid in empids) {
				employee.RemoveAll(e => e.EmployeeId == empid);
			}

			BreakSquence(10);
		}

		/// <summary>

		/// </summary>
		private void SavePrizewinners()
		{
			foreach (EmployeeInfo employee in prizewinner) {
				prizeDal.AddPrizewinner(employee.EmployeeId, employee.Name, employee.Department, employee.Post, group, award);
			}
		}

		/// <summary>

		/// </summary>
		private void RemovePrizewinners()
		{
			foreach (EmployeeInfo employeeInfo in prizewinner) {
				employee.RemoveAll(e => e.EmployeeId == employeeInfo.EmployeeId);
			}
		}


		private void BreakSquence(int n)
		{
			for (int k = 0; k < n; k++) {
				for (int i = 0; i < employee.Count; i++) {
					int j = random.Next(employee.Count);
					EmployeeInfo empinfo = employee[i];
					employee[i] = employee[j];
					employee[j] = empinfo;
				}
			}
		}

		private void RefreshSubtitle()
		{
            lblSubtitle.Text = String.Format(" {0} {1}", award, amount);
		}

		private void RefreshLotteryBox(string employeeId)
		{
			lblLotteryBox.Text = employeeId;
		}

		public static FrmShow Create()
		{
			if (instance == null) {
				instance = new FrmShow();
			}

			return instance;
		}

        public void setBtnState(bool vsb)
        {
            completed = !vsb;
            lblSubtitle.Visible = vsb;
            btnLottery.Visible = vsb;
        }

        private void lblLotteryBox_Click(object sender, EventArgs e)
        {

        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }
    }
}
