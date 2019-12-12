
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectSnake
{
	/// <summary>
	/// Description of FrmMain.
	/// form chinh
	/// </summary>
	public partial class FrmMain : Form
	{
		private FrmOption frmOption;
		private FrmTopScore frmHighScore;
		private FrmMode1 frmMode1;
		private FrmMode2 frmMode2;
		private ClsData database;
		public FrmMain()
		{
			InitializeComponent();
			this.BackgroundImage = new Bitmap(Application.StartupPath + ClsParameter.LinkBackground + ClsParameter.Extension);
			this.BackgroundImageLayout = ImageLayout.Stretch;
			this.frmOption = new FrmOption();
			this.frmHighScore = new FrmTopScore();
			database = new ClsData();
		}
		void BtStartClick(object sender, EventArgs e)
		{
			this.Hide();
			if (frmOption.isSingle)
			{
				frmMode1 = new FrmMode1(frmOption.mapSize, 
				                        frmOption.hasBorder, 
				                        frmOption.BGcolor, 
				                        frmOption.snakeLengh, 
				                        frmOption.snakeSize, 
				                        frmOption.snakeColor1,  
				                        frmOption.foodColor, 
				                        frmOption.isSpeedup, 
				                        frmOption.playerKey1);
				frmMode1.ShowDialog();
				database.saveScore(frmMode1.playerName, frmMode1.score, (frmOption.hasBorder) ? 1 : 2);
			}
			else
			{
				frmMode2 = new FrmMode2(frmOption.mapSize,
				                        frmOption.hasBorder, 
				                        frmOption.BGcolor, 
				                        frmOption.snakeLengh, 
				                        frmOption.snakeSize, 
				                        frmOption.snakeColor1, 
				                        frmOption.snakeColor2, 
				                        frmOption.foodColor, 
				                        frmOption.isSpeedup, 
				                        frmOption.playerKey1, 
				                        frmOption.playerKey2);
				frmMode2.ShowDialog();
				database.saveScore(frmMode2.playerName1, frmMode2.playerName2, frmMode1.score, frmMode2.score2, (frmOption.hasBorder) ? 1 : 2);
			}
			this.Show();
		}
		void BtOptionClick(object sender, EventArgs e)
		{
			this.frmOption.ShowDialog();
		}
		void BtTopScoreClick(object sender, EventArgs e)
		{
			this.frmHighScore.ShowDialog();
		}
		void BtExitClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtStartMouseHover(object sender, EventArgs e)
		{
			this.btStart.BackColor = Color.DarkSlateBlue;
			this.btStart.ForeColor = Color.White;
		}
		void BtStartMouseLeave(object sender, EventArgs e)
		{
			this.btStart.BackColor = Color.MediumPurple;
			this.btStart.ForeColor = Color.Black;
		}
		void BtOptionMouseHover(object sender, EventArgs e)
		{
			this.btOption.BackColor = Color.DarkSlateBlue;
			this.btOption.ForeColor = Color.White;
		}
		void BtOptionMouseLeave(object sender, EventArgs e)
		{
			this.btOption.BackColor = Color.MediumPurple;
			this.btOption.ForeColor = Color.Black;
		}
		void BtTopcoreMouseHover(object sender, EventArgs e)
		{
			this.btTopScore.BackColor = Color.DarkSlateBlue;
			this.btTopScore.ForeColor = Color.White;
		}
		void BtTopcoreMouseLeave(object sender, EventArgs e)
		{
			this.btTopScore.BackColor = Color.MediumPurple;
			this.btTopScore.ForeColor = Color.Black;
		}
		void BtExitMouseHover(object sender, EventArgs e)
		{
			this.btExit.BackColor = Color.DarkSlateBlue;
			this.btExit.ForeColor = Color.White;
		}
		void BtExitMouseLeave(object sender, EventArgs e)
		{
			this.btExit.BackColor = Color.MediumPurple;
			this.btExit.ForeColor = Color.Black;
		}
	}
}
