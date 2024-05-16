using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class frmMedicalExaminationDetails : Form
    {
        public int currentDoctor = 1;
        private int selectedPatience = -1;
        public frmMedicalExaminationDetails()
        {
            InitializeComponent();
        }

		private void frmMedicalExaminationDetails_Load(object sender, System.EventArgs e)
		{
			DatabaseSetup db = new DatabaseSetup();
			try
			{
				db.OpenConnection();
				if (db.CheckConnection())
				{
					DataTable dt = new DataTable();
					db.command.CommandText = $"Select BacSi.Name as N'Bác sĩ khám', BenhNhan.Name as N'Bệnh nhân được khám', ToaThuocID as N'Mã toa thuốc', Description, NgayKham, TotalPrice from ChiTietKhamBenh join BacSi on BacSi.ID = ChiTietKhamBenh.BacSiID join BenhNhan on BenhNhan.ID = ChiTietKhamBenh.BenhNhanID where BacSiID = {currentDoctor}";
					SqlDataReader reader = db.command.ExecuteReader();
					dt.Load(reader);
					dGV_CTKB.DataSource = dt;
				} else MessageBox.Show("Lỗi kết nối !", "Thông báo");
				db.CloseConnection();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo");
			}
			try
			{
				db.OpenConnection();
				if (db.CheckConnection())
				{
					DataTable dt = new DataTable();
					db.command.CommandText = $"Select ID, Name from BenhNhan";
					SqlDataReader reader = db.command.ExecuteReader();
					dt.Load(reader);
					dGV_BenhNhan.DataSource = dt;
				}
				else MessageBox.Show("Lỗi kết nối !", "Thông báo");
				db.CloseConnection();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo");
			}	
		}

		private void dGV_CTKB_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dGV_CTKB.Columns[e.ColumnIndex].Name == "TotalPrice" && e.Value != null)
			{
				e.Value = string.Format("{0:N0} VND", e.Value);
				e.FormattingApplied = true;
			}
		}

		private void btnXacNhan_Click(object sender, EventArgs e)
		{
			
		}
	}
}
