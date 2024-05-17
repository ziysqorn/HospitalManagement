namespace HospitalManagement
{
    partial class frmMedicalExaminationDetails
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dGV_BenhNhan = new System.Windows.Forms.DataGridView();
			this.txtBenhNhan = new System.Windows.Forms.TextBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.btnUncheck = new System.Windows.Forms.Button();
			this.btnSuaNgay = new System.Windows.Forms.Button();
			this.btnXacNhan = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.datePicker = new System.Windows.Forms.DateTimePicker();
			this.txtDesciption = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.btnXem = new System.Windows.Forms.Button();
			this.dGV_CTKB = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGV_BenhNhan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dGV_CTKB)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dGV_BenhNhan);
			this.groupBox1.Controls.Add(this.txtBenhNhan);
			this.groupBox1.Controls.Add(this.txtPrice);
			this.groupBox1.Controls.Add(this.btnUncheck);
			this.groupBox1.Controls.Add(this.btnSuaNgay);
			this.groupBox1.Controls.Add(this.btnXacNhan);
			this.groupBox1.Controls.Add(this.btnSua);
			this.groupBox1.Controls.Add(this.btnThem);
			this.groupBox1.Controls.Add(this.datePicker);
			this.groupBox1.Controls.Add(this.txtDesciption);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.groupBox1.Location = new System.Drawing.Point(64, 344);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(841, 357);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông Tin:";
			// 
			// dGV_BenhNhan
			// 
			this.dGV_BenhNhan.AllowUserToAddRows = false;
			this.dGV_BenhNhan.AllowUserToDeleteRows = false;
			this.dGV_BenhNhan.AllowUserToResizeColumns = false;
			this.dGV_BenhNhan.AllowUserToResizeRows = false;
			this.dGV_BenhNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dGV_BenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGV_BenhNhan.Location = new System.Drawing.Point(416, 64);
			this.dGV_BenhNhan.MultiSelect = false;
			this.dGV_BenhNhan.Name = "dGV_BenhNhan";
			this.dGV_BenhNhan.ReadOnly = true;
			this.dGV_BenhNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGV_BenhNhan.Size = new System.Drawing.Size(407, 152);
			this.dGV_BenhNhan.TabIndex = 19;
			this.dGV_BenhNhan.TabStop = false;
			// 
			// txtBenhNhan
			// 
			this.txtBenhNhan.Location = new System.Drawing.Point(574, 34);
			this.txtBenhNhan.Name = "txtBenhNhan";
			this.txtBenhNhan.ReadOnly = true;
			this.txtBenhNhan.Size = new System.Drawing.Size(249, 24);
			this.txtBenhNhan.TabIndex = 18;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(37, 220);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(232, 24);
			this.txtPrice.TabIndex = 18;
			// 
			// btnUncheck
			// 
			this.btnUncheck.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnUncheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnUncheck.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnUncheck.Location = new System.Drawing.Point(416, 230);
			this.btnUncheck.Margin = new System.Windows.Forms.Padding(2);
			this.btnUncheck.Name = "btnUncheck";
			this.btnUncheck.Size = new System.Drawing.Size(137, 35);
			this.btnUncheck.TabIndex = 3;
			this.btnUncheck.Text = "Bỏ chọn";
			this.btnUncheck.UseVisualStyleBackColor = false;
			this.btnUncheck.Click += new System.EventHandler(this.btnUncheck_Click);
			// 
			// btnSuaNgay
			// 
			this.btnSuaNgay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnSuaNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnSuaNgay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnSuaNgay.Location = new System.Drawing.Point(286, 54);
			this.btnSuaNgay.Margin = new System.Windows.Forms.Padding(2);
			this.btnSuaNgay.Name = "btnSuaNgay";
			this.btnSuaNgay.Size = new System.Drawing.Size(96, 35);
			this.btnSuaNgay.TabIndex = 3;
			this.btnSuaNgay.Text = "Sửa ngày";
			this.btnSuaNgay.UseVisualStyleBackColor = false;
			this.btnSuaNgay.Click += new System.EventHandler(this.btnSuaNgay_Click);
			// 
			// btnXacNhan
			// 
			this.btnXacNhan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnXacNhan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnXacNhan.Location = new System.Drawing.Point(686, 230);
			this.btnXacNhan.Margin = new System.Windows.Forms.Padding(2);
			this.btnXacNhan.Name = "btnXacNhan";
			this.btnXacNhan.Size = new System.Drawing.Size(137, 35);
			this.btnXacNhan.TabIndex = 3;
			this.btnXacNhan.Text = "Xác nhận";
			this.btnXacNhan.UseVisualStyleBackColor = false;
			this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnSua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnSua.Location = new System.Drawing.Point(454, 306);
			this.btnSua.Margin = new System.Windows.Forms.Padding(2);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(137, 35);
			this.btnSua.TabIndex = 3;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnThem.Location = new System.Drawing.Point(245, 306);
			this.btnThem.Margin = new System.Windows.Forms.Padding(2);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(137, 35);
			this.btnThem.TabIndex = 3;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// datePicker
			// 
			this.datePicker.Location = new System.Drawing.Point(37, 57);
			this.datePicker.Margin = new System.Windows.Forms.Padding(2);
			this.datePicker.Name = "datePicker";
			this.datePicker.Size = new System.Drawing.Size(232, 24);
			this.datePicker.TabIndex = 17;
			// 
			// txtDesciption
			// 
			this.txtDesciption.Location = new System.Drawing.Point(37, 123);
			this.txtDesciption.Margin = new System.Windows.Forms.Padding(2);
			this.txtDesciption.Multiline = true;
			this.txtDesciption.Name = "txtDesciption";
			this.txtDesciption.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDesciption.Size = new System.Drawing.Size(232, 55);
			this.txtDesciption.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 199);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 18);
			this.label1.TabIndex = 5;
			this.label1.Text = "Tổng tiền";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(34, 103);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 18);
			this.label6.TabIndex = 5;
			this.label6.Text = "Mô tả bệnh";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(413, 37);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(156, 18);
			this.label2.TabIndex = 4;
			this.label2.Text = "Bệnh nhân được khám";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(34, 37);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 18);
			this.label5.TabIndex = 4;
			this.label5.Text = "Ngày khám";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label10.Location = new System.Drawing.Point(302, 9);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(391, 39);
			this.label10.TabIndex = 2;
			this.label10.Text = "CHI TIẾT KHÁM BỆNH";
			// 
			// btnXem
			// 
			this.btnXem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnXem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnXem.Location = new System.Drawing.Point(768, 287);
			this.btnXem.Margin = new System.Windows.Forms.Padding(2);
			this.btnXem.Name = "btnXem";
			this.btnXem.Size = new System.Drawing.Size(137, 42);
			this.btnXem.TabIndex = 3;
			this.btnXem.Text = "Xem chi tiết";
			this.btnXem.UseVisualStyleBackColor = false;
			this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
			// 
			// dGV_CTKB
			// 
			this.dGV_CTKB.AllowUserToAddRows = false;
			this.dGV_CTKB.AllowUserToDeleteRows = false;
			this.dGV_CTKB.AllowUserToResizeColumns = false;
			this.dGV_CTKB.AllowUserToResizeRows = false;
			this.dGV_CTKB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dGV_CTKB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGV_CTKB.Location = new System.Drawing.Point(64, 57);
			this.dGV_CTKB.MultiSelect = false;
			this.dGV_CTKB.Name = "dGV_CTKB";
			this.dGV_CTKB.ReadOnly = true;
			this.dGV_CTKB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGV_CTKB.Size = new System.Drawing.Size(841, 225);
			this.dGV_CTKB.TabIndex = 7;
			this.dGV_CTKB.TabStop = false;
			this.dGV_CTKB.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dGV_CTKB_CellFormatting);
			// 
			// frmMedicalExaminationDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.ClientSize = new System.Drawing.Size(958, 712);
			this.Controls.Add(this.dGV_CTKB);
			this.Controls.Add(this.btnXem);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.groupBox1);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "frmMedicalExaminationDetails";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmMedicalExaminationDetails";
			this.Load += new System.EventHandler(this.frmMedicalExaminationDetails_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGV_BenhNhan)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dGV_CTKB)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDesciption;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXem;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBenhNhan;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnXacNhan;
		private System.Windows.Forms.DataGridView dGV_CTKB;
		private System.Windows.Forms.DataGridView dGV_BenhNhan;
		private System.Windows.Forms.Button btnUncheck;
		private System.Windows.Forms.Button btnSuaNgay;
	}
}