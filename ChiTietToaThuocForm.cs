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
	public partial class ChiTietToaThuocForm : Form
	{
		string username = "nhanvienBanthuoc";
		string password = "NVBT@2203";
        private DatabaseSetup dbSetup;
        private int toaThuocID;
        public ChiTietToaThuocForm(int id)
		{
            InitializeComponent();
            dbSetup = new DatabaseSetup(username, password);
            toaThuocID = id;
            LoadChiTietToaThuocData();
        }

        private void ChiTietToaThuocForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadChiTietToaThuocData()
        {
            try
            {
                dbSetup.OpenConnection();
                string query = @"SELECT 
                ctt.Amount AS 'Số lượng',
                ctt.Description AS 'Mô tả',
                t.Name AS 'Tên thuốc'
            FROM 
                ChiTietToaThuoc ctt
            INNER JOIN 
                Thuoc t ON ctt.ThuocID = t.ID
            WHERE 
                ctt.ToaThuocID = @ToaThuocID";

                
                dbSetup.command.CommandText = query;
                dbSetup.command.Parameters.AddWithValue("@ToaThuocID", toaThuocID);
                DataTable dt = new DataTable();
                dt.Load(dbSetup.command.ExecuteReader());
                dgv_ChiTietToa.DataSource = dt;
                dbSetup.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_View_Thuoc_Click(object sender, EventArgs e)
        {

        }
    }
}
