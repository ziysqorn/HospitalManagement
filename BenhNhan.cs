using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class BenhNhan : Form
    {
        string username = "NVTiepTan";
        string password = "NVTT@0711";

        public BenhNhan()
        {
            InitializeComponent();
            DatabaseSetup dbSetup = new DatabaseSetup("NVTiepTan", "NVTT@0711");
            LoadPatientData();
            dgv_BN.CellClick += dgv_BN_CellClick;
        }

        private void LoadPatientData()
         {
            try
            {
                DatabaseSetup dbSetup = new DatabaseSetup(username, password);
                dbSetup.OpenConnection();
                if (dbSetup.CheckConnection())
                {
                    string query = @"select * from BenhNhan";
                    DataTable dt = new DataTable();
                    dbSetup.command.CommandText = query;
                    dt.Load(dbSetup.command.ExecuteReader());
                    dgv_BN.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Lỗi kết nối");
                }
                dbSetup.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
         }

        private void dgv_BN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_BN.Rows[e.RowIndex];
                // Hiển thị thông tin của hàng được chọn lên các ô TextBox tương ứng
                txt_Name_BN.Text = row.Cells["Name"].Value.ToString();
                txt_Birth_BN.Text = Convert.ToDateTime(row.Cells["DateOfBirth"].Value).ToString("dd/MM/yyyy");
                txt_Phone_BN.Text = row.Cells["PhoneNumber"].Value.ToString();
                txt_Address_BN.Text = row.Cells["Address"].Value.ToString();
                txt_CCCD_BN.Text = row.Cells["PersonalID"].Value.ToString();
            }
        }
        private void ResetTxtBox()
        {
            txt_Name_BN.Text = "";
            txt_Birth_BN.Text = "";
            txt_Phone_BN.Text = "";
            txt_Address_BN.Text = "";
            txt_CCCD_BN.Text = "";
            LoadPatientData();
        }
        private void Btn_Add_BN_Click(object sender, EventArgs e)
        {
            string name = txt_Name_BN.Text;
            string dateOfBirth = txt_Birth_BN.Text; // Assume this is in US datetime format
            string phoneNumber = txt_Phone_BN.Text;
            string address = txt_Address_BN.Text;
            string personalID = txt_CCCD_BN.Text;

            // Kiểm tra xem tất cả các ô textbox đã được điền đầy đủ chưa
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(dateOfBirth) || string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(personalID))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DatabaseSetup dbSetup = new DatabaseSetup(username, password);
                dbSetup.OpenConnection();
                if (dbSetup.CheckConnection())
                {
                    // Thực hiện chèn dữ liệu vào bảng BenhNhan
                    string query = @"INSERT INTO BenhNhan (Name, DateOfBirth, PhoneNumber, Address, PersonalID) VALUES (@Name, @DateOfBirth, @PhoneNumber, @Address, @PersonalID)";
                    dbSetup.command.CommandText = query;
                    dbSetup.command.Parameters.AddWithValue("@Name", name);
                    dbSetup.command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    dbSetup.command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    dbSetup.command.Parameters.AddWithValue("@Address", address);
                    dbSetup.command.Parameters.AddWithValue("@PersonalID", personalID);

                    int rowsAffected = dbSetup.command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm bệnh nhân thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Reset các ô textbox sau khi thêm thành công
                        ResetTxtBox();
                    }
                    else
                    {
                        MessageBox.Show("Thêm bệnh nhân thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dbSetup.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Btn_Del_BN_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn hàng nào chưa
            if (dgv_BN.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dgv_BN.SelectedRows[0];
                int patientID = Convert.ToInt32(selectedRow.Cells["ID"].Value); // Giả sử cột ID là cột chứa ID của bệnh nhân

                // Tiến hành xóa bệnh nhân từ cơ sở dữ liệu
                try
                {
                    DatabaseSetup dbSetup = new DatabaseSetup(username, password);
                    dbSetup.OpenConnection();
                    if (dbSetup.CheckConnection())
                    {
                        // Thực hiện xóa bệnh nhân dựa trên ID
                        string query = "DELETE FROM BenhNhan WHERE ID = @PatientID";
                        dbSetup.command.CommandText = query;
                        dbSetup.command.Parameters.AddWithValue("@PatientID", patientID);

                        int rowsAffected = dbSetup.command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xoá bệnh nhân thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Sau khi xoá thành công, cập nhật lại DataGridView và reset các ô TextBox
                            LoadPatientData();
                            ResetTxtBox();
                        }
                        else
                        {
                            MessageBox.Show("Xoá bệnh nhân thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dbSetup.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_Edit_BN_Click(object sender, EventArgs e)
        {
            if (dgv_BN.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_BN.SelectedRows[0];
                int patientID = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                string name = txt_Name_BN.Text;
                string dateOfBirth = txt_Birth_BN.Text;
                string phoneNumber = txt_Phone_BN.Text;
                string address = txt_Address_BN.Text;
                string personalID = txt_CCCD_BN.Text;

                // Kiểm tra xem tất cả các ô textbox đã được điền đầy đủ chưa
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(dateOfBirth) || string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(personalID))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    DatabaseSetup dbSetup = new DatabaseSetup(username, password);
                    dbSetup.OpenConnection();
                    if (dbSetup.CheckConnection())
                    {
                        string query = @"UPDATE BenhNhan SET Name = @Name, DateOfBirth = @DateOfBirth, PhoneNumber = @PhoneNumber, Address = @Address, PersonalID = @PersonalID WHERE ID = @PatientID";
                        dbSetup.command.CommandText = query;
                        dbSetup.command.Parameters.AddWithValue("@Name", name);
                        dbSetup.command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        dbSetup.command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        dbSetup.command.Parameters.AddWithValue("@Address", address);
                        dbSetup.command.Parameters.AddWithValue("@PersonalID", personalID);
                        dbSetup.command.Parameters.AddWithValue("@PatientID", patientID);

                        int rowsAffected = dbSetup.command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sửa thông tin bệnh nhân thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Reset các ô textbox sau khi sửa thành công
                            ResetTxtBox();
                        }
                        else
                        {
                            MessageBox.Show("Sửa thông tin bệnh nhân thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dbSetup.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
