namespace HospitalManagement
{
	partial class ThongTinChiTietKB
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dGV_CTKBDVu = new System.Windows.Forms.DataGridView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dGV_DV = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnThemDV = new System.Windows.Forms.Button();
			this.btnSuaDV = new System.Windows.Forms.Button();
			this.btnXoaDV = new System.Windows.Forms.Button();
			this.dGV_Thuoc = new System.Windows.Forms.DataGridView();
			this.dGV_CTTT = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSuaThuoc = new System.Windows.Forms.Button();
			this.btnXoaThuoc = new System.Windows.Forms.Button();
			this.btnThemThuoc = new System.Windows.Forms.Button();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnSuaThongTin = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGV_CTKBDVu)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGV_DV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dGV_Thuoc)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dGV_CTTT)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(-1, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(801, 413);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btnSuaDV);
			this.tabPage1.Controls.Add(this.btnXoaDV);
			this.tabPage1.Controls.Add(this.btnThemDV);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.dGV_DV);
			this.tabPage1.Controls.Add(this.dGV_CTKBDVu);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(793, 387);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Dịch vụ và thủ tục khám bệnh";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// dGV_CTKBDVu
			// 
			this.dGV_CTKBDVu.AllowUserToAddRows = false;
			this.dGV_CTKBDVu.AllowUserToDeleteRows = false;
			this.dGV_CTKBDVu.AllowUserToResizeColumns = false;
			this.dGV_CTKBDVu.AllowUserToResizeRows = false;
			this.dGV_CTKBDVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dGV_CTKBDVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGV_CTKBDVu.Location = new System.Drawing.Point(9, 59);
			this.dGV_CTKBDVu.MultiSelect = false;
			this.dGV_CTKBDVu.Name = "dGV_CTKBDVu";
			this.dGV_CTKBDVu.ReadOnly = true;
			this.dGV_CTKBDVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGV_CTKBDVu.Size = new System.Drawing.Size(354, 240);
			this.dGV_CTKBDVu.TabIndex = 7;
			this.dGV_CTKBDVu.TabStop = false;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.txtDescription);
			this.tabPage2.Controls.Add(this.txtAmount);
			this.tabPage2.Controls.Add(this.btnSuaThongTin);
			this.tabPage2.Controls.Add(this.btnSuaThuoc);
			this.tabPage2.Controls.Add(this.btnXoaThuoc);
			this.tabPage2.Controls.Add(this.btnThemThuoc);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.dGV_Thuoc);
			this.tabPage2.Controls.Add(this.dGV_CTTT);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(793, 387);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Chi tiết toa thuốc";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// dGV_DV
			// 
			this.dGV_DV.AllowUserToAddRows = false;
			this.dGV_DV.AllowUserToDeleteRows = false;
			this.dGV_DV.AllowUserToResizeColumns = false;
			this.dGV_DV.AllowUserToResizeRows = false;
			this.dGV_DV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dGV_DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGV_DV.Location = new System.Drawing.Point(431, 59);
			this.dGV_DV.MultiSelect = false;
			this.dGV_DV.Name = "dGV_DV";
			this.dGV_DV.ReadOnly = true;
			this.dGV_DV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGV_DV.Size = new System.Drawing.Size(354, 240);
			this.dGV_DV.TabIndex = 7;
			this.dGV_DV.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(243, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Các dịch vụ và thủ tục khám bệnh được yêu cầu ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(428, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Chọn dịch vụ để thêm hoặc sửa";
			// 
			// btnThemDV
			// 
			this.btnThemDV.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnThemDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnThemDV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnThemDV.Location = new System.Drawing.Point(431, 304);
			this.btnThemDV.Margin = new System.Windows.Forms.Padding(2);
			this.btnThemDV.Name = "btnThemDV";
			this.btnThemDV.Size = new System.Drawing.Size(137, 42);
			this.btnThemDV.TabIndex = 9;
			this.btnThemDV.Text = "Thêm";
			this.btnThemDV.UseVisualStyleBackColor = false;
			this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
			// 
			// btnSuaDV
			// 
			this.btnSuaDV.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnSuaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnSuaDV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnSuaDV.Location = new System.Drawing.Point(582, 304);
			this.btnSuaDV.Margin = new System.Windows.Forms.Padding(2);
			this.btnSuaDV.Name = "btnSuaDV";
			this.btnSuaDV.Size = new System.Drawing.Size(137, 42);
			this.btnSuaDV.TabIndex = 9;
			this.btnSuaDV.Text = "Sửa";
			this.btnSuaDV.UseVisualStyleBackColor = false;
			this.btnSuaDV.Click += new System.EventHandler(this.btnSuaDV_Click);
			// 
			// btnXoaDV
			// 
			this.btnXoaDV.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnXoaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnXoaDV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnXoaDV.Location = new System.Drawing.Point(226, 304);
			this.btnXoaDV.Margin = new System.Windows.Forms.Padding(2);
			this.btnXoaDV.Name = "btnXoaDV";
			this.btnXoaDV.Size = new System.Drawing.Size(137, 42);
			this.btnXoaDV.TabIndex = 9;
			this.btnXoaDV.Text = "Xóa";
			this.btnXoaDV.UseVisualStyleBackColor = false;
			this.btnXoaDV.Click += new System.EventHandler(this.btnXoaDV_Click);
			// 
			// dGV_Thuoc
			// 
			this.dGV_Thuoc.AllowUserToAddRows = false;
			this.dGV_Thuoc.AllowUserToDeleteRows = false;
			this.dGV_Thuoc.AllowUserToResizeColumns = false;
			this.dGV_Thuoc.AllowUserToResizeRows = false;
			this.dGV_Thuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dGV_Thuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGV_Thuoc.Location = new System.Drawing.Point(431, 35);
			this.dGV_Thuoc.MultiSelect = false;
			this.dGV_Thuoc.Name = "dGV_Thuoc";
			this.dGV_Thuoc.ReadOnly = true;
			this.dGV_Thuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGV_Thuoc.Size = new System.Drawing.Size(354, 198);
			this.dGV_Thuoc.TabIndex = 8;
			this.dGV_Thuoc.TabStop = false;
			// 
			// dGV_CTTT
			// 
			this.dGV_CTTT.AllowUserToAddRows = false;
			this.dGV_CTTT.AllowUserToDeleteRows = false;
			this.dGV_CTTT.AllowUserToResizeColumns = false;
			this.dGV_CTTT.AllowUserToResizeRows = false;
			this.dGV_CTTT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dGV_CTTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGV_CTTT.Location = new System.Drawing.Point(9, 35);
			this.dGV_CTTT.MultiSelect = false;
			this.dGV_CTTT.Name = "dGV_CTTT";
			this.dGV_CTTT.ReadOnly = true;
			this.dGV_CTTT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGV_CTTT.Size = new System.Drawing.Size(354, 198);
			this.dGV_CTTT.TabIndex = 9;
			this.dGV_CTTT.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(428, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(151, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Chọn thuốc để thêm hoặc sửa";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(163, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Các loại thuốc được kê trong toa";
			// 
			// btnSuaThuoc
			// 
			this.btnSuaThuoc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnSuaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnSuaThuoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnSuaThuoc.Location = new System.Drawing.Point(582, 238);
			this.btnSuaThuoc.Margin = new System.Windows.Forms.Padding(2);
			this.btnSuaThuoc.Name = "btnSuaThuoc";
			this.btnSuaThuoc.Size = new System.Drawing.Size(137, 42);
			this.btnSuaThuoc.TabIndex = 12;
			this.btnSuaThuoc.Text = "Sửa thuốc";
			this.btnSuaThuoc.UseVisualStyleBackColor = false;
			this.btnSuaThuoc.Click += new System.EventHandler(this.btnSuaThuoc_Click);
			// 
			// btnXoaThuoc
			// 
			this.btnXoaThuoc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnXoaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnXoaThuoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnXoaThuoc.Location = new System.Drawing.Point(226, 238);
			this.btnXoaThuoc.Margin = new System.Windows.Forms.Padding(2);
			this.btnXoaThuoc.Name = "btnXoaThuoc";
			this.btnXoaThuoc.Size = new System.Drawing.Size(137, 42);
			this.btnXoaThuoc.TabIndex = 13;
			this.btnXoaThuoc.Text = "Xóa";
			this.btnXoaThuoc.UseVisualStyleBackColor = false;
			this.btnXoaThuoc.Click += new System.EventHandler(this.btnXoaThuoc_Click);
			// 
			// btnThemThuoc
			// 
			this.btnThemThuoc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnThemThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnThemThuoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnThemThuoc.Location = new System.Drawing.Point(431, 238);
			this.btnThemThuoc.Margin = new System.Windows.Forms.Padding(2);
			this.btnThemThuoc.Name = "btnThemThuoc";
			this.btnThemThuoc.Size = new System.Drawing.Size(137, 42);
			this.btnThemThuoc.TabIndex = 14;
			this.btnThemThuoc.Text = "Thêm";
			this.btnThemThuoc.UseVisualStyleBackColor = false;
			this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);
			// 
			// txtAmount
			// 
			this.txtAmount.Location = new System.Drawing.Point(175, 307);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(188, 20);
			this.txtAmount.TabIndex = 19;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(440, 307);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(188, 20);
			this.txtDescription.TabIndex = 19;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(123, 310);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 13);
			this.label5.TabIndex = 20;
			this.label5.Text = "Số lượng";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(400, 310);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(34, 13);
			this.label6.TabIndex = 20;
			this.label6.Text = "Mô tả";
			// 
			// btnSuaThongTin
			// 
			this.btnSuaThongTin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnSuaThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnSuaThongTin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnSuaThongTin.Location = new System.Drawing.Point(330, 347);
			this.btnSuaThongTin.Margin = new System.Windows.Forms.Padding(2);
			this.btnSuaThongTin.Name = "btnSuaThongTin";
			this.btnSuaThongTin.Size = new System.Drawing.Size(137, 34);
			this.btnSuaThongTin.TabIndex = 12;
			this.btnSuaThongTin.Text = "Sửa thông tin";
			this.btnSuaThongTin.UseVisualStyleBackColor = false;
			this.btnSuaThongTin.Click += new System.EventHandler(this.btnSuaThongTin_Click);
			// 
			// ThongTinChiTietKB
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 414);
			this.Controls.Add(this.tabControl1);
			this.Name = "ThongTinChiTietKB";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thông tin chi tiết khám bệnh";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThongTinChiTietKB_FormClosed);
			this.Load += new System.EventHandler(this.ThongTinChiTietKB_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGV_CTKBDVu)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGV_DV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dGV_Thuoc)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dGV_CTTT)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView dGV_CTKBDVu;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dGV_DV;
		private System.Windows.Forms.Button btnSuaDV;
		private System.Windows.Forms.Button btnThemDV;
		private System.Windows.Forms.Button btnXoaDV;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dGV_Thuoc;
		private System.Windows.Forms.DataGridView dGV_CTTT;
		private System.Windows.Forms.Button btnSuaThuoc;
		private System.Windows.Forms.Button btnXoaThuoc;
		private System.Windows.Forms.Button btnThemThuoc;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Button btnSuaThongTin;
	}
}