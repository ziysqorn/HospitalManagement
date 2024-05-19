using System.Windows.Forms;

namespace HospitalManagement
{
	partial class ToaThuocForm
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
			this.label6 = new System.Windows.Forms.Label();
			this.txt_TotalPrice = new System.Windows.Forms.TextBox();
			this.Exit_Btn = new System.Windows.Forms.Button();
			this.dgv_QLToaThuoc = new System.Windows.Forms.DataGridView();
			this.mtxt_PayDate_TT = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.Btn_Detail_ToaThuoc = new System.Windows.Forms.Button();
			this.Btn_Edit_Toa = new System.Windows.Forms.Button();
			this.Btn_Del_Toathuoc = new System.Windows.Forms.Button();
			this.btn_Add_ToaThuoc = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgv_QLToaThuoc)).BeginInit();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(734, 223);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Thành tiền";
			// 
			// txt_TotalPrice
			// 
			this.txt_TotalPrice.Location = new System.Drawing.Point(737, 238);
			this.txt_TotalPrice.Name = "txt_TotalPrice";
			this.txt_TotalPrice.Size = new System.Drawing.Size(200, 20);
			this.txt_TotalPrice.TabIndex = 9;
			// 
			// Exit_Btn
			// 
			this.Exit_Btn.BackColor = System.Drawing.Color.Red;
			this.Exit_Btn.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Exit_Btn.ForeColor = System.Drawing.SystemColors.Control;
			this.Exit_Btn.Location = new System.Drawing.Point(886, 422);
			this.Exit_Btn.Name = "Exit_Btn";
			this.Exit_Btn.Size = new System.Drawing.Size(97, 34);
			this.Exit_Btn.TabIndex = 8;
			this.Exit_Btn.Text = "Thoát";
			this.Exit_Btn.UseVisualStyleBackColor = false;
			this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
			// 
			// dgv_QLToaThuoc
			// 
			this.dgv_QLToaThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv_QLToaThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_QLToaThuoc.Location = new System.Drawing.Point(12, 42);
			this.dgv_QLToaThuoc.Name = "dgv_QLToaThuoc";
			this.dgv_QLToaThuoc.ReadOnly = true;
			this.dgv_QLToaThuoc.Size = new System.Drawing.Size(667, 354);
			this.dgv_QLToaThuoc.TabIndex = 7;
			// 
			// mtxt_PayDate_TT
			// 
			this.mtxt_PayDate_TT.Location = new System.Drawing.Point(737, 167);
			this.mtxt_PayDate_TT.Mask = "00/00/0000 90:00";
			this.mtxt_PayDate_TT.Name = "mtxt_PayDate_TT";
			this.mtxt_PayDate_TT.Size = new System.Drawing.Size(200, 20);
			this.mtxt_PayDate_TT.TabIndex = 5;
			this.mtxt_PayDate_TT.ValidatingType = typeof(System.DateTime);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(734, 151);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Ngày thanh toán";
			// 
			// Btn_Detail_ToaThuoc
			// 
			this.Btn_Detail_ToaThuoc.BackColor = System.Drawing.Color.MediumAquamarine;
			this.Btn_Detail_ToaThuoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Detail_ToaThuoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Btn_Detail_ToaThuoc.Location = new System.Drawing.Point(572, 415);
			this.Btn_Detail_ToaThuoc.Name = "Btn_Detail_ToaThuoc";
			this.Btn_Detail_ToaThuoc.Size = new System.Drawing.Size(107, 41);
			this.Btn_Detail_ToaThuoc.TabIndex = 2;
			this.Btn_Detail_ToaThuoc.Text = "Xem chi tiết";
			this.Btn_Detail_ToaThuoc.UseVisualStyleBackColor = false;
			this.Btn_Detail_ToaThuoc.Click += new System.EventHandler(this.Btn_Detail_ToaThuoc_Click);
			// 
			// Btn_Edit_Toa
			// 
			this.Btn_Edit_Toa.BackColor = System.Drawing.SystemColors.HotTrack;
			this.Btn_Edit_Toa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Edit_Toa.ForeColor = System.Drawing.SystemColors.Control;
			this.Btn_Edit_Toa.Location = new System.Drawing.Point(784, 287);
			this.Btn_Edit_Toa.Name = "Btn_Edit_Toa";
			this.Btn_Edit_Toa.Size = new System.Drawing.Size(107, 41);
			this.Btn_Edit_Toa.TabIndex = 2;
			this.Btn_Edit_Toa.Text = "Sửa";
			this.Btn_Edit_Toa.UseVisualStyleBackColor = false;
			this.Btn_Edit_Toa.Click += new System.EventHandler(this.Btn_Edit_Toa_Click);
			// 
			// Btn_Del_Toathuoc
			// 
			this.Btn_Del_Toathuoc.BackColor = System.Drawing.SystemColors.HotTrack;
			this.Btn_Del_Toathuoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Del_Toathuoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Btn_Del_Toathuoc.Location = new System.Drawing.Point(274, 415);
			this.Btn_Del_Toathuoc.Name = "Btn_Del_Toathuoc";
			this.Btn_Del_Toathuoc.Size = new System.Drawing.Size(107, 41);
			this.Btn_Del_Toathuoc.TabIndex = 2;
			this.Btn_Del_Toathuoc.Text = "Xóa";
			this.Btn_Del_Toathuoc.UseVisualStyleBackColor = false;
			// 
			// btn_Add_ToaThuoc
			// 
			this.btn_Add_ToaThuoc.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btn_Add_ToaThuoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Add_ToaThuoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btn_Add_ToaThuoc.Location = new System.Drawing.Point(127, 415);
			this.btn_Add_ToaThuoc.Name = "btn_Add_ToaThuoc";
			this.btn_Add_ToaThuoc.Size = new System.Drawing.Size(107, 41);
			this.btn_Add_ToaThuoc.TabIndex = 2;
			this.btn_Add_ToaThuoc.Text = "Thêm";
			this.btn_Add_ToaThuoc.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(449, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Quản lý toa thuốc";
			// 
			// ToaThuocForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1005, 468);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txt_TotalPrice);
			this.Controls.Add(this.Exit_Btn);
			this.Controls.Add(this.dgv_QLToaThuoc);
			this.Controls.Add(this.mtxt_PayDate_TT);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Btn_Detail_ToaThuoc);
			this.Controls.Add(this.Btn_Edit_Toa);
			this.Controls.Add(this.Btn_Del_Toathuoc);
			this.Controls.Add(this.btn_Add_ToaThuoc);
			this.Controls.Add(this.label1);
			this.Name = "ToaThuocForm";
			this.Text = "Quản lý toa thuốc";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ToaThuocForm_FormClosed);
			this.Load += new System.EventHandler(this.ToaThuocForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_QLToaThuoc)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_Add_ToaThuoc;
		private System.Windows.Forms.Button Btn_Del_Toathuoc;
		private System.Windows.Forms.Button Btn_Edit_Toa;
		private System.Windows.Forms.Button Btn_Detail_ToaThuoc;
		private System.Windows.Forms.MaskedTextBox mtxt_PayDate_TT;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dgv_QLToaThuoc;
        private System.Windows.Forms.Button Exit_Btn;
        private TextBox txt_TotalPrice;
        private Label label6;
    }
}