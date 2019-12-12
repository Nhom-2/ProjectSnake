
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;


namespace ProjectSnake
{
	/// <summary>
	/// Description of FormTopCore.
	/// </summary>
	public partial class FrmTopScore : Form
	{
		public int Currentindex ;
		public string Username ;
		private ClsData Data_Object = new ClsData();
		public FrmTopScore()
		{
			InitializeComponent();	
		}
		void FormTopCoreLoad(object sender, EventArgs e)
		{
			loadTopCore();
		}
		void BtTongClick(object sender, EventArgs e)
		{
		  	loadTopCore();
		}
		void BtCoVienClick(object sender, EventArgs e)
		{
			loadTopCoreTypeBorder();
		}
		void BtKhongVienClick(object sender, EventArgs e)
		{
			loadTopCoreTypeNoBorder();
		}
		void DataGridView1DoubleClick(object sender, EventArgs e)
		{
				
			Currentindex = dataGridView1.CurrentRow.Index;
			Username = dataGridView1.Rows[Currentindex].Cells[0].Value.ToString();
			if (Username == "")
			{
				MessageBox.Show("Không Có Dữ Liệu");
			}
			else
			{
				FormScoreUser FrCoreUser = new FormScoreUser();
				FrCoreUser.Username = this.Username;
				FrCoreUser.ShowDialog();
			}
				
		}
		void FormTopCoreFormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}
		void loadTopCore()
		{
			Data_Object.loadDataTopCore(dataGridView1);				
		}
		void loadTopCoreTypeBorder()
		{
			Data_Object.loadDataTopCoreTypeBorder(dataGridView1);
		}
		void loadTopCoreTypeNoBorder()
		{
			Data_Object.loadDataTopCoreTypeNoBorder(dataGridView1);
		}
		void DataGridView1Click(object sender, EventArgs e)
		{
			
		}
	}
}
