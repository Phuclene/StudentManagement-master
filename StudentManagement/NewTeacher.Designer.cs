namespace StudentManagement
{
    partial class NewTeacher
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
            this.btn_BackTeacher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaGiaoVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTenGiaoVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dTP_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_SubmitTeacher = new System.Windows.Forms.Button();
            this.txtSDTGiaoVien = new System.Windows.Forms.TextBox();
            this.txtEmailGiaoVien = new System.Windows.Forms.TextBox();
            this.radioBtnNu = new System.Windows.Forms.RadioButton();
            this.radioBtnNam = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChuyenNganh = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_BackTeacher
            // 
            this.btn_BackTeacher.BackColor = System.Drawing.Color.Red;
            this.btn_BackTeacher.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_BackTeacher.Location = new System.Drawing.Point(1008, 616);
            this.btn_BackTeacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_BackTeacher.Name = "btn_BackTeacher";
            this.btn_BackTeacher.Size = new System.Drawing.Size(168, 60);
            this.btn_BackTeacher.TabIndex = 0;
            this.btn_BackTeacher.Text = "Quay lại";
            this.btn_BackTeacher.UseVisualStyleBackColor = false;
            this.btn_BackTeacher.Click += new System.EventHandler(this.btn_BackTeacher_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÊM GIÁO VIÊN";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 60);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thông Tin Giáo Viên";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Giáo Viên:";
            // 
            // txtMaGiaoVien
            // 
            this.txtMaGiaoVien.Location = new System.Drawing.Point(45, 219);
            this.txtMaGiaoVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaGiaoVien.Name = "txtMaGiaoVien";
            this.txtMaGiaoVien.Size = new System.Drawing.Size(196, 26);
            this.txtMaGiaoVien.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Họ và Tên:";
            // 
            // txtHoTenGiaoVien
            // 
            this.txtHoTenGiaoVien.Location = new System.Drawing.Point(45, 326);
            this.txtHoTenGiaoVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoTenGiaoVien.Name = "txtHoTenGiaoVien";
            this.txtHoTenGiaoVien.Size = new System.Drawing.Size(270, 26);
            this.txtHoTenGiaoVien.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày/Tháng/Năm Sinh:";
            // 
            // dTP_NgaySinh
            // 
            this.dTP_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_NgaySinh.Location = new System.Drawing.Point(45, 536);
            this.dTP_NgaySinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dTP_NgaySinh.Name = "dTP_NgaySinh";
            this.dTP_NgaySinh.Size = new System.Drawing.Size(140, 26);
            this.dTP_NgaySinh.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(443, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số Điện Thoại:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(443, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 32);
            this.label11.TabIndex = 20;
            this.label11.Text = "Email:";
            // 
            // btn_SubmitTeacher
            // 
            this.btn_SubmitTeacher.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_SubmitTeacher.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_SubmitTeacher.Location = new System.Drawing.Point(785, 616);
            this.btn_SubmitTeacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SubmitTeacher.Name = "btn_SubmitTeacher";
            this.btn_SubmitTeacher.Size = new System.Drawing.Size(168, 60);
            this.btn_SubmitTeacher.TabIndex = 22;
            this.btn_SubmitTeacher.Text = "Thêm";
            this.btn_SubmitTeacher.UseVisualStyleBackColor = false;
            this.btn_SubmitTeacher.Click += new System.EventHandler(this.btn_SubmitTeacher_Click);
            // 
            // txtSDTGiaoVien
            // 
            this.txtSDTGiaoVien.Location = new System.Drawing.Point(448, 209);
            this.txtSDTGiaoVien.Name = "txtSDTGiaoVien";
            this.txtSDTGiaoVien.Size = new System.Drawing.Size(270, 26);
            this.txtSDTGiaoVien.TabIndex = 23;
            // 
            // txtEmailGiaoVien
            // 
            this.txtEmailGiaoVien.Location = new System.Drawing.Point(448, 300);
            this.txtEmailGiaoVien.Name = "txtEmailGiaoVien";
            this.txtEmailGiaoVien.Size = new System.Drawing.Size(233, 26);
            this.txtEmailGiaoVien.TabIndex = 24;
            // 
            // radioBtnNu
            // 
            this.radioBtnNu.AutoSize = true;
            this.radioBtnNu.Location = new System.Drawing.Point(119, 428);
            this.radioBtnNu.Name = "radioBtnNu";
            this.radioBtnNu.Size = new System.Drawing.Size(54, 24);
            this.radioBtnNu.TabIndex = 30;
            this.radioBtnNu.TabStop = true;
            this.radioBtnNu.Text = "Nữ";
            this.radioBtnNu.UseVisualStyleBackColor = true;
            // 
            // radioBtnNam
            // 
            this.radioBtnNam.AutoSize = true;
            this.radioBtnNam.Location = new System.Drawing.Point(46, 428);
            this.radioBtnNam.Name = "radioBtnNam";
            this.radioBtnNam.Size = new System.Drawing.Size(67, 24);
            this.radioBtnNam.TabIndex = 29;
            this.radioBtnNam.TabStop = true;
            this.radioBtnNam.Text = "Nam";
            this.radioBtnNam.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 39);
            this.label7.TabIndex = 28;
            this.label7.Text = "Giới Tính:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(443, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 30);
            this.label8.TabIndex = 31;
            this.label8.Text = "Chuyên Ngành:";
            // 
            // txtChuyenNganh
            // 
            this.txtChuyenNganh.Location = new System.Drawing.Point(448, 387);
            this.txtChuyenNganh.Name = "txtChuyenNganh";
            this.txtChuyenNganh.Size = new System.Drawing.Size(233, 26);
            this.txtChuyenNganh.TabIndex = 32;
            // 
            // NewTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(1212, 704);
            this.Controls.Add(this.txtChuyenNganh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioBtnNu);
            this.Controls.Add(this.radioBtnNam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmailGiaoVien);
            this.Controls.Add(this.txtSDTGiaoVien);
            this.Controls.Add(this.btn_SubmitTeacher);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dTP_NgaySinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHoTenGiaoVien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaGiaoVien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_BackTeacher);
            this.ForeColor = System.Drawing.Color.Aquamarine;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewTeacher";
            this.Text = "NewTeacher";
            this.Load += new System.EventHandler(this.NewTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BackTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaGiaoVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTenGiaoVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dTP_NgaySinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_SubmitTeacher;
        private System.Windows.Forms.TextBox txtSDTGiaoVien;
        private System.Windows.Forms.TextBox txtEmailGiaoVien;
        private System.Windows.Forms.RadioButton radioBtnNu;
        private System.Windows.Forms.RadioButton radioBtnNam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChuyenNganh;
    }
}