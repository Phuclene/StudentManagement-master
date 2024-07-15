namespace StudentManagement
{
    partial class Teachers
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
            this.btn_Add_teacher = new System.Windows.Forms.Button();
            this.btn_Update_teacher = new System.Windows.Forms.Button();
            this.btn_PC_teacher = new System.Windows.Forms.Button();
            this.btn_Back_teacher = new System.Windows.Forms.Button();
            this.btn_ThongBao_teacher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Add_teacher
            // 
            this.btn_Add_teacher.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_Add_teacher.Location = new System.Drawing.Point(16, 20);
            this.btn_Add_teacher.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add_teacher.Name = "btn_Add_teacher";
            this.btn_Add_teacher.Size = new System.Drawing.Size(129, 36);
            this.btn_Add_teacher.TabIndex = 0;
            this.btn_Add_teacher.Text = "Thêm Giáo Viên";
            this.btn_Add_teacher.UseVisualStyleBackColor = true;
            this.btn_Add_teacher.Click += new System.EventHandler(this.btn_Add_teacher_Click);
            // 
            // btn_Update_teacher
            // 
            this.btn_Update_teacher.ForeColor = System.Drawing.Color.Purple;
            this.btn_Update_teacher.Location = new System.Drawing.Point(160, 20);
            this.btn_Update_teacher.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Update_teacher.Name = "btn_Update_teacher";
            this.btn_Update_teacher.Size = new System.Drawing.Size(129, 36);
            this.btn_Update_teacher.TabIndex = 1;
            this.btn_Update_teacher.Text = "Cập Nhật Giáo Viên";
            this.btn_Update_teacher.UseVisualStyleBackColor = true;
            this.btn_Update_teacher.Click += new System.EventHandler(this.btn_Update_teacher_Click);
            // 
            // btn_PC_teacher
            // 
            this.btn_PC_teacher.ForeColor = System.Drawing.Color.Navy;
            this.btn_PC_teacher.Location = new System.Drawing.Point(308, 20);
            this.btn_PC_teacher.Margin = new System.Windows.Forms.Padding(2);
            this.btn_PC_teacher.Name = "btn_PC_teacher";
            this.btn_PC_teacher.Size = new System.Drawing.Size(129, 36);
            this.btn_PC_teacher.TabIndex = 3;
            this.btn_PC_teacher.Text = "Phân Công Giáo Viên";
            this.btn_PC_teacher.UseVisualStyleBackColor = true;
            this.btn_PC_teacher.Click += new System.EventHandler(this.btn_PC_teacher_Click);
            // 
            // btn_Back_teacher
            // 
            this.btn_Back_teacher.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Back_teacher.Location = new System.Drawing.Point(478, 309);
            this.btn_Back_teacher.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Back_teacher.Name = "btn_Back_teacher";
            this.btn_Back_teacher.Size = new System.Drawing.Size(104, 28);
            this.btn_Back_teacher.TabIndex = 6;
            this.btn_Back_teacher.Text = "Quay Lại";
            this.btn_Back_teacher.UseVisualStyleBackColor = true;
            this.btn_Back_teacher.Click += new System.EventHandler(this.btn_Back_teacher_Click);
            // 
            // btn_ThongBao_teacher
            // 
            this.btn_ThongBao_teacher.ForeColor = System.Drawing.Color.Aqua;
            this.btn_ThongBao_teacher.Location = new System.Drawing.Point(453, 20);
            this.btn_ThongBao_teacher.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ThongBao_teacher.Name = "btn_ThongBao_teacher";
            this.btn_ThongBao_teacher.Size = new System.Drawing.Size(129, 36);
            this.btn_ThongBao_teacher.TabIndex = 7;
            this.btn_ThongBao_teacher.Text = "Xem Thông Báo Của Giáo Viên";
            this.btn_ThongBao_teacher.UseVisualStyleBackColor = true;
            this.btn_ThongBao_teacher.Click += new System.EventHandler(this.btn_ThongBao_teacher_Click);
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_ThongBao_teacher);
            this.Controls.Add(this.btn_Back_teacher);
            this.Controls.Add(this.btn_PC_teacher);
            this.Controls.Add(this.btn_Update_teacher);
            this.Controls.Add(this.btn_Add_teacher);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Teachers";
            this.Text = "Teachers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Add_teacher;
        private System.Windows.Forms.Button btn_Update_teacher;
        private System.Windows.Forms.Button btn_PC_teacher;
        private System.Windows.Forms.Button btn_Back_teacher;
        private System.Windows.Forms.Button btn_ThongBao_teacher;
    }
}