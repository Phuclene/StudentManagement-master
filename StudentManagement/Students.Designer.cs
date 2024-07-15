namespace StudentManagement
{
    partial class Students
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
            this.btn_Add_Std = new System.Windows.Forms.Button();
            this.btn_Update_Std = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnXepLop = new System.Windows.Forms.Button();
            this.btn_BackStd = new System.Windows.Forms.Button();
            this.btnAddStdByFile = new System.Windows.Forms.Button();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Add_Std
            // 
            this.btn_Add_Std.Location = new System.Drawing.Point(74, 66);
            this.btn_Add_Std.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add_Std.Name = "btn_Add_Std";
            this.btn_Add_Std.Size = new System.Drawing.Size(104, 89);
            this.btn_Add_Std.TabIndex = 0;
            this.btn_Add_Std.Text = "TIẾP NHẬN HỒ SƠ";
            this.btn_Add_Std.UseVisualStyleBackColor = true;
            this.btn_Add_Std.Click += new System.EventHandler(this.btn_Add_Std_Click);
            // 
            // btn_Update_Std
            // 
            this.btn_Update_Std.Location = new System.Drawing.Point(262, 65);
            this.btn_Update_Std.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update_Std.Name = "btn_Update_Std";
            this.btn_Update_Std.Size = new System.Drawing.Size(108, 89);
            this.btn_Update_Std.TabIndex = 2;
            this.btn_Update_Std.Text = "CẬP NHẬT THÔNG TIN";
            this.btn_Update_Std.UseVisualStyleBackColor = true;
            this.btn_Update_Std.Click += new System.EventHandler(this.btn_Update_Std_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(464, 66);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 89);
            this.button7.TabIndex = 6;
            this.button7.Text = "ĐIỂM DANH";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btnXepLop
            // 
            this.btnXepLop.Location = new System.Drawing.Point(633, 66);
            this.btnXepLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXepLop.Name = "btnXepLop";
            this.btnXepLop.Size = new System.Drawing.Size(88, 89);
            this.btnXepLop.TabIndex = 7;
            this.btnXepLop.Text = "XẾP LỚP";
            this.btnXepLop.UseVisualStyleBackColor = true;
            this.btnXepLop.Click += new System.EventHandler(this.btnXepLop_Click);
            // 
            // btn_BackStd
            // 
            this.btn_BackStd.BackColor = System.Drawing.Color.IndianRed;
            this.btn_BackStd.ForeColor = System.Drawing.Color.Black;
            this.btn_BackStd.Location = new System.Drawing.Point(656, 369);
            this.btn_BackStd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BackStd.Name = "btn_BackStd";
            this.btn_BackStd.Size = new System.Drawing.Size(110, 54);
            this.btn_BackStd.TabIndex = 8;
            this.btn_BackStd.Text = "Quay Lại";
            this.btn_BackStd.UseVisualStyleBackColor = false;
            // 
            // btnAddStdByFile
            // 
            this.btnAddStdByFile.Location = new System.Drawing.Point(74, 248);
            this.btnAddStdByFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddStdByFile.Name = "btnAddStdByFile";
            this.btnAddStdByFile.Size = new System.Drawing.Size(133, 89);
            this.btnAddStdByFile.TabIndex = 9;
            this.btnAddStdByFile.Text = "TIẾP NHẬN HỒ SƠ BẰNG FILE";
            this.btnAddStdByFile.UseVisualStyleBackColor = true;
            this.btnAddStdByFile.Click += new System.EventHandler(this.btnAddStdByFile_Click);
            // 
            // btnShutDown
            // 
            this.btnShutDown.Location = new System.Drawing.Point(60, 371);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(149, 52);
            this.btnShutDown.TabIndex = 10;
            this.btnShutDown.Text = "Tắt Chương Trình";
            this.btnShutDown.UseVisualStyleBackColor = true;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.btnShutDown);
            this.Controls.Add(this.btnAddStdByFile);
            this.Controls.Add(this.btn_BackStd);
            this.Controls.Add(this.btnXepLop);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btn_Update_Std);
            this.Controls.Add(this.btn_Add_Std);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Students";
            this.Text = "Students";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Add_Std;
        private System.Windows.Forms.Button btn_Update_Std;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnXepLop;
        private System.Windows.Forms.Button btn_BackStd;
        private System.Windows.Forms.Button btnAddStdByFile;
        private System.Windows.Forms.Button btnShutDown;
    }
}