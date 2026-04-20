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
    public partial class FrmLogin : Form
    {
        private FrmMain _frmMain;
        public FrmLogin(FrmMain frm = null)
        {
            InitializeComponent();
            _frmMain = frm;
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            //var sql = $"SELECT TenDangNhap, HoTen, VaiTro, HieuLuc FROM NguoiDung WHERE HieuLuc=1 AND TenDangNhap = '{TxtUsername.Text}' AND MatKhau='{TxtPassword.Text}'";
            //var dtUsers = DataProvider.TruyVan_LayDuLieu(sql);

            var sql = "SELECT TenDangNhap, HoTen, VaiTro, HieuLuc FROM NguoiDung WHERE HieuLuc=1 AND TenDangNhap = @TenDangNhap AND MatKhau=@MatKhau";
            var sqlParams = new[]
            {
                new SqlParameter("@TenDangNhap", TxtUsername.Text),
                new SqlParameter("@MatKhau", TxtPassword.Text)
            };
            var dtUsers = DataProvider.SelectData(sql, CommandType.Text, sqlParams);
            if (dtUsers.Rows.Count > 0)
            {
                var user = dtUsers.Rows[0];
                MessageBox.Show( $"Đăng nhập thành công! Chào {user["HoTen"]}", "Thông báo", MessageBoxButtons.OK);
                _frmMain.TenDangNhap = user["TenDangNhap"].ToString();
                _frmMain.HoTen = user["HoTen"].ToString();
                _frmMain.VaiTro = user["VaiTro"].ToString();
                _frmMain.HienThiMenu();
                this.Close();//đóng form đăng nhập
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.");
            }
        }
    }
}
