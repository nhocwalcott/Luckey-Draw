using System;
using System.Windows.Forms;

namespace BPVN.LuckyDraw
{
	public partial class InputBox : Form
	{
		public bool isAllowEmpty = true;

		public InputBox(string caption, string tip, bool isAllowEmpty)
		{
			InitializeComponent();

			base.Text = caption;
			this.lblTip.Text = tip;
			this.isAllowEmpty = isAllowEmpty;
			this.txtText.Text = String.Empty;

		}

		public new string Text {
			get { return this.txtText.Text; }
		}

		

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (!isAllowEmpty && String.IsNullOrEmpty(txtText.Text)) {
				errorProvider1.SetError(this.txtText, "Nội dung không được để trống.");
				return;
			}

			DialogResult = DialogResult.OK;
		}

		private void txtText_Enter(object sender, EventArgs e)
		{
			errorProvider1.SetError(this.txtText, "");
		}

		public static DialogResult Show(out string text, string caption, string tip, bool isAllowEmpty)
		{
			text = String.Empty;

			InputBox inputBox = new InputBox(caption, tip, isAllowEmpty);
			DialogResult result = inputBox.ShowDialog();
			if (result == DialogResult.OK) {
				text = inputBox.Text;
			}

			inputBox.Dispose();

			return result;
		}

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
