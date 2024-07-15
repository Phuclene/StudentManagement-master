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
    public partial class TeacherNotifications : Form
    {
        public TeacherNotifications()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TeacherNotifications_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo danh sách các thông báo giả
            var notifications = new List<(string Title, string Content)>
            {
                ("Lịch thi cuối kỳ", "Lịch thi cuối kỳ sẽ diễn ra từ ngày 20/07 đến 30/07. Các bạn chuẩn bị ôn tập thật tốt."),
                ("Thông báo nghỉ học", "Ngày 10/07 lớp chúng ta sẽ nghỉ học do giáo viên bận công tác."),
                ("Bài tập về nhà", "Các bạn làm bài tập từ trang 45 đến trang 50 trong sách giáo khoa."),
                ("Thay đổi lịch học", "Tuần sau, chúng ta sẽ học vào thứ 4 thay vì thứ 5 như thường lệ."),
                ("Thông báo họp lớp", "Cuộc họp lớp sẽ diễn ra vào lúc 8 giờ sáng thứ 7 tuần này tại phòng 202."),
                ("Kết quả kiểm tra", "Kết quả kiểm tra giữa kỳ đã có, các bạn vui lòng xem trên hệ thống."),
                ("Chuyến dã ngoại", "Lớp chúng ta sẽ có một chuyến dã ngoại vào ngày 25/07. Đăng ký tại văn phòng khoa."),
                ("Cập nhật tài liệu", "Tài liệu mới cho môn học đã được cập nhật trên website lớp."),
                ("Nhắc nhở đóng học phí", "Hạn chót đóng học phí là ngày 15/07. Các bạn lưu ý hoàn thành đúng hạn."),
                ("Hoạt động ngoại khóa", "Tham gia hoạt động ngoại khóa vào chiều thứ 6 tuần này tại sân trường.")
            };



            // Thêm các thông báo mới vào ListView
            foreach (var notification in notifications)
            {
                var listViewItem = new ListViewItem(notification.Title);
                listViewItem.SubItems.Add(notification.Content);
                listView1.Items.Add(listViewItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            teachers.Show();
            this.Hide();
            teachers.FormClosed += (s, args) => this.Close();
        }
    }
}
