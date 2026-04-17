using OfficeOpenXml;
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

namespace Lab07QLHS
{
    public partial class FrmQLLop : Form
    {
        public FrmQLLop()
        {
            InitializeComponent();
        }

        private void FrmQLLop_Load(object sender, EventArgs e)
        {
            loadDsLop();
        }
        private void loadDsLop()
        {
            var dtLop = DataProvider.TruyVan_LayDuLieu("SELECT MaLop, TenLop, SiSo FROM LOP");
            lvLop.Items.Clear();//xóa dữ liệu cũ
            foreach (DataRow dr in dtLop.Rows)
            {
                var item = new ListViewItem(dr["MaLop"].ToString());
                item.Tag = dr["MaLop"].ToString();
                item.SubItems.Add(dr["TenLop"].ToString());
                item.SubItems.Add(dr["SiSo"].ToString());
                lvLop.Items.Add(item);
            }
        }
        private void cboListType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvLop.View = (View)cboListType.SelectedIndex;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                var sql = $"INSERT INTO Lop(MaLop, TenLop, SiSo) VALUES('{txtMaLop.Text}', N'{txtTenLop.Text}', '{txtSiSo.Text}')";
                //MessageBox.Show(sql);
                if (DataProvider.TruyVan_XuLy(sql))
                {
                    MessageBox.Show("Thêm mới thành công");
                    loadDsLop();
                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool validateData()
        {
            if (string.IsNullOrEmpty(txtMaLop.Text))
            {
                MessageBox.Show("Mã lớp không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLop.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenLop.Text))
            {
                MessageBox.Show("Tên lớp không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.Focus();
                return false;
            }
            if (!int.TryParse(txtSiSo.Text, out int siSo) || siSo < 1)
            {
                MessageBox.Show("Sĩ số phải là một số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSiSo.Focus();
                return false;
            }
            return true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                var sql = "UPDATE Lop SET TenLop = @TenLop, SiSo = @SiSo WHERE MaLop = @MaLop";
                var parameters = new SqlParameter[3];
                parameters[0] = new SqlParameter("@TenLop", txtTenLop.Text);
                parameters[1] = new SqlParameter("@SiSo", SqlDbType.Int);
                parameters[1].Value = int.Parse(txtSiSo.Text);
                parameters[2] = new SqlParameter("@MaLop", txtMaLop.Text);

                if (DataProvider.ExcuteNonQuery(sql, CommandType.Text, parameters) > 0)
                {
                    MessageBox.Show("Cập nhật thành công");
                    loadDsLop();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExcelPackage.License.SetNonCommercialPersonal("My Name");
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("DanhSachLop");
                // Thêm tiêu đề cột
                worksheet.Cells[1, 1].Value = "Mã Lớp";
                worksheet.Cells[1, 2].Value = "Tên Lớp";
                worksheet.Cells[1, 3].Value = "Sĩ Số";
                // Thêm dữ liệu từ ListView
                int row = 2; // Bắt đầu từ hàng thứ 2 (hàng 1 là tiêu đề)
                var dtLop = DataProvider.TruyVan_LayDuLieu("SELECT MaLop, TenLop, SiSo FROM LOP");
                foreach (DataRow item in dtLop.Rows)
                {
                    worksheet.Cells[row, 1].Value = item["MaLop"].ToString();
                    worksheet.Cells[row, 2].Value = item["TenLop"].ToString();
                    worksheet.Cells[row, 3].Value = item["SiSo"].ToString();
                    row++;
                }
                // Lưu file Excel
                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Save an Excel File"
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    package.SaveAs(new System.IO.FileInfo(saveFileDialog.FileName));
                    MessageBox.Show("Xuất Excel thành công!");
                }
            }

        }
    }
}
