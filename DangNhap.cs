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
	public partial class DangNhap : Form
	{
		public DangNhap()
		{
			InitializeComponent();
		}

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
            string username = txt_UserName.Text;
            string password = txt_Pass.Text;

            DatabaseSetup db = new DatabaseSetup(username, password);
            try
            {
                db.OpenConnection();
                if (db.CheckConnection())
                {
                    MessageBox.Show("Kết nối thành công");

                    if (username == "nhanvienChuyenMon" && password == "NVCM@2206")
                    {
                        frmMedicalExaminationDetails form = new frmMedicalExaminationDetails();
                        form.Show();
                    }
                    else if (username == "nhanvienBanThuoc" && password == "NVBT@2203")
                    {
                        ToaThuocForm form = new ToaThuocForm(); // form dành cho nhân viên bán thuốc
                        form.Show();
                    }
                    else if (username == "NVTiepTan" && password == "NVTT@0711")
                    {
                        BenhNhan form = new BenhNhan();
                        frmServices DichVu = new frmServices();
                        form.Show();
                        DichVu.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lỗi kết nối");
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
  }
}
