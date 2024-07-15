namespace StudentManagement
{
    partial class XepLop
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
            this.btnAddHocSinhToLop = new System.Windows.Forms.Button();
            this.btnAddLop = new System.Windows.Forms.Button();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchTenHocSinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbLopHienCo = new System.Windows.Forms.ComboBox();
            this.dgvHocSinhXepLop = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinhXepLop)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddHocSinhToLop
            // 
            this.btnAddHocSinhToLop.Location = new System.Drawing.Point(342, 337);
            this.btnAddHocSinhToLop.Name = "btnAddHocSinhToLop";
            this.btnAddHocSinhToLop.Size = new System.Drawing.Size(200, 53);
            this.btnAddHocSinhToLop.TabIndex = 1;
            this.btnAddHocSinhToLop.Text = "Thêm Học Sinh Vào Lớp";
            this.btnAddHocSinhToLop.UseVisualStyleBackColor = true;
            this.btnAddHocSinhToLop.Click += new System.EventHandler(this.btnAddHocSinhToLop_Click);
            // 
            // btnAddLop
            // 
            this.btnAddLop.Location = new System.Drawing.Point(56, 284);
            this.btnAddLop.Name = "btnAddLop";
            this.btnAddLop.Size = new System.Drawing.Size(145, 38);
            this.btnAddLop.TabIndex = 0;
            this.btnAddLop.Text = "Thêm Lớp";
            this.btnAddLop.UseVisualStyleBackColor = true;
            this.btnAddLop.Click += new System.EventHandler(this.btnAddLop_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(56, 59);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(100, 26);
            this.txtMaLop.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Lớp:";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(56, 142);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(100, 26);
            this.txtTenLop.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số Lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(56, 221);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 26);
            this.txtSoLuong.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tìm Học Sinh:";
            // 
            // txtSearchTenHocSinh
            // 
            this.txtSearchTenHocSinh.Location = new System.Drawing.Point(342, 59);
            this.txtSearchTenHocSinh.Name = "txtSearchTenHocSinh";
            this.txtSearchTenHocSinh.Size = new System.Drawing.Size(196, 26);
            this.txtSearchTenHocSinh.TabIndex = 11;
            this.txtSearchTenHocSinh.TextChanged += new System.EventHandler(this.txtSearchTenHocSinh_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Các Lớp Hiện Có:";
            // 
            // cbbLopHienCo
            // 
            this.cbbLopHienCo.FormattingEnabled = true;
            this.cbbLopHienCo.Location = new System.Drawing.Point(342, 281);
            this.cbbLopHienCo.Name = "cbbLopHienCo";
            this.cbbLopHienCo.Size = new System.Drawing.Size(121, 28);
            this.cbbLopHienCo.TabIndex = 13;
            // 
            // dgvHocSinhXepLop
            // 
            this.dgvHocSinhXepLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinhXepLop.Location = new System.Drawing.Point(342, 96);
            this.dgvHocSinhXepLop.Name = "dgvHocSinhXepLop";
            this.dgvHocSinhXepLop.RowHeadersWidth = 62;
            this.dgvHocSinhXepLop.RowTemplate.Height = 28;
            this.dgvHocSinhXepLop.Size = new System.Drawing.Size(434, 150);
            this.dgvHocSinhXepLop.TabIndex = 14;
            // 
            // XepLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvHocSinhXepLop);
            this.Controls.Add(this.cbbLopHienCo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearchTenHocSinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.btnAddHocSinhToLop);
            this.Controls.Add(this.btnAddLop);
            this.Name = "XepLop";
            this.Text = "XepLop";
            this.Load += new System.EventHandler(this.XepLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinhXepLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddHocSinhToLop;
        private System.Windows.Forms.Button btnAddLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchTenHocSinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbLopHienCo;
        private System.Windows.Forms.DataGridView dgvHocSinhXepLop;
    }
}