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
    public partial class UpdateTeacher : Form
    {
        private string connectionString = "Data Source=TANLOCTHINKPAD\\SQLEXPRESS;Initial Catalog=StudentManagement;Integrated Security=True";

        public UpdateTeacher()
        {
            InitializeComponent();
        }

        private void btnBackTeacher_Click(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            teachers.Show();
            this.Close();
            teachers.FormClosed += (s, agrs) => this.Close();
        }

        private void btnUpdateTeacher_Click(object sender, EventArgs e)
        {
            LoadData(txtSearchBox.Text);
        }

        private void dgvTeacherInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadData(string searchValue)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string showQuery = "SELECT MaGiaoVien, HoTenGiaoVien, NgaySinh, SoDienThoai, Email, ChuyenNganh, TenLop " + "FROM Teacher " +
                        "WHERE MaGiaoVien LIKE @SearchValue OR HoTenGiaoVien LIKE @SearchValue";
                    using (SqlCommand command = new SqlCommand(showQuery, connection))
                    {
                        command.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%");
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvTeacherInfo.DataSource = dataTable;
                    }
                }
                catch (Exception ex) { MessageBox.Show("Hiển thị thông tin thất bại"); }
            }
        }

        private void btnSearchTeacher_Click(object sender, EventArgs e)
        {
            LoadData(txtSearchBox.Text);
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            if (dgvTeacherInfo.SelectedRows.Count > 0)
            {
                string maGiaoVien = dgvTeacherInfo.SelectedRows[0].Cells["MaGiaoVien"].Value.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string deleteQuery = "DELETE FROM Teacher WHERE MaGiaoVien = @MaGiaoVien";
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@MaGiaoVien", maGiaoVien);
                            int result = command.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Xóa giáo viên thành công.");
                                LoadData(txtSearchBox.Text);
                            }
                            else
                            {
                                MessageBox.Show("Xóa giáo viên thất bại.");
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
                MessageBox.Show("Vui lòng chọn một giáo viên để xóa.");
            }
        }
    }
    
}
