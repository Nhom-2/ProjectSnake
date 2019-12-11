
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
			
			this.BackgroundImage = new Bitmap(Application.StartupPath + ClsParameter.LinkBackground + ClsParameter.Extension);
			this.BackgroundImageLayout = ImageLayout.Stretch;
			this.ptbGame.BackgroundImage = new Bitmap(Application.StartupPath + ClsParameter.LinkBGGame + color + ClsParameter.Extension);
			this.ptbGame.BackgroundImageLayout = ImageLayout.Stretch;
			this.ptbBorder.BackgroundImage = new Bitmap(Application.StartupPath + ClsParameter.LinkBDGame + ClsParameter.Extension);
			this.ptbBorder.BackgroundImageLayout = ImageLayout.Stretch;
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
			this.press.processEventKey(this.snake, this.key);
			if (hasBorder)
				this.process.logicBorderEnable(snake, ref this.increaceFree, food, this.MapSizeWidth, this.MapSizeHeight, this.isSpeedup, this.timerDelay);
			else
				this.process.logicBorderDisable(snake, ref this.increaceFree, food, this.MapSizeWidth, this.MapSizeHeight, this.isSpeedup, this.timerDelay);
			this.ptbGame.Invalidate();
		}
		void TimerCheckAliveTick(object sender, EventArgs e)
		{
			if (!this.snake.Status)
				this.Close();
		}
		void PtbGamePaint(object sender, PaintEventArgs e)
		{
			this.lbScore.Text = string.Concat("Score ", ((this.snake.lengh - ClsParameter.SnakeLenghDefault) * 15).ToString());
			this.food.drawFood(e, this.snake.Size);
			this.snake.drawSnake(e);
		}
		private void resumeGame()
		{
			this.lbPause.Visible = false;
			this.timerDelay.Start();
			this.timerCheckAlive.Start();
		}
		private void pauseGame()
		{
			this.lbPause.Visible = true;
			this.lbPause.Text = "Press any key";
			this.timerDelay.Stop();
			this.timerCheckAlive.Stop();
		}
		void FrmRunGameKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Space)
			{
				this.pauseGame();
				return;
			}
			if (!timerDelay.Enabled)
				this.resumeGame();
			ClsInput.ChangeState(e.KeyCode, true);
		}
		void FrmMode1KeyUp(object sender, KeyEventArgs e)
		{
			ClsInput.ChangeState(e.KeyCode, false);
		}
		void FrmMode1FormClosing(object sender, FormClosingEventArgs e)
		{
			this.timerDelay.Stop();
			this.timerCheckAlive.Stop();
			this.score = (this.snake.lengh - ClsParameter.SnakeLenghDefault) * 15;
			FrmEndGame1 frmEndGame1 = new FrmEndGame1(this.score);
			frmEndGame1.ShowDialog();
			this.playerName = frmEndGame1.name;
		}
	}
}
