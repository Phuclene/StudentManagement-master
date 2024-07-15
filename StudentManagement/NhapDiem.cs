using ExcelDataReader;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class NhapDiem : Form
    {
        private string connectionString = "Data Source=TANLOCTHINKPAD\\SQLEXPRESS;Initial Catalog=StudentManagement;Integrated Security=True";

        public NhapDiem()
        {
            InitializeComponent();
            this.Load += new EventHandler(NhapDiem_Load);
        }

        private void NhapDiem_Load(object sender, EventArgs e)
        {
            LoadMonData();
            LoadDiemData(); // Load dữ liệu điểm vào DataGridView khi form load
        }

        private void btnImportPointFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ImportExcelToDatabase(filePath);
                LoadDiemData(); // Load lại dữ liệu điểm vào DataGridView sau khi import
            }
        }

        private void ImportExcelToDatabase(string filePath)
        {
            try
            {
                using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        var dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                            {
                                UseHeaderRow = true
                            }
                        });

                        DataTable dataTable = dataSet.Tables[0];

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            foreach (DataRow row in dataTable.Rows)
                            {
                                string query = "INSERT INTO Diem (MaMon, TenMon, MaHocSinh, Diem15p, Diem45p, DiemCuoiKy) VALUES (@MaMon, @TenMon, @MaHocSinh, @Diem15p, @Diem45p, @DiemCuoiKy)";
                                using (SqlCommand cmd = new SqlCommand(query, connection))
                                {
                                    cmd.Parameters.AddWithValue("@MaMon", row["MaMon"]);
                                    cmd.Parameters.AddWithValue("@TenMon", row["TenMon"]);
                                    cmd.Parameters.AddWithValue("@MaHocSinh", row["MaHocSinh"]);
                                    cmd.Parameters.AddWithValue("@Diem15p", row["Diem15p"]);
                                    cmd.Parameters.AddWithValue("@Diem45p", row["Diem45p"]);
                                    cmd.Parameters.AddWithValue("@DiemCuoiKy", row["DiemCuoiKy"]);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
                MessageBox.Show("Import thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void LoadMonData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MaMon, TenMon FROM Mon";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string monInfo = $"{reader["MaMon"]} - {reader["TenMon"]}";
                            cbbMonHoc.Items.Add(monInfo);
                        }
                    }
                }
            }
        }

        private void LoadDiemData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Diem";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvDiemHocSinh.DataSource = dataTable;
                }
            }
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            // Xử lý khi nội dung của search box thay đổi
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maHocSinh = txtSearchBox.Text.Trim();
            if (string.IsNullOrEmpty(maHocSinh))
            {
                MessageBox.Show("Vui lòng nhập mã học sinh.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT HoTenHocSinh FROM Student WHERE MaHocSinh = @MaHocSinh";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MaHocSinh", maHocSinh);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string tenHocSinh = reader["HoTenHocSinh"].ToString();
                            // Hiển thị thông tin học sinh nếu cần thiết
                            MessageBox.Show($"Tìm thấy học sinh: {tenHocSinh}");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy học sinh.");
                        }
                    }
                }
            }
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            string maHocSinh = txtSearchBox.Text.Trim();
            string[] monInfo = cbbMonHoc.SelectedItem.ToString().Split('-');
            string maMon = monInfo[0].Trim();
            string tenMon = monInfo[1].Trim();
            float diem15p, diem45p, diemCuoiKy;

            if (string.IsNullOrEmpty(maHocSinh) ||
                !float.TryParse(txtDiem15p.Text.Trim(), out diem15p) ||
                !float.TryParse(txtDiem45p.Text.Trim(), out diem45p) ||
                !float.TryParse(txtDiemCuoiKy.Text.Trim(), out diemCuoiKy))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và chính xác thông tin.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Diem (MaMon, TenMon, MaHocSinh, Diem15p, Diem45p, DiemCuoiKy) VALUES (@MaMon, @TenMon, @MaHocSinh, @Diem15p, @Diem45p, @DiemCuoiKy)";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MaMon", maMon);
                    cmd.Parameters.AddWithValue("@TenMon", tenMon);
                    cmd.Parameters.AddWithValue("@MaHocSinh", maHocSinh);
                    cmd.Parameters.AddWithValue("@Diem15p", diem15p);
                    cmd.Parameters.AddWithValue("@Diem45p", diem45p);
                    cmd.Parameters.AddWithValue("@DiemCuoiKy", diemCuoiKy);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Nhập điểm thành công!");
            LoadDiemData(); // Load lại dữ liệu điểm vào DataGridView sau khi nhập điểm
        }
    }
}
