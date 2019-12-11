
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectSnake
{
	public partial class FrmMode1 : Form
	{
		/// <summary>
		/// Description of FrmOption.
		/// form chay game mode 1
		/// </summary>
		private readonly int MapSizeWidth;
		private readonly int MapSizeHeight;
		private readonly bool hasBorder;
		
		private ClsSnake snake;
		private ClsFood food;
		private ClsKeyCode key;
		
		private bool isSpeedup;
		
		private bool increaceFree;
		
		private ClsProcessLogic process;
		private ClsEventKey press;
		
		public string playerName;
		public int score;
		
		public FrmMode1(ClsMapWidthHeight winsize, 
		                bool hasborder,
		                string color, 
		                int lengh, 
		                int snakesize, 
		                string snakecolor, 
		                string foodcolor, 
		                bool isspeedup, 
		                ClsKeyCode playerkey)
		{
			InitializeComponent();
			this.MapSizeWidth = winsize.Width;
			this.MapSizeHeight = winsize.Height;
			this.hasBorder = hasborder;

			this.ptbBorder.Visible = (this.hasBorder);
			
			this.snake = new ClsSnake(lengh, snakesize, snakecolor, 2, this.MapSizeWidth, this.MapSizeHeight);
			this.food = new ClsFood(foodcolor);
			
			this.isSpeedup = isspeedup;
			this.key = playerkey;
			
			this.increaceFree = false;
			
			this.process = new ClsProcessLogic();
			this.press = new ClsEventKey();
			
			this.score = 0;
			
			this.setWindow();
			
			this.timerDelay.Interval = ClsParameter.DelayDefault;
			this.timerDelay.Start();
			this.timerCheckAlive.Start();
			
			this.food.generateFood(snake, MapSizeWidth, MapSizeHeight);
		}
		private void setWindow()
		{
			this.Width = (this.MapSizeWidth + 9) + ClsParameter.MarginLeft * 2;
			this.Height = (this.MapSizeHeight + 32) + ClsParameter.MarginTop + ClsParameter.MarginLeft;
			this.ptbGame.Width = (MapSizeWidth + 3);
			this.ptbGame.Height = (MapSizeHeight + 3);
			this.ptbBorder.Width = this.ptbGame.Width + ClsParameter.BorderSize * 2;
			this.ptbBorder.Height = this.ptbGame.Height + ClsParameter.BorderSize * 2;
			this.ptbGame.Location = new Point((this.Width - this.ptbGame.Width) / 2 - 3, ClsParameter.MarginTop);
			this.ptbBorder.Location = new Point(((this.Width - this.ptbGame.Width) / 2 - 3) - ClsParameter.BorderSize, ClsParameter.MarginTop - ClsParameter.BorderSize);
			this.lbScore.Location = new Point((this.Width - this.lbScore.Width) / 2, (ClsParameter.MarginTop - this.lbScore.Height) / 2);
			this.lbScore.ForeColor = ClsParameter.TextColor;
			this.lbScore.BackColor = Color.Transparent;
			this.lbPause.Location = new Point((this.ptbGame.Width - this.lbPause.Width) / 2, (this.ptbGame.Height - this.lbPause.Height) / 2);
			this.lbPause.Parent = this.ptbGame;
			this.lbPause.ForeColor = ClsParameter.TextColor;this.lbScore.Parent = this;
			this.lbPause.BackColor = Color.Transparent;
			this.lbPause.Visible = false;
		}
		void TimerDelayTick(object sender, EventArgs e)
		{	

		}
		void TimerCheckAliveTick(object sender, EventArgs e)
		{

		}
		void PtbGamePaint(object sender, PaintEventArgs e)
		{

		}
		private void resumeGame()
		{

		}
		private void pauseGame()
		{

		}
		void FrmRunGameKeyDown(object sender, KeyEventArgs e)
		{

			ClsInput.ChangeState(e.KeyCode, true);
		}
		void FrmMode1KeyUp(object sender, KeyEventArgs e)
		{
			ClsInput.ChangeState(e.KeyCode, false);
		}
		void FrmMode1FormClosing(object sender, FormClosingEventArgs e)
		{

		}
	}
}
