using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class DetailUpdateStudent : Form
    {
        private string maHocSinh;
        private string hoTenHocSinh;
        private string lop;
        private DateTime ngaySinh;
        private string noiSinh;
        private string tonGiao;
        private string queQuan;
        private string diaChi;

        public DetailUpdateStudent(string maHocSinh, string hoTenHocSinh, string lop, DateTime ngaySinh, string noiSinh, string tonGiao, string queQuan, string diaChi)
        {
            InitializeComponent();
            this.maHocSinh = maHocSinh;
            this.hoTenHocSinh = hoTenHocSinh;
            this.lop = lop;
            this.ngaySinh = ngaySinh;
            this.noiSinh = noiSinh;
            this.tonGiao = tonGiao;
            this.queQuan = queQuan;
            this.diaChi = diaChi;

            
            
            txtHoTenHocSinhUpdate.Text = hoTenHocSinh;
            txtLopUpdate.Text = lop;
            txtNgaySinh.Text = ngaySinh.ToString("dd/MM/yyyy");
            txtUpdateNoiSinh.Text = noiSinh;
            txtUpdateTonGiao.Text = tonGiao;
            txtUpdateQueQuan.Text = queQuan;
            txtUpdateDiaChi.Text = diaChi;

            txtMaHocSinhUpdate.Text = maHocSinh;
            txtMaHocSinhUpdate.ReadOnly = true;


        }


        private void DetailUpdateStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {            
            string hoTenHocSinh = txtHoTenHocSinhUpdate.Text;
            string lop = txtLopUpdate.Text;
            DateTime ngaySinh = DateTime.ParseExact(txtNgaySinh.Text, "dd/MM/yyyy", null);
            string noiSinh = txtUpdateNoiSinh.Text;
            string tonGiao = txtUpdateTonGiao.Text;
            string queQuan = txtUpdateQueQuan.Text;
            string diaChi = txtUpdateDiaChi.Text;

        string connectionString = "Data Source=TANLOCTHINKPAD\\SQLEXPRESS;Initial Catalog=StudentManagement;Integrated Security=True";

        string query = "UPDATE Student SET HoTenHocSinh = @HoTenHocSinh, Lop = @Lop, NgaySinh = @NgaySinh, NoiSinh = @NoiSinh, TonGiao = @TonGiao, QueQuan = @QueQuan, NoiO = @NoiO WHERE MaHocSinh = @MaHocSinh";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaHocSinh", maHocSinh);
                    command.Parameters.AddWithValue("@HoTenHocSinh", hoTenHocSinh);
                    command.Parameters.AddWithValue("@Lop", lop);
                    command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    command.Parameters.AddWithValue("@NoiSinh", noiSinh);
                    command.Parameters.AddWithValue("@TonGiao", tonGiao);
                    command.Parameters.AddWithValue("@QueQuan", queQuan);
                    command.Parameters.AddWithValue("@NoiO", diaChi);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin học sinh thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy học sinh với mã học sinh đã cho.");
                        }
                    }
                    catch (Exception ex)
                    {                       
                        MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                    }
                }
            }
        }
    }
}
