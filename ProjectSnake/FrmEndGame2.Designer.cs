/*
 * Created by SharpDevelop.
 * User: thinh
 * Date: 09/12/2019
 * Time: 8:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProjectSnake
{
	partial class FrmEndGame2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.TextBox tbName1;
		private System.Windows.Forms.Label lbName1;
		private System.Windows.Forms.Label lbScoreValue1;
		private System.Windows.Forms.Label lbScore1;
		private System.Windows.Forms.TextBox tbName2;
		private System.Windows.Forms.Label lbName2;
		private System.Windows.Forms.Label lbScoreValue2;
		private System.Windows.Forms.Label lbScore2;
		
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
			this.btOK = new System.Windows.Forms.Button();
			this.tbName1 = new System.Windows.Forms.TextBox();
			this.lbName1 = new System.Windows.Forms.Label();
			this.lbScoreValue1 = new System.Windows.Forms.Label();
			this.lbScore1 = new System.Windows.Forms.Label();
			this.tbName2 = new System.Windows.Forms.TextBox();
			this.lbName2 = new System.Windows.Forms.Label();
			this.lbScoreValue2 = new System.Windows.Forms.Label();
			this.lbScore2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btOK
			// 
			this.btOK.Location = new System.Drawing.Point(96, 199);
			this.btOK.Name = "btOK";
			this.btOK.Size = new System.Drawing.Size(86, 25);
			this.btOK.TabIndex = 2;
			this.btOK.Text = "OK";
			this.btOK.UseVisualStyleBackColor = true;
			this.btOK.Click += new System.EventHandler(this.BtOKClick);
			// 
			// tbName1
			// 
			this.tbName1.Location = new System.Drawing.Point(125, 62);
			this.tbName1.Name = "tbName1";
			this.tbName1.Size = new System.Drawing.Size(120, 20);
			this.tbName1.TabIndex = 0;
			// 
			// lbName1
			// 
			this.lbName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbName1.Location = new System.Drawing.Point(37, 56);
			this.lbName1.Name = "lbName1";
			this.lbName1.Size = new System.Drawing.Size(82, 32);
			this.lbName1.TabIndex = 7;
			this.lbName1.Text = "Name";
			this.lbName1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbScoreValue1
			// 
			this.lbScoreValue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbScoreValue1.ForeColor = System.Drawing.Color.Red;
			this.lbScoreValue1.Location = new System.Drawing.Point(125, 22);
			this.lbScoreValue1.Name = "lbScoreValue1";
			this.lbScoreValue1.Size = new System.Drawing.Size(121, 32);
			this.lbScoreValue1.TabIndex = 6;
			this.lbScoreValue1.Text = "score";
			this.lbScoreValue1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbScore1
			// 
			this.lbScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbScore1.Location = new System.Drawing.Point(37, 24);
			this.lbScore1.Name = "lbScore1";
			this.lbScore1.Size = new System.Drawing.Size(82, 32);
			this.lbScore1.TabIndex = 5;
			this.lbScore1.Text = "Player 1";
			this.lbScore1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbName2
			// 
			this.tbName2.Location = new System.Drawing.Point(125, 153);
			this.tbName2.Name = "tbName2";
			this.tbName2.Size = new System.Drawing.Size(120, 20);
			this.tbName2.TabIndex = 1;
			// 
			// lbName2
			// 
			this.lbName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbName2.Location = new System.Drawing.Point(37, 147);
			this.lbName2.Name = "lbName2";
			this.lbName2.Size = new System.Drawing.Size(82, 32);
			this.lbName2.TabIndex = 12;
			this.lbName2.Text = "Name";
			this.lbName2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbScoreValue2
			// 
			this.lbScoreValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbScoreValue2.ForeColor = System.Drawing.Color.Red;
			this.lbScoreValue2.Location = new System.Drawing.Point(125, 113);
			this.lbScoreValue2.Name = "lbScoreValue2";
			this.lbScoreValue2.Size = new System.Drawing.Size(121, 32);
			this.lbScoreValue2.TabIndex = 11;
			this.lbScoreValue2.Text = "score";
			this.lbScoreValue2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbScore2
			// 
			this.lbScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbScore2.Location = new System.Drawing.Point(37, 115);
			this.lbScore2.Name = "lbScore2";
			this.lbScore2.Size = new System.Drawing.Size(82, 32);
			this.lbScore2.TabIndex = 10;
			this.lbScore2.Text = "Player 1";
			this.lbScore2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FrmEndGame2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(284, 242);
			this.Controls.Add(this.tbName2);
			this.Controls.Add(this.lbName2);
			this.Controls.Add(this.lbScoreValue2);
			this.Controls.Add(this.lbScore2);
			this.Controls.Add(this.btOK);
			this.Controls.Add(this.tbName1);
			this.Controls.Add(this.lbName1);
			this.Controls.Add(this.lbScoreValue1);
			this.Controls.Add(this.lbScore1);
			this.Name = "FrmEndGame2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmEndGame2";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEndGame2FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
