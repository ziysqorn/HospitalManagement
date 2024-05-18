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

namespace HospitalManagement
{
    public partial class frmAddNhanVien : Form
    {
        public frmAddNhanVien()
        {
            InitializeComponent();
            NhanVienDAO nhanVienDAO = new NhanVienDAO();
            nhanVienDAO.getNameBoPhan(cbb_BP);
            nhanVienDAO.getPhongBan(cbb_PB);
        }

        private void Btn_Add_NV_Click(object sender, EventArgs e)
        {
            string name = txt_Name_NV.Text.Trim();
            string personalID = txt_CCCD_NV.Text.Trim();
            string phoneNumber = txt_Phone_NV.Text.Trim();
            string address = txtDiaChi.Text.Trim();
            string email = txt_Mail_NV.Text.Trim();
            string salaryStr = txt_Salary_NV.Text.Trim();
            string role = txt_Roles_NV.Text.Trim();

            // Lấy giá trị từ ComboBox
            if (cbb_PB.SelectedValue == null || cbb_BP.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn phòng ban và bộ phận.");
                return;
            }

            int phongBanID = Convert.ToInt32(cbb_PB.SelectedValue);
            int boPhanID = Convert.ToInt32(cbb_BP.SelectedValue);

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(personalID) || string.IsNullOrEmpty(phoneNumber) ||
                string.IsNullOrEmpty(address) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(salaryStr))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (!int.TryParse(salaryStr, out int salary) || salary < 0)
            {
                MessageBox.Show("Lương không hợp lệ.");
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

            NhanVienDAO nhanvienDAO = new NhanVienDAO();

            if (nhanvienDAO.AddNhanVien(name, dateOfBirth, sex, personalID, email, phoneNumber, salary, role, address, phongBanID, boPhanID))
            {
                MessageBox.Show("Thêm mới nhân viên thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm mới nhân viên thất bại. Vui lòng thử lại.");
            }
        }

    }
}
