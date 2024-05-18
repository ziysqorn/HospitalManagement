using HospitalManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HospitalManagement
{
    public partial class PhongBan : Form
    {
        
        public PhongBan()
        {
            InitializeComponent();
          
            PhongBanDAO phongBanDAO = new PhongBanDAO();
            phongBanDAO.loadPhongBanList(dgv_PBan);

        }

     
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void clear_input()
        {
            txt_ID_PB.Text = "";
            txt_Name_PB.Text = "";
        }

        private void Btn_Add_PB_Click(object sender, EventArgs e)
        {
            using (InputBoxForm inputBox = new InputBoxForm("Nhập tên phòng ban:", "Thêm phòng ban mới"))
            {
                if (inputBox.ShowDialog() == DialogResult.OK)
                {
                    string phongBanName = inputBox.InputText;
                    if (!string.IsNullOrEmpty(phongBanName))
                    {
                        // Xử lý thêm nhân viên với tên employeeName
                        PhongBanDAO phongBanDAO = new PhongBanDAO();
                        if (phongBanDAO.AddPhongBan(phongBanName))
                        {
                            MessageBox.Show($"Phòng ban {phongBanName} đã được thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            phongBanDAO.loadPhongBanList(dgv_PBan);
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Tên phòng ban không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgv_PBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Kiểm tra xem có phải dòng header hay không
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgv_PBan.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                // Lấy dòng hiện tại dựa trên chỉ số dòng (row index)
                DataGridViewRow row = dgv_PBan.Rows[e.RowIndex];

                // Giả sử bạn có các TextBox để hiển thị thông tin
                txt_ID_PB.Text = row.Cells["ID"].Value.ToString();
                txt_Name_PB.Text = row.Cells["Name"].Value.ToString();
            }
        }

        private void Btn_Edit_PB_Click(object sender, EventArgs e)
        {
            int ID;
            if (int.TryParse(txt_ID_PB.Text, out ID))
            {
                string newName = txt_Name_PB.Text;
                if (!string.IsNullOrEmpty(newName))
                {
                    PhongBanDAO phongBanDAO = new PhongBanDAO();
                    bool success = phongBanDAO.UpdatePhongBan(ID, newName);
                    if (success)
                    {
                        MessageBox.Show("Tên phòng ban đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Load lại danh phong ban hoặc làm các thao tác cập nhật khác tại đây
                        phongBanDAO.loadPhongBanList(dgv_PBan);

                    }
                }
                else
                {
                    MessageBox.Show("Tên mới không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ID phòng ban không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Del_PB_Click(object sender, EventArgs e)
        {
            int phongBanID;

            if (int.TryParse(txt_ID_PB.Text, out phongBanID))
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    PhongBanDAO phongBanDAO = new PhongBanDAO();
                    bool success = phongBanDAO.DeletePhongBan(phongBanID);
                    if (success)
                    {
                        MessageBox.Show("Phòng ban đã được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Load lại danh sách phòng ban hoặc làm các thao tác cập nhật khác tại đây
                        phongBanDAO.loadPhongBanList(dgv_PBan);
                        clear_input();
                    }
                }
            }
            else
            {
                MessageBox.Show("ID phòng ban không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Exit_PB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


    public class InputBoxForm : Form
    {
        private Label labelPrompt;
        private TextBox textBoxInput;
        private Button buttonOk;
        private Button buttonCancel;

        public string InputText { get; private set; }

        public InputBoxForm(string prompt, string title)
        {
            InitializeComponent();
            this.Text = title;
            this.labelPrompt.Text = prompt;
        }

        private void InitializeComponent()
        {
            this.labelPrompt = new Label();
            this.textBoxInput = new TextBox();
            this.buttonOk = new Button();
            this.buttonCancel = new Button();

            this.SuspendLayout();

            // labelPrompt
            this.labelPrompt.AutoSize = true;
            this.labelPrompt.Location = new System.Drawing.Point(12, 9);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(50, 13);
            this.labelPrompt.TabIndex = 0;

            // textBoxInput
            this.textBoxInput.Location = new System.Drawing.Point(15, 25);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(257, 20);
            this.textBoxInput.TabIndex = 1;

            // buttonOk
            this.buttonOk.Location = new System.Drawing.Point(116, 51);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new EventHandler(this.ButtonOk_Click);

            // buttonCancel
            this.buttonCancel.Location = new System.Drawing.Point(197, 51);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new EventHandler(this.ButtonCancel_Click);

            // InputBoxForm
            this.ClientSize = new System.Drawing.Size(284, 86);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelPrompt);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputBoxForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            this.InputText = this.textBoxInput.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

}
