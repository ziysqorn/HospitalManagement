namespace HospitalManagement
{
    partial class BenhNhan
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
            this.txt_Address_BN = new System.Windows.Forms.TextBox();
            this.label_Address_BS = new System.Windows.Forms.Label();
            this.label_CCCD = new System.Windows.Forms.Label();
            this.group_BS_Actions = new System.Windows.Forms.GroupBox();
            this.Btn_Exit_BN = new System.Windows.Forms.Button();
            this.Btn_Add_BN = new System.Windows.Forms.Button();
            this.Btn_Del_BN = new System.Windows.Forms.Button();
            this.Btn_Edit_BN = new System.Windows.Forms.Button();
            this.group_QLNV = new System.Windows.Forms.GroupBox();
            this.txt_CCCD_BN = new System.Windows.Forms.TextBox();
            this.txt_Phone_BN = new System.Windows.Forms.TextBox();
            this.Phone_BS = new System.Windows.Forms.Label();
            this.txt_Birth_BN = new System.Windows.Forms.MaskedTextBox();
            this.Birth_BS = new System.Windows.Forms.Label();
            this.txt_Name_BN = new System.Windows.Forms.TextBox();
            this.Name_BN = new System.Windows.Forms.Label();
            this.QLBS_label = new System.Windows.Forms.Label();
            this.dgv_BN = new System.Windows.Forms.DataGridView();
            this.group_BS_Actions.SuspendLayout();
            this.group_QLNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BN)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Address_BN
            // 
            this.txt_Address_BN.Location = new System.Drawing.Point(559, 18);
            this.txt_Address_BN.Name = "txt_Address_BN";
            this.txt_Address_BN.Size = new System.Drawing.Size(146, 20);
            this.txt_Address_BN.TabIndex = 25;
            // 
            // label_Address_BS
            // 
            this.label_Address_BS.AutoSize = true;
            this.label_Address_BS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Address_BS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Address_BS.Location = new System.Drawing.Point(477, 20);
            this.label_Address_BS.Name = "label_Address_BS";
            this.label_Address_BS.Size = new System.Drawing.Size(56, 19);
            this.label_Address_BS.TabIndex = 24;
            this.label_Address_BS.Text = "Địa chỉ";
            // 
            // label_CCCD
            // 
            this.label_CCCD.AutoSize = true;
            this.label_CCCD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CCCD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_CCCD.Location = new System.Drawing.Point(477, 58);
            this.label_CCCD.Name = "label_CCCD";
            this.label_CCCD.Size = new System.Drawing.Size(54, 19);
            this.label_CCCD.TabIndex = 22;
            this.label_CCCD.Text = "CCCD";
            // 
            // group_BS_Actions
            // 
            this.group_BS_Actions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.group_BS_Actions.Controls.Add(this.Btn_Exit_BN);
            this.group_BS_Actions.Controls.Add(this.Btn_Add_BN);
            this.group_BS_Actions.Controls.Add(this.Btn_Del_BN);
            this.group_BS_Actions.Controls.Add(this.Btn_Edit_BN);
            this.group_BS_Actions.Location = new System.Drawing.Point(13, 395);
            this.group_BS_Actions.Name = "group_BS_Actions";
            this.group_BS_Actions.Size = new System.Drawing.Size(775, 54);
            this.group_BS_Actions.TabIndex = 19;
            this.group_BS_Actions.TabStop = false;
            // 
            // Btn_Exit_BN
            // 
            this.Btn_Exit_BN.BackColor = System.Drawing.Color.Red;
            this.Btn_Exit_BN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit_BN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Exit_BN.Location = new System.Drawing.Point(685, 15);
            this.Btn_Exit_BN.Name = "Btn_Exit_BN";
            this.Btn_Exit_BN.Size = new System.Drawing.Size(84, 33);
            this.Btn_Exit_BN.TabIndex = 14;
            this.Btn_Exit_BN.Text = "Thoát";
            this.Btn_Exit_BN.UseVisualStyleBackColor = false;
            // 
            // Btn_Add_BN
            // 
            this.Btn_Add_BN.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_Add_BN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add_BN.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Add_BN.Location = new System.Drawing.Point(6, 15);
            this.Btn_Add_BN.Name = "Btn_Add_BN";
            this.Btn_Add_BN.Size = new System.Drawing.Size(84, 33);
            this.Btn_Add_BN.TabIndex = 0;
            this.Btn_Add_BN.Text = "Thêm";
            this.Btn_Add_BN.UseVisualStyleBackColor = false;
            this.Btn_Add_BN.Click += new System.EventHandler(this.Btn_Add_BN_Click);
            // 
            // Btn_Del_BN
            // 
            this.Btn_Del_BN.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_Del_BN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Del_BN.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Del_BN.Location = new System.Drawing.Point(133, 15);
            this.Btn_Del_BN.Name = "Btn_Del_BN";
            this.Btn_Del_BN.Size = new System.Drawing.Size(84, 33);
            this.Btn_Del_BN.TabIndex = 1;
            this.Btn_Del_BN.Text = "Xoá";
            this.Btn_Del_BN.UseVisualStyleBackColor = false;
            this.Btn_Del_BN.Click += new System.EventHandler(this.Btn_Del_BN_Click);
            // 
            // Btn_Edit_BN
            // 
            this.Btn_Edit_BN.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_Edit_BN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Edit_BN.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Edit_BN.Location = new System.Drawing.Point(261, 15);
            this.Btn_Edit_BN.Name = "Btn_Edit_BN";
            this.Btn_Edit_BN.Size = new System.Drawing.Size(84, 33);
            this.Btn_Edit_BN.TabIndex = 1;
            this.Btn_Edit_BN.Text = "Sửa";
            this.Btn_Edit_BN.UseVisualStyleBackColor = false;
            this.Btn_Edit_BN.Click += new System.EventHandler(this.Btn_Edit_BN_Click);
            // 
            // group_QLNV
            // 
            this.group_QLNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.group_QLNV.Controls.Add(this.txt_Address_BN);
            this.group_QLNV.Controls.Add(this.label_Address_BS);
            this.group_QLNV.Controls.Add(this.txt_CCCD_BN);
            this.group_QLNV.Controls.Add(this.label_CCCD);
            this.group_QLNV.Controls.Add(this.txt_Phone_BN);
            this.group_QLNV.Controls.Add(this.Phone_BS);
            this.group_QLNV.Controls.Add(this.txt_Birth_BN);
            this.group_QLNV.Controls.Add(this.Birth_BS);
            this.group_QLNV.Controls.Add(this.txt_Name_BN);
            this.group_QLNV.Controls.Add(this.Name_BN);
            this.group_QLNV.Location = new System.Drawing.Point(13, 32);
            this.group_QLNV.Name = "group_QLNV";
            this.group_QLNV.Size = new System.Drawing.Size(775, 132);
            this.group_QLNV.TabIndex = 18;
            this.group_QLNV.TabStop = false;
            // 
            // txt_CCCD_BN
            // 
            this.txt_CCCD_BN.Location = new System.Drawing.Point(559, 59);
            this.txt_CCCD_BN.Name = "txt_CCCD_BN";
            this.txt_CCCD_BN.Size = new System.Drawing.Size(146, 20);
            this.txt_CCCD_BN.TabIndex = 23;
            // 
            // txt_Phone_BN
            // 
            this.txt_Phone_BN.Location = new System.Drawing.Point(174, 98);
            this.txt_Phone_BN.Name = "txt_Phone_BN";
            this.txt_Phone_BN.Size = new System.Drawing.Size(127, 20);
            this.txt_Phone_BN.TabIndex = 11;
            // 
            // Phone_BS
            // 
            this.Phone_BS.AutoSize = true;
            this.Phone_BS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_BS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Phone_BS.Location = new System.Drawing.Point(73, 97);
            this.Phone_BS.Name = "Phone_BS";
            this.Phone_BS.Size = new System.Drawing.Size(95, 19);
            this.Phone_BS.TabIndex = 10;
            this.Phone_BS.Text = "Số điện thoại";
            // 
            // txt_Birth_BN
            // 
            this.txt_Birth_BN.Location = new System.Drawing.Point(155, 59);
            this.txt_Birth_BN.Mask = "00/00/0000";
            this.txt_Birth_BN.Name = "txt_Birth_BN";
            this.txt_Birth_BN.Size = new System.Drawing.Size(146, 20);
            this.txt_Birth_BN.TabIndex = 7;
            // 
            // Birth_BS
            // 
            this.Birth_BS.AutoSize = true;
            this.Birth_BS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birth_BS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Birth_BS.Location = new System.Drawing.Point(73, 58);
            this.Birth_BS.Name = "Birth_BS";
            this.Birth_BS.Size = new System.Drawing.Size(76, 19);
            this.Birth_BS.TabIndex = 6;
            this.Birth_BS.Text = "Ngày sinh";
            // 
            // txt_Name_BN
            // 
            this.txt_Name_BN.Location = new System.Drawing.Point(133, 19);
            this.txt_Name_BN.Name = "txt_Name_BN";
            this.txt_Name_BN.Size = new System.Drawing.Size(168, 20);
            this.txt_Name_BN.TabIndex = 3;
            // 
            // Name_BN
            // 
            this.Name_BN.AutoSize = true;
            this.Name_BN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_BN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name_BN.Location = new System.Drawing.Point(73, 18);
            this.Name_BN.Name = "Name_BN";
            this.Name_BN.Size = new System.Drawing.Size(54, 19);
            this.Name_BN.TabIndex = 2;
            this.Name_BN.Text = "Họ tên";
            // 
            // QLBS_label
            // 
            this.QLBS_label.AutoSize = true;
            this.QLBS_label.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLBS_label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.QLBS_label.Location = new System.Drawing.Point(269, 1);
            this.QLBS_label.Name = "QLBS_label";
            this.QLBS_label.Size = new System.Drawing.Size(264, 28);
            this.QLBS_label.TabIndex = 17;
            this.QLBS_label.Text = "QUẢN LÝ BỆNH NHÂN";
            // 
            // dgv_BN
            // 
            this.dgv_BN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BN.Location = new System.Drawing.Point(13, 170);
            this.dgv_BN.Name = "dgv_BN";
            this.dgv_BN.Size = new System.Drawing.Size(775, 219);
            this.dgv_BN.TabIndex = 16;
            this.dgv_BN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BN_CellClick);
            // 
            // BenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.group_BS_Actions);
            this.Controls.Add(this.group_QLNV);
            this.Controls.Add(this.QLBS_label);
            this.Controls.Add(this.dgv_BN);
            this.Name = "BenhNhan";
            this.Text = "BenhNhan";
            this.group_BS_Actions.ResumeLayout(false);
            this.group_QLNV.ResumeLayout(false);
            this.group_QLNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Address_BN;
        private System.Windows.Forms.Label label_Address_BS;
        private System.Windows.Forms.Label label_CCCD;
        private System.Windows.Forms.GroupBox group_BS_Actions;
        private System.Windows.Forms.Button Btn_Exit_BN;
        private System.Windows.Forms.Button Btn_Add_BN;
        private System.Windows.Forms.Button Btn_Del_BN;
        private System.Windows.Forms.Button Btn_Edit_BN;
        private System.Windows.Forms.GroupBox group_QLNV;
        private System.Windows.Forms.TextBox txt_CCCD_BN;
        private System.Windows.Forms.TextBox txt_Phone_BN;
        private System.Windows.Forms.Label Phone_BS;
        private System.Windows.Forms.MaskedTextBox txt_Birth_BN;
        private System.Windows.Forms.Label Birth_BS;
        private System.Windows.Forms.TextBox txt_Name_BN;
        private System.Windows.Forms.Label Name_BN;
        private System.Windows.Forms.Label QLBS_label;
        private System.Windows.Forms.DataGridView dgv_BN;
    }
}