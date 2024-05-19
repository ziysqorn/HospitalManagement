using HospitalManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HospitalManagement.BaseForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HospitalManagement
{
    public partial class NhanVien : BaseForm
    {
        int idNV = 0;
        public NhanVien()
        {
            InitializeComponent();
            NhanVienDAO nhanVienDAO = new NhanVienDAO();
            nhanVienDAO.loadNhanVienList(dgv_NV, Username);
            nhanVienDAO.getNameBoPhan(cbb_BP);
            nhanVienDAO.getPhongBan(cbb_PB);
		}

		public NhanVien(string username, string password, Role role, DangNhap DN)
		{
			InitializeComponent();
			Username = username;
			Password = password;
			PersonRole = role;
			dangNhap = DN;
			if (PersonRole == Role.NVKeToan)
			{
				Btn_Add_NV.Visible = false;
				Btn_Del_NV.Visible = false;
				txtDiaChi.ReadOnly = true;
				txt_Birth_NV.ReadOnly = true;
				txt_CCCD_NV.ReadOnly = true;
				txt_Mail_NV.ReadOnly = true;
				txt_Name_NV.ReadOnly = true;
				txt_Phone_NV.ReadOnly = true;
				txt_Roles_NV.ReadOnly = true;
				rdbnam.Enabled = false;
				rdbnu.Enabled = false;
				cbb_BP.Enabled = false;
				cbb_PB.Enabled = false;
				txt_Salary_NV.ReadOnly = false;
			}
		}


        private void dgv_NV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có phải dòng header hay không
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgv_NV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                // Lấy dòng hiện tại dựa trên chỉ số dòng (row index)
                DataGridViewRow row = dgv_NV.Rows[e.RowIndex];


                // Giả sử bạn có các TextBox để hiển thị thông tin
                txt_Name_NV.Text = row.Cells["Name"].Value.ToString();
                txt_Birth_NV.Text = ((DateTime)row.Cells["DateOfBirth"].Value).ToString("dd/MM/yyyy");
                idNV = (int)row.Cells["ID"].Value;
                txt_CCCD_NV.Text = row.Cells["PersonalID"].Value.ToString();
                txt_Phone_NV.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtDiaChi.Text = row.Cells["Address"].Value.ToString();

                txt_Mail_NV.Text = row.Cells["Email"].Value.ToString();
                txt_Salary_NV.Text = row.Cells["Salary"].Value.ToString();
                cbb_BP.Text = row.Cells["BoPhan"].Value.ToString();
                cbb_PB.Text = row.Cells["PhongBan"].Value.ToString();
                txt_Roles_NV.Text = row.Cells["Role"].Value.ToString();
                // Hiển thị giới tính
                bool isFemale = (bool)row.Cells["Sex"].Value;


                if (isFemale) rdbnu.Checked = true;
                else
                    rdbnam.Checked = true;
                // Chuyển đổi và hiển thị giá trị của cột "Salary" sang hexa
                if (txt_Salary_NV.ReadOnly == true)
                {
                    byte[] salaryBytes = (byte[])row.Cells["Salary"].Value;
                    string salaryHex = BitConverter.ToString(salaryBytes).Replace("-", "");
                    txt_Salary_NV.Text = salaryHex;
                }


            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Add_NV_Click(object sender, EventArgs e)
        {
            try
            {
				frmAddNhanVien frm_AddNhanVien = new frmAddNhanVien(Username, Password, PersonRole);
				frm_AddNhanVien.ShowDialog();
				NhanVienDAO nhanVienDAO = new NhanVienDAO(Username, Password);
				nhanVienDAO.loadNhanVienList(dgv_NV, Username);
			}
            catch(Exception ex)
            {
				MessageBox.Show(ex.Message, "Thông báo");
			}
        }

        private void Btn_Edit_NV_Click(object sender, EventArgs e)
        {
            try
            {
				int ID = idNV;
				if (ID != 0)
				{
					string name = txt_Name_NV.Text.Trim();
					string personalID = txt_CCCD_NV.Text.Trim();
					string phoneNumber = txt_Phone_NV.Text.Trim();
					string address = txtDiaChi.Text.Trim();
					string email = txt_Mail_NV.Text.Trim();

					string role = txt_Roles_NV.Text.Trim();


					int phongBanID = Convert.ToInt32(cbb_PB.SelectedValue);
					int boPhanID = Convert.ToInt32(cbb_BP.SelectedValue);

					if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(personalID) || string.IsNullOrEmpty(phoneNumber) ||
						string.IsNullOrEmpty(address) || string.IsNullOrEmpty(email))
					{
						MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
						return;
					}

					// Lấy giá trị từ ComboBox
					if (cbb_PB.SelectedItem == null || cbb_BP.SelectedItem == null)
					{
						MessageBox.Show("Vui lòng chọn phòng ban và bộ phận.");
						return;
					}

					if (!rdbnam.Checked && !rdbnu.Checked)
					{
						MessageBox.Show("Vui lòng chọn giới tính.");
						return;
					}

					bool sex = rdbnu.Checked; // Nữ nếu rdbnu được chọn, Nam nếu không

					DateTime dateOfBirth;
					if (!DateTime.TryParseExact(txt_Birth_NV.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dateOfBirth))
					{
						MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy.");
						return;
					}

					NhanVienDAO nhanVienDAO = new NhanVienDAO(Username, Password);
					if (PersonRole == Role.QLTaiNguyen)
					{
						if (nhanVienDAO.UpdateNhanVien(ID, name, dateOfBirth, personalID, phoneNumber, address, sex, email, phongBanID, boPhanID, role))
						{
							MessageBox.Show("Cập nhật nhân viên thành công!");
							nhanVienDAO.loadNhanVienList(dgv_NV, Username);
						}
						else
						{
							MessageBox.Show("Cập nhật nhân viên thất bại. Vui lòng thử lại.");
						}
					}
					else if (PersonRole == Role.NVKeToan)
					{
						// sua luong 
						if (!int.TryParse(txt_Salary_NV.Text, out int salary) || salary < 0)
						{
							MessageBox.Show("Lương không hợp lệ.");
							return;
						}
						if (txt_Salary_NV.Text == string.Empty)
						{
							MessageBox.Show("Vui lòng nhập đủ thông tin.");
							return;
						}
						if (nhanVienDAO.updateLuongNhanVien(ID, name, dateOfBirth, sex, personalID, email, phoneNumber, salary, role, address, phongBanID, boPhanID))
						{
							MessageBox.Show("Cập nhật nhân viên thành công!");
							nhanVienDAO.loadNhanVienListGiaiMa(dgv_NV, Username);
						}
						else
						{
							MessageBox.Show("Cập nhật nhân viên thất bại. Vui lòng thử lại.");
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

        private void Btn_Del_NV_Click(object sender, EventArgs e)
        {
			try
			{
				int ID = idNV; // Lấy ID của nhân viên cần xóa

				if (ID != 0)
				{
					// Hiển thị hộp thoại xác nhận trước khi xóa
					DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					// Kiểm tra xem người dùng đã xác nhận xóa hay không
					if (result == DialogResult.Yes)
					{
						// Thực hiện xóa 
						NhanVienDAO nhanVienDAO = new NhanVienDAO(Username, Password);
						if (nhanVienDAO.DeleteNhanVien(ID))
						{
							MessageBox.Show("Xóa bác sĩ thành công!");
							// Thực hiện các hành động cần thiết sau khi xóa, ví dụ: reload danh sách 
							nhanVienDAO.loadNhanVienList(dgv_NV, Username);
							clearInput();
						}
						else
						{
							MessageBox.Show("Xóa nhân viên thất bại. Vui lòng thử lại.");
						}
					}
				}
				else
				{
					MessageBox.Show("ID nhân viên không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch( Exception ex )
			{
				MessageBox.Show(ex.Message, "Thông báo");
			}
        }

        private void clearInput()
        {
            idNV = 0;
            txtDiaChi.Text = string.Empty;
            txt_Birth_NV.Text = string.Empty;
            txt_CCCD_NV.Text = string.Empty;
            txt_Mail_NV.Text = string.Empty;
            txt_Name_NV.Text = string.Empty;
            txt_Phone_NV.Text = string.Empty;
            txt_Roles_NV.Text = string.Empty;
            txt_Salary_NV.Text = string.Empty;
           
               
        }

		private void NhanVien_Load(object sender, EventArgs e)
		{
			try
			{
				NhanVienDAO nhanVienDAO = new NhanVienDAO(Username, Password);
				if (PersonRole == Role.NVKeToan) nhanVienDAO.loadNhanVienListGiaiMa(dgv_NV, Username);
				else nhanVienDAO.loadNhanVienList(dgv_NV, Username);
				nhanVienDAO.getNameBoPhan(cbb_BP);
				nhanVienDAO.getPhongBan(cbb_PB);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo");
				this.Close();
			}
		}

		private void NhanVien_FormClosed(object sender, FormClosedEventArgs e)
		{
            dangNhap.Show();
		}

		private void dgv_NV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgv_NV.Columns[e.ColumnIndex].Name == "Lương" && e.Value != null)
			{
				e.Value = string.Format("{0:N0} VND", e.Value);
				e.FormattingApplied = true;
			}
		}
	}
}
