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
using static HospitalManagement.BaseForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HospitalManagement
{
    public partial class frmServices : BaseForm
    {
        public frmServices()
        {
            InitializeComponent();
		}

		public frmServices(string username, string password, Role role, DangNhap DN)
		{
			InitializeComponent();
			Username = username;
			Password = password;
			PersonRole = role;
			dangNhap = DN;
		}

		private void frmServices_Load(object sender, EventArgs e)
		{
			DatabaseSetup db = new DatabaseSetup(Username, Password);
			try
			{
				db.OpenConnection();
				if (db.CheckConnection())
				{
					try
					{
						DataTable dt = new DataTable();
						db.command.CommandText = "Select * from DVKhamBenh";
						SqlDataReader reader = db.command.ExecuteReader();
						dt.Load(reader);
						dGV_DV.DataSource = dt;
					}
					catch(Exception ex)
					{
						MessageBox.Show(ex.Message, "Thông báo");
					}
				} else MessageBox.Show("Lỗi kết nối !", "Thông báo");
				db.CloseConnection();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo");
				this.Close();
			}
		}

		private void dGV_DV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dGV_DV.Columns[e.ColumnIndex].Name == "Price" && e.Value != null)
			{
				e.Value = string.Format("{0:N0} VND", e.Value);
				e.FormattingApplied = true;
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (txtName.Text != "" && txtPrice.Text != "")
			{
				DatabaseSetup db = new DatabaseSetup(Username, Password);
				try
				{
					db.OpenConnection();
					if (db.CheckConnection())
					{
						try
						{
							db.command.CommandText = string.Format("Insert into DVKhamBenh (Name, Price) values (N'{0}', {1})", txtName.Text, txtPrice.Text);
							if (db.command.ExecuteNonQuery() > 0)
							{
								MessageBox.Show("Thêm dữ liệu dịch vụ thành công !", "Thông báo");
								txtName.Text = "";
								txtPrice.Text = "";
								txtName.Focus();
								this.OnLoad(e);
							}
							else MessageBox.Show("Không thể thêm dữ liệu vào hệ thống !", "Thông báo");
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, "Thông báo");
						}
					}
					db.CloseConnection();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Thông báo");
				}
			}
			else MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông báo");
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (txtName.Text == "" && txtPrice.Text == "") MessageBox.Show("Vui lòng nhập thông tin muốn sửa !", "Thông báo");
			else
			{
				DatabaseSetup db = new DatabaseSetup(Username, Password);
				try
				{
					db.OpenConnection();
					if (db.CheckConnection())
					{
						try
						{
							string toUpdate = "";
							if (txtName.Text != "") toUpdate = toUpdate + $"Name = N'{txtName.Text}',";
							if (txtPrice.Text != "") toUpdate = toUpdate + $"Price = {txtPrice.Text},";
							toUpdate = toUpdate.Substring(0, toUpdate.Length - 1);
							db.command.CommandText = $"Update DVKhamBenh set {toUpdate} where ID = {dGV_DV.SelectedRows[0].Cells[0].Value}";
							if (db.command.ExecuteNonQuery() > 0)
							{
								MessageBox.Show("Sửa dữ liệu dịch vụ thành công !", "Thông báo");
								txtName.Text = "";
								txtPrice.Text = "";
								txtName.Focus();
								this.OnLoad(e);
							}
							else MessageBox.Show("Không thể sửa dữ liệu dịch vụ !", "Thông báo");
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, "Thông báo");
						}
					}
					db.CloseConnection();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Thông báo");
				}
			}
		}
	}
}
