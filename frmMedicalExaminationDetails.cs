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
    public partial class frmMedicalExaminationDetails : BaseForm
    {
        public int currentDoctor = 1;
        private int selectedPatience = -1;
        public frmMedicalExaminationDetails() 
		{
			InitializeComponent();
		}

		public frmMedicalExaminationDetails(string username, string password, int doctor, Role role, DangNhap DN)
		{
			InitializeComponent();
			Username = username;
			Password = password;
			currentDoctor = doctor;
			PersonRole = role;
			dangNhap = DN;	
		}

		public frmMedicalExaminationDetails(string username, string password, Role role, DangNhap DN)
		{
			InitializeComponent();
			Username = username;
			Password = password;
			PersonRole = role;
			dangNhap = DN;
		}

		private void frmMedicalExaminationDetails_Load(object sender, System.EventArgs e)
		{
			DatabaseSetup db = new DatabaseSetup(Username, Password);
			try
			{
				if(PersonRole == Role.BacSi)
				{
					db.OpenConnection();
					if (db.CheckConnection())
					{
						DataTable dt = new DataTable();
						db.command.CommandText = $"Select ChiTietKhamBenh.ID as N'Mã chi tiết', BacSi.ID as N'Mã bác sĩ', BacSi.Name as N'Bác sĩ khám', BenhNhan.ID as N'Mã bệnh nhân', BenhNhan.Name as N'Bệnh nhân được khám', Description, NgayKham, TotalPrice from ChiTietKhamBenh join BacSi on BacSi.ID = ChiTietKhamBenh.BacSiID join BenhNhan on BenhNhan.ID = ChiTietKhamBenh.BenhNhanID where BacSiID = {currentDoctor}";
						SqlDataReader reader = db.command.ExecuteReader();
						dt.Load(reader);
						dGV_CTKB.DataSource = dt;
					}
					else MessageBox.Show("Lỗi kết nối !", "Thông báo");
					db.CloseConnection();
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
					dangNhap.Hide();
				}
				else if(PersonRole == Role.NVTaiVu)
				{
					db.OpenConnection();
					if (db.CheckConnection())
					{
						DataTable dt = new DataTable();
						db.command.CommandText = $"Select ChiTietKhamBenh.ID as N'Mã chi tiết', BacSi.ID as N'Mã bác sĩ', BacSi.Name as N'Bác sĩ khám', BenhNhan.ID as N'Mã bệnh nhân', BenhNhan.Name as N'Bệnh nhân được khám', Description, NgayKham, TotalPrice from ChiTietKhamBenh join BacSi on BacSi.ID = ChiTietKhamBenh.BacSiID join BenhNhan on BenhNhan.ID = ChiTietKhamBenh.BenhNhanID";
						SqlDataReader reader = db.command.ExecuteReader();
						dt.Load(reader);
						dGV_CTKB.DataSource = dt;
					}
					else MessageBox.Show("Lỗi kết nối !", "Thông báo");
					db.CloseConnection();
				}
				else if(PersonRole == Role.QLChuyenMon)
				{
					db.OpenConnection();
					if (db.CheckConnection())
					{
						DataTable dt = new DataTable();
						db.command.CommandText = $"Select ChiTietKhamBenh.ID as N'Mã chi tiết', BacSi.ID as N'Mã bác sĩ', BacSi.Name as N'Bác sĩ khám', BenhNhan.ID as N'Mã bệnh nhân', BenhNhan.Name as N'Bệnh nhân được khám', Description, NgayKham, TotalPrice from ChiTietKhamBenh join BacSi on BacSi.ID = ChiTietKhamBenh.BacSiID join BenhNhan on BenhNhan.ID = ChiTietKhamBenh.BenhNhanID";
						SqlDataReader reader = db.command.ExecuteReader();
						dt.Load(reader);
						dGV_CTKB.DataSource = dt;
					}
					else MessageBox.Show("Lỗi kết nối !", "Thông báo");
					db.CloseConnection();
				}
				dangNhap.Hide();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo");
				db.CloseConnection();
				this.Close();
			}	
		}

		private void dGV_CTKB_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if(dGV_CTKB.Columns[e.ColumnIndex].Name == "TotalPrice" && e.Value != null)
			{
				e.Value = string.Format("{0:N0} VND", e.Value);
				e.FormattingApplied = true;
			}
		}

		private void btnXacNhan_Click(object sender, EventArgs e)
		{
			txtBenhNhan.Text = dGV_BenhNhan.SelectedRows[0].Cells[1].Value.ToString();
			selectedPatience = (int)dGV_BenhNhan.SelectedRows[0].Cells[0].Value;
		}

		private void btnUncheck_Click(object sender, EventArgs e)
		{
			txtBenhNhan.Text = "";
			selectedPatience = -1;
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (datePicker.Text != "" && txtDesciption.Text != "" && txtPrice.Text != "" && selectedPatience > 0)
			{
				DatabaseSetup db = new DatabaseSetup(Username, Password);
				try
				{
					db.OpenConnection();
					if (db.CheckConnection())
					{
							db.command.CommandText = $"Insert into ChiTietKhamBenh values ({currentDoctor}, {selectedPatience}, null, N'{txtDesciption.Text}', '{datePicker.Value.ToString("yyyy-MM-dd")}', {txtPrice.Text})";
							if (db.command.ExecuteNonQuery() > 0)
							{
								MessageBox.Show("Thêm dữ liệu mới thành công !", "Thông báo");
								txtDesciption.Text = "";
								txtPrice.Text = "";
								txtBenhNhan.Text = "";
								selectedPatience = -1;
								this.OnLoad(e);
							}
							else MessageBox.Show("Không thể thêm mới dữ liệu !", "Thông báo");
					}
					else MessageBox.Show("Lỗi kết nối !", "Thông báo");
					db.CloseConnection();
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message, "Thông báo");
					db.CloseConnection();
				}
			}
			else MessageBox.Show("Vui lòng điền đủ thông tin !", "Thông báo");
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (txtDesciption.Text == "" && txtPrice.Text == "" && selectedPatience <= 0)
			{
				MessageBox.Show("Vui lòng điền thông tin để sửa!", "Thông báo");
			}
			else
			{
				DatabaseSetup db = new DatabaseSetup(Username, Password);
				try
				{
					db.OpenConnection();
					if (db.CheckConnection())
					{
							string toUpdate = "";
							if (txtDesciption.Text != "") toUpdate = toUpdate + $"Description = N'{txtDesciption.Text}',";
							if (txtPrice.Text != "") toUpdate = toUpdate + $"TotalPrice = {txtPrice.Text},";
							if (selectedPatience > 0) toUpdate = toUpdate + $"BenhNhanID = {selectedPatience},";
							toUpdate = toUpdate.Substring(0, toUpdate.Length - 1);
							db.command.CommandText = $"Update ChiTietKhamBenh set {toUpdate} where ID = {dGV_CTKB.SelectedRows[0].Cells[0].Value}";
							if (db.command.ExecuteNonQuery() > 0)
							{
								MessageBox.Show("Sửa dữ liệu thành công !", "Thông báo");
								txtDesciption.Text = "";
								txtPrice.Text = "";
								txtBenhNhan.Text = "";
								selectedPatience = -1;
								this.OnLoad(e);
							}
							else MessageBox.Show("Không thể sửa dữ liệu !", "Thông báo");
					}
					else MessageBox.Show("Lỗi kết nối !", "Thông báo");
					db.CloseConnection();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Thông báo");
					db.CloseConnection();
				}
			}
		}

		private void btnSuaNgay_Click(object sender, EventArgs e)
		{
			DatabaseSetup db = new DatabaseSetup(Username, Password);
			try
			{
				db.OpenConnection();
				if (db.CheckConnection())
				{
						db.command.CommandText = $"Update ChiTietKhamBenh set NgayKham = '{datePicker.Value.ToString("yyyy-MM-dd")}' where ID = {dGV_CTKB.SelectedRows[0].Cells[0].Value}";
						if (db.command.ExecuteNonQuery() > 0)
						{
							MessageBox.Show("Sửa ngày thành công !", "Thông báo");
							txtDesciption.Text = "";
							txtPrice.Text = "";
							txtBenhNhan.Text = "";
							selectedPatience = -1;
							this.OnLoad(e);
						}
						else MessageBox.Show("Không thể sửa dữ liệu !", "Thông báo");
				} 
				else MessageBox.Show("Lỗi kết nối !", "Thông báo");
				db.CloseConnection();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo");
			}
		}

		private void btnXem_Click(object sender, EventArgs e)
		{
			ThongTinChiTietKB ctkb = new ThongTinChiTietKB((int)dGV_CTKB.SelectedRows[0].Cells[0].Value, (int)dGV_CTKB.SelectedRows[0].Cells[3].Value, Username, Password, PersonRole, this);
			ctkb.Show();
			ctkb.BringToFront();
			this.Hide();
		}

		private void frmMedicalExaminationDetails_FormClosed(object sender, FormClosedEventArgs e)
		{
			dangNhap.Show();
		}
	}
}
