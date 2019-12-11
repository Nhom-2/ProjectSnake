/*
 * Created by SharpDevelop.
 * User: thinh
 * Date: 09/12/2019
 * Time: 8:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProjectSnake
{
	partial class FrmEndGame1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbScore;
		private System.Windows.Forms.Label lbScoreValue;
		private System.Windows.Forms.Label lbName;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Button btOK;
		
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
			this.lbScore = new System.Windows.Forms.Label();
			this.lbScoreValue = new System.Windows.Forms.Label();
			this.lbName = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.btOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbScore
			// 
			this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbScore.Location = new System.Drawing.Point(8, 10);
			this.lbScore.Name = "lbScore";
			this.lbScore.Size = new System.Drawing.Size(104, 32);
			this.lbScore.TabIndex = 0;
			this.lbScore.Text = "Your score";
			this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbScoreValue
			// 
			this.lbScoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbScoreValue.ForeColor = System.Drawing.Color.Red;
			this.lbScoreValue.Location = new System.Drawing.Point(118, 9);
			this.lbScoreValue.Name = "lbScoreValue";
			this.lbScoreValue.Size = new System.Drawing.Size(121, 32);
			this.lbScoreValue.TabIndex = 1;
			this.lbScoreValue.Text = "score";
			this.lbScoreValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbName
			// 
			this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbName.Location = new System.Drawing.Point(8, 42);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(104, 32);
			this.lbName.TabIndex = 2;
			this.lbName.Text = "Your name";
			this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(118, 49);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(120, 20);
			this.tbName.TabIndex = 0;
			// 
			// btOK
			// 
			this.btOK.Location = new System.Drawing.Point(81, 83);
			this.btOK.Name = "btOK";
			this.btOK.Size = new System.Drawing.Size(86, 25);
			this.btOK.TabIndex = 1;
			this.btOK.Text = "OK";
			this.btOK.UseVisualStyleBackColor = true;
			this.btOK.Click += new System.EventHandler(this.BtOKClick);
			// 
			// FrmEndGame1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(251, 113);
			this.Controls.Add(this.btOK);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.lbScoreValue);
			this.Controls.Add(this.lbScore);
			this.Name = "FrmEndGame1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Announce";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEndGame1FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
