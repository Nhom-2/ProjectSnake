
using System;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace ProjectSnake
{
	/// <summary>
	/// Description of ClsData.
	/// </summary>
	public class ClsData
	{
		private SqlConnection Connect ;
		private SqlCommand Cmd;
		public ClsData()
		{
			
		}
		public void  connetDataBase()
		{
			try
			{
				Connect = new SqlConnection();
				Connect.ConnectionString = @"server= " + ClsParameter.databaseServerName + "; database = " + ClsParameter.databaseName + "; user id = " + ClsParameter.databaseUserName + "; password = " + ClsParameter.databasePassword;
				Connect.Open();	
			}
			catch
			{
				MessageBox.Show("Something is wrong", "Warning");
			}
		}
		public void closeDataBase()
		{
			Connect.Close();
		}
		public void loadDataTopCore(DataGridView Name)
		{
			connetDataBase();
			try
			{
				string Query = 
				@"select B.Username  as [Tên Người Chơi] , SUM(A.Score) as [Điểm]  from Score as A join [User] as B on A.ID_User = B.ID_User 
				  Group by B.Username Order by [Điểm] DESC ";
				Cmd = new SqlCommand(Query,Connect);
				SqlDataAdapter Da = new SqlDataAdapter(Cmd);
				DataTable Tb = new DataTable();
				Da.Fill(Tb);
				Name.DataSource = Tb;	
			}
			catch
			{
				MessageBox.Show("Something is wrong", "Warning");
			}
			closeDataBase();
		}
		public void loadDataTopCoreTypeBorder(DataGridView Name)
		{
			connetDataBase();
			try
			{
				string Query = @"select  A.Username as [Tên Người Chơi] ,C.Type as [Loại], SUM(B.Score) as [Điểm Có Viền] from 
							 [User] as A inner join Score as B on A.ID_User = B.ID_User
							 inner join [Type] as C on B.ID_Type = C.ID_Type where C.ID_Type = 1
							 Group by   C.Type , A.Username
							 Order by [Điểm Có Viền] DESC	";
				Cmd = new SqlCommand(Query,Connect);
				SqlDataAdapter Da = new SqlDataAdapter(Cmd);
				DataTable Tb = new DataTable();
				Da.Fill(Tb);
				Name.DataSource = Tb;				
			}
			catch
			{
				MessageBox.Show("Something is wrong", "Warning");
			}
												
			closeDataBase();
		}
		public void loadDataTopCoreTypeNoBorder(DataGridView Name)
		{
			connetDataBase();
			try
			{
					string Query = @"select  A.Username as [Tên Người Chơi] ,C.Type as [Loại], SUM(B.Score) as [Điểm Không Viền] from 
							       [User] as A inner join Score as B on A.ID_User = B.ID_User
							       inner join [Type] as C on B.ID_Type = C.ID_Type where C.ID_Type = 2
							       Group by   C.Type ,A.Username
										   Order by [Điểm Không Viền] DESC	";
					Cmd = new SqlCommand(Query,Connect);
					SqlDataAdapter Da = new SqlDataAdapter(Cmd);
					DataTable Tb = new DataTable();
					Da.Fill(Tb);
					Name.DataSource = Tb;				
			}
			catch
			{
				MessageBox.Show("Something is wrong", "Warning");
			}
										
			closeDataBase();
		}
		public void loadDataUsername( int ID , TextBox Username , TextBox Core)
		{
			connetDataBase();
			try
			{
				string Query = @"select * from Core Where ID = '" + ID +" '";
				Cmd = new SqlCommand(Query,Connect);
				SqlDataReader Reader = Cmd.ExecuteReader();
				
				while(Reader.Read())
				{
					Username.Text = Reader.GetValue(1).ToString();
					Core.Text = Reader.GetValue(2).ToString();
				}
			}
			catch
			{
				MessageBox.Show("Something is wrong", "Warning");	
			}
			
			closeDataBase();
		}
		public void loadDataCoreUser(DataGridView Name_DataGridView , string Username)
		{
			connetDataBase();
			try
			{
				string Query = @"select  A.Username as N'Tên Người Chơi' ,C.Type as N'Loại', SUM(B.Score) as N'Điểm Có Viền' from 
							 [User] as A inner join Score as B on A.ID_User = B.ID_User
							 inner join [Type] as C on B.ID_Type = C.ID_Type where A.Username = N'"+Username+"'Group by   C.Type ,A.Username	";
				Cmd = new SqlCommand(Query,Connect);
				SqlDataAdapter Da = new SqlDataAdapter(Cmd);
				DataTable Tb = new DataTable();
				Da.Fill(Tb);
				Name_DataGridView.DataSource = Tb;			
			}
			catch
			{
				MessageBox.Show("Something is wrong", "Warning");
			}
							
			closeDataBase();
		}
		private bool isExist(string Name)
		{
			connetDataBase();
			string DataName = null;
			try
			{
				string Query = @"select Username from [User]  Where Username = N'"+Name+"'";
				Cmd = new SqlCommand(Query,Connect);
				SqlDataReader Reader = Cmd.ExecuteReader();
				while(Reader.Read())
				{
					DataName = Reader.GetValue(0).ToString();
				}
			}
			catch
			{
				MessageBox.Show("Something is wrong", "Warning");
			}
		
			closeDataBase();
			return (DataName == null) ? false : true;		
		}
		private void insertDataUser(string Name)
		{
			bool Exist = isExist(Name);
			if (!Exist)
			{
				connetDataBase();
				try
				{
					string Query = @"insert into [User](Username) Values(N'"+Name+"')";
					Cmd = new SqlCommand(Query,Connect);
					Cmd.ExecuteNonQuery();
					closeDataBase();
				}
				catch
				{
					MessageBox.Show("Something is wrong", "Warning");
				}
				
			}
			else
			{
				return;
			}
		}
		private void insertDataScore(string Name, int Score, int Type)
		{
			connetDataBase();
			try
			{
				
				string Query = @"insert into Score(Score,ID_Type,ID_User) VALUES(" + Score + "," + Type + ",(select ID_User from [User]  Where Username = N'" + Name + "'))" ;
				Cmd = new SqlCommand(Query,Connect);
				Cmd.ExecuteNonQuery();
			
			}
			catch
			{
				MessageBox.Show("Something is wrong", "Warning");
			}
			closeDataBase();
		}
		public void saveScore(string Name, int Score, int Type)
		{
			this.insertDataUser(Name);
			this.insertDataScore(Name, Score, Type);
		}
		public void saveScore(string Name1, string Name2, int Score1, int Score2, int Type)
		{
			this.insertDataUser(Name1);
			this.insertDataScore(Name1, Score1, Type);
			this.insertDataUser(Name2);
			this.insertDataScore(Name2, Score2, Type);
		}
	}
}
