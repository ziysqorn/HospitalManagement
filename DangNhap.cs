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
    {       string username = txtUserName.Text.ToString();
            string password = txtPassWord.Text.ToString();

            DatabaseSetup db = new DatabaseSetup();
            try
            {
                db.OpenConnection();
                if (db.CheckConnection()) { 
                    MessageBox.Show("Kết nối thành công");

                    PhongBan phongBan = new PhongBan();
                    phongBan.ShowDialog();

                    BacSi bacSi = new BacSi();
                    bacSi.ShowDialog();

                    BacSi bacsi_ketoan = new BacSi("ketoan");
                    bacsi_ketoan.ShowDialog();

                    NhanVien nhanVien = new NhanVien();
                    nhanVien.ShowDialog();

                    NhanVien nhanvienketoan = new NhanVien("ketoan");
                    nhanvienketoan.ShowDialog();
                }
                else MessageBox.Show("Ngu");
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
  }
}
