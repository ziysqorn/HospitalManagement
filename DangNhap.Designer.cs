namespace HospitalManagement
{
	partial class DangNhap
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
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cbbBoPhan = new System.Windows.Forms.ComboBox();
			this.cbbPhongBan = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnDangNhap = new System.Windows.Forms.Button();
			this.btnDangKi = new System.Windows.Forms.Button();
			this.rdoBacSi = new System.Windows.Forms.RadioButton();
			this.rdoNV = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.cbbCV = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label1.Location = new System.Drawing.Point(174, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "ĐĂNG NHẬP";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(136, 221);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Phòng ban";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(136, 281);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 21);
			this.label4.TabIndex = 3;
			this.label4.Text = "Bộ phận";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(136, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 21);
			this.label5.TabIndex = 4;
			this.label5.Text = "Tài khoản";
			// 
			// cbbBoPhan
			// 
			this.cbbBoPhan.FormattingEnabled = true;
			this.cbbBoPhan.Location = new System.Drawing.Point(140, 305);
			this.cbbBoPhan.Name = "cbbBoPhan";
			this.cbbBoPhan.Size = new System.Drawing.Size(209, 21);
			this.cbbBoPhan.TabIndex = 6;
			this.cbbBoPhan.TabStop = false;
			this.cbbBoPhan.SelectedIndexChanged += new System.EventHandler(this.cbbBoPhan_SelectedIndexChanged);
			// 
			// cbbPhongBan
			// 
			this.cbbPhongBan.FormattingEnabled = true;
			this.cbbPhongBan.Location = new System.Drawing.Point(140, 244);
			this.cbbPhongBan.Name = "cbbPhongBan";
			this.cbbPhongBan.Size = new System.Drawing.Size(209, 21);
			this.cbbPhongBan.TabIndex = 7;
			this.cbbPhongBan.TabStop = false;
			this.cbbPhongBan.SelectedIndexChanged += new System.EventHandler(this.cbbPhongBan_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(136, 158);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 21);
			this.label6.TabIndex = 8;
			this.label6.Text = "Mật khẩu";
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(138, 120);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(211, 20);
			this.txtUsername.TabIndex = 0;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(138, 182);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(211, 20);
			this.txtPassword.TabIndex = 1;
			// 
			// btnDangNhap
			// 
			this.btnDangNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDangNhap.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnDangNhap.Location = new System.Drawing.Point(81, 415);
			this.btnDangNhap.Name = "btnDangNhap";
			this.btnDangNhap.Size = new System.Drawing.Size(150, 50);
			this.btnDangNhap.TabIndex = 11;
			this.btnDangNhap.TabStop = false;
			this.btnDangNhap.Text = "Đăng nhập";
			this.btnDangNhap.UseVisualStyleBackColor = false;
			this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
			// 
			// btnDangKi
			// 
			this.btnDangKi.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnDangKi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDangKi.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnDangKi.Location = new System.Drawing.Point(267, 415);
			this.btnDangKi.Name = "btnDangKi";
			this.btnDangKi.Size = new System.Drawing.Size(150, 50);
			this.btnDangKi.TabIndex = 11;
			this.btnDangKi.TabStop = false;
			this.btnDangKi.Text = "Đăng kí";
			this.btnDangKi.UseVisualStyleBackColor = false;
			this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
			// 
			// rdoBacSi
			// 
			this.rdoBacSi.AutoSize = true;
			this.rdoBacSi.Location = new System.Drawing.Point(152, 63);
			this.rdoBacSi.Name = "rdoBacSi";
			this.rdoBacSi.Size = new System.Drawing.Size(57, 17);
			this.rdoBacSi.TabIndex = 12;
			this.rdoBacSi.TabStop = true;
			this.rdoBacSi.Text = "Bác sĩ";
			this.rdoBacSi.UseVisualStyleBackColor = true;
			this.rdoBacSi.CheckedChanged += new System.EventHandler(this.rdoBacSi_CheckedChanged);
			// 
			// rdoNV
			// 
			this.rdoNV.AutoSize = true;
			this.rdoNV.Location = new System.Drawing.Point(256, 63);
			this.rdoNV.Name = "rdoNV";
			this.rdoNV.Size = new System.Drawing.Size(74, 17);
			this.rdoNV.TabIndex = 12;
			this.rdoNV.TabStop = true;
			this.rdoNV.Text = "Nhân viên";
			this.rdoNV.UseVisualStyleBackColor = true;
			this.rdoNV.CheckedChanged += new System.EventHandler(this.rdoNV_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(136, 340);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 21);
			this.label2.TabIndex = 3;
			this.label2.Text = "Chức vụ";
			// 
			// cbbCV
			// 
			this.cbbCV.FormattingEnabled = true;
			this.cbbCV.Location = new System.Drawing.Point(140, 364);
			this.cbbCV.Name = "cbbCV";
			this.cbbCV.Size = new System.Drawing.Size(209, 21);
			this.cbbCV.TabIndex = 6;
			this.cbbCV.TabStop = false;
			// 
			// DangNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(485, 477);
			this.Controls.Add(this.rdoNV);
			this.Controls.Add(this.rdoBacSi);
			this.Controls.Add(this.btnDangKi);
			this.Controls.Add(this.btnDangNhap);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cbbPhongBan);
			this.Controls.Add(this.cbbCV);
			this.Controls.Add(this.cbbBoPhan);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "DangNhap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng nhập";
			this.Load += new System.EventHandler(this.DangNhap_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox cbbBoPhan;
    private System.Windows.Forms.ComboBox cbbPhongBan;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnDangNhap;
	private System.Windows.Forms.Button btnDangKi;
		private System.Windows.Forms.RadioButton rdoBacSi;
		private System.Windows.Forms.RadioButton rdoNV;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbbCV;
	}
}

