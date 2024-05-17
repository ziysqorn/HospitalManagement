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
			this.button1 = new System.Windows.Forms.Button();
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
			this.label3.Location = new System.Drawing.Point(137, 197);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Phòng ban";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(137, 257);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 21);
			this.label4.TabIndex = 3;
			this.label4.Text = "Bộ phận";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(137, 65);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 21);
			this.label5.TabIndex = 4;
			this.label5.Text = "Tài khoản";
			// 
			// cbbBoPhan
			// 
			this.cbbBoPhan.FormattingEnabled = true;
			this.cbbBoPhan.Location = new System.Drawing.Point(141, 281);
			this.cbbBoPhan.Name = "cbbBoPhan";
			this.cbbBoPhan.Size = new System.Drawing.Size(209, 21);
			this.cbbBoPhan.TabIndex = 6;
			// 
			// cbbPhongBan
			// 
			this.cbbPhongBan.FormattingEnabled = true;
			this.cbbPhongBan.Location = new System.Drawing.Point(141, 220);
			this.cbbPhongBan.Name = "cbbPhongBan";
			this.cbbPhongBan.Size = new System.Drawing.Size(209, 21);
			this.cbbPhongBan.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(137, 127);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 21);
			this.label6.TabIndex = 8;
			this.label6.Text = "Mật khẩu";
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(139, 89);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(211, 20);
			this.txtUsername.TabIndex = 9;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(139, 151);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(211, 20);
			this.txtPassword.TabIndex = 10;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button1.Location = new System.Drawing.Point(166, 328);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(150, 50);
			this.button1.TabIndex = 11;
			this.button1.Text = "Đăng nhập";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// DangNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(485, 390);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cbbPhongBan);
			this.Controls.Add(this.cbbBoPhan);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "DangNhap";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
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
    private System.Windows.Forms.Button button1;
  }
}

