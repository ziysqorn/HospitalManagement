using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement.DAO
{
    public class PhongBanDAO
    {
        private DatabaseSetup dbconnect;
        public PhongBanDAO() 
        {
            dbconnect = new DatabaseSetup();
        }
        public PhongBanDAO(string username, string password)
        {
            dbconnect = new DatabaseSetup(username,password);
            
        }

       
        public void loadPhongBanList(DataGridView dataGridView)
        {
			try
			{
				string query = "select ID, [Name] from PhongBan;";
				DataTable data = dbconnect.ExecuteSelectQuery(query);

				// Xóa các cột hiện có trong DataGridView nếu có
				dataGridView.Columns.Clear();

				// Thêm các cột vào DataGridView và đặt tên cho từng cột
				foreach (DataColumn column in data.Columns)
				{
					dataGridView.Columns.Add(column.ColumnName, column.ColumnName);
				}

				// Đổi tên của các cột nếu cần thiết
				if (dataGridView.Columns.Count > 0)
				{
					dataGridView.Columns["ID"].HeaderText = "Mã Phòng";

					dataGridView.Columns["Name"].HeaderText = "Tên Phòng";
					dataGridView.Columns["Name"].Width = 220;
				}



				// Thêm các hàng vào DataGridView
				foreach (DataRow row in data.Rows)
				{
					dataGridView.Rows.Add(row.ItemArray);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        public  bool AddPhongBan(string name)
        {
            try
            {
				string query = "INSERT INTO PhongBan ([Name]) VALUES (@Name)";

				using (SqlConnection connection = dbconnect.GetConnection())
				{
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@Name", name);
						connection.Open();
						int result = command.ExecuteNonQuery();
						return result > 0;
					}
				}
			}
            catch(Exception ex)
            {
				MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
        }

        public  bool UpdatePhongBan(int ID, string newName)
        {
            try
            {
				string query = "UPDATE PhongBan SET [Name] = @NewName WHERE ID = @ID";

				using (SqlConnection connection = dbconnect.GetConnection())
				{
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@NewName", newName);
						command.Parameters.AddWithValue("@ID", ID);
						connection.Open();
						int result = command.ExecuteNonQuery();
						return result > 0;
					}
				}
			}
            catch(Exception ex)
            {
				MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
        }


        public  bool DeletePhongBan(int phongBanID)
        {
            try
            {
				string query = "DELETE FROM PhongBan WHERE ID = @PhongBanID";

				using (SqlConnection connection = dbconnect.GetConnection())
				{
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@PhongBanID", phongBanID);

						try
						{
							connection.Open();
							int result = command.ExecuteNonQuery();
							return result > 0;
						}
						catch (Exception ex)
						{
							MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return false;
						}
					}
				}
			}
            catch(Exception ex)
            {
				MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
        }

    }
}
