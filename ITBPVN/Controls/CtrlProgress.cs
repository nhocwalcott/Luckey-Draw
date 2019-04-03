using System.Windows.Forms;

namespace BPVN.LuckyDraw.Controls
{
	public partial class CtrlProgress : UserControl
	{
		public CtrlProgress()
		{
			InitializeComponent();
		}

		public int Value {
			get { return progressBar1.Value; }
			set { progressBar1.Value = value; }
		}
	}
}
