using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoiTien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDoiTien_Click(object sender, EventArgs e)
        {
            double soTien;
            if (!double.TryParse(TxtSoTien.Text, out soTien) || soTien < 0)
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
                TxtSoTien.Focus();//đưa dấu nháy về ô nhập liệu
                return;
            }
            else
            {
                double ketQua = soTien * 26000;
                TxtKetQua.Text = ketQua.ToString("N2") + " VND";
            }
        }
    }
}
