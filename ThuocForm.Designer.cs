namespace HospitalManagement
{
	partial class ThuocForm
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
			this.label3 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.dGV_Thuoc = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dGV_Thuoc)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(256, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Quản lý thuốc";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(440, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tên thuốc";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(440, 165);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Đơn giá";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(443, 109);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(252, 20);
			this.txtName.TabIndex = 0;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(443, 181);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(252, 20);
			this.txtPrice.TabIndex = 1;
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(582, 224);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(113, 35);
			this.btnSua.TabIndex = 5;
			this.btnSua.TabStop = false;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(443, 224);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(113, 35);
			this.btnThem.TabIndex = 5;
			this.btnThem.TabStop = false;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// dGV_Thuoc
			// 
			this.dGV_Thuoc.AllowUserToAddRows = false;
			this.dGV_Thuoc.AllowUserToDeleteRows = false;
			this.dGV_Thuoc.AllowUserToResizeColumns = false;
			this.dGV_Thuoc.AllowUserToResizeRows = false;
			this.dGV_Thuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dGV_Thuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGV_Thuoc.Location = new System.Drawing.Point(12, 51);
			this.dGV_Thuoc.MultiSelect = false;
			this.dGV_Thuoc.Name = "dGV_Thuoc";
			this.dGV_Thuoc.ReadOnly = true;
			this.dGV_Thuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGV_Thuoc.Size = new System.Drawing.Size(392, 241);
			this.dGV_Thuoc.TabIndex = 6;
			this.dGV_Thuoc.TabStop = false;
			this.dGV_Thuoc.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dGV_Thuoc_CellFormatting);
			// 
			// ThuocForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(717, 315);
			this.Controls.Add(this.dGV_Thuoc);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "ThuocForm";
			this.Text = "Quản lý thuốc";
			this.Load += new System.EventHandler(this.ThuocForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dGV_Thuoc)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.DataGridView dGV_Thuoc;
	}
}

