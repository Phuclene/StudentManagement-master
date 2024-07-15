namespace StudentManagement
{
    partial class AddStudentByFile
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
            this.btnAddStudentFile = new System.Windows.Forms.Button();
            this.dgvShowStdByFile = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowStdByFile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddStudentFile
            // 
            this.btnAddStudentFile.Location = new System.Drawing.Point(334, 51);
            this.btnAddStudentFile.Name = "btnAddStudentFile";
            this.btnAddStudentFile.Size = new System.Drawing.Size(437, 68);
            this.btnAddStudentFile.TabIndex = 0;
            this.btnAddStudentFile.Text = "Thêm File";
            this.btnAddStudentFile.UseVisualStyleBackColor = true;
            this.btnAddStudentFile.Click += new System.EventHandler(this.btnAddStudentFile_Click);
            // 
            // dgvShowStdByFile
            // 
            this.dgvShowStdByFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowStdByFile.Location = new System.Drawing.Point(105, 147);
            this.dgvShowStdByFile.Name = "dgvShowStdByFile";
            this.dgvShowStdByFile.RowHeadersWidth = 62;
            this.dgvShowStdByFile.RowTemplate.Height = 28;
            this.dgvShowStdByFile.Size = new System.Drawing.Size(1139, 271);
            this.dgvShowStdByFile.TabIndex = 1;
            // 
            // AddStudentByFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.dgvShowStdByFile);
            this.Controls.Add(this.btnAddStudentFile);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "AddStudentByFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudentByFile";
            this.Load += new System.EventHandler(this.AddStudentByFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowStdByFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddStudentFile;
        private System.Windows.Forms.DataGridView dgvShowStdByFile;
    }
}