using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HospitalManagement.DAO
{
    internal class BacSiDAO
    {
        private DatabaseSetup dbconnect;
        public BacSiDAO()
        {
            dbconnect = new DatabaseSetup();
        }
        public BacSiDAO(string username, string password)
        {
            dbconnect = new DatabaseSetup(username, password);

        }

        public void loadBacSiList(DataGridView dataGridView)
        {
            dataGridView.CellFormatting -= dataGridView_CellFormatting;
            dataGridView.CellFormatting -= dataGridView_CellFormattingGiaiMa;


            string query = "SELECT ID, [NAME], DateOfBirth, PersonalID, PhoneNumber, [Address], Sex, Email, Salary FROM BacSi;";
            DataTable data = dbconnect.ExecuteSelectQuery(query);

            // Xóa các cột hiện có trong DataGridView nếu có
            dataGridView.Columns.Clear();

            // Thêm các cột vào DataGridView và đặt tên cho từng cột
            foreach (DataColumn column in data.Columns)
            {
                dataGridView.Columns.Add(column.ColumnName, column.ColumnName);
            }

            // Đổi tên của các cột nếu cần thiết
            dataGridView.Columns["ID"].HeaderText = "Mã Bác Sĩ";
            dataGridView.Columns["Name"].HeaderText = "Tên Bác Sĩ";
            dataGridView.Columns["DateOfBirth"].HeaderText = "Ngày Sinh";
            dataGridView.Columns["PersonalID"].HeaderText = "CMND";
            dataGridView.Columns["PhoneNumber"].HeaderText = "Số Điện Thoại";
            dataGridView.Columns["Address"].HeaderText = "Địa Chỉ";
            dataGridView.Columns["Sex"].HeaderText = "Giới Tính";
            dataGridView.Columns["Email"].HeaderText = "Email";
            dataGridView.Columns["Salary"].HeaderText = "Lương";
            dataGridView.Columns["DateOfBirth"].DefaultCellStyle.Format = "dd/MM/yyyy";


            // Thêm các hàng vào DataGridView
            foreach (DataRow row in data.Rows)
            {
                dataGridView.Rows.Add(row.ItemArray);
            }

            // Đăng ký sự kiện CellFormatting để định dạng lại giá trị của cột Sex
            dataGridView.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView_CellFormatting);

        }


        private static void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
            DataGridView dgv = sender as DataGridView;

            // Định dạng lại giá trị của cột Sex
            if (dgv.Columns[e.ColumnIndex].Name == "Sex" && e.Value != null)
            {
                bool sexValue = (bool)e.Value;
                e.Value = sexValue ? "Nữ" : "Nam";
                e.FormattingApplied = true;
            }

            // Định dạng lại giá trị của cột Salary
            if (dgv.Columns[e.ColumnIndex].Name == "Salary" && e.Value != null && e.Value is byte[])
            {
                byte[] salaryBytes = (byte[])e.Value;
                e.Value = BitConverter.ToString(salaryBytes).Replace("-", "");
                e.FormattingApplied = true;
            }

        }


        public bool AddBacSi(string name, DateTime dateOfBirth, string personalID, string phoneNumber, string address, bool sex, string email, int salary)
        {

            

            using (SqlConnection connection = dbconnect.GetConnection())
            {

                using (SqlCommand command = new SqlCommand("PROC_CREATE_BS", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    // them cac tham so
                    
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@PersonalID", personalID);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Sex", sex);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Salary", salary);

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


        public bool UpdateBacSi(int id, string name, DateTime dateOfBirth, string personalID, string phoneNumber, string address, bool sex, string email)
        {
            try
            {
                using (SqlConnection connection = dbconnect.GetConnection())
                {
                    connection.Open();
                    string query = @"UPDATE BacSi 
                             SET Name = @Name, 
                                 DateOfBirth = @DateOfBirth, 
                                 PersonalID = @PersonalID, 
                                 PhoneNumber = @PhoneNumber, 
                                 Address = @Address, 
                                 Sex = @Sex, 
                                 Email = @Email 
                             WHERE ID = @ID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@PersonalID", personalID);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Sex", sex);
                    command.Parameters.AddWithValue("@Email", email);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool DeleteBacSi(int id)
        {
            try
            {
                using (SqlConnection connection =  dbconnect.GetConnection())
                {
                    connection.Open();
                    string query = "DELETE FROM BacSi WHERE ID = @ID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", id);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public void loadBacSiListGiaiMa(DataGridView dataGridView)
        {
            dataGridView.CellFormatting -= dataGridView_CellFormatting;
            dataGridView.CellFormatting -= dataGridView_CellFormattingGiaiMa;

            DataTable data;
            using (SqlConnection connection = dbconnect.GetConnection())
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("PROC_READ_BS", connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                data = dataTable;
            }


            // Xóa các cột hiện có trong DataGridView nếu có
            dataGridView.Columns.Clear();

            // Thêm các cột vào DataGridView và đặt tên cho từng cột
            foreach (DataColumn column in data.Columns)
            {
                dataGridView.Columns.Add(column.ColumnName, column.ColumnName);
            }

            // Đổi tên của các cột nếu cần thiết
            dataGridView.Columns["ID"].HeaderText = "Mã Bác Sĩ";
            dataGridView.Columns["Name"].HeaderText = "Tên Bác Sĩ";
            dataGridView.Columns["DateOfBirth"].HeaderText = "Ngày Sinh";
            dataGridView.Columns["PersonalID"].HeaderText = "CMND";
            dataGridView.Columns["PhoneNumber"].HeaderText = "Số Điện Thoại";
            dataGridView.Columns["Address"].HeaderText = "Địa Chỉ";
            dataGridView.Columns["Sex"].HeaderText = "Giới Tính";
            dataGridView.Columns["Email"].HeaderText = "Email";
            dataGridView.Columns["Salary"].HeaderText = "Lương";
            dataGridView.Columns["DateOfBirth"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // Thêm các hàng vào DataGridView
            foreach (DataRow row in data.Rows)
            {
                dataGridView.Rows.Add(row.ItemArray);
            }


            // Đăng ký sự kiện CellFormatting để định dạng lại giá trị của cột Sex
            dataGridView.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView_CellFormattingGiaiMa);

        }


        private static void dataGridView_CellFormattingGiaiMa(object sender, DataGridViewCellFormattingEventArgs e)
        {

            DataGridView dgv = sender as DataGridView;

            // Định dạng lại giá trị của cột Sex
            if (dgv.Columns[e.ColumnIndex].Name == "Sex" && e.Value != null)
            {
                bool sexValue = (bool)e.Value;
                e.Value = sexValue ? "Nữ" : "Nam";
                e.FormattingApplied = true;
            }

        }



        public bool updateLuongBacSi(int bacSiID, string name, DateTime dateOfBirth, string personalID, string phoneNumber, string address, bool sex, string email, int salary)
        {
            using (SqlConnection connection = dbconnect.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("PROC_UPDATE_BS", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số cho stored procedure
                    command.Parameters.AddWithValue("@BacSiID", bacSiID);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@PersonalID", personalID);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Sex", sex);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Salary", salary);

                    try
                    {
                        connection.Open();
                        int effectRows= command.ExecuteNonQuery();
                        return effectRows > 0;
                    }
                    catch (SqlException ex)
                    {
                        // Xử lý exception ở đây (ví dụ: log lại exception, hiển thị message box...)
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }




    }
}
