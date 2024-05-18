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
	public partial class DangNhap : Form
	{
		public DangNhap()
		{
			InitializeComponent();
		}

		private void DangNhap_Load(object sender, EventArgs e)
		{
			cbbPhongBan.Items.Clear();
			cbbBoPhan.Items.Clear();
			cbbCV.Items.Clear();
			txtUsername.Text = string.Empty;
			txtPassword.Text = string.Empty;
			rdoBacSi.Checked = true;
			DatabaseSetup db = new DatabaseSetup();
			try
			{
				db.OpenConnection();
				try
				{
					db.command.CommandText = "Select ID, Name from PhongBan";
					SqlDataReader reader = db.command.ExecuteReader();
					while(reader.Read()) {
						cbbPhongBan.Items.Add(new ComboBoxItem(reader[1].ToString(), reader[0].ToString()));
					}
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message, "Thông báo");
					return;
				}
				db.CloseConnection();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo");
				return;
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			if(txtUsername.Text == "" || txtPassword.Text == "")
			{
				MessageBox.Show("Vui lòng nhập Username và Password");
			}
			else
			{
				if(rdoBacSi.Checked == true)
				{
					DatabaseSetup db = new DatabaseSetup();
					try
					{
						db.OpenConnection();
						if (db.CheckConnection())
						{
							db.command.CommandText = $"Select COUNT(*) from BacSi where PersonalID = '{txtUsername.Text}'";
							int count = (int)db.command.ExecuteScalar();
							if (count > 0)
							{
								db.CloseConnection();
								db.OpenConnection();
								db.command.CommandText = $"Select ID from BacSi where PersonalID = '{txtUsername.Text}'";
								int doctor = (int)db.command.ExecuteScalar();
								db.CloseConnection();
								frmMedicalExaminationDetails CTKB = new frmMedicalExaminationDetails(txtUsername.Text, txtPassword.Text, doctor, BaseForm.Role.BacSi, this);
								CTKB.Show();
							}
							else MessageBox.Show("Thông tin bác sĩ không tồn tại trong hệ thống !", "Thông báo");
						}
						else MessageBox.Show("Lỗi kết nối !", "Thông báo");
						db.CloseConnection();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Thông báo");
					}
				}
				else
				{
					if(cbbPhongBan.Text == "" && cbbBoPhan.Text == "" && cbbCV.Text == "")
					{
						MessageBox.Show("Vui lòng chọn vị trí của mình trong hệ thống để đăng nhập !", "Thông báo");
					}
					else
					{
						ComboBoxItem PhongBanItem = cbbPhongBan.SelectedItem as ComboBoxItem;
						ComboBoxItem BoPhanItem = cbbBoPhan.SelectedItem as ComboBoxItem;
						ComboBoxItem CVItem = cbbCV.SelectedItem as ComboBoxItem;
						if(PhongBanItem.Value == "1")
						{
							if (BoPhanItem == null)
							{
								DatabaseSetup db = new DatabaseSetup();
								try
								{
									db.OpenConnection();
									if (db.CheckConnection())
									{
										db.command.CommandText = $"Select COUNT(*) from NhanVien where PersonalID = '{txtUsername.Text}' and PhongBanID = 1";
										int count = (int)db.command.ExecuteScalar();
										if (count > 0)
										{
											frmMedicalExaminationDetails CTKB = new frmMedicalExaminationDetails();
											CTKB.Show();
										}
										else MessageBox.Show("Thông tin nhân viên không tồn tại trong hệ thống !", "Thông báo");
									}
									else MessageBox.Show("Lỗi kết nối !", "Thông báo");
									db.CloseConnection();
								}
								catch (Exception ex)
								{
									MessageBox.Show(ex.Message, "Thông báo");
								}
							}
							else if (BoPhanItem.Value == "3")
							{
								DatabaseSetup db = new DatabaseSetup();
								try
								{
									db.OpenConnection();
									if (db.CheckConnection())
									{
										db.command.CommandText = $"Select COUNT(*) from NhanVien where PersonalID = '{txtUsername.Text}' and BoPhanID = 3";
										int count = (int)db.command.ExecuteScalar();
										if (count > 0)
										{
											BacSi bs = new BacSi();
											NhanVien nv = new NhanVien();
											bs.Show();
											nv.Show();
										}
										else MessageBox.Show("Thông tin nhân viên không tồn tại trong hệ thống !", "Thông báo");
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
						else if(PhongBanItem.Value == "2")
						{
							DatabaseSetup db = new DatabaseSetup();
							try
							{
								db.OpenConnection();
								if (db.CheckConnection())
								{
									db.command.CommandText = $"Select COUNT(*) from NhanVien where PersonalID = '{txtUsername.Text}' and PhongBanID = 2";
									int count = (int)db.command.ExecuteScalar();
									if (count > 0)
									{
										ToaThuocForm toathuoc = new ToaThuocForm();
										toathuoc.Show();
									}
									else MessageBox.Show("Thông tin nhân viên không tồn tại trong hệ thống !", "Thông báo");
								}
								else MessageBox.Show("Lỗi kết nối !", "Thông báo");
								db.CloseConnection();
							}
							catch (Exception ex)
							{
								MessageBox.Show(ex.Message, "Thông báo");
							}
						}
						else if(PhongBanItem.Value == "3")
						{
							if(BoPhanItem.Value == "1")
							{
								if(CVItem.Value == "1")
								{
									DatabaseSetup db = new DatabaseSetup();
									try
									{
										db.OpenConnection();
										if (db.CheckConnection())
										{
											db.command.CommandText = $"Select COUNT(*) from NhanVien where PersonalID = '{txtUsername.Text}' and BoPhanID = 1";
											int count = (int)db.command.ExecuteScalar();
											if (count > 0)
											{
												BacSi bs = new BacSi();
												NhanVien nv = new NhanVien();
												PhongBan phongban = new PhongBan();
												bs.Show();
												nv.Show();
												phongban.Show();
											}
											else MessageBox.Show("Thông tin nhân viên không tồn tại trong hệ thống !", "Thông báo");
										}
										else MessageBox.Show("Lỗi kết nối !", "Thông báo");
										db.CloseConnection();
									}
									catch (Exception ex)
									{
										MessageBox.Show(ex.Message, "Thông báo");
									}
								}
								else if(CVItem.Value == "2")
								{
									DatabaseSetup db = new DatabaseSetup();
									try
									{
										db.OpenConnection();
										if (db.CheckConnection())
										{
											db.command.CommandText = $"Select COUNT(*) from NhanVien where PersonalID = '{txtUsername.Text}' and BoPhanID = 1";
											int count = (int)db.command.ExecuteScalar();
											if (count > 0)
											{
												frmServices service = new frmServices();
												ThuocForm thuoc = new ThuocForm();
												service.Show();
												thuoc.Show();	
											}
											else MessageBox.Show("Thông tin nhân viên không tồn tại trong hệ thống !", "Thông báo");
										}
										else MessageBox.Show("Lỗi kết nối !", "Thông báo");
										db.CloseConnection();
									}
									catch (Exception ex)
									{
										MessageBox.Show(ex.Message, "Thông báo");
									}
								}
								else if(CVItem.Value == "3")
								{
									DatabaseSetup db = new DatabaseSetup();
									try
									{
										db.OpenConnection();
										if (db.CheckConnection())
										{
											db.command.CommandText = $"Select COUNT(*) from NhanVien where PersonalID = '{txtUsername.Text}' and BoPhanID = 1";
											int count = (int)db.command.ExecuteScalar();
											if (count > 0)
											{
												frmServices service = new frmServices();
												ThuocForm thuoc = new ThuocForm();
												service.Show();
												thuoc.Show();
											}
											else MessageBox.Show("Thông tin nhân viên không tồn tại trong hệ thống !", "Thông báo");
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
						}
						else if(PhongBanItem.Value == "4")
						{
							if(BoPhanItem.Value == "2")
							{
								DatabaseSetup db = new DatabaseSetup();
								try
								{
									db.OpenConnection();
									if (db.CheckConnection())
									{
										db.command.CommandText = $"Select COUNT(*) from NhanVien where PersonalID = '{txtUsername.Text}' and BoPhanID = 2";
										int count = (int)db.command.ExecuteScalar();
										if (count > 0)
										{
											BacSi bs = new BacSi();
											NhanVien nv = new NhanVien();
											bs.Show();
											nv.Show();
										}
										else MessageBox.Show("Thông tin nhân viên không tồn tại trong hệ thống !", "Thông báo");
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
					}
				}
			}
		}

		private void btnDangKi_Click(object sender, EventArgs e)
		{
			if (txtUsername.Text == "" || txtPassword.Text == "")
			{
				MessageBox.Show("Vui lòng nhập Username và Password để đăng kí");
			}
			else
			{
				if (rdoBacSi.Checked == true)
				{
					DatabaseSetup db = new DatabaseSetup();
					try
					{
						db.OpenConnection();
						if (db.CheckConnection())
						{
								db.command.CommandText = $"Select COUNT(*) from BacSi where PersonalID = '{txtUsername.Text}'";
								int count = (int)db.command.ExecuteScalar();
								if (count > 0)
								{
									db.CloseConnection();
									db.OpenConnection();
									db.command.CommandText = $"CREATE LOGIN {txtUsername.Text} WITH PASSWORD = '{txtPassword.Text}' CREATE USER {txtUsername.Text} FOR LOGIN {txtUsername.Text} ALTER ROLE BacSi ADD MEMBER {txtUsername.Text}";
								    db.command.ExecuteNonQuery();
								    db.CloseConnection();
								    MessageBox.Show("Đăng kí tài khoản thành công !", "Thông báo");
								    db.OpenConnection();
								    db.command.CommandText = $"Select ID from BacSi where PersonalID = '{txtUsername.Text}'";
								    int doctor = (int)db.command.ExecuteScalar();
								    db.CloseConnection();
								    frmMedicalExaminationDetails CTKB = new frmMedicalExaminationDetails(txtUsername.Text, txtPassword.Text, doctor, BaseForm.Role.BacSi, this);
								    CTKB.Show();
								}
								else MessageBox.Show("Thông tin bác sĩ không tồn tại trong hệ thống !", "Thông báo");
						}
						else MessageBox.Show("Lỗi kết nối !", "Thông báo");
						db.CloseConnection();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
				else
				{
					if (cbbPhongBan.Text == "" && cbbBoPhan.Text == "" && cbbCV.Text == "")
					{
						MessageBox.Show("Vui lòng chọn vị trí của mình trong hệ thống để đăng nhập !", "Thông báo");
					}
					else
					{
						ComboBoxItem PhongBanItem = cbbPhongBan.SelectedItem as ComboBoxItem;
						ComboBoxItem BoPhanItem = cbbBoPhan.SelectedItem as ComboBoxItem;
						ComboBoxItem CVItem = cbbCV.SelectedItem as ComboBoxItem;
						if (PhongBanItem.Value == "1")
						{
							if (BoPhanItem == null)
							{
								DatabaseSetup db = new DatabaseSetup();
								try
								{
									db.OpenConnection();
									if (db.CheckConnection())
									{
										db.command.CommandText = $"Select COUNT(*) from NhanVien where PersonalID = '{txtUsername.Text}' and PhongBanID = 1";
										int count = (int)db.command.ExecuteScalar();
										if (count > 0)
										{
											db.CloseConnection();
											db.OpenConnection();
											db.command.CommandText = $"CREATE LOGIN {txtUsername.Text} WITH PASSWORD = '{txtPassword.Text}' CREATE USER {txtUsername.Text} FOR LOGIN {txtUsername.Text} ALTER ROLE NVTaiVu ADD MEMBER {txtUsername.Text}";
											db.command.ExecuteNonQuery();
											db.CloseConnection();
											MessageBox.Show("Đăng kí tài khoản thành công !", "Thông báo");
											frmMedicalExaminationDetails CTKB = new frmMedicalExaminationDetails();
											CTKB.Show();
										}
										else MessageBox.Show("Thông tin nhân viên không tồn tại trong hệ thống !", "Thông báo");
									}
									else MessageBox.Show("Lỗi kết nối !", "Thông báo");
									db.CloseConnection();
								}
								catch (Exception ex)
								{
									MessageBox.Show(ex.Message, "Thông báo");
								}
							}
							else if (BoPhanItem.Value == "3")
							{
								DatabaseSetup db = new DatabaseSetup();
								try
								{
									db.OpenConnection();
									if (db.CheckConnection())
									{
										db.command.CommandText = $"Select COUNT(*) from NhanVien where PersonalID = '{txtUsername.Text}' and BoPhanID = 3";
										int count = (int)db.command.ExecuteScalar();
										if (count > 0)
										{
											db.CloseConnection();
											db.OpenConnection();
											db.command.CommandText = $"CREATE LOGIN {txtUsername.Text} WITH PASSWORD = '{txtPassword.Text}' CREATE USER {txtUsername.Text} FOR LOGIN {txtUsername.Text} ALTER ROLE NVKeToan ADD MEMBER {txtUsername.Text}";
											db.command.ExecuteNonQuery();
											db.CloseConnection();
											BacSi bs = new BacSi();
											NhanVien nv = new NhanVien();
											bs.Show();
											nv.Show();
										}
										else MessageBox.Show("Thông tin nhân viên không tồn tại trong hệ thống !", "Thông báo");
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
						else if (PhongBanItem.Value == "2")
						{
							DatabaseSetup db = new DatabaseSetup();
							try
							{
								db.OpenConnection();
								if (db.CheckConnection())
								{
									db.command.CommandText = $"Select COUNT(*) from NhanVien where PersonalID = '{txtUsername.Text}' and PhongBanID = 2";
									int count = (int)db.command.ExecuteScalar();
									if (count > 0)
									{
										db.CloseConnection();
										db.OpenConnection();
										db.command.CommandText = $"CREATE LOGIN {txtUsername.Text} WITH PASSWORD = '{txtPassword.Text}' CREATE USER {txtUsername.Text} FOR LOGIN {txtUsername.Text} ALTER ROLE NVBanThuoc ADD MEMBER {txtUsername.Text}";
										db.command.ExecuteNonQuery();
										db.CloseConnection();
										ToaThuocForm toathuoc = new ToaThuocForm();
										toathuoc.Show();
									}
									else MessageBox.Show("Thông tin nhân viên không tồn tại trong hệ thống !", "Thông báo");
								}
								else MessageBox.Show("Lỗi kết nối !", "Thông báo");
								db.CloseConnection();
							}
							catch (Exception ex)
							{
								MessageBox.Show(ex.Message, "Thông báo");
							}
						}
						else if (PhongBanItem.Value == "3")
						{
							if (BoPhanItem.Value == "1")
							{
								if (CVItem.Value == "1")
								{
									DatabaseSetup db = new DatabaseSetup();
									try
									{
										db.OpenConnection();
										if (db.CheckConnection())
										{
											db.command.CommandText = $"Select COUNT(*) from NhanVien where PersonalID = '{txtUsername.Text}' and BoPhanID = 1";
											int count = (int)db.command.ExecuteScalar();
											if (count > 0)
											{
												db.CloseConnection();
												db.OpenConnection();
												db.command.CommandText = $"CREATE LOGIN {txtUsername.Text} WITH PASSWORD = '{txtPassword.Text}' CREATE USER {txtUsername.Text} FOR LOGIN {txtUsername.Text} ALTER ROLE QLTaiNguyen ADD MEMBER {txtUsername.Text}";
												db.command.ExecuteNonQuery();
												db.CloseConnection();
												BacSi bs = new BacSi();
												NhanVien nv = new NhanVien();
												PhongBan phongban = new PhongBan();
												bs.Show();
												nv.Show();
												phongban.Show();
											}
											else MessageBox.Show("Thông tin nhân viên không tồn tại trong hệ thống !", "Thông báo");
										}
										else MessageBox.Show("Lỗi kết nối !", "Thông báo");
										db.CloseConnection();
									}
									catch (Exception ex)
									{
										MessageBox.Show(ex.Message, "Thông báo");
									}
								}
								else if (CVItem.Value == "2")
								{
									DatabaseSetup db = new DatabaseSetup();
									try
									{
										db.OpenConnection();
										if (db.CheckConnection())
										{
											db.command.CommandText = $"Select COUNT(*) from NhanVien where PersonalID = '{txtUsername.Text}' and BoPhanID = 1";
											int count = (int)db.command.ExecuteScalar();
											if (count > 0)
											{
												db.CloseConnection();
												db.OpenConnection();
												db.command.CommandText = $"CREATE LOGIN {txtUsername.Text} WITH PASSWORD = '{txtPassword.Text}' CREATE USER {txtUsername.Text} FOR LOGIN {txtUsername.Text} ALTER ROLE QLTaiVu ADD MEMBER {txtUsername.Text}";
												db.command.ExecuteNonQuery();
												db.CloseConnection();
												frmServices service = new frmServices();
												ThuocForm thuoc = new ThuocForm();
												service.Show();
												thuoc.Show();
											}
											else MessageBox.Show("Thông tin nhân viên không tồn tại trong hệ thống !", "Thông báo");
										}
										else MessageBox.Show("Lỗi kết nối !", "Thông báo");
										db.CloseConnection();
									}
									catch (Exception ex)
									{
										MessageBox.Show(ex.Message, "Thông báo");
									}
								}
								else if (CVItem.Value == "3")
								{
									DatabaseSetup db = new DatabaseSetup();
									try
									{
										db.OpenConnection();
										if (db.CheckConnection())
										{
											db.command.CommandText = $"Select COUNT(*) from NhanVien where PersonalID = '{txtUsername.Text}' and BoPhanID = 1";
											int count = (int)db.command.ExecuteScalar();
											if (count > 0)
											{
												db.CloseConnection();
												db.OpenConnection();
												db.command.CommandText = $"CREATE LOGIN {txtUsername.Text} WITH PASSWORD = '{txtPassword.Text}' CREATE USER {txtUsername.Text} FOR LOGIN {txtUsername.Text} ALTER ROLE QLChuyenMon ADD MEMBER {txtUsername.Text}";
												db.command.ExecuteNonQuery();
												db.CloseConnection();
												frmMedicalExaminationDetails CTKB = new frmMedicalExaminationDetails();
												CTKB.Show();
											}
											else MessageBox.Show("Thông tin nhân viên không tồn tại trong hệ thống !", "Thông báo");
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
						}
						else if (PhongBanItem.Value == "4")
						{
							if (BoPhanItem.Value == "2")
							{
								DatabaseSetup db = new DatabaseSetup();
								try
								{
									db.OpenConnection();
									if (db.CheckConnection())
									{
										db.command.CommandText = $"Select COUNT(*) from NhanVien where PersonalID = '{txtUsername.Text}' and BoPhanID = 2";
										int count = (int)db.command.ExecuteScalar();
										if (count > 0)
										{
											db.CloseConnection();
											db.OpenConnection();
											db.command.CommandText = $"CREATE LOGIN {txtUsername.Text} WITH PASSWORD = '{txtPassword.Text}' CREATE USER {txtUsername.Text} FOR LOGIN {txtUsername.Text} ALTER ROLE BoPhanTiepTan ADD MEMBER {txtUsername.Text}";
											db.command.ExecuteNonQuery();
											db.CloseConnection();
											BenhNhan benhNhan = new BenhNhan();
											frmServices services = new frmServices();	
											services.Show();
											benhNhan.Show();
										}
										else MessageBox.Show("Thông tin nhân viên không tồn tại trong hệ thống !", "Thông báo");
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
					}
				}
			}
		}

		private void cbbPhongBan_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbbBoPhan.Items.Clear();
			ComboBoxItem item = cbbPhongBan.SelectedItem as ComboBoxItem;
			DatabaseSetup db = new DatabaseSetup();
			try
			{
				db.OpenConnection();
					db.command.CommandText = $"Select ID, Name from BoPhan where PhongBanID = {item.Value}";
					SqlDataReader reader = db.command.ExecuteReader();
					while (reader.Read())
					{
						cbbBoPhan.Items.Add(new ComboBoxItem(reader[1].ToString(), reader[0].ToString()));
					}
				db.CloseConnection();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo");
			}
		}

		private void rdoBacSi_CheckedChanged(object sender, EventArgs e)
		{
			cbbPhongBan.Enabled = false;
			cbbBoPhan.Enabled = false;
			cbbCV.Enabled = false;
		}

		private void rdoNV_CheckedChanged(object sender, EventArgs e)
		{
			cbbPhongBan.Enabled = true;
			cbbBoPhan.Enabled = true;
			cbbCV.Enabled = true;
		}

		private void cbbBoPhan_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbbCV.Items.Clear();
			ComboBoxItem PhongBanItem = cbbPhongBan.SelectedItem as ComboBoxItem;
			ComboBoxItem BoPhanItem = cbbBoPhan.SelectedItem as ComboBoxItem;
			if(PhongBanItem.Value == "3" && BoPhanItem.Value == "1")
			{
				cbbCV.Items.Add(new ComboBoxItem("Quản lý tài nguyên", "1"));
				cbbCV.Items.Add(new ComboBoxItem("Quản lý tài vụ", "2"));
				cbbCV.Items.Add(new ComboBoxItem("Quản lý chuyên môn", "3"));
			}
		}
	}
	public class ComboBoxItem
	{
		public string Text { get; set; }
		public string Value { get; set; }

		public ComboBoxItem(string text, string value)
		{
			Text = text;
			Value = value;
		}

		public override string ToString()
		{
			return Text;
		}
	}
}
