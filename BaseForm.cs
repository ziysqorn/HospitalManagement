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
	public class BaseForm : Form
	{
		protected string Username { get; set; }
		protected string Password { get; set; }
		public Role PersonRole { get; set; }
		public enum Role
		{
			QLTaiNguyen,
			QLTaiVu,
			QLChuyenMon,
			BoPhanTiepTan,
			NVTaiVu,
			BacSi,
			NVBanThuoc,
			NVKeToan
		}
		protected DangNhap dangNhap;
		public BaseForm()
		{
		}
	}
}
