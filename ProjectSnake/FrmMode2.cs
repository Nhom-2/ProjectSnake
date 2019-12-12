
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectSnake
{
	public partial class FrmMode2 : Form
	{
		/// <summary>
		/// Description of FrmOption.
		/// form chay game mode 2
		/// </summary>
		private readonly int MapSizeWidth;
		private readonly int MapSizeHeight;
		private readonly bool hasBorder;
		
		private ClsSnake snake1;
		private ClsSnake snake2;
		private ClsFood food;
		private ClsKeyCode key1;
		private ClsKeyCode key2;
		
		private bool isSpeedup;
		
		private bool increaceFree1;
		private bool increaceFree2;	
		
		ClsProcessLogic process;
		private ClsEventKey press;
		
		public string playerName1;
		public string playerName2;
		public int score1;
		public int score2;
		
		public FrmMode2(ClsMapWidthHeight winsize, 
		                bool hasborder, 
		                string color, 
		                int lengh, 
		                int snakesize, 
		                string snakecolor1, 
		                string snakecolor2, 
		                string foodcolor, 
		                bool isspeedup, 
		                ClsKeyCode playerkey1, 
		                ClsKeyCode playerkey2)
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
			
			this.snake1 = new ClsSnake(lengh, snakesize, snakecolor1, 1, this.MapSizeWidth, this.MapSizeHeight);
			this.snake2 = new ClsSnake(lengh, snakesize, snakecolor2, 3, this.MapSizeWidth, this.MapSizeHeight);
			this.food = new ClsFood(foodcolor);
			
			this.isSpeedup = isspeedup;
			this.key1 = playerkey1;
			this.key2 = playerkey2;
			
			this.increaceFree1 = false;
			this.increaceFree2 = false;
			
			this.process = new ClsProcessLogic();
			this.press = new ClsEventKey();
			
			this.playerName1 = "";
			this.playerName2 = "";
			this.score1 = 0;
			this.score2 = 0;
			
			this.setWindow();
			
			this.timerDelay1.Interval = ClsParameter.DelayDefault;
			this.timerDelay1.Start();
			this.timerDelay2.Interval = ClsParameter.DelayDefault;
			this.timerDelay2.Start();
			
			this.food.generateFood(snake1, snake2, MapSizeWidth, MapSizeHeight);
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
			this.lbScore1.Location = new Point((this.Width - this.lbScore1.Width) / 4, (ClsParameter.MarginTop - this.lbScore1.Height) / 2);
			this.lbScore1.ForeColor = ClsParameter.TextColor;
			this.lbScore1.BackColor = Color.Transparent;
			this.lbScore2.Location = new Point((this.Width + this.Width / 2 - this.lbScore1.Width) / 2, (ClsParameter.MarginTop - this.lbScore1.Height) / 2);
			this.lbScore2.ForeColor = ClsParameter.TextColor;
			this.lbScore2.BackColor = Color.Transparent;
			this.lbPause.Location = new Point((this.ptbGame.Width - this.lbPause.Width) / 2, (this.ptbGame.Height - this.lbPause.Height) / 2);
			this.lbPause.Parent = this.ptbGame;
			this.lbPause.ForeColor = ClsParameter.TextColor;this.lbScore1.Parent = this;
			this.lbPause.BackColor = Color.Transparent;
			this.lbPause.Visible = false;
		}
		void TimerDelay1Tick(object sender, EventArgs e)
		{
			if (!this.snake1.Status)
			{
				this.timerDelay1.Stop();
				if (!this.snake2.Status)
				{
					this.timerDelay2.Stop();		// tranh tinh trang chet cung luc load form chong len nhau
					this.Close();
				}
			}	
			this.press.processEventKey(this.snake1, this.key1);
			if (hasBorder)
				this.process.logicBorderEnable(snake1, snake2, ref this.increaceFree1, food, this.MapSizeWidth, this.MapSizeHeight, this.isSpeedup, this.timerDelay1);
			else
				this.process.logicBorderDisable(snake1, snake2, ref this.increaceFree1, food, this.MapSizeWidth, this.MapSizeHeight, this.isSpeedup, this.timerDelay1);
			this.ptbGame.Invalidate();
		}
		void TimerDelay2Tick(object sender, EventArgs e)
		{
			if (!this.snake2.Status)
			{
				this.timerDelay2.Stop();
				if (!this.snake1.Status)
				{
					this.timerDelay1.Stop();		// tranh tinh trang chet cung luc load form chong len nhau
					this.Close();
				}
			}	
			this.press.processEventKey(this.snake2, this.key2);
			if (hasBorder)
				this.process.logicBorderEnable(snake2, snake1, ref this.increaceFree2, food, this.MapSizeWidth, this.MapSizeHeight, this.isSpeedup, this.timerDelay2);
			else
				this.process.logicBorderDisable(snake2, snake1, ref this.increaceFree2, food, this.MapSizeWidth, this.MapSizeHeight, this.isSpeedup, this.timerDelay2);
			this.ptbGame.Invalidate();
		}
		void PtbGamePaint(object sender, PaintEventArgs e)
		{
			this.lbScore1.Text = string.Concat("Snake 1: ", ((this.snake1.lengh - ClsParameter.SnakeLenghDefault) * 15).ToString());
			this.lbScore2.Text = string.Concat("Snake 2: ", ((this.snake2.lengh - ClsParameter.SnakeLenghDefault) * 15).ToString());
			this.food.drawFood(e, this.snake1.Size);
			if (this.snake1.Status)
				this.snake1.drawSnake(e);
			if (this.snake2.Status)
				this.snake2.drawSnake(e);
		}
		private void resumeGame()
		{
			this.lbPause.Visible = false;
			this.timerDelay1.Start();
			this.timerDelay2.Start();
		}
		private void pauseGame()
		{
			this.lbPause.Visible = true;
			this.lbPause.Text = "Press any key";
			this.timerDelay1.Stop();
			this.timerDelay2.Stop();
		}
		void FrmRunGameKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Space)
			{
				this.pauseGame();
				return;
			}
			if (!timerDelay1.Enabled && !this.timerDelay2.Enabled)
				this.resumeGame();
			ClsInput.ChangeState(e.KeyCode, true);
		}
		void FrmMode2KeyUp(object sender, KeyEventArgs e)
		{
			ClsInput.ChangeState(e.KeyCode, false);
		}
		void FrmMode2FormClosing(object sender, FormClosingEventArgs e)
		{
			this.score1 = (this.snake1.lengh - ClsParameter.SnakeLenghDefault) * 15;
			this.score2 = (this.snake2.lengh - ClsParameter.SnakeLenghDefault) * 15;
			FrmEndGame2 frmEndGame2 = new FrmEndGame2(this.score1, this.score2);
			frmEndGame2.ShowDialog();
			this.playerName1 = frmEndGame2.name1;
			this.playerName2 = frmEndGame2.name2;
		}
	}
}
