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
            DatabaseSetup db = new DatabaseSetup("nhanvienChuyenMon", "NVCM@2206");
            try {
                db.OpenConnection();
                if (db.CheckConnection()) 
                { 
                    MessageBox.Show("Kết nối thành công");
                    frmMedicalExaminationDetails form = new frmMedicalExaminationDetails();
                    form.Show();
                    this.Hide();
                }
                else MessageBox.Show("Lỗi kết nối condioi");
				db.CloseConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
    }
  }
}
