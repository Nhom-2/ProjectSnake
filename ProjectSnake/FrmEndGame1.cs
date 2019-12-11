
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectSnake
{
	/// <summary>
	/// Description of FrmNameAndScore.
	/// </summary>
	public partial class FrmEndGame1 : Form
	{
		public string name;
		public FrmEndGame1(int score)
		{
			InitializeComponent();
			this.lbScoreValue.Text = score.ToString();
			this.name = "";
		}
		void BtOKClick(object sender, EventArgs e)
		{
			this.name = this.tbName.Text;
			this.Close();
		}
		void FrmEndGame1FormClosing(object sender, FormClosingEventArgs e)
		{
			this.name = this.tbName.Text;
		}
	}
}
