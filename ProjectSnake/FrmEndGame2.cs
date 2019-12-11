
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectSnake
{
	/// <summary>
	/// Description of FrmEndGame2.
	/// </summary>
	public partial class FrmEndGame2 : Form
	{
		public string name1;
		public string name2;
		public FrmEndGame2(int score1, int score2)
		{
			InitializeComponent();
			this.lbScoreValue1.Text = score1.ToString();
			this.lbScoreValue2.Text = score2.ToString();
			this.name1 = "";
			this.name2 = "";
		}
		void BtOKClick(object sender, EventArgs e)
		{
			this.name1 = this.tbName1.Text;
			this.name2 = this.tbName2.Text;
			this.Close();
		}
		void FrmEndGame2FormClosing(object sender, FormClosingEventArgs e)
		{
			this.name1 = this.tbName1.Text;
			this.name2 = this.tbName2.Text;
		}
	}
}
