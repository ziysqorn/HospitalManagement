namespace HospitalManagement
{
	partial class ChiTietToaThuocForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox_SLThuoc = new System.Windows.Forms.MaskedTextBox();
            this.txt_TenThuoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_View_Thuoc = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv_ChiTietToa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietToa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi tiết toa thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lượng";
            // 
            // maskedTextBox_SLThuoc
            // 
            this.maskedTextBox_SLThuoc.Location = new System.Drawing.Point(585, 205);
            this.maskedTextBox_SLThuoc.Name = "maskedTextBox_SLThuoc";
            this.maskedTextBox_SLThuoc.Size = new System.Drawing.Size(177, 20);
            this.maskedTextBox_SLThuoc.TabIndex = 5;
            // 
            // txt_TenThuoc
            // 
            this.txt_TenThuoc.Location = new System.Drawing.Point(585, 126);
            this.txt_TenThuoc.Name = "txt_TenThuoc";
            this.txt_TenThuoc.Size = new System.Drawing.Size(177, 20);
            this.txt_TenThuoc.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thuốc";
            // 
            // Btn_View_Thuoc
            // 
            this.Btn_View_Thuoc.Location = new System.Drawing.Point(784, 116);
            this.Btn_View_Thuoc.Name = "Btn_View_Thuoc";
            this.Btn_View_Thuoc.Size = new System.Drawing.Size(99, 39);
            this.Btn_View_Thuoc.TabIndex = 7;
            this.Btn_View_Thuoc.Text = "Chọn thuốc";
            this.Btn_View_Thuoc.UseVisualStyleBackColor = true;
            this.Btn_View_Thuoc.Click += new System.EventHandler(this.Btn_View_Thuoc_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgv_ChiTietToa
            // 
            this.dgv_ChiTietToa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ChiTietToa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietToa.Location = new System.Drawing.Point(12, 62);
            this.dgv_ChiTietToa.Name = "dgv_ChiTietToa";
            this.dgv_ChiTietToa.Size = new System.Drawing.Size(514, 258);
            this.dgv_ChiTietToa.TabIndex = 8;
            // 
            // ChiTietToaThuocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 334);
            this.Controls.Add(this.dgv_ChiTietToa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_View_Thuoc);
            this.Controls.Add(this.txt_TenThuoc);
            this.Controls.Add(this.maskedTextBox_SLThuoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChiTietToaThuocForm";
            this.Text = "ChiTietToaThuocForm";
            this.Load += new System.EventHandler(this.ChiTietToaThuocForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietToa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MaskedTextBox maskedTextBox_SLThuoc;
		private System.Windows.Forms.TextBox txt_TenThuoc;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button Btn_View_Thuoc;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridView dgv_ChiTietToa;
	}
}