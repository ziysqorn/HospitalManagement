namespace HospitalManagement
{
    partial class frmServices
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.btnSua = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.dGV_DV = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGV_DV)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(266, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(389, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "DỊCH VỤ KHÁM BỆNH";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(64, 36);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 22);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tên dịch vụ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(64, 103);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 22);
			this.label4.TabIndex = 3;
			this.label4.Text = "Giá";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtPrice);
			this.groupBox1.Controls.Add(this.btnSua);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.btnThem);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.groupBox1.Location = new System.Drawing.Point(165, 296);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Size = new System.Drawing.Size(560, 179);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông Tin:";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(68, 127);
			this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(227, 27);
			this.txtPrice.TabIndex = 6;
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnSua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnSua.Location = new System.Drawing.Point(340, 123);
			this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(161, 37);
			this.btnSua.TabIndex = 7;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtName.Location = new System.Drawing.Point(68, 60);
			this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(227, 26);
			this.txtName.TabIndex = 5;
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnThem.Location = new System.Drawing.Point(340, 52);
			this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(161, 40);
			this.btnThem.TabIndex = 5;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// dGV_DV
			// 
			this.dGV_DV.AllowUserToAddRows = false;
			this.dGV_DV.AllowUserToDeleteRows = false;
			this.dGV_DV.AllowUserToResizeColumns = false;
			this.dGV_DV.AllowUserToResizeRows = false;
			this.dGV_DV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dGV_DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGV_DV.Location = new System.Drawing.Point(65, 61);
			this.dGV_DV.MultiSelect = false;
			this.dGV_DV.Name = "dGV_DV";
			this.dGV_DV.ReadOnly = true;
			this.dGV_DV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGV_DV.Size = new System.Drawing.Size(764, 230);
			this.dGV_DV.TabIndex = 7;
			this.dGV_DV.TabStop = false;
			this.dGV_DV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dGV_DV_CellFormatting);
			// 
			// frmServices
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(896, 495);
			this.Controls.Add(this.dGV_DV);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "frmServices";
			this.Text = "frmServices";
			this.Load += new System.EventHandler(this.frmServices_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGV_DV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.DataGridView dGV_DV;
	}
}