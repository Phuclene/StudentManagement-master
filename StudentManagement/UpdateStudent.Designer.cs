namespace StudentManagement
{
    partial class UpdateStudent
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
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteInfoStudent = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.dgvStudentInfo = new System.Windows.Forms.DataGridView();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.BackColor = System.Drawing.Color.Red;
            this.btnUpdateStudent.Location = new System.Drawing.Point(748, 620);
            this.btnUpdateStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(174, 54);
            this.btnUpdateStudent.TabIndex = 39;
            this.btnUpdateStudent.Text = "Cập Nhật";
            this.btnUpdateStudent.UseVisualStyleBackColor = false;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 40);
            this.label1.TabIndex = 20;
            this.label1.Text = "CẬP NHẬT HỒ SƠ HỌC SINH";
            // 
            // btnDeleteInfoStudent
            // 
            this.btnDeleteInfoStudent.BackColor = System.Drawing.Color.Red;
            this.btnDeleteInfoStudent.Location = new System.Drawing.Point(966, 620);
            this.btnDeleteInfoStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteInfoStudent.Name = "btnDeleteInfoStudent";
            this.btnDeleteInfoStudent.Size = new System.Drawing.Size(174, 54);
            this.btnDeleteInfoStudent.TabIndex = 41;
            this.btnDeleteInfoStudent.Text = "Xóa Hồ Sơ";
            this.btnDeleteInfoStudent.UseVisualStyleBackColor = false;
            this.btnDeleteInfoStudent.Click += new System.EventHandler(this.btnDeleteInfoStudent_Click);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(314, 112);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchBox.Multiline = true;
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(338, 52);
            this.txtSearchBox.TabIndex = 42;
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(688, 109);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(112, 57);
            this.btnSearchStudent.TabIndex = 43;
            this.btnSearchStudent.Text = "Tìm kiếm";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvStudentInfo
            // 
            this.dgvStudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentInfo.Location = new System.Drawing.Point(88, 226);
            this.dgvStudentInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvStudentInfo.Name = "dgvStudentInfo";
            this.dgvStudentInfo.RowHeadersWidth = 62;
            this.dgvStudentInfo.Size = new System.Drawing.Size(1020, 272);
            this.dgvStudentInfo.TabIndex = 44;
            this.dgvStudentInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentInfo_CellClick);
            // 
            // btnRefesh
            // 
            this.btnRefesh.BackColor = System.Drawing.Color.Red;
            this.btnRefesh.Location = new System.Drawing.Point(528, 620);
            this.btnRefesh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(174, 54);
            this.btnRefesh.TabIndex = 45;
            this.btnRefesh.Text = "Tải Lại";
            this.btnRefesh.UseVisualStyleBackColor = false;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.RosyBrown;
            this.btnBack.Location = new System.Drawing.Point(29, 30);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(145, 48);
            this.btnBack.TabIndex = 46;
            this.btnBack.Text = "Quay Lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.dgvStudentInfo);
            this.Controls.Add(this.btnSearchStudent);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.btnDeleteInfoStudent);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdateStudent";
            this.Text = "UpdateStudent";
            this.Load += new System.EventHandler(this.UpdateStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteInfoStudent;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.DataGridView dgvStudentInfo;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.Button btnBack;
    }
}