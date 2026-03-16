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
    public partial class frmXuat : Form
    {
        public int SoDong { get; set; }
        public int SoCot { get; set; }
        public frmXuat()
        {
            InitializeComponent();
        }

        const int CellSize = 50;
        const int Spacing = 20;
        private void frmXuat_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    var btn = new Button();
                    btn.Size = new Size(CellSize, CellSize);
                    btn.Left = Spacing + j * (CellSize + Spacing);
                    btn.Top = Spacing + i * (CellSize + Spacing);
                    btn.Text = $"({i},{j})";
                    btn.Click += new EventHandler(XuLyClickButton);
                    btn.MouseHover += new EventHandler(XuLyHoverChuot);
                    this.Controls.Add(btn);
                }
            }

            //ép kích thước form để vừa với số lượng nút
            this.Width = Spacing + SoCot * (CellSize + Spacing) + 15;
            this.Height = Spacing + SoDong * (CellSize + Spacing) + 30;
        }

        private void XuLyClickButton(object sender, EventArgs e)
        {
            MessageBox.Show($"Bạn đã click vào nút {((Button)sender).Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void XuLyHoverChuot(object sender, EventArgs e)
        {
            this.Text = $"Bạn đang hover chuột vào nút {((Button)sender).Text}";
        }
    }
}
