using ClosedXML.Excel;
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
    public partial class AddStudentByFile : Form
    {
        private string connectionString = "Data Source=TANLOCTHINKPAD\\SQLEXPRESS;Initial Catalog=StudentManagement;Integrated Security=True";
        public AddStudentByFile()
        {
            InitializeComponent();
        }



        private void btnAddStudentFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    DataTable dt = new DataTable();
                    using (var workbook = new XLWorkbook(filePath))
                    {
                        var worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        foreach (var row in worksheet.Rows())
                        {
                            if (firstRow)
                            {
                                foreach (var cell in row.Cells())
                                {
                                    dt.Columns.Add(cell.Value.ToString());
                                }
                                firstRow = false;
                            }
                            else
                            {
                                dt.Rows.Add();
                                int i = 0;
                                foreach (var cell in row.Cells())
                                {
                                    dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                                    i++;
                                }
                            }
                        }
                    }

                    dgvShowStdByFile.DataSource = dt;

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        foreach (DataRow row in dt.Rows)
                        {
                            string insertQuery = "INSERT INTO Student (MaHocSinh, HoTenHocSinh, NgaySinh, NoiSinh, QueQuan, NoiO, TonGiao, DanToc, DiemThiTuyenSinh) " +
                                                 "VALUES (@MaHocSinh, @HoTenHocSinh, @NgaySinh, @NoiSinh, @QueQuan, @NoiO, @TonGiao, @DanToc, @DiemThiTuyenSinh)";
                            using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@MaHocSinh", row["MaHocSinh"]);
                                cmd.Parameters.AddWithValue("@HoTenHocSinh", row["HoTenHocSinh"]);
                                cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(row["NgaySinh"].ToString()));
                                cmd.Parameters.AddWithValue("@NoiSinh", row["NoiSinh"]);
                                cmd.Parameters.AddWithValue("@QueQuan", row["QueQuan"]);
                                cmd.Parameters.AddWithValue("@NoiO", row["NoiO"]);
                                cmd.Parameters.AddWithValue("@TonGiao", row["TonGiao"]);
                                cmd.Parameters.AddWithValue("@DanToc", row["DanToc"]);
                                cmd.Parameters.AddWithValue("@DiemThiTuyenSinh", float.Parse(row["DiemThiTuyenSinh"].ToString()));

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }

        private void AddStudentByFile_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MaHocSinh, HoTenHocSinh, NgaySinh, NoiSinh, QueQuan, NoiO, TonGiao, DanToc, DiemThiTuyenSinh FROM Student";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvShowStdByFile.DataSource = dt;
            }
        }
    }
}
