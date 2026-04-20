using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07QLHS
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDongHo.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss tt");
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmLogin(this);
            frm.MdiParent = this;
            frm.Show();
        }

        private void lỚPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmQLLop();
            frm.MdiParent = this;
            frm.Show();
        }

        public string TenDangNhap { get; set; }
        public string HoTen { get; set; }
        public string VaiTro { get; set; }

        public void HienThiMenu()
        {
            //hiển thị menu theo vai trò
            if (VaiTro == "Admin")
            {
                mnuDanhMucLop.Enabled = true;
                mnuHoSoHocSinh.Enabled = true;
            }
            else if (VaiTro == "User")
            {
                mnuDanhMucLop.Enabled = false;
                mnuHoSoHocSinh.Enabled = true;
            }
            lblTenDangNhapMain.Text = $"Xin chào {HoTen} ({VaiTro})";
        }
        public void Logout()
        {
            CamThaoTacMenu();
            //đóng màn hình con đang mở
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            //reset thông tin người dùng
            TenDangNhap = null;HoTen = null;VaiTro = null;
            lblTenDangNhapMain.Text = "Bạn chưa đăng nhập!";
        }

        private void CamThaoTacMenu()
        {
            //cấm thao tác trên chức năng cần đăng nhập
            mnuDanhMucLop.Enabled = false;
            mnuHoSoHocSinh.Enabled = false;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Logout();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout();
        }
    }
}
