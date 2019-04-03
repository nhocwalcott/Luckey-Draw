using System;
using System.Drawing;
using System.Windows.Forms;

namespace BPVN.LuckyDraw.Controls
{
	public partial class CtrlSetting : UserControl
	{
		private SystemConfig systemConfig;
		private TitleConfig titleConfig;
		private SubtitleConfig subtitleConfig;
		private ScrollTextConfig scrollTextConfig;
		private LotteryButtonConfig lotteryButtonConfig;
		private LotteryBoxConfig lotteryBoxConfig;

		public CtrlSetting()
		{
			InitializeComponent();

			this.systemConfig = SystemConfig.ReadConfig();
			this.titleConfig = TitleConfig.ReadConfig();
			this.subtitleConfig = SubtitleConfig.ReadConfig();
			this.scrollTextConfig = ScrollTextConfig.ReadConfig();
			this.lotteryButtonConfig = LotteryButtonConfig.ReadConfig();
			this.lotteryBoxConfig = LotteryBoxConfig.ReadConfig();
		}

		private void CtrlSetting_Load(object sender, EventArgs e)
		{
            ckbHcenter.Checked = systemConfig.Hcenter;

			txtTitle.Text = titleConfig.Text;
			btnTitleColor.BackColor = titleConfig.Color;

			btnSubtitleColor.BackColor = subtitleConfig.Color;

			txtScrollText.Text = scrollTextConfig.Text;
			btnScrollTextColor.BackColor = scrollTextConfig.Color;

			txtBkImage.Text = systemConfig.BackgroundImage;

			btnLotteryButtonColor.BackColor = lotteryButtonConfig.Color;

			btnLotteryBoxColor.BackColor = lotteryBoxConfig.Color;

		}

		private void SaveConfigData()
		{

			titleConfig.Text = txtTitle.Text;
			titleConfig.Save();

			subtitleConfig.Save();

			scrollTextConfig.Text = txtScrollText.Text;
			scrollTextConfig.Save();

			systemConfig.BackgroundImage = txtBkImage.Text;
            systemConfig.Hcenter = ckbHcenter.Checked;
			systemConfig.Save();

			lotteryButtonConfig.Save();

			lotteryBoxConfig.Save();
		}

		
		private void btnSave_Click(object sender, EventArgs e)
		{
			try {
				SaveConfigData();
				MessageBox.Show("Lưu thành công！\r\nCần khởi động lại chương trình để có hiệu lực", "Lời nhắn");
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Sai");
			}
		}

		/// <summary>

		/// </summary>
		/// <param name="initFont"></param>
		/// <returns></returns>
		private Font ShowFontDialog(Font initFont)
		{
			if (initFont == null) {
				throw new ArgumentNullException("initFont");
			}

			FontDialog fontDialog = new FontDialog();
			fontDialog.Font = initFont;
			if (fontDialog.ShowDialog() == DialogResult.OK) {
				return fontDialog.Font;
			}

			return initFont;
		}

		/// <summary>

		/// </summary>
		/// <param name="initColor"></param>
		/// <returns></returns>
		private Color ShowColorDialog(Color initColor)
		{
			if (initColor == null) {
				throw new ArgumentNullException("initColor");
			}

			ColorDialog colorDialog = new ColorDialog();
			colorDialog.Color = initColor;
			if (colorDialog.ShowDialog() == DialogResult.OK) {
				return colorDialog.Color;
			}

			return initColor;
		}


		private void btnBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.RestoreDirectory = true;
			openFileDialog.Filter = "jpg,jpeg|*.jpg;*jpeg|png|*.png";
			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				txtBkImage.Text = openFileDialog.FileName;
			}
		}

		private void btnTitleFont_Click(object sender, EventArgs e)
		{
			titleConfig.Font = ShowFontDialog(titleConfig.Font);
			
		}

		private void btnTitleColor_Click(object sender, EventArgs e)
		{
			titleConfig.Color = ShowColorDialog(titleConfig.Color);
			btnTitleColor.BackColor = titleConfig.Color;
		}

		private void btnScrollTextFont_Click(object sender, EventArgs e)
		{
			scrollTextConfig.Font = ShowFontDialog(scrollTextConfig.Font);
		}

		private void btnScrollTextColor_Click(object sender, EventArgs e)
		{
			scrollTextConfig.Color = ShowColorDialog(scrollTextConfig.Color);
			btnScrollTextColor.BackColor = scrollTextConfig.Color;
		}

		private void btnLotteryButtonFont_Click(object sender, EventArgs e)
		{
			lotteryButtonConfig.Font = ShowFontDialog(lotteryButtonConfig.Font);
		}

		private void btnLotteryButtonColor_Click(object sender, EventArgs e)
		{
			lotteryButtonConfig.Color = ShowColorDialog(lotteryButtonConfig.Color);
			btnLotteryButtonColor.BackColor = lotteryButtonConfig.Color;
		}

		private void btnLotteryBoxFont_Click(object sender, EventArgs e)
		{
			lotteryBoxConfig.Font = ShowFontDialog(lotteryBoxConfig.Font);
		}

		private void btnLotteryBoxColor_Click(object sender, EventArgs e)
		{
			lotteryBoxConfig.Color = ShowColorDialog(lotteryBoxConfig.Color);
			btnLotteryBoxColor.BackColor = lotteryBoxConfig.Color;
		}

		private void btnSubtitleFont_Click(object sender, EventArgs e)
		{
			subtitleConfig.Font = ShowFontDialog(subtitleConfig.Font);
		}

		private void btnSubtitleColor_Click(object sender, EventArgs e)
		{
			subtitleConfig.Color = ShowColorDialog(subtitleConfig.Color);
			btnSubtitleColor.BackColor = subtitleConfig.Color;
		}
	}
}
