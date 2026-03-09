using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi04WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnChao_Click(object sender, EventArgs e)
        {
            TxtKetQua.Text = "Xin chào " + TxtHoTen.Text;
        }

        private void TxtHoTen_KeyUp(object sender, KeyEventArgs e)
        {
            LblChuoi.Text = TxtHoTen.Text;
        }

        private void TxtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
