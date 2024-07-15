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
    public partial class XepLop : Form
    {

        private string connectionString = "Data Source=TANLOCTHINKPAD\\SQLEXPRESS;Initial Catalog=StudentManagement;Integrated Security=True";

        public XepLop()
        {
            InitializeComponent();
        }

        private void XepLop_Load(object sender, EventArgs e)
        {
            LoadClasses();
        }

        private void LoadClasses()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT MaLop, TenLop FROM Class";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        cbbLopHienCo.DataSource = dataTable;
                        cbbLopHienCo.DisplayMember = "TenLop";
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi tải danh sách lớp: " + ex.Message);
                }
            }
        }

        private void SaveData(string maLop, string tenLop, int soLuong)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO Class (MaLop, TenLop, SoLuong, MaGiaoVienChuNhiem ) VALUES (@MaLop, @TenLop, @SoLuong, NULL )";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@MaLop", maLop);
                        command.Parameters.AddWithValue("@TenLop", tenLop);
                        command.Parameters.AddWithValue("@SoLuong", soLuong);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Thêm lớp thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Thêm lớp thất bại.");
                        }
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Có lỗi xảy ra, thêm lớp chưa thành công!" + ex.Message);
                }
                
            }
        }

        private void btnAddLop_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text;
            string tenLop = txtTenLop.Text;
            int soLuong;

            if (string.IsNullOrEmpty(maLop) || string.IsNullOrEmpty(tenLop))
            {
                MessageBox.Show("Mã lớp và tên lớp không được để trống.");
                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out soLuong))
            {
                MessageBox.Show("Số lượng không hợp lệ.");
                return;
            }

            SaveData(maLop, tenLop, soLuong);
        }

        private void LoadStudents(string searchValue)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT MaHocSinh, HoTenHocSinh, DiemThiTuyenSinh FROM Student WHERE MaHocSinh LIKE @SearchValue OR HoTenHocSinh LIKE @SearchValue";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvHocSinhXepLop.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi tìm kiếm học sinh: " + ex.Message);
                }
            }
        }

        private void txtSearchTenHocSinh_TextChanged(object sender, EventArgs e)
        {
            LoadStudents(txtSearchTenHocSinh.Text);
        }

        private void btnAddHocSinhToLop_Click(object sender, EventArgs e)
        {
            // Lấy mã học sinh từ DataGridView
            if (dgvHocSinhXepLop.SelectedRows.Count > 0)
            {
                string maHocSinh = dgvHocSinhXepLop.SelectedRows[0].Cells["MaHocSinh"].Value.ToString();
                string tenLop = cbbLopHienCo.Text;

                if (!string.IsNullOrEmpty(maHocSinh) && !string.IsNullOrEmpty(tenLop))
                {
                    AddStudentToClass(maHocSinh, tenLop);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn lớp và nhập mã học sinh.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn học sinh từ danh sách.");
            }
        }

        private void AddStudentToClass(string maHocSinh, string tenLop)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Kiểm tra xem học sinh đã có lớp hay chưa
                    string checkLopQuery = "SELECT MaLop FROM Student WHERE MaHocSinh = @MaHocSinh";
                    string existingMaLop = "";
                    using (SqlCommand checkLopCommand = new SqlCommand(checkLopQuery, connection))
                    {
                        checkLopCommand.Parameters.AddWithValue("@MaHocSinh", maHocSinh);
                        object result = checkLopCommand.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            existingMaLop = result.ToString();
                            MessageBox.Show("Học sinh đã có lớp. Không thể thêm vào lớp mới.");
                            return;
                        }
                    }

                    // Lấy MaLop từ TenLop trong bảng Class
                    string getMaLopQuery = "SELECT MaLop FROM Class WHERE TenLop = @TenLop";
                    string maLop = "";
                    using (SqlCommand getMaLopCommand = new SqlCommand(getMaLopQuery, connection))
                    {
                        getMaLopCommand.Parameters.AddWithValue("@TenLop", tenLop);
                        object result = getMaLopCommand.ExecuteScalar();

                        if (result != null)
                        {
                            maLop = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy mã lớp cho tên lớp được cung cấp.");
                            return;
                        }
                    }

                    // Cập nhật MaLop và Lop trong bảng Students
                    string updateQuery = "UPDATE Student SET MaLop = @MaLop, Lop = @TenLop WHERE MaHocSinh = @MaHocSinh";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@MaHocSinh", maHocSinh);
                        updateCommand.Parameters.AddWithValue("@MaLop", maLop);
                        updateCommand.Parameters.AddWithValue("@TenLop", tenLop);

                        int updateResult = updateCommand.ExecuteNonQuery();
                        if (updateResult > 0)
                        {
                            MessageBox.Show("Thêm học sinh vào lớp thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Thêm học sinh vào lớp thất bại.");
                        }
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

