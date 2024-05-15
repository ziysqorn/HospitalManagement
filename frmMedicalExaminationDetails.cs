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
    public partial class frmMedicalExaminationDetails : Form
    {
        private DatabaseSetup dbSetup;
        public frmMedicalExaminationDetails()
        {
            InitializeComponent();
            dbSetup = new DatabaseSetup("nhanvienChuyenMon", "NVCM@2206");
        }

        private void frmMedicalExaminationDetails_Load(object sender, EventArgs e)
        {
            Load_ChiTietKhamBenh();
            dgv_KhamBenh_details.RowHeaderMouseClick += dgv_KhamBenh_details_RowHeaderMouseClick;

        }

        private void Load_ChiTietKhamBenh()
        {
            string query = @"
               SELECT 
                    ct.ID,
                    ct.BacSiID AS 'Mã bác sĩ',
                    bs.Name AS 'Bác sĩ',
                    ct.BenhNhanID AS 'Mã bệnh nhân',
                    bn.Name AS 'Bệnh nhân',
                    dv.ID AS 'Mã dịch vụ',
                    dv.Name AS 'Dịch vụ',
                    ct.ToaThuocID AS 'Mã toa thuốc',
                    ct.Description AS 'Mô tả',
                    ct.NgayKham AS 'Ngày khám',
                    ct.TotalPrice AS 'Thành tiền'
                FROM 
                    ChiTietKhamBenh ct
                INNER JOIN 
                    BacSi bs ON ct.BacSiID = bs.ID
                INNER JOIN 
                    BenhNhan bn ON ct.BenhNhanID = bn.ID
                INNER JOIN 
                    ToaThuoc tt ON ct.ToaThuocID = tt.ID
                LEFT JOIN 
                    ChiTietKhamBenh_DV ctdv ON ct.ID = ctdv.ChiTietID
                LEFT JOIN 
                    DVKhamBenh dv ON ctdv.DichVuID = dv.ID";
            DataTable dt = dbSetup.ExecuteSelectQuery(query);
            dgv_KhamBenh_details.DataSource = dt;
        }

        private void Btn_Add_details_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Del_details_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Update_details_Click(object sender, EventArgs e)
        {

        }

        private void dgv_KhamBenh_details_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_KhamBenh_details.Rows[e.RowIndex];
                DisplaySelectedRowDetails(row);
            }
        }

        private void DisplaySelectedRowDetails(DataGridViewRow row)
        {
            txt_BSID_details.Text = row.Cells["Mã bác sĩ"].Value.ToString();
            txt_BSname_details.Text = row.Cells["Bác sĩ"].Value.ToString();
            txt_BNID_details.Text = row.Cells["Mã bệnh nhân"].Value.ToString();
            txt_BNname_details.Text = row.Cells["Bệnh nhân"].Value.ToString();
            txt_DVID_details.Text = row.Cells["Mã dịch vụ"].Value.ToString();
            txt_DVname_details.Text = row.Cells["Dịch vụ"].Value.ToString();
            txt_ToaID_details.Text = row.Cells["Mã toa thuốc"].Value.ToString();
            dateNgayKham.Value = Convert.ToDateTime(row.Cells["Ngày khám"].Value);
            txt_MoTaBenh.Text = row.Cells["Mô tả"].Value.ToString();
        }
    }
}
