namespace StudentManagement
{
    partial class AdminHome
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
            this.btn_Std = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_BackAdHome = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnTKB = new System.Windows.Forms.Button();
            this.btnNhapDiem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Std
            // 
            this.btn_Std.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Std.Location = new System.Drawing.Point(34, 129);
            this.btn_Std.Name = "btn_Std";
            this.btn_Std.Size = new System.Drawing.Size(172, 122);
            this.btn_Std.TabIndex = 0;
            this.btn_Std.Text = "HỌC SINH";
            this.btn_Std.UseVisualStyleBackColor = false;
            this.btn_Std.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHỨC NĂNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button2.Location = new System.Drawing.Point(240, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 122);
            this.button2.TabIndex = 2;
            this.button2.Text = "GIÁO VIÊN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_BackAdHome
            // 
            this.btn_BackAdHome.BackColor = System.Drawing.Color.IndianRed;
            this.btn_BackAdHome.ForeColor = System.Drawing.Color.Black;
            this.btn_BackAdHome.Location = new System.Drawing.Point(754, 373);
            this.btn_BackAdHome.Name = "btn_BackAdHome";
            this.btn_BackAdHome.Size = new System.Drawing.Size(111, 54);
            this.btn_BackAdHome.TabIndex = 3;
            this.btn_BackAdHome.Text = "Quay Lại";
            this.btn_BackAdHome.UseVisualStyleBackColor = false;
            this.btn_BackAdHome.Click += new System.EventHandler(this.btn_BackAdHome_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(683, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 122);
            this.button3.TabIndex = 4;
            this.button3.Text = "TÀI KHOẢN";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnTKB
            // 
            this.btnTKB.BackColor = System.Drawing.Color.Lime;
            this.btnTKB.Location = new System.Drawing.Point(460, 129);
            this.btnTKB.Name = "btnTKB";
            this.btnTKB.Size = new System.Drawing.Size(183, 122);
            this.btnTKB.TabIndex = 5;
            this.btnTKB.Text = "THỜI KHÓA BIỂU";
            this.btnTKB.UseVisualStyleBackColor = false;
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnNhapDiem.Location = new System.Drawing.Point(34, 290);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(172, 122);
            this.btnNhapDiem.TabIndex = 6;
            this.btnNhapDiem.Text = "NHẬP ĐIỂM";
            this.btnNhapDiem.UseVisualStyleBackColor = false;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(902, 449);
            this.Controls.Add(this.btnNhapDiem);
            this.Controls.Add(this.btnTKB);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_BackAdHome);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Std);
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Std;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_BackAdHome;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnTKB;
        private System.Windows.Forms.Button btnNhapDiem;
    }
}