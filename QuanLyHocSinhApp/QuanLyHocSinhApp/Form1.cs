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

namespace QuanLyHocSinhApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ChuoiKetNoi = @"Data Source=.;Initial Catalog=QLHS;Integrated Security=True;";
        private void Form1_Load(object sender, EventArgs e)
        {
            layDanhSachLop();
        }

        private void layDanhSachLop()
        {
            var sql = "SELECT MaLop, TenLop, SiSo FROM Lop";
            SqlConnection conn = new SqlConnection(ChuoiKetNoi);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            // Hiển thị dữ liệu lên DataGridView từ dataTable
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //validate dữ liệu
            var sql = $"INSERT INTO Lop (MaLop, TenLop, SiSo) VALUES ('{txtMaLop.Text}', N'{txtTenLop.Text}', {txtSiSo.Text})";
            //MessageBox.Show(sql);
            SqlConnection conn = new SqlConnection(ChuoiKetNoi);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm lớp thành công!");
                layDanhSachLop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            conn.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //validate dữ liệu
            var sql = $"UPDATE Lop SET TenLop=N'{txtTenLop.Text}', SiSo={txtSiSo.Text} WHERE MaLop='{txtMaLop.Text}'";
            //MessageBox.Show(sql);
            SqlConnection conn = new SqlConnection(ChuoiKetNoi);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            try
            {
                int soDong = cmd.ExecuteNonQuery();
                if (soDong > 0)
                {
                    MessageBox.Show("Sửa lớp thành công!");
                    layDanhSachLop();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy lớp để sửa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            conn.Close();
        }
    }
}
