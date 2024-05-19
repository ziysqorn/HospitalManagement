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
	public partial class ChiTietToaThuocForm : BaseForm
	{
        private DatabaseSetup dbSetup;
        private int toaThuocID;
        public ChiTietToaThuocForm(int id)
		{
            InitializeComponent();
            toaThuocID = id;
            LoadChiTietToaThuocData();
        }
		public ChiTietToaThuocForm(int id, string username, string password, Role role)
		{
			InitializeComponent();
            Username = username;
            Password = password;
            PersonRole = role;
			dbSetup = new DatabaseSetup(username, password);
			toaThuocID = id;
		}
		private void ChiTietToaThuocForm_Load(object sender, EventArgs e)
        {
			LoadChiTietToaThuocData();
		}
        private void LoadChiTietToaThuocData()
        {
            try
            {
                dbSetup.OpenConnection();
                string query = @"SELECT 
                ctt.Amount AS 'Số lượng',
                t.Name AS 'Tên thuốc',
                ctt.Description AS 'Mô tả',
                t.Price AS 'Giá tiền'
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

		private void dgv_ChiTietToa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgv_ChiTietToa.Columns[e.ColumnIndex].Name == "Giá tiền" && e.Value != null)
			{
				e.Value = string.Format("{0:N0} VND", e.Value);
				e.FormattingApplied = true;
			}
		}
	}
}
