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
    public partial class AdminHome : Form
    {

    
        

        public AdminHome()
        {
            InitializeComponent();
        }

        private void btn_BackAdHome_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
            adminLogin.FormClosed += (s, args) => this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            students.Show();
            this.Hide();
            students.FormClosed += (s, args) => this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            teachers.Show();
            this.Hide();
            teachers.FormClosed += (s, args) => this.Close();
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            NhapDiem nhapDiem = new NhapDiem();
            nhapDiem.Show();
            this.Hide();
        }
    }
}
