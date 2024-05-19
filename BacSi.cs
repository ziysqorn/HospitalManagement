using HospitalManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HospitalManagement.BaseForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HospitalManagement
{
    public partial class BacSi : BaseForm
    {
        int idBS = 0;

        public BacSi()
        {
            InitializeComponent();
           
            BacSiDAO bacSiDAO = new BacSiDAO();
            bacSiDAO.loadBacSiList(dgv_BS);
        }

        public BacSi(string username, string password, Role role, DangNhap DN)
        {
			InitializeComponent();
            Username = username;
            Password = password;
            PersonRole = role;
            dangNhap = DN;
			if (PersonRole == Role.NVKeToan)
			{
				Btn_Add_BS.Visible = false;
				Btn_Del_BS.Visible = false;
				txt_Address_Doctor.ReadOnly = true;
				txt_Birth_Doctor.ReadOnly = true;
				txt_CCCD_Doctor.ReadOnly = true;
				txt_Mail_Doctor.ReadOnly = true;
				txt_Name_Doctor.ReadOnly = true;
				txt_Phone_Doctor.ReadOnly = true;
				txt_Salary_Doctor.ReadOnly = false;
				rdbnam.Enabled = false;
				rdbnu.Enabled = false;
			}
		}


        private void dgv_BS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có phải dòng header hay không
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgv_BS.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                // Lấy dòng hiện tại dựa trên chỉ số dòng (row index)
                DataGridViewRow row = dgv_BS.Rows[e.RowIndex];


                // Giả sử bạn có các TextBox để hiển thị thông tin
                txt_Name_Doctor.Text = row.Cells["Name"].Value.ToString();
                txt_Birth_Doctor.Text = ((DateTime)row.Cells["DateOfBirth"].Value).ToString("dd/MM/yyyy");
                idBS = (int)row.Cells["ID"].Value;
                txt_CCCD_Doctor.Text = row.Cells["PersonalID"].Value.ToString();
                txt_Phone_Doctor.Text = row.Cells["PhoneNumber"].Value.ToString();
                txt_Address_Doctor.Text = row.Cells["Address"].Value.ToString();
                
                txt_Mail_Doctor.Text = row.Cells["Email"].Value.ToString();
                txt_Salary_Doctor.Text = row.Cells["Salary"].Value.ToString();

                // Hiển thị giới tính
                bool isFemale = (bool)row.Cells["Sex"].Value;
        

                if(isFemale)  rdbnu.Checked = true; 
                else
                    rdbnam.Checked = true;
                // Chuyển đổi và hiển thị giá trị của cột "Salary" sang hexa
                if (txt_Salary_Doctor.ReadOnly == true) 
                {
                    byte[] salaryBytes = (byte[])row.Cells["Salary"].Value;
                    string salaryHex = BitConverter.ToString(salaryBytes).Replace("-", "");
                    txt_Salary_Doctor.Text = salaryHex;

                }

            }

        }

        private void Btn_Add_BS_Click(object sender, EventArgs e)
        {
            try
            {
				frmAddBacSi frm_AddBacSi = new frmAddBacSi(Username, Password, Role.QLTaiNguyen);
				frm_AddBacSi.ShowDialog();
				BacSiDAO bacSiDAO = new BacSiDAO(Username, Password);
				bacSiDAO.loadBacSiList(dgv_BS);
			}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void Btn_Edit_BS_Click(object sender, EventArgs e)
        {
            try
            {
				int ID = idBS;
				if (ID != 0)
				{
					string name = txt_Name_Doctor.Text.Trim();
					string personalID = txt_CCCD_Doctor.Text.Trim();
					string phoneNumber = txt_Phone_Doctor.Text.Trim();
					string address = txt_Address_Doctor.Text.Trim();
					string email = txt_Mail_Doctor.Text.Trim();
					bool sex = rdbnu.Checked;
					string salaryStr = txt_Salary_Doctor.Text.Trim();

					if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(personalID) || string.IsNullOrEmpty(phoneNumber) ||
					string.IsNullOrEmpty(address) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(salaryStr))
					{
						MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
						return;
					}

					DateTime dateOfBirth;
					if (!DateTime.TryParseExact(txt_Birth_Doctor.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dateOfBirth))
					{
						MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy.");
						return;
					}
					if (!rdbnam.Checked && !rdbnu.Checked)
					{
						MessageBox.Show("Vui lòng chọn giới tính.");
						return;
					}

					BacSiDAO bacSiDAO = new BacSiDAO(Username, Password);
					if (PersonRole == Role.QLTaiNguyen)
					{
						if (bacSiDAO.UpdateBacSi(ID, name, dateOfBirth, personalID, phoneNumber, address, sex, email))
						{
							MessageBox.Show("Cập nhật bác sĩ thành công!");
							bacSiDAO.loadBacSiList(dgv_BS);

						}
						else
						{
							MessageBox.Show("Cập nhật bác sĩ thất bại. Vui lòng thử lại.");
						}
					}
					else if(PersonRole == Role.NVKeToan)
					{
						// update luong


						if (!int.TryParse(txt_Salary_Doctor.Text, out int salary) || salary < 0)
						{
							MessageBox.Show("Lương không hợp lệ.");
							return;
						}
						if (bacSiDAO.updateLuongBacSi(ID, name, dateOfBirth, personalID, phoneNumber, address, sex, email, salary))
						{
							MessageBox.Show("Cập nhật bác sĩ thành công!");
							bacSiDAO.loadBacSiListGiaiMa(dgv_BS);

						}
						else
						{
							MessageBox.Show("Cập nhật bác sĩ thất bại. Vui lòng thử lại.");
						}
					}

				}
				else
				{
					MessageBox.Show("ID  không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
            catch(Exception ex)
            {
				MessageBox.Show(ex.Message, "Thông báo");
			}
        }

        private void Btn_Del_BS_Click(object sender, EventArgs e)
        {
            try
            {
				int ID = idBS; // Lấy ID của bác sĩ cần xóa

				if (ID != 0)
				{
					// Hiển thị hộp thoại xác nhận trước khi xóa
					DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bác sĩ này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					// Kiểm tra xem người dùng đã xác nhận xóa hay không
					if (result == DialogResult.Yes)
					{
						// Thực hiện xóa bác sĩ
						BacSiDAO bacSiDAO = new BacSiDAO(Username, Password);
						if (bacSiDAO.DeleteBacSi(ID))
						{
							MessageBox.Show("Xóa bác sĩ thành công!");
							// Thực hiện các hành động cần thiết sau khi xóa, ví dụ: reload danh sách bác sĩ
							bacSiDAO.loadBacSiList(dgv_BS);
							clearInput();
						}
						else
						{
							MessageBox.Show("Xóa bác sĩ thất bại. Vui lòng thử lại.");
						}
					}
				}
				else
				{
					MessageBox.Show("ID bác sĩ không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
            catch(Exception ex)
            {
				MessageBox.Show(ex.Message, "Thông báo");
			}
        }

        private void Btn_Exit_BS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearInput()
        {   
            idBS = 0;
            txt_Address_Doctor.Text = string.Empty;
            txt_Birth_Doctor.Text = string.Empty;
            txt_CCCD_Doctor.Text = string.Empty;
            txt_Mail_Doctor.Text = string.Empty;
            txt_Name_Doctor.Text = string.Empty;
            txt_Phone_Doctor.Text = string.Empty;
            txt_Salary_Doctor.Text = string.Empty;
		}

		private void BacSi_Load(object sender, EventArgs e)
		{
			try
			{
				BacSiDAO bacSiDAO = new BacSiDAO(Username, Password);
				if (PersonRole == Role.NVKeToan) bacSiDAO.loadBacSiListGiaiMa(dgv_BS);
				else bacSiDAO.loadBacSiList(dgv_BS);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo");
				this.Close();
			}
		}

		private void BacSi_FormClosed(object sender, FormClosedEventArgs e)
		{
			dangNhap.Show();
		}
	}

}
