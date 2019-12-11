
namespace ProjectSnake
{
	partial class FormScoreUser
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label lbUsername;
		private System.Windows.Forms.Button btThoat;
		
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.lbUsername = new System.Windows.Forms.Label();
			this.btThoat = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(110, 42);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(304, 150);
			this.dataGridView1.TabIndex = 0;
			// 
			// lbUsername
			// 
			this.lbUsername.BackColor = System.Drawing.Color.MintCream;
			this.lbUsername.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbUsername.ForeColor = System.Drawing.Color.Brown;
			this.lbUsername.Location = new System.Drawing.Point(1, 0);
			this.lbUsername.Name = "lbUsername";
			this.lbUsername.Size = new System.Drawing.Size(525, 39);
			this.lbUsername.TabIndex = 1;
			this.lbUsername.Text = "Null";
			this.lbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btThoat
			// 
			this.btThoat.BackColor = System.Drawing.Color.Brown;
			this.btThoat.Location = new System.Drawing.Point(226, 198);
			this.btThoat.Name = "btThoat";
			this.btThoat.Size = new System.Drawing.Size(75, 41);
			this.btThoat.TabIndex = 2;
			this.btThoat.Text = "Thoát";
			this.btThoat.UseVisualStyleBackColor = false;
			this.btThoat.Click += new System.EventHandler(this.BtThoatClick);
			// 
			// FormScoreUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MintCream;
			this.ClientSize = new System.Drawing.Size(526, 241);
			this.Controls.Add(this.btThoat);
			this.Controls.Add(this.lbUsername);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FormScoreUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "High Score";
			this.Load += new System.EventHandler(this.FormCoreUserLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
