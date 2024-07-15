using DocumentFormat.OpenXml.Drawing.Charts;
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
    public partial class UpdateStudent : Form
    {
        private string connectionString = "Data Source=TANLOCTHINKPAD\\SQLEXPRESS;Initial Catalog=StudentManagement;Integrated Security=True";

        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Search(string searchValue)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string showQuery = "SELECT MaHocSinh, HoTenHocSinh, Lop, NgaySinh, NoiSinh, QueQuan, NoiO, TonGiao, DanToc, TinhTrang " + "FROM Student " +
                        "WHERE MaHocSinh LIKE @SearchValue OR HoTenHocSinh LIKE @SearchValue";
                    using (SqlCommand command = new SqlCommand(showQuery, connection))
                    {
                        command.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        System.Data.DataTable dt = new System.Data.DataTable();
                        adapter.Fill(dt);

                        dgvStudentInfo.DataSource = dt;
                    }
                }
                catch (Exception ex) { MessageBox.Show("Hiển thị thông tin thất bại: " + ex.Message); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search(txtSearchBox.Text);
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudentInfo.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvStudentInfo.SelectedRows[0];
                string maHocSinh = row.Cells["MaHocSinh"].Value.ToString();
                string hoTenHocSinh = row.Cells["HoTenHocSinh"].Value.ToString();
                string lop = row.Cells["Lop"].Value.ToString();
                DateTime ngaySinh = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                string noiSinh = row.Cells["NoiSinh"].Value.ToString();
                string tonGiao = row.Cells["TonGiao"].Value.ToString();
                string queQuan = row.Cells["QueQuan"].Value.ToString();
                string diaChi = row.Cells["NoiO"].Value.ToString();

                DetailUpdateStudent detailForm = new DetailUpdateStudent(maHocSinh, hoTenHocSinh, lop, ngaySinh, noiSinh, tonGiao, queQuan, diaChi);
                detailForm.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một học sinh để cập nhật.");
            }
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MaHocSinh, HoTenHocSinh, Lop, NgaySinh, NoiSinh, QueQuan, NoiO, TonGiao, DanToc, DiemThiTuyenSinh FROM Student";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgvStudentInfo.DataSource = dt;
            }
        }

        private void btnDeleteInfoStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudentInfo.SelectedRows.Count > 0)
            {
                string maGiaoVien = dgvStudentInfo.SelectedRows[0].Cells["MaHocSinh"].Value.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string deleteQuery = "DELETE FROM Student WHERE MaHocSinh = @MaHocSinh";
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@MaHocSinh", maGiaoVien);
                            int result = command.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Xóa học sinh thành công.");
                                Search(txtSearchBox.Text);
                            }
                            else
                            {
                                MessageBox.Show("Xóa học sinh thất bại!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một học sinh để xóa.");
            }
        }

        private void dgvStudentInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students students = new Students();
            students.Show();
        }

        private void dgvStudentInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
