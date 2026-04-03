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
            var frm = new FrmLogin();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
