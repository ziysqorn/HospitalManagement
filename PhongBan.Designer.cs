namespace HospitalManagement
{
    partial class PhongBan
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
            this.dgv_PBan = new System.Windows.Forms.DataGridView();
            this.PBan_label = new System.Windows.Forms.Label();
            this.group_Pban = new System.Windows.Forms.GroupBox();
            this.Btn_Exit_PB = new System.Windows.Forms.Button();
            this.Btn_Edit_PB = new System.Windows.Forms.Button();
            this.Btn_Del_PB = new System.Windows.Forms.Button();
            this.Btn_Add_PB = new System.Windows.Forms.Button();
            this.label_ID_PB = new System.Windows.Forms.Label();
            this.label_Name_PB = new System.Windows.Forms.Label();
            this.txt_ID_PB = new System.Windows.Forms.TextBox();
            this.txt_Name_PB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PBan)).BeginInit();
            this.group_Pban.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_PBan
            // 
            this.dgv_PBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PBan.Location = new System.Drawing.Point(16, 14);
            this.dgv_PBan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgv_PBan.Name = "dgv_PBan";
            this.dgv_PBan.RowHeadersWidth = 51;
            this.dgv_PBan.Size = new System.Drawing.Size(499, 422);
            this.dgv_PBan.TabIndex = 1;
            this.dgv_PBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PBan_CellClick);
            // 
            // PBan_label
            // 
            this.PBan_label.AutoSize = true;
            this.PBan_label.BackColor = System.Drawing.Color.Transparent;
            this.PBan_label.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PBan_label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PBan_label.Location = new System.Drawing.Point(559, 10);
            this.PBan_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PBan_label.Name = "PBan_label";
            this.PBan_label.Size = new System.Drawing.Size(342, 34);
            this.PBan_label.TabIndex = 2;
            this.PBan_label.Text = "QUẢN LÝ PHÒNG BAN";
            // 
            // group_Pban
            // 
            this.group_Pban.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.group_Pban.Controls.Add(this.Btn_Exit_PB);
            this.group_Pban.Controls.Add(this.Btn_Edit_PB);
            this.group_Pban.Controls.Add(this.Btn_Del_PB);
            this.group_Pban.Controls.Add(this.Btn_Add_PB);
            this.group_Pban.Location = new System.Drawing.Point(533, 305);
            this.group_Pban.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_Pban.Name = "group_Pban";
            this.group_Pban.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_Pban.Size = new System.Drawing.Size(417, 136);
            this.group_Pban.TabIndex = 3;
            this.group_Pban.TabStop = false;
            this.group_Pban.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Btn_Exit_PB
            // 
            this.Btn_Exit_PB.BackColor = System.Drawing.Color.Red;
            this.Btn_Exit_PB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit_PB.ForeColor = System.Drawing.SystemColors.Info;
            this.Btn_Exit_PB.Location = new System.Drawing.Point(309, 80);
            this.Btn_Exit_PB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Exit_PB.Name = "Btn_Exit_PB";
            this.Btn_Exit_PB.Size = new System.Drawing.Size(100, 43);
            this.Btn_Exit_PB.TabIndex = 3;
            this.Btn_Exit_PB.Text = "Thoát";
            this.Btn_Exit_PB.UseVisualStyleBackColor = false;
            this.Btn_Exit_PB.Click += new System.EventHandler(this.Btn_Exit_PB_Click);
            // 
            // Btn_Edit_PB
            // 
            this.Btn_Edit_PB.BackColor = System.Drawing.Color.Teal;
            this.Btn_Edit_PB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Edit_PB.ForeColor = System.Drawing.SystemColors.Info;
            this.Btn_Edit_PB.Location = new System.Drawing.Point(309, 22);
            this.Btn_Edit_PB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Edit_PB.Name = "Btn_Edit_PB";
            this.Btn_Edit_PB.Size = new System.Drawing.Size(100, 39);
            this.Btn_Edit_PB.TabIndex = 2;
            this.Btn_Edit_PB.Text = "Sửa";
            this.Btn_Edit_PB.UseVisualStyleBackColor = false;
            this.Btn_Edit_PB.Click += new System.EventHandler(this.Btn_Edit_PB_Click);
            // 
            // Btn_Del_PB
            // 
            this.Btn_Del_PB.BackColor = System.Drawing.Color.Teal;
            this.Btn_Del_PB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Del_PB.ForeColor = System.Drawing.SystemColors.Info;
            this.Btn_Del_PB.Location = new System.Drawing.Point(159, 22);
            this.Btn_Del_PB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Del_PB.Name = "Btn_Del_PB";
            this.Btn_Del_PB.Size = new System.Drawing.Size(100, 39);
            this.Btn_Del_PB.TabIndex = 1;
            this.Btn_Del_PB.Text = "Xoá";
            this.Btn_Del_PB.UseVisualStyleBackColor = false;
            this.Btn_Del_PB.Click += new System.EventHandler(this.Btn_Del_PB_Click);
            // 
            // Btn_Add_PB
            // 
            this.Btn_Add_PB.BackColor = System.Drawing.Color.Teal;
            this.Btn_Add_PB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add_PB.ForeColor = System.Drawing.SystemColors.Info;
            this.Btn_Add_PB.Location = new System.Drawing.Point(8, 22);
            this.Btn_Add_PB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Add_PB.Name = "Btn_Add_PB";
            this.Btn_Add_PB.Size = new System.Drawing.Size(100, 39);
            this.Btn_Add_PB.TabIndex = 0;
            this.Btn_Add_PB.Text = "Thêm";
            this.Btn_Add_PB.UseVisualStyleBackColor = false;
            this.Btn_Add_PB.Click += new System.EventHandler(this.Btn_Add_PB_Click);
            // 
            // label_ID_PB
            // 
            this.label_ID_PB.AutoSize = true;
            this.label_ID_PB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID_PB.Location = new System.Drawing.Point(536, 208);
            this.label_ID_PB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ID_PB.Name = "label_ID_PB";
            this.label_ID_PB.Size = new System.Drawing.Size(121, 22);
            this.label_ID_PB.TabIndex = 4;
            this.label_ID_PB.Text = "Mã phòng ban";
            // 
            // label_Name_PB
            // 
            this.label_Name_PB.AutoSize = true;
            this.label_Name_PB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name_PB.Location = new System.Drawing.Point(539, 256);
            this.label_Name_PB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Name_PB.Name = "label_Name_PB";
            this.label_Name_PB.Size = new System.Drawing.Size(125, 22);
            this.label_Name_PB.TabIndex = 5;
            this.label_Name_PB.Text = "Tên phòng ban";
            // 
            // txt_ID_PB
            // 
            this.txt_ID_PB.Location = new System.Drawing.Point(692, 209);
            this.txt_ID_PB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ID_PB.Name = "txt_ID_PB";
            this.txt_ID_PB.ReadOnly = true;
            this.txt_ID_PB.Size = new System.Drawing.Size(176, 22);
            this.txt_ID_PB.TabIndex = 6;
            // 
            // txt_Name_PB
            // 
            this.txt_Name_PB.Location = new System.Drawing.Point(692, 257);
            this.txt_Name_PB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Name_PB.Name = "txt_Name_PB";
            this.txt_Name_PB.Size = new System.Drawing.Size(176, 22);
            this.txt_Name_PB.TabIndex = 7;
            // 
            // PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(969, 455);
            this.Controls.Add(this.txt_Name_PB);
            this.Controls.Add(this.txt_ID_PB);
            this.Controls.Add(this.label_Name_PB);
            this.Controls.Add(this.label_ID_PB);
            this.Controls.Add(this.PBan_label);
            this.Controls.Add(this.dgv_PBan);
            this.Controls.Add(this.group_Pban);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PhongBan";
            this.Text = "Quản lý phòng ban";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PBan)).EndInit();
            this.group_Pban.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_PBan;
        private System.Windows.Forms.Label PBan_label;
        private System.Windows.Forms.GroupBox group_Pban;
        private System.Windows.Forms.Button Btn_Add_PB;
        private System.Windows.Forms.Button Btn_Exit_PB;
        private System.Windows.Forms.Button Btn_Edit_PB;
        private System.Windows.Forms.Button Btn_Del_PB;
        private System.Windows.Forms.Label label_ID_PB;
        private System.Windows.Forms.Label label_Name_PB;
        private System.Windows.Forms.TextBox txt_ID_PB;
        private System.Windows.Forms.TextBox txt_Name_PB;
    }
}