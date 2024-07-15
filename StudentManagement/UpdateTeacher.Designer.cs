namespace StudentManagement
{
    partial class UpdateTeacher
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
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.btnSearchTeacher = new System.Windows.Forms.Button();
            this.dgvTeacherInfo = new System.Windows.Forms.DataGridView();
            this.btnBackTeacher = new System.Windows.Forms.Button();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.btnUpdateTeacher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT THÔNG TIN GIÁO VIÊN";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(367, 121);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchBox.Multiline = true;
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(338, 52);
            this.txtSearchBox.TabIndex = 1;
            // 
            // btnSearchTeacher
            // 
            this.btnSearchTeacher.Location = new System.Drawing.Point(749, 121);
            this.btnSearchTeacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchTeacher.Name = "btnSearchTeacher";
            this.btnSearchTeacher.Size = new System.Drawing.Size(112, 58);
            this.btnSearchTeacher.TabIndex = 2;
            this.btnSearchTeacher.Text = "Tìm kiếm";
            this.btnSearchTeacher.UseVisualStyleBackColor = true;
            this.btnSearchTeacher.Click += new System.EventHandler(this.btnSearchTeacher_Click);
            // 
            // dgvTeacherInfo
            // 
            this.dgvTeacherInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherInfo.Location = new System.Drawing.Point(87, 220);
            this.dgvTeacherInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTeacherInfo.Name = "dgvTeacherInfo";
            this.dgvTeacherInfo.RowHeadersWidth = 51;
            this.dgvTeacherInfo.RowTemplate.Height = 24;
            this.dgvTeacherInfo.Size = new System.Drawing.Size(1020, 272);
            this.dgvTeacherInfo.TabIndex = 3;
            this.dgvTeacherInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeacherInfo_CellContentClick);
            // 
            // btnBackTeacher
            // 
            this.btnBackTeacher.BackColor = System.Drawing.Color.Red;
            this.btnBackTeacher.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnBackTeacher.Location = new System.Drawing.Point(988, 595);
            this.btnBackTeacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBackTeacher.Name = "btnBackTeacher";
            this.btnBackTeacher.Size = new System.Drawing.Size(174, 54);
            this.btnBackTeacher.TabIndex = 4;
            this.btnBackTeacher.Text = "Quay lại";
            this.btnBackTeacher.UseVisualStyleBackColor = false;
            this.btnBackTeacher.Click += new System.EventHandler(this.btnBackTeacher_Click);
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDeleteTeacher.ForeColor = System.Drawing.Color.Blue;
            this.btnDeleteTeacher.Location = new System.Drawing.Point(767, 595);
            this.btnDeleteTeacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(174, 54);
            this.btnDeleteTeacher.TabIndex = 5;
            this.btnDeleteTeacher.Text = "Xóa giáo viên";
            this.btnDeleteTeacher.UseVisualStyleBackColor = false;
            this.btnDeleteTeacher.Click += new System.EventHandler(this.btnDeleteTeacher_Click);
            // 
            // btnUpdateTeacher
            // 
            this.btnUpdateTeacher.BackColor = System.Drawing.Color.Gold;
            this.btnUpdateTeacher.ForeColor = System.Drawing.Color.Indigo;
            this.btnUpdateTeacher.Location = new System.Drawing.Point(544, 595);
            this.btnUpdateTeacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateTeacher.Name = "btnUpdateTeacher";
            this.btnUpdateTeacher.Size = new System.Drawing.Size(174, 54);
            this.btnUpdateTeacher.TabIndex = 6;
            this.btnUpdateTeacher.Text = "Cập nhật";
            this.btnUpdateTeacher.UseVisualStyleBackColor = false;
            this.btnUpdateTeacher.Click += new System.EventHandler(this.btnUpdateTeacher_Click);
            // 
            // UpdateTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnUpdateTeacher);
            this.Controls.Add(this.btnDeleteTeacher);
            this.Controls.Add(this.btnBackTeacher);
            this.Controls.Add(this.dgvTeacherInfo);
            this.Controls.Add(this.btnSearchTeacher);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateTeacher";
            this.Text = "UpdateTeacher";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Button btnSearchTeacher;
        private System.Windows.Forms.DataGridView dgvTeacherInfo;
        private System.Windows.Forms.Button btnBackTeacher;
        private System.Windows.Forms.Button btnDeleteTeacher;
        private System.Windows.Forms.Button btnUpdateTeacher;
    }
}