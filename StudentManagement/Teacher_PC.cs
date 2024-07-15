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
    public partial class Teacher_PC : Form
    {
        public Teacher_PC()
        {
            InitializeComponent();
        }

        private void Teacher_PC_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtThoiGian_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_BackTeacherPC_Click(object sender, EventArgs e)
        {
         
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btn_BackTeacherPC_Click_1(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            teachers.Show();
            this.Hide();
            teachers.FormClosed += (s, args) => this.Close();
        }
    }
}
