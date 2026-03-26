using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Point startPoint;
        Color BorderColor = Color.Blue, FillColor = Color.Red;
        private void panelBanVe_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnBorderColor.BackColor = BorderColor;
            btnFillColor.BackColor = FillColor;
        }

        private void btnBorderColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                BorderColor = cd.Color;
                btnBorderColor.BackColor = BorderColor;
            }
        }

        private void btnFillColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                FillColor = cd.Color;
                btnFillColor.BackColor = FillColor;
            }
        }

        private void panelBanVe_MouseUp(object sender, MouseEventArgs e)
        {
            Pen pen = new Pen(BorderColor, (int)nudBorderSize.Value);
            SolidBrush brush = new SolidBrush(FillColor);
            var width = Math.Abs(e.X - startPoint.X);
            var height = Math.Abs(e.Y - startPoint.Y);
            var x = Math.Min(e.X, startPoint.X);
            var y = Math.Min(e.Y, startPoint.Y);
            var g = panelBanVe.CreateGraphics();//vẽ trên panel
            switch (cboType.SelectedIndex)
            {
                case 0://Line
                    g.DrawLine(pen, startPoint, e.Location);
                    break;
                case 1://DrawRectangle
                    
                    g.DrawRectangle(pen, x, y, width, height);
                    break;
                    // Draw Ellipse
                    // Fill Rectangle
                case 4: //Fill Ellipse
                    g.FillEllipse(brush, x, y, width, height);
                    break;
//Draw String
//Draw Triangle
//Draw Diamond
            }
        }
    }
}
