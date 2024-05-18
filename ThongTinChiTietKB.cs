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
using System.Xml.Linq;

namespace HospitalManagement
{
	public partial class ThongTinChiTietKB : Form
	{
		private int selectedCTKB = -1;
		private int selectedPatience = -1;
		private frmMedicalExaminationDetails CTKB;
		public ThongTinChiTietKB()
		{
			InitializeComponent();
		}
		public ThongTinChiTietKB(int ctkbID, int patient, frmMedicalExaminationDetails cTKB)
		{
			InitializeComponent();
			selectedCTKB = ctkbID;
			selectedPatience = patient;
			CTKB = cTKB;
		}

		private void ThongTinChiTietKB_Load(object sender, EventArgs e)
		{
			DatabaseSetup db = new DatabaseSetup();
			try
			{
				db.OpenConnection();
				if (db.CheckConnection())
				{
					try
					{
						DataTable dt = new DataTable();
						db.command.CommandText = $"Select DVKhamBenh.ID, DVKhamBenh.Name, DVKhamBenh.Price from ChiTietKhamBenh_DV join DVKhamBenh on DVKhamBenh.ID = ChiTietKhamBenh_DV.DichVuID where ChiTietID = {selectedCTKB}";
						SqlDataReader reader = db.command.ExecuteReader();
						dt.Load(reader);
						dGV_CTKBDVu.DataSource = dt;
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Thông báo");
					}
				}
				else MessageBox.Show("Lỗi kết nối !", "Thông báo");
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
					db.command.CommandText = $"Select ID, Name, Price from DVKhamBenh";
					SqlDataReader reader = db.command.ExecuteReader();
					dt.Load(reader);
					dGV_DV.DataSource = dt;
				}
				else MessageBox.Show("Lỗi kết nối !", "Thông báo");
				db.CloseConnection();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo");
			}
			try
			{
				db.OpenConnection();
				if (db.CheckConnection())
				{
					DataTable dt = new DataTable();
					db.command.CommandText = $"Select ID, Name from Thuoc";
					SqlDataReader reader = db.command.ExecuteReader();
					dt.Load(reader);
					dGV_Thuoc.DataSource = dt;
				}
				else MessageBox.Show("Lỗi kết nối !", "Thông báo");
				db.CloseConnection();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo");
			}
		}

		private void ThongTinChiTietKB_FormClosed(object sender, FormClosedEventArgs e)
		{
			CTKB.Show();
		}

		private void btnThemDV_Click(object sender, EventArgs e)
		{
			DatabaseSetup db = new DatabaseSetup();
			try
			{
				db.OpenConnection();
				if (db.CheckConnection())
				{
					try
					{
						db.command.CommandText = $"Insert into ChiTietKhamBenh_DV values ({selectedCTKB}, {dGV_DV.SelectedRows[0].Cells[0].Value})";
						if (db.command.ExecuteNonQuery() > 0)
						{
							MessageBox.Show("Thêm dịch vụ vào chi tiết thành công !", "Thông báo");
							this.OnLoad(e);
						}
						else MessageBox.Show("Không thể thêm dữ liệu vào hệ thống !", "Thông báo");
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Thông báo");
					}
				}
				else MessageBox.Show("Lỗi kết nối !", "Thông báo");
				db.CloseConnection();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo");
			}
		}

		private void btnSuaDV_Click(object sender, EventArgs e)
		{
			DatabaseSetup db = new DatabaseSetup();
			try
			{
				db.OpenConnection();
				if (db.CheckConnection())
				{
					try
					{
						db.command.CommandText = $"Update ChiTietKhamBenh_DV set DichVuID = {dGV_DV.SelectedRows[0].Cells[0].Value} where ChiTietID = {selectedCTKB} and DichVuID = {dGV_CTKBDVu.SelectedRows[0].Cells[0].Value}";
						if (db.command.ExecuteNonQuery() > 0)
						{
							MessageBox.Show("Cập nhật dịch vụ vào chi tiết thành công !", "Thông báo");
							this.OnLoad(e);
						}
						else MessageBox.Show("Không thể cập nhật dữ liệu vào hệ thống !", "Thông báo");
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Thông báo");
					}
				}
				else MessageBox.Show("Lỗi kết nối !", "Thông báo");
				db.CloseConnection();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo");
			}
		}

		private void btnXoaDV_Click(object sender, EventArgs e)
		{
			DatabaseSetup db = new DatabaseSetup();
			try
			{
				db.OpenConnection();
				if (db.CheckConnection())
				{
					try
					{
						db.command.CommandText = $"Delete from ChiTietKhamBenh_DV where ChiTietID = {selectedCTKB} and DichVuID = {dGV_CTKBDVu.SelectedRows[0].Cells[0].Value}";
						if (db.command.ExecuteNonQuery() > 0)
						{
							MessageBox.Show("Xóa dịch vụ khỏi chi tiết thành công !", "Thông báo");
							this.OnLoad(e);
						}
						else MessageBox.Show("Không thể xóa dữ liệu !", "Thông báo");
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Thông báo");
					}
				}
				else MessageBox.Show("Lỗi kết nối !", "Thông báo");
				db.CloseConnection();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo");
			}
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabControl1.SelectedIndex == 1)
			{
				DatabaseSetup db = new DatabaseSetup();
				try
				{
					db.OpenConnection();
					if (db.CheckConnection())
					{
						try
						{
							db.command.CommandText = $"Select ID from ToaThuoc where CTKB_ID = {selectedCTKB}";
							SqlDataReader reader = db.command.ExecuteReader();
							if (!reader.Read())
							{
								db.CloseConnection();
								DialogResult result = MessageBox.Show("Toa thuốc chưa được khởi tạo. Bạn có muốn tạo dữ liệu toa thuốc mới ?", "Thông báo", MessageBoxButtons.YesNo);
								if (result == DialogResult.Yes)
								{
									try
									{
										db.OpenConnection();
										db.command.CommandText = $"Insert into ToaThuoc (CTKB_ID, BenhNhanID) values ({selectedCTKB}, {selectedPatience})";
										if(db.command.ExecuteNonQuery() > 0)
										{
											db.CloseConnection();
											MessageBox.Show("Tạo mới dữ liệu toa thuốc thành công !", "Thông báo");
											try
											{
												DataTable dt = new DataTable();
												db.OpenConnection();
												db.command.CommandText = $"Select Thuoc.ID, Thuoc.Name, Amount, Description from ChiTietToaThuoc join Thuoc on Thuoc.ID = ChiTietToaThuoc.ThuocID join ToaThuoc on ToaThuoc.ID = ChiTietToaThuoc.ToaThuocID where ToaThuoc.CTKB_ID = {selectedCTKB}";
												SqlDataReader dr = db.command.ExecuteReader();
												dt.Load(dr);
												dGV_CTTT.DataSource = dt;
												db.CloseConnection();
											}
											catch(Exception ex)
											{
												MessageBox.Show(ex.Message, "Thông báo");
											}
										}
										else MessageBox.Show("Tạo mới dữ liệu toa thuốc thất bại !", "Thông báo");
									}
									catch(Exception ex)
									{
										MessageBox.Show(ex.Message, "Thông báo");
									}
								}
								else
								{
									tabControl1.SelectedIndex = 0;
								}
							}
							else
							{
								try
								{
									db.CloseConnection();
									db.OpenConnection();
									DataTable dt = new DataTable();
									db.command.CommandText = $"Select Thuoc.ID, Thuoc.Name, Amount, Description from ChiTietToaThuoc join Thuoc on Thuoc.ID = ChiTietToaThuoc.ThuocID join ToaThuoc on ToaThuoc.ID = ChiTietToaThuoc.ToaThuocID where ToaThuoc.CTKB_ID = {selectedCTKB}";
									SqlDataReader dr = db.command.ExecuteReader();
									dt.Load(dr);
									dGV_CTTT.DataSource = dt;
									db.CloseConnection();
								}
								catch (Exception ex)
								{
									MessageBox.Show(ex.Message, "Thông báo");
								}
							}
						}
						catch (Exception ex) 
						{
							MessageBox.Show(ex.Message, "Thông báo");
						}
					}
					else MessageBox.Show("Lỗi kết nối !", "Thông báo");
					db.CloseConnection();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Thông báo");
				}
			}
		}

		private void btnThemThuoc_Click(object sender, EventArgs e)
		{
			if (txtAmount.Text != "" && txtDescription.Text != "")
			{
				DatabaseSetup db = new DatabaseSetup();
				try
				{
					db.OpenConnection();
					if (db.CheckConnection())
					{
						try
						{
							db.command.CommandText = $"Insert into ChiTietToaThuoc values({txtAmount.Text}, N'{txtDescription.Text}', {dGV_Thuoc.SelectedRows[0].Cells[0].Value}, (Select ID from ToaThuoc where ToaThuoc.CTKB_ID = {selectedCTKB}))";
							if (db.command.ExecuteNonQuery() > 0)
							{
								MessageBox.Show("Thêm dữ liệu mới thành công !", "Thông báo");
								txtAmount.Text = "";
								txtDescription.Text = "";
								this.OnLoad(e);
								tabControl1.SelectedIndex = 0;
								tabControl1.SelectedIndex = 1;
							}
							else MessageBox.Show("Không thể thêm mới dữ liệu !", "Thông báo");
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, "Thông báo");
						}
					}
					else MessageBox.Show("Lỗi kết nối !", "Thông báo");
					db.CloseConnection();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Thông báo");
				}
			}
			else MessageBox.Show("Vui lòng điền đủ thông tin !", "Thông báo");
		}

		private void btnSuaThuoc_Click(object sender, EventArgs e)
		{
			DatabaseSetup db = new DatabaseSetup();
			try
			{
				db.OpenConnection();
				if (db.CheckConnection())
				{
					try
					{
						db.command.CommandText = $"Update ChiTietToaThuoc set ThuocID = {dGV_Thuoc.SelectedRows[0].Cells[0].Value} where ToaThuocID = (Select ID from ToaThuoc where ToaThuoc.CTKB_ID = {selectedCTKB}) and ThuocID = {dGV_CTTT.SelectedRows[0].Cells[0].Value}";
						if (db.command.ExecuteNonQuery() > 0)
						{
							MessageBox.Show("Sửa thuốc thành công !", "Thông báo");
							this.OnLoad(e);
							tabControl1.SelectedIndex = 0;
							tabControl1.SelectedIndex = 1;
						}
						else MessageBox.Show("Không thể sửa dữ liệu !", "Thông báo");
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Thông báo");
					}
				}
				else MessageBox.Show("Lỗi kết nối !", "Thông báo");
				db.CloseConnection();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo");
			}
		}

		private void btnXoaThuoc_Click(object sender, EventArgs e)
		{
			DatabaseSetup db = new DatabaseSetup();
			try
			{
				db.OpenConnection();
				if (db.CheckConnection())
				{
					try
					{
						db.command.CommandText = $"Delete from ChiTietToaThuoc where ToaThuocID = (Select ID from ToaThuoc where ToaThuoc.CTKB_ID = {selectedCTKB}) and ThuocID = {dGV_CTTT.SelectedRows[0].Cells[0].Value}";
						if (db.command.ExecuteNonQuery() > 0)
						{
							MessageBox.Show("Xóa thuốc khỏi chi tiết khám bệnh thành công !", "Thông báo");
							this.OnLoad(e);
							tabControl1.SelectedIndex = 0;
							tabControl1.SelectedIndex = 1;
						}
						else MessageBox.Show("Không thể xóa dữ liệu !", "Thông báo");
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Thông báo");
					}
				}
				else MessageBox.Show("Lỗi kết nối !", "Thông báo");
				db.CloseConnection();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo");
			}
		}

		private void btnSuaThongTin_Click(object sender, EventArgs e)
		{
			if (txtAmount.Text == "" && txtDescription.Text == "") MessageBox.Show("Vui lòng nhập thông tin muốn sửa !", "Thông báo");
			else
			{
				DatabaseSetup db = new DatabaseSetup();
				try
				{
					db.OpenConnection();
					if (db.CheckConnection())
					{
						try
						{
							string toUpdate = "";
							if (txtDescription.Text != "") toUpdate = toUpdate + $"Description = N'{txtDescription.Text}',";
							if (txtAmount.Text != "") toUpdate = toUpdate + $"Amount = {txtAmount.Text},";
							toUpdate = toUpdate.Substring(0, toUpdate.Length - 1);
							db.command.CommandText = $"Update ChiTietToaThuoc set {toUpdate} where ToaThuocID = (Select ID from ToaThuoc where ToaThuoc.CTKB_ID = {selectedCTKB}) and ThuocID = {dGV_CTTT.SelectedRows[0].Cells[0].Value}";
							if (db.command.ExecuteNonQuery() > 0)
							{
								MessageBox.Show("Sửa thông tin chi tiết thuốc thành công !", "Thông báo");
								txtAmount.Text = "";
								txtDescription.Text = "";
								this.OnLoad(e);
								tabControl1.SelectedIndex = 0;
								tabControl1.SelectedIndex = 1;
							}
							else MessageBox.Show("Không thể sửa thông tin chi tiết thuốc !", "Thông báo");
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
