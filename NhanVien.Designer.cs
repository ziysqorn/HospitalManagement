namespace HospitalManagement
{
    partial class NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.dgv_NV = new System.Windows.Forms.DataGridView();
			this.QLNV_label = new System.Windows.Forms.Label();
			this.group_QLNV = new System.Windows.Forms.GroupBox();
			this.cbb_BP = new System.Windows.Forms.ComboBox();
			this.cbb_PB = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.rdbnu = new System.Windows.Forms.RadioButton();
			this.rdbnam = new System.Windows.Forms.RadioButton();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.label_Address_NV = new System.Windows.Forms.Label();
			this.label_Email_NV = new System.Windows.Forms.Label();
			this.Btn_Exit = new System.Windows.Forms.Button();
			this.txt_CCCD_NV = new System.Windows.Forms.TextBox();
			this.label_CCCD = new System.Windows.Forms.Label();
			this.txt_Salary_NV = new System.Windows.Forms.TextBox();
			this.Salary_NV = new System.Windows.Forms.Label();
			this.Btn_Edit_NV = new System.Windows.Forms.Button();
			this.Btn_Add_NV = new System.Windows.Forms.Button();
			this.Btn_Del_NV = new System.Windows.Forms.Button();
			this.txt_Roles_NV = new System.Windows.Forms.TextBox();
			this.Roles_NV = new System.Windows.Forms.Label();
			this.txt_Phone_NV = new System.Windows.Forms.TextBox();
			this.Phone_NV = new System.Windows.Forms.Label();
			this.txt_Mail_NV = new System.Windows.Forms.TextBox();
			this.txt_Birth_NV = new System.Windows.Forms.MaskedTextBox();
			this.Birth_NV = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_Name_NV = new System.Windows.Forms.TextBox();
			this.Name_NV = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgv_NV)).BeginInit();
			this.group_QLNV.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgv_NV
			// 
			this.dgv_NV.AllowUserToAddRows = false;
			this.dgv_NV.AllowUserToDeleteRows = false;
			this.dgv_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_NV.Location = new System.Drawing.Point(13, 207);
			this.dgv_NV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgv_NV.Name = "dgv_NV";
			this.dgv_NV.RowHeadersWidth = 51;
			this.dgv_NV.Size = new System.Drawing.Size(775, 200);
			this.dgv_NV.TabIndex = 0;
			this.dgv_NV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NV_CellClick);
			this.dgv_NV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_NV_CellFormatting);
			// 
			// QLNV_label
			// 
			this.QLNV_label.AutoSize = true;
			this.QLNV_label.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.QLNV_label.ForeColor = System.Drawing.SystemColors.Desktop;
			this.QLNV_label.Location = new System.Drawing.Point(277, 8);
			this.QLNV_label.Name = "QLNV_label";
			this.QLNV_label.Size = new System.Drawing.Size(253, 28);
			this.QLNV_label.TabIndex = 1;
			this.QLNV_label.Text = "QUẢN LÝ NHÂN VIÊN";
			// 
			// group_QLNV
			// 
			this.group_QLNV.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.group_QLNV.Controls.Add(this.cbb_BP);
			this.group_QLNV.Controls.Add(this.cbb_PB);
			this.group_QLNV.Controls.Add(this.label3);
			this.group_QLNV.Controls.Add(this.label2);
			this.group_QLNV.Controls.Add(this.rdbnu);
			this.group_QLNV.Controls.Add(this.rdbnam);
			this.group_QLNV.Controls.Add(this.txtDiaChi);
			this.group_QLNV.Controls.Add(this.label_Address_NV);
			this.group_QLNV.Controls.Add(this.label_Email_NV);
			this.group_QLNV.Controls.Add(this.Btn_Exit);
			this.group_QLNV.Controls.Add(this.txt_CCCD_NV);
			this.group_QLNV.Controls.Add(this.label_CCCD);
			this.group_QLNV.Controls.Add(this.txt_Salary_NV);
			this.group_QLNV.Controls.Add(this.Salary_NV);
			this.group_QLNV.Controls.Add(this.Btn_Edit_NV);
			this.group_QLNV.Controls.Add(this.Btn_Add_NV);
			this.group_QLNV.Controls.Add(this.Btn_Del_NV);
			this.group_QLNV.Controls.Add(this.txt_Roles_NV);
			this.group_QLNV.Controls.Add(this.Roles_NV);
			this.group_QLNV.Controls.Add(this.txt_Phone_NV);
			this.group_QLNV.Controls.Add(this.Phone_NV);
			this.group_QLNV.Controls.Add(this.txt_Mail_NV);
			this.group_QLNV.Controls.Add(this.txt_Birth_NV);
			this.group_QLNV.Controls.Add(this.Birth_NV);
			this.group_QLNV.Controls.Add(this.label1);
			this.group_QLNV.Controls.Add(this.txt_Name_NV);
			this.group_QLNV.Controls.Add(this.Name_NV);
			this.group_QLNV.Location = new System.Drawing.Point(12, 37);
			this.group_QLNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.group_QLNV.Name = "group_QLNV";
			this.group_QLNV.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.group_QLNV.Size = new System.Drawing.Size(775, 164);
			this.group_QLNV.TabIndex = 2;
			this.group_QLNV.TabStop = false;
			// 
			// cbb_BP
			// 
			this.cbb_BP.FormattingEnabled = true;
			this.cbb_BP.Location = new System.Drawing.Point(348, 88);
			this.cbb_BP.Margin = new System.Windows.Forms.Padding(2);
			this.cbb_BP.Name = "cbb_BP";
			this.cbb_BP.Size = new System.Drawing.Size(146, 21);
			this.cbb_BP.TabIndex = 27;
			// 
			// cbb_PB
			// 
			this.cbb_PB.FormattingEnabled = true;
			this.cbb_PB.Location = new System.Drawing.Point(348, 62);
			this.cbb_PB.Margin = new System.Windows.Forms.Padding(2);
			this.cbb_PB.Name = "cbb_PB";
			this.cbb_PB.Size = new System.Drawing.Size(146, 21);
			this.cbb_PB.TabIndex = 26;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(266, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 19);
			this.label3.TabIndex = 25;
			this.label3.Text = "Bộ phận";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(266, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 19);
			this.label2.TabIndex = 24;
			this.label2.Text = "Phòng ban";
			// 
			// rdbnu
			// 
			this.rdbnu.AutoSize = true;
			this.rdbnu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbnu.ForeColor = System.Drawing.SystemColors.Highlight;
			this.rdbnu.Location = new System.Drawing.Point(654, 103);
			this.rdbnu.Margin = new System.Windows.Forms.Padding(2);
			this.rdbnu.Name = "rdbnu";
			this.rdbnu.Size = new System.Drawing.Size(41, 19);
			this.rdbnu.TabIndex = 23;
			this.rdbnu.TabStop = true;
			this.rdbnu.Text = "Nữ";
			this.rdbnu.UseVisualStyleBackColor = true;
			// 
			// rdbnam
			// 
			this.rdbnam.AutoSize = true;
			this.rdbnam.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbnam.ForeColor = System.Drawing.SystemColors.Highlight;
			this.rdbnam.Location = new System.Drawing.Point(605, 103);
			this.rdbnam.Margin = new System.Windows.Forms.Padding(2);
			this.rdbnam.Name = "rdbnam";
			this.rdbnam.Size = new System.Drawing.Size(50, 19);
			this.rdbnam.TabIndex = 22;
			this.rdbnam.TabStop = true;
			this.rdbnam.Text = "Nam";
			this.rdbnam.UseVisualStyleBackColor = true;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(593, 76);
			this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(171, 20);
			this.txtDiaChi.TabIndex = 21;
			// 
			// label_Address_NV
			// 
			this.label_Address_NV.AutoSize = true;
			this.label_Address_NV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Address_NV.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label_Address_NV.Location = new System.Drawing.Point(529, 76);
			this.label_Address_NV.Name = "label_Address_NV";
			this.label_Address_NV.Size = new System.Drawing.Size(56, 19);
			this.label_Address_NV.TabIndex = 20;
			this.label_Address_NV.Text = "Địa chỉ";
			// 
			// label_Email_NV
			// 
			this.label_Email_NV.AutoSize = true;
			this.label_Email_NV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Email_NV.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label_Email_NV.Location = new System.Drawing.Point(6, 53);
			this.label_Email_NV.Name = "label_Email_NV";
			this.label_Email_NV.Size = new System.Drawing.Size(47, 19);
			this.label_Email_NV.TabIndex = 19;
			this.label_Email_NV.Text = "Email";
			// 
			// Btn_Exit
			// 
			this.Btn_Exit.BackColor = System.Drawing.Color.Red;
			this.Btn_Exit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.Btn_Exit.Location = new System.Drawing.Point(685, 128);
			this.Btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Btn_Exit.Name = "Btn_Exit";
			this.Btn_Exit.Size = new System.Drawing.Size(84, 31);
			this.Btn_Exit.TabIndex = 14;
			this.Btn_Exit.Text = "Thoát";
			this.Btn_Exit.UseVisualStyleBackColor = false;
			this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
			// 
			// txt_CCCD_NV
			// 
			this.txt_CCCD_NV.Location = new System.Drawing.Point(348, 38);
			this.txt_CCCD_NV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_CCCD_NV.Name = "txt_CCCD_NV";
			this.txt_CCCD_NV.Size = new System.Drawing.Size(146, 20);
			this.txt_CCCD_NV.TabIndex = 18;
			// 
			// label_CCCD
			// 
			this.label_CCCD.AutoSize = true;
			this.label_CCCD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_CCCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label_CCCD.Location = new System.Drawing.Point(266, 38);
			this.label_CCCD.Name = "label_CCCD";
			this.label_CCCD.Size = new System.Drawing.Size(54, 19);
			this.label_CCCD.TabIndex = 17;
			this.label_CCCD.Text = "CCCD";
			// 
			// txt_Salary_NV
			// 
			this.txt_Salary_NV.Location = new System.Drawing.Point(593, 19);
			this.txt_Salary_NV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_Salary_NV.Name = "txt_Salary_NV";
			this.txt_Salary_NV.ReadOnly = true;
			this.txt_Salary_NV.Size = new System.Drawing.Size(171, 20);
			this.txt_Salary_NV.TabIndex = 16;
			// 
			// Salary_NV
			// 
			this.Salary_NV.AutoSize = true;
			this.Salary_NV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Salary_NV.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Salary_NV.Location = new System.Drawing.Point(529, 19);
			this.Salary_NV.Name = "Salary_NV";
			this.Salary_NV.Size = new System.Drawing.Size(54, 19);
			this.Salary_NV.TabIndex = 15;
			this.Salary_NV.Text = "Lương";
			// 
			// Btn_Edit_NV
			// 
			this.Btn_Edit_NV.BackColor = System.Drawing.SystemColors.Highlight;
			this.Btn_Edit_NV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Edit_NV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.Btn_Edit_NV.Location = new System.Drawing.Point(232, 128);
			this.Btn_Edit_NV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Btn_Edit_NV.Name = "Btn_Edit_NV";
			this.Btn_Edit_NV.Size = new System.Drawing.Size(84, 31);
			this.Btn_Edit_NV.TabIndex = 1;
			this.Btn_Edit_NV.Text = "Sửa";
			this.Btn_Edit_NV.UseVisualStyleBackColor = false;
			this.Btn_Edit_NV.Click += new System.EventHandler(this.Btn_Edit_NV_Click);
			// 
			// Btn_Add_NV
			// 
			this.Btn_Add_NV.BackColor = System.Drawing.SystemColors.Highlight;
			this.Btn_Add_NV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Add_NV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.Btn_Add_NV.Location = new System.Drawing.Point(6, 128);
			this.Btn_Add_NV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Btn_Add_NV.Name = "Btn_Add_NV";
			this.Btn_Add_NV.Size = new System.Drawing.Size(84, 31);
			this.Btn_Add_NV.TabIndex = 0;
			this.Btn_Add_NV.Text = "Thêm";
			this.Btn_Add_NV.UseVisualStyleBackColor = false;
			this.Btn_Add_NV.Click += new System.EventHandler(this.Btn_Add_NV_Click);
			// 
			// Btn_Del_NV
			// 
			this.Btn_Del_NV.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.Btn_Del_NV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Del_NV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.Btn_Del_NV.Location = new System.Drawing.Point(118, 128);
			this.Btn_Del_NV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Btn_Del_NV.Name = "Btn_Del_NV";
			this.Btn_Del_NV.Size = new System.Drawing.Size(84, 31);
			this.Btn_Del_NV.TabIndex = 1;
			this.Btn_Del_NV.Text = "Xoá";
			this.Btn_Del_NV.UseVisualStyleBackColor = false;
			this.Btn_Del_NV.Click += new System.EventHandler(this.Btn_Del_NV_Click);
			// 
			// txt_Roles_NV
			// 
			this.txt_Roles_NV.Location = new System.Drawing.Point(593, 50);
			this.txt_Roles_NV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_Roles_NV.Name = "txt_Roles_NV";
			this.txt_Roles_NV.Size = new System.Drawing.Size(171, 20);
			this.txt_Roles_NV.TabIndex = 13;
			// 
			// Roles_NV
			// 
			this.Roles_NV.AutoSize = true;
			this.Roles_NV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Roles_NV.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Roles_NV.Location = new System.Drawing.Point(527, 48);
			this.Roles_NV.Name = "Roles_NV";
			this.Roles_NV.Size = new System.Drawing.Size(65, 19);
			this.Roles_NV.TabIndex = 12;
			this.Roles_NV.Text = "Chức vụ";
			// 
			// txt_Phone_NV
			// 
			this.txt_Phone_NV.Location = new System.Drawing.Point(107, 89);
			this.txt_Phone_NV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_Phone_NV.Name = "txt_Phone_NV";
			this.txt_Phone_NV.Size = new System.Drawing.Size(127, 20);
			this.txt_Phone_NV.TabIndex = 11;
			// 
			// Phone_NV
			// 
			this.Phone_NV.AutoSize = true;
			this.Phone_NV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Phone_NV.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Phone_NV.Location = new System.Drawing.Point(6, 87);
			this.Phone_NV.Name = "Phone_NV";
			this.Phone_NV.Size = new System.Drawing.Size(95, 19);
			this.Phone_NV.TabIndex = 10;
			this.Phone_NV.Text = "Số điện thoại";
			// 
			// txt_Mail_NV
			// 
			this.txt_Mail_NV.Location = new System.Drawing.Point(66, 51);
			this.txt_Mail_NV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_Mail_NV.Name = "txt_Mail_NV";
			this.txt_Mail_NV.Size = new System.Drawing.Size(168, 20);
			this.txt_Mail_NV.TabIndex = 9;
			// 
			// txt_Birth_NV
			// 
			this.txt_Birth_NV.Location = new System.Drawing.Point(348, 15);
			this.txt_Birth_NV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_Birth_NV.Mask = "00/00/0000";
			this.txt_Birth_NV.Name = "txt_Birth_NV";
			this.txt_Birth_NV.Size = new System.Drawing.Size(146, 20);
			this.txt_Birth_NV.TabIndex = 7;
			this.txt_Birth_NV.ValidatingType = typeof(System.DateTime);
			// 
			// Birth_NV
			// 
			this.Birth_NV.AutoSize = true;
			this.Birth_NV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Birth_NV.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Birth_NV.Location = new System.Drawing.Point(266, 15);
			this.Birth_NV.Name = "Birth_NV";
			this.Birth_NV.Size = new System.Drawing.Size(76, 19);
			this.Birth_NV.TabIndex = 6;
			this.Birth_NV.Text = "Ngày sinh";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(529, 102);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 19);
			this.label1.TabIndex = 4;
			this.label1.Text = "Giới tính";
			// 
			// txt_Name_NV
			// 
			this.txt_Name_NV.Location = new System.Drawing.Point(66, 15);
			this.txt_Name_NV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_Name_NV.Name = "txt_Name_NV";
			this.txt_Name_NV.Size = new System.Drawing.Size(168, 20);
			this.txt_Name_NV.TabIndex = 3;
			// 
			// Name_NV
			// 
			this.Name_NV.AutoSize = true;
			this.Name_NV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name_NV.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Name_NV.Location = new System.Drawing.Point(6, 15);
			this.Name_NV.Name = "Name_NV";
			this.Name_NV.Size = new System.Drawing.Size(54, 19);
			this.Name_NV.TabIndex = 2;
			this.Name_NV.Text = "Họ tên";
			// 
			// NhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 418);
			this.Controls.Add(this.group_QLNV);
			this.Controls.Add(this.QLNV_label);
			this.Controls.Add(this.dgv_NV);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "NhanVien";
			this.Text = "Quản lý nhân viên";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NhanVien_FormClosed);
			this.Load += new System.EventHandler(this.NhanVien_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_NV)).EndInit();
			this.group_QLNV.ResumeLayout(false);
			this.group_QLNV.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_NV;
        private System.Windows.Forms.Label QLNV_label;
        private System.Windows.Forms.GroupBox group_QLNV;
        private System.Windows.Forms.Button Btn_Add_NV;
        private System.Windows.Forms.Button Btn_Edit_NV;
        private System.Windows.Forms.Button Btn_Del_NV;
        private System.Windows.Forms.Label Name_NV;
        private System.Windows.Forms.TextBox txt_Name_NV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Birth_NV;
        private System.Windows.Forms.MaskedTextBox txt_Birth_NV;
        private System.Windows.Forms.TextBox txt_Phone_NV;
        private System.Windows.Forms.Label Phone_NV;
        private System.Windows.Forms.TextBox txt_Mail_NV;
        private System.Windows.Forms.TextBox txt_Roles_NV;
        private System.Windows.Forms.Label Roles_NV;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.TextBox txt_Salary_NV;
        private System.Windows.Forms.Label Salary_NV;
        private System.Windows.Forms.TextBox txt_CCCD_NV;
        private System.Windows.Forms.Label label_CCCD;
        private System.Windows.Forms.Label label_Email_NV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label_Address_NV;
        private System.Windows.Forms.RadioButton rdbnu;
        private System.Windows.Forms.RadioButton rdbnam;
        private System.Windows.Forms.ComboBox cbb_BP;
        private System.Windows.Forms.ComboBox cbb_PB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}