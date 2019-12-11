
namespace ProjectSnake
{
	partial class FrmMain
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btStart;
		private System.Windows.Forms.Button btOption;
		private System.Windows.Forms.Button btExit;
		private System.Windows.Forms.Button btTopScore;
		
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
			this.btStart = new System.Windows.Forms.Button();
			this.btOption = new System.Windows.Forms.Button();
			this.btTopScore = new System.Windows.Forms.Button();
			this.btExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btStart
			// 
			this.btStart.BackColor = System.Drawing.Color.MediumPurple;
			this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btStart.Location = new System.Drawing.Point(146, 39);
			this.btStart.Name = "btStart";
			this.btStart.Size = new System.Drawing.Size(150, 100);
			this.btStart.TabIndex = 0;
			this.btStart.TabStop = false;
			this.btStart.Text = "START";
			this.btStart.UseVisualStyleBackColor = false;
			this.btStart.Click += new System.EventHandler(this.BtStartClick);
			this.btStart.MouseLeave += new System.EventHandler(this.BtStartMouseLeave);
			this.btStart.MouseHover += new System.EventHandler(this.BtStartMouseHover);
			// 
			// btOption
			// 
			this.btOption.BackColor = System.Drawing.Color.MediumPurple;
			this.btOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btOption.Location = new System.Drawing.Point(146, 145);
			this.btOption.Name = "btOption";
			this.btOption.Size = new System.Drawing.Size(150, 100);
			this.btOption.TabIndex = 1;
			this.btOption.TabStop = false;
			this.btOption.Text = "OPTION";
			this.btOption.UseVisualStyleBackColor = false;
			this.btOption.Click += new System.EventHandler(this.BtOptionClick);
			this.btOption.MouseLeave += new System.EventHandler(this.BtOptionMouseLeave);
			this.btOption.MouseHover += new System.EventHandler(this.BtOptionMouseHover);
			// 
			// btTopScore
			// 
			this.btTopScore.BackColor = System.Drawing.Color.MediumPurple;
			this.btTopScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btTopScore.Location = new System.Drawing.Point(146, 251);
			this.btTopScore.Name = "btTopScore";
			this.btTopScore.Size = new System.Drawing.Size(150, 100);
			this.btTopScore.TabIndex = 1;
			this.btTopScore.TabStop = false;
			this.btTopScore.Text = "TOP SCORE";
			this.btTopScore.UseVisualStyleBackColor = false;
			this.btTopScore.Click += new System.EventHandler(this.BtTopScoreClick);
			this.btTopScore.MouseLeave += new System.EventHandler(this.BtTopcoreMouseLeave);
			this.btTopScore.MouseHover += new System.EventHandler(this.BtTopcoreMouseHover);
			// 
			// btExit
			// 
			this.btExit.BackColor = System.Drawing.Color.MediumPurple;
			this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btExit.Location = new System.Drawing.Point(146, 357);
			this.btExit.Name = "btExit";
			this.btExit.Size = new System.Drawing.Size(150, 100);
			this.btExit.TabIndex = 1;
			this.btExit.TabStop = false;
			this.btExit.Text = "EXIT";
			this.btExit.UseVisualStyleBackColor = false;
			this.btExit.Click += new System.EventHandler(this.BtExitClick);
			this.btExit.MouseLeave += new System.EventHandler(this.BtExitMouseLeave);
			this.btExit.MouseHover += new System.EventHandler(this.BtExitMouseHover);
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(439, 503);
			this.Controls.Add(this.btExit);
			this.Controls.Add(this.btTopScore);
			this.Controls.Add(this.btOption);
			this.Controls.Add(this.btStart);
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Snack";
			this.ResumeLayout(false);

		}
	}
}
