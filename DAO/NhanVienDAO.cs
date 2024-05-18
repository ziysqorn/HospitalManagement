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
using System.Xml.Linq;
using System.Collections;

namespace HospitalManagement.DAO
{
    internal class NhanVienDAO
    {
        private DatabaseSetup dbconnect;
        public NhanVienDAO()
        {
            dbconnect = new DatabaseSetup();
        }
        public NhanVienDAO(string username, string password)
        {
            dbconnect = new DatabaseSetup(username, password);

        }


        public void loadNhanVienList(DataGridView dataGridView)
        {

            dataGridView.CellFormatting -= dataGridView_CellFormatting;
            dataGridView.CellFormatting -= dataGridView_CellFormattingGiaiMa;

            // Câu truy vấn SQL để lấy dữ liệu từ bảng NhanVien và liên kết với bảng PhongBan và BoPhan
            string query = @"
        SELECT 
            nv.ID, 
            nv.Name, 
            nv.DateOfBirth, 
            nv.PersonalId, 
            nv.PhoneNumber, 
            nv.Address, 
            nv.Sex, 
            nv.Email, 
            nv.Salary, 
            nv.Role, 
            pb.Name as PhongBan, 
            bp.Name as BoPhan
        FROM 
            NhanVien nv
        LEFT JOIN 
            PhongBan pb ON nv.PhongBanID = pb.ID
        LEFT JOIN 
            BoPhan bp ON nv.BoPhanID = bp.ID;";

            DataTable data = dbconnect.ExecuteSelectQuery(query);

            // Xóa các cột hiện có trong DataGridView nếu có
            dataGridView.Columns.Clear();

            // Thêm các cột vào DataGridView và đặt tên cho từng cột
            foreach (DataColumn column in data.Columns)
            {
                dataGridView.Columns.Add(column.ColumnName, column.ColumnName);
            }

            // Đổi tên của các cột nếu cần thiết
            dataGridView.Columns["ID"].HeaderText = "Mã Nhân Viên";
            dataGridView.Columns["Name"].HeaderText = "Tên Nhân Viên";
            dataGridView.Columns["DateOfBirth"].HeaderText = "Ngày Sinh";
            dataGridView.Columns["PersonalId"].HeaderText = "CMND";
            dataGridView.Columns["PhoneNumber"].HeaderText = "Số Điện Thoại";
            dataGridView.Columns["Address"].HeaderText = "Địa Chỉ";
            dataGridView.Columns["Sex"].HeaderText = "Giới Tính";
            dataGridView.Columns["Email"].HeaderText = "Email";
            dataGridView.Columns["Salary"].HeaderText = "Lương";
            dataGridView.Columns["Role"].HeaderText = "Vai Trò";
            dataGridView.Columns["PhongBan"].HeaderText = "Phòng Ban";
            dataGridView.Columns["BoPhan"].HeaderText = "Bộ Phận";
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

        public void getNameBoPhan(ComboBox comboBox)
        {
            using (SqlConnection connection = dbconnect.GetConnection())
            {
                string query = "SELECT ID,[NAME] FROM BoPhan";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        // Set the ValueMember and DisplayMember before adding items
                        comboBox.ValueMember = "Key";
                        comboBox.DisplayMember = "Value";

                        List<KeyValuePair<int, string>> items = new List<KeyValuePair<int, string>>();

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            // Create a KeyValuePair for each record
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            items.Add(new KeyValuePair<int, string>(id, name));
                        }
                        // Add the items to the ComboBox
                        comboBox.DataSource = items;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                }
            }
        }


        public void getPhongBan(ComboBox comboBox)
        {
            using (SqlConnection connection = dbconnect.GetConnection())
            {
                string query = "SELECT ID, [Name] FROM PhongBan";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        // Clear the ComboBox items before adding new items
                        comboBox.Items.Clear();

                        // Set the ValueMember and DisplayMember before adding items
                        comboBox.ValueMember = "Key";
                        comboBox.DisplayMember = "Value";

                        // Use a List to store items
                        List<KeyValuePair<int, string>> items = new List<KeyValuePair<int, string>>();

                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            items.Add(new KeyValuePair<int, string>(id, name));
                        }

                        // Bind the items to the ComboBox
                        comboBox.DataSource = items;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public bool AddNhanVien(string name, DateTime dateOfBirth, bool sex, string personalID,string email,string phoneNumber,int salary,string role,string address,int phongBanID,int boPhanID)
        {
            using (SqlConnection connection = dbconnect.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("PROC_CREATE_NV", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@Sex", sex);
                    command.Parameters.AddWithValue("@PersonalId", personalID);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@Salary", salary);
                    command.Parameters.AddWithValue("@Role", role);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@PhongBanID", phongBanID);
                    command.Parameters.AddWithValue("@BoPhanID", boPhanID);

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

        public bool UpdateNhanVien(int id, string name, DateTime dateOfBirth, string personalID, string phoneNumber, string address, bool sex, string email, int phongBanID, int boPhanID, string role)
        {
            try
            {
                using (SqlConnection connection = dbconnect.GetConnection())
                {
                    connection.Open();
                    string query = @"UPDATE NhanVien 
                             SET Name = @Name, 
                                 DateOfBirth = @DateOfBirth, 
                                 PersonalId = @PersonalID, 
                                 PhoneNumber = @PhoneNumber, 
                                 Address = @Address, 
                                 Sex = @Sex, 
                                 Email = @Email, 
                                 PhongBanID = @PhongBanID, 
                                 BoPhanID = @BoPhanID, 
                                 Role = @Role 
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
                    command.Parameters.AddWithValue("@PhongBanID", phongBanID);
                    command.Parameters.AddWithValue("@BoPhanID", boPhanID);
                    command.Parameters.AddWithValue("@Role", role);

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


        public bool DeleteNhanVien(int id)
        {
            try
            {
                using (SqlConnection connection = dbconnect.GetConnection())
                {
                    connection.Open();
                    string query = "DELETE FROM NhanVien WHERE ID = @ID";
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


        public void loadNhanVienListGiaiMa(DataGridView dataGridView)
        {
            dataGridView.CellFormatting -= dataGridView_CellFormatting;
            dataGridView.CellFormatting -= dataGridView_CellFormattingGiaiMa;

            // Câu truy vấn SQL để lấy dữ liệu từ bảng NhanVien và liên kết với bảng PhongBan và BoPhan


            DataTable data;
            using (SqlConnection connection = dbconnect.GetConnection())
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("PROC_READ_NV", connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                data =  dataTable;
            }


            // Xóa các cột hiện có trong DataGridView nếu có
            dataGridView.Columns.Clear();

            // Thêm các cột vào DataGridView và đặt tên cho từng cột
            foreach (DataColumn column in data.Columns)
            {
                dataGridView.Columns.Add(column.ColumnName, column.ColumnName);
            }

            // Đổi tên của các cột nếu cần thiết
            dataGridView.Columns["ID"].HeaderText = "Mã Nhân Viên";
            dataGridView.Columns["Name"].HeaderText = "Tên Nhân Viên";
            dataGridView.Columns["DateOfBirth"].HeaderText = "Ngày Sinh";
            dataGridView.Columns["PersonalId"].HeaderText = "CMND";
            dataGridView.Columns["PhoneNumber"].HeaderText = "Số Điện Thoại";
            dataGridView.Columns["Address"].HeaderText = "Địa Chỉ";
            dataGridView.Columns["Sex"].HeaderText = "Giới Tính";
            dataGridView.Columns["Email"].HeaderText = "Email";
            dataGridView.Columns["Salary"].HeaderText = "Lương";
            dataGridView.Columns["Role"].HeaderText = "Vai Trò";
            dataGridView.Columns["PhongBan"].HeaderText = "Phòng Ban";
            dataGridView.Columns["BoPhan"].HeaderText = "Bộ Phận";
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

        public bool updateLuongNhanVien(int nhanVienID, string name, DateTime dateOfBirth, bool sex, string personalId, string email, string phoneNumber, int salary, string role, string address, int phongBanID, int boPhanID)
        {

            using (SqlConnection connection = dbconnect.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("PROC_UPDATE_NV", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số cho stored procedure
                    command.Parameters.AddWithValue("@NhanVienID", nhanVienID);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@Sex", sex);
                    command.Parameters.AddWithValue("@PersonalId", personalId);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@Salary", salary);
                    command.Parameters.AddWithValue("@Role", role);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@PhongBanID", phongBanID);
                    command.Parameters.AddWithValue("@BoPhanID", boPhanID);

                    try
                    {
                        connection.Open();
                        
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
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
