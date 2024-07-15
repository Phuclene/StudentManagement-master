using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentManagement
{
    public partial class NewStudent : Form
    {
        private string connectionString = "Data Source=TANLOCTHINKPAD\\SQLEXPRESS;Initial Catalog=StudentManagement;Integrated Security=True";

        public NewStudent()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NewStudent_Load(object sender, EventArgs e)
        {

        }

        private void btn_BackAddStd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students students = new Students();
            students.FormClosed += (s, args) => this.Close();
            students.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_SubmitStd_Click(object sender, EventArgs e)
        {
            string maHocSinh = txtMaHocSinh.Text;
            string hoTenHocSinh = txtStudentName.Text;
            DateTime ngaySinh = dTP_NgaySinh.Value;
            string gioiTinh = rdbtnNam.Checked ? "Nam" : "Nữ";
            string noiSinh = txtPOB.Text;
            string queQuan = txtHomeTown.Text;
            string diaChi = txtAddress.Text;
            string tonGiao = txtReligion.Text;
            string danToc = txtDanToc.Text;
            float diemThiTuyenSinh;

            

            if (string.IsNullOrEmpty(maHocSinh) || string.IsNullOrEmpty(hoTenHocSinh))
            {
                MessageBox.Show("Không được để trống mã và họ tên!");
                return;
            }

            if (!float.TryParse(txtComingPoint.Text, out diemThiTuyenSinh))
            {
                MessageBox.Show("Điểm thi tuyển sinh không hợp lệ!");
                return;
            }

            // Kết nối đến cơ sở dữ liệu và kiểm tra tính duy nhất của mã học sinh
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Kiểm tra mã học sinh đã tồn tại chưa
                    string checkQuery = "SELECT COUNT(*) FROM Student WHERE MaHocSinh = @MaHocSinh";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@MaHocSinh", maHocSinh);
                        int count = (int)checkCommand.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Mã học sinh đã tồn tại!");
                            return;
                        }
                    }

                    // Lưu dữ liệu vào cơ sở dữ liệu nếu mã học sinh không tồn tại
                    string insertQuery = "INSERT INTO Student (MaHocSinh, HoTenHocSinh, NgaySinh, GioiTinh, NoiSinh, QueQuan, NoiO, TonGiao, DanToc, DiemThiTuyenSinh) " +
                                         "VALUES (@MaHocSinh, @HoTenHocSinh, @NgaySinh, @GioiTinh, @NoiSinh, @QueQuan, @NoiO, @TonGiao, @DanToc, @DiemThiTuyenSinh)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@MaHocSinh", maHocSinh);
                        insertCommand.Parameters.AddWithValue("@HoTenHocSinh", hoTenHocSinh);
                        insertCommand.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        insertCommand.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        insertCommand.Parameters.AddWithValue("@NoiSinh", noiSinh);
                        insertCommand.Parameters.AddWithValue("@QueQuan", queQuan);
                        insertCommand.Parameters.AddWithValue("@NoiO", diaChi);
                        insertCommand.Parameters.AddWithValue("@TonGiao", tonGiao);
                        insertCommand.Parameters.AddWithValue("@DanToc", danToc);
                        insertCommand.Parameters.AddWithValue("@DiemThiTuyenSinh", diemThiTuyenSinh);
                        

                        int result = insertCommand.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Thêm thông tin học sinh thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
       
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
