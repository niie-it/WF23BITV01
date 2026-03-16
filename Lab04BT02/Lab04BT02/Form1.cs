using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04BT02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            int soDong, soCot;
            if (!int.TryParse(txtSoDong.Text, out soDong) || soDong < 1)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho số dòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoDong.Focus();
                return;
            }
            if (!int.TryParse(txtSoCot.Text, out soCot) || soCot < 1)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho số cột.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoCot.Focus();
                return;
            }

            frmXuat f = new frmXuat();
            f.SoCot = soCot; f.SoDong = soDong;

            //f.ShowDialog();// Hiển thị form frmXuat dưới dạng dialog (phải đóng form mới có thể tiếp tục tương tác với form hiện tại)
            f.Show();
        }
    }
}
