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
using System.Xml.Linq;
using static HospitalManagement.BaseForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HospitalManagement
{
    public partial class frmAddBacSi : BaseForm
    {
        public frmAddBacSi()
        {
            InitializeComponent();
        }

		public frmAddBacSi(string username, string password, Role role)
		{
			InitializeComponent();
			Username = username;
			Password = password;
			PersonRole = role;
		}

		// Tạo một sự kiện để thông báo khi quá trình thêm bác sĩ hoàn thành


		private void btn_add_Click(object sender, EventArgs e)
        {
            string name = txt_Name_Doctor.Text.Trim();
            string personalID = txt_CCCD_Doctor.Text.Trim();
            string phoneNumber = txt_Phone_Doctor.Text.Trim();
            string address = txt_Address_Doctor.Text.Trim();
            string email = txt_Mail_Doctor.Text.Trim();
            string salaryStr = txt_Salary_Doctor.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(personalID) || string.IsNullOrEmpty(phoneNumber) ||
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
            if (!DateTime.TryParseExact(txt_Birth_Doctor.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dateOfBirth))
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy.");
                return;
            }

            BacSiDAO bacSiDAO = new BacSiDAO(Username, Password);
            
            if (bacSiDAO.AddBacSi(name, dateOfBirth, personalID, phoneNumber, address, sex, email, salary))
            {
                MessageBox.Show("Thêm mới bác sĩ thành công!");

                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm mới bác sĩ thất bại. Vui lòng thử lại.");
            }
        }

		private void frmAddBacSi_FormClosed(object sender, FormClosedEventArgs e)
		{
		}
	}
}
