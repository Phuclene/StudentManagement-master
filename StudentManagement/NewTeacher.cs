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
    public partial class NewTeacher : Form
    {
        private string connectionString = "Data Source=TANLOCTHINKPAD\\SQLEXPRESS;Initial Catalog=StudentManagement;Integrated Security=True";

        public NewTeacher()
        {
            InitializeComponent();
        }

        private void btn_BackTeacher_Click(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            teachers.Show();
            this.Close();
            teachers.FormClosed += (s, agrs) => this.Close();
        }

        private void btn_SubmitTeacher_Click(object sender, EventArgs e)
        {
            string maGiaoVien = txtMaGiaoVien.Text;
            string hoTenGiaoVien = txtHoTenGiaoVien.Text;
            string gioiTinh = radioBtnNam.Checked ? "Nam" : "Nữ";
            DateTime ngaySinh = dTP_NgaySinh.Value;
            int SoDienThoai = int.Parse(txtSDTGiaoVien.Text);
            string email = txtEmailGiaoVien.Text;
            string chuyenNganh = txtChuyenNganh.Text;

            if(string.IsNullOrEmpty(maGiaoVien) || string.IsNullOrEmpty(hoTenGiaoVien))
            {
                MessageBox.Show("Không được để trống mã và họ tên!");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string checkQuery = "SELECT COUNT(*) FROM Teacher WHERE MaGiaoVien = @MaGiaoVien";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@MaGiaoVien", maGiaoVien);
                        int count = (int)checkCommand.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Mã giáo viên đã tồn tại!");
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO Teacher (MaGiaoVien, HoTenGiaoVien, GioiTinh, NgaySinh, SoDienThoai, Email, ChuyenNganh)" +
                                         "VALUES (@MaGiaoVien, @HoTenGiaoVien, @GioiTinh, @NgaySinh, @SoDienThoai, @Email, @ChuyenNganh)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@MaGiaoVien", maGiaoVien);
                        insertCommand.Parameters.AddWithValue("@HoTenGiaoVien", hoTenGiaoVien);
                        insertCommand.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        insertCommand.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        insertCommand.Parameters.AddWithValue("@SoDienThoai", SoDienThoai);
                        insertCommand.Parameters.AddWithValue("@Email", email);
                        insertCommand.Parameters.AddWithValue("@ChuyenNganh", chuyenNganh);


                        int result = insertCommand.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Thêm thông tin giáo viên thành công!");
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

        private void NewTeacher_Load(object sender, EventArgs e)
        {

        }
    }
}
