using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
	internal class DatabaseSetup
	{
		private SqlConnection connection;
		public SqlCommand command;
		private string connectionString = "Data Source=DESKTOP-0LKMS10\\SQLEXPRESS;Initial Catalog=HospitalManagement;Integrated Security=True";
		public DatabaseSetup()
		{
			connection = new SqlConnection(connectionString);
			command = new SqlCommand();
			command.Connection = connection;
		}
		public DatabaseSetup(string username, string password)
		{
			connectionString = $"Data Source=DESKTOP-0LKMS10\\SQLEXPRESS;Initial Catalog=HospitalManagement;User ID={username};Password={password}";
			connection = new SqlConnection(connectionString);
			command = new SqlCommand();
			command.Connection = connection;
		}
		~DatabaseSetup() { connection.Close(); }
		public void OpenConnection() { connection.Open(); }
		public void CloseConnection() { connection.Close(); }
		public SqlConnection GetConnection()
		{
			return new SqlConnection(connectionString);
		}
		public DataTable ExecuteSelectQuery(string query)
		{
			using (SqlConnection connection = GetConnection())
			{
				SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
				DataTable dataTable = new DataTable();
				try
				{
                    dataAdapter.Fill(dataTable);
                    return dataTable;

                }
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				return dataTable;
			}

		}
		public bool CheckConnection()
		{
			return this.connection.State == ConnectionState.Open;
		}
	}
}
