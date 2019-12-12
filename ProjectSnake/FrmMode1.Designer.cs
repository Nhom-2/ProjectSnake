
namespace ProjectSnake
{
	partial class FrmMode1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox ptbGame;
		private System.Windows.Forms.Timer timerDelay;
		private System.Windows.Forms.PictureBox ptbBorder;
		private System.Windows.Forms.Label lbScore;
		private System.Windows.Forms.Label lbPause;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.ptbGame = new System.Windows.Forms.PictureBox();
			this.timerDelay = new System.Windows.Forms.Timer(this.components);
			this.ptbBorder = new System.Windows.Forms.PictureBox();
			this.lbScore = new System.Windows.Forms.Label();
			this.lbPause = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.ptbGame)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbBorder)).BeginInit();
			this.SuspendLayout();
			// 
			// ptbGame
			// 
			this.ptbGame.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ptbGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ptbGame.Location = new System.Drawing.Point(41, 105);
			this.ptbGame.Name = "ptbGame";
			this.ptbGame.Size = new System.Drawing.Size(200, 200);
			this.ptbGame.TabIndex = 0;
			this.ptbGame.TabStop = false;
			this.ptbGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PtbGamePaint);
			// 
			// timerDelay
			// 
			this.timerDelay.Interval = 150;
			this.timerDelay.Tick += new System.EventHandler(this.TimerDelayTick);
			// 
			// ptbBorder
			// 
			this.ptbBorder.BackColor = System.Drawing.Color.MidnightBlue;
			this.ptbBorder.Location = new System.Drawing.Point(31, 95);
			this.ptbBorder.Name = "ptbBorder";
			this.ptbBorder.Size = new System.Drawing.Size(220, 220);
			this.ptbBorder.TabIndex = 1;
			this.ptbBorder.TabStop = false;
			// 
			// lbScore
			// 
			this.lbScore.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lbScore.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbScore.ForeColor = System.Drawing.Color.Crimson;
			this.lbScore.Location = new System.Drawing.Point(41, 9);
			this.lbScore.Margin = new System.Windows.Forms.Padding(0);
			this.lbScore.Name = "lbScore";
			this.lbScore.Size = new System.Drawing.Size(200, 38);
			this.lbScore.TabIndex = 0;
			this.lbScore.Text = "Score 0";
			this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbPause
			// 
			this.lbPause.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lbPause.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPause.ForeColor = System.Drawing.Color.Crimson;
			this.lbPause.Location = new System.Drawing.Point(244, 9);
			this.lbPause.Margin = new System.Windows.Forms.Padding(0);
			this.lbPause.Name = "lbPause";
			this.lbPause.Size = new System.Drawing.Size(270, 100);
			this.lbPause.TabIndex = 0;
			this.lbPause.Text = "Pause";
			this.lbPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FrmMode1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(526, 373);
			this.Controls.Add(this.lbPause);
			this.Controls.Add(this.lbScore);
			this.Controls.Add(this.ptbGame);
			this.Controls.Add(this.ptbBorder);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FrmMode1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Snake";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMode1FormClosing);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRunGameKeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmMode1KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.ptbGame)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbBorder)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
