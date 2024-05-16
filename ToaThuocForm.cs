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
	public partial class ToaThuocForm : Form
	{
		private DatabaseSetup dbSetup;
		public ToaThuocForm()
		{
			InitializeComponent();
			dbSetup = new DatabaseSetup("nhanvienBanThuoc", "NVBT@2203");
		}
        private void ToaThuocForm_Load(object sender, EventArgs e)
        {
            LoadThoathuocData();
            dgv_QLToaThuoc.RowHeaderMouseClick += dgv_QLToaThuoc_RowHeaderMouseClick;
        }
        private void LoadThoathuocData()
        {
            string query = @"SELECT 
                    tt.ID AS 'Mã toa thuốc',
                    tt.PayDate AS 'Ngày thanh toán',
                    bn.Name AS 'Tên bệnh nhân',
                    nv.Name AS 'Tên nhân viên',
                    bs.Name AS 'Tên bác sĩ'
                FROM 
                    ToaThuoc tt
                INNER JOIN 
                    BenhNhan bn ON tt.BenhNhanID = bn.ID
                INNER JOIN 
                    NhanVien nv ON tt.NhanVienID = nv.ID
                INNER JOIN 
                    ChiTietKhamBenh ctkb ON tt.ID = ctkb.ToaThuocID
                INNER JOIN 
                    BacSi bs ON ctkb.BacSiID = bs.ID";
            DataTable dt = dbSetup.ExecuteSelectQuery(query);
            dgv_QLToaThuoc.DataSource = dt;
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
			DangNhap form = new DangNhap();
            this.Hide();
            form.Show();
        }

        private void dgv_QLToaThuoc_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_QLToaThuoc.Rows[e.RowIndex];
                DisplaySelectedRowDetails(row);
            }
        }
        private void DisplaySelectedRowDetails(DataGridViewRow row)
        {
            txt_BSname_TT.Text = row.Cells["Tên bác sĩ"].Value.ToString();
            txt_BNname_TT.Text = row.Cells["Tên bệnh nhân"].Value.ToString();
            txt_NVname_TT.Text = row.Cells["Tên nhân viên"].Value.ToString();
            mtxt_PayDate_TT.Text = Convert.ToDateTime(row.Cells["Ngày thanh toán"].Value).ToString("MM/dd/yyyy HH:mm");
        }
    }
}
