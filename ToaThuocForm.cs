using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HospitalManagement.BaseForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HospitalManagement
{
	public partial class ToaThuocForm : BaseForm
	{
		private DatabaseSetup dbSetup;
		public ToaThuocForm()
		{
			InitializeComponent();
			dbSetup = new DatabaseSetup("nhanvienBanThuoc", "NVBT@2203");
		}
		public ToaThuocForm(string username, string password, Role role, DangNhap DN)
		{
			InitializeComponent();
			Username = username;
			Password = password;
			PersonRole = role;
			dangNhap = DN;
            dbSetup = new DatabaseSetup(Username, Password);
		}
		private void ToaThuocForm_Load(object sender, EventArgs e)
        {
            LoadThoathuocData();
            dgv_QLToaThuoc.RowHeaderMouseClick += dgv_QLToaThuoc_RowHeaderMouseClick;
            dgv_QLToaThuoc.CellFormatting += dgv_QLToaThuoc_CellFormatting; // Add this line

        }
        private void dgv_QLToaThuoc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_QLToaThuoc.Columns[e.ColumnIndex].Name == "Tổng tiền" && e.Value != null)
            {
                e.Value = string.Format("{0:N0} VND", e.Value);
                e.FormattingApplied = true;
            }
        }
        private void LoadThoathuocData()
        {
            try
            {
                dbSetup.OpenConnection();
                string query = @"SELECT 
                tt.ID AS 'Mã toa thuốc',
                    tt.PayDate AS 'Ngày thanh toán',
                    tt.TotalPrice AS 'Tổng tiền',
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
                    ChiTietKhamBenh ctkb ON tt.CTKB_ID = ctkb.ID
                INNER JOIN 
                    BacSi bs ON ctkb.BacSiID = bs.ID";
                DataTable dt = dbSetup.ExecuteSelectQuery(query);
                dgv_QLToaThuoc.DataSource = dt;
                dbSetup.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_QLToaThuoc_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_QLToaThuoc.Rows[e.RowIndex];

                // Kiểm tra nếu bất kỳ cell nào của hàng được chọn rỗng thì không hiển thị chi tiết
                if (!row.Cells.Cast<DataGridViewCell>().Any(c => c.Value == null || c.Value == DBNull.Value))
                {
                    DisplaySelectedRowDetails(row);
                }
            }
        }
        private void DisplaySelectedRowDetails(DataGridViewRow row)
        {
            mtxt_PayDate_TT.Text = Convert.ToDateTime(row.Cells["Ngày thanh toán"].Value).ToString("dd/MM/yyyy hh:mm");
            txt_TotalPrice.Text = row.Cells["Tổng tiền"].Value.ToString();
        }

        private void Btn_Detail_ToaThuoc_Click(object sender, EventArgs e)
        {
            if (dgv_QLToaThuoc.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_QLToaThuoc.SelectedRows[0];
                int selectedToaThuocID = Convert.ToInt32(selectedRow.Cells["Mã toa thuốc"].Value);

                ChiTietToaThuocForm chiTietToaThuocForm = new ChiTietToaThuocForm(selectedToaThuocID, Username, Password, PersonRole);
                chiTietToaThuocForm.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một toa thuốc để xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void reLoadData()
        {
            LoadThoathuocData();
            mtxt_PayDate_TT.Clear();
            txt_TotalPrice.Clear();
        }
        private void Btn_Edit_Toa_Click(object sender, EventArgs e)
        {
            if (dgv_QLToaThuoc.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_QLToaThuoc.SelectedRows[0];
                int selectedToaThuocID = Convert.ToInt32(selectedRow.Cells["Mã toa thuốc"].Value);

                try
                {
                    dbSetup.OpenConnection();

                    string payDate = Convert.ToDateTime(mtxt_PayDate_TT.Text).ToString("yyyy-MM-dd");
                    int totalPrice = Convert.ToInt32(txt_TotalPrice.Text.Replace(" VND", "").Replace(",", ""));

                    string query = $"UPDATE ToaThuoc SET PayDate = '{payDate}', TotalPrice = {totalPrice}, NhanVienID = (Select ID from NhanVien where PersonalId = '{Username}') WHERE ID = {selectedToaThuocID}";
                    dbSetup.ExecuteSelectQuery(query);

                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reLoadData();
                    dbSetup.OpenConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một toa thuốc để chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

		private void ToaThuocForm_FormClosed(object sender, FormClosedEventArgs e)
		{
            dangNhap.Show();
		}
	}
}
