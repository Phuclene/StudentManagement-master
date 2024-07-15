using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void btn_Add_Std_Click(object sender, EventArgs e)
        {
            NewStudent newStudent = new NewStudent();
            newStudent.Show();
            this.Hide();
            newStudent.FormClosed += (s, args) => this.Close();
        }

        private void btn_Update_Std_Click(object sender, EventArgs e)
        {
            UpdateStudent updateStudent = new UpdateStudent();
            updateStudent.Show();
            this.Hide();
        }

        private void btnXepLop_Click(object sender, EventArgs e)
        {
            XepLop xepLop = new XepLop();
            xepLop.Show();
            this.Hide();
            xepLop.FormClosed += (s, args) => this.Close();
        }

        private void btnAddStdByFile_Click(object sender, EventArgs e)
        {
            AddStudentByFile addStudentByFile = new AddStudentByFile();
            addStudentByFile.Show();
            this.Hide();
            addStudentByFile.FormClosed += (s, args) => this.Close();
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
