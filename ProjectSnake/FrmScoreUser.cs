
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectSnake
{
	/// <summary>
	/// Description of FormCoreUser.
	/// </summary>
	public partial class FormScoreUser : Form
	{
		public string Username ;
		private ClsData Data_Object = new ClsData();
		public FormScoreUser()
		{
			InitializeComponent();	
		}
		private void loadCoreUser()
		{
			Data_Object.loadDataCoreUser(dataGridView1,Username);
		}
		void BtThoatClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void FormCoreUserLoad(object sender, EventArgs e)
		{
			lbUsername.Text = Username;
			loadCoreUser();
		}
	}
}
