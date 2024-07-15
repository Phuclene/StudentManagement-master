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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
        }

        private void btn_Back_teacher_Click(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            teachers.Show();
            this.Hide();
            teachers.FormClosed += (s, args) => this.Close();
        }

        private void btn_Add_teacher_Click(object sender, EventArgs e)
        {
            NewTeacher newTeacher = new NewTeacher();
            newTeacher.Show();
            this.Hide();
            newTeacher.FormClosed += (s, args) => this.Close();
        }

        private void btn_Update_teacher_Click(object sender, EventArgs e)
        {
            UpdateTeacher updateTeacher = new UpdateTeacher();
            updateTeacher.Show();
            this.Hide();
            updateTeacher.FormClosed += (s, args) => this.Close();
        }

        private void btn_PC_teacher_Click(object sender, EventArgs e)
        {
            Teacher_PC teacher_PC = new Teacher_PC();
            teacher_PC.Show();
            this.Hide();
            teacher_PC.FormClosed += (s, args) => this.Close();
        }

        private void btn_ThongBao_teacher_Click(object sender, EventArgs e)
        {
            TeacherNotifications teacherNotifications = new TeacherNotifications();
            teacherNotifications.Show();
            this.Hide();
            teacherNotifications.FormClosed += (s, args) => this.Close();
        }
    }
}
