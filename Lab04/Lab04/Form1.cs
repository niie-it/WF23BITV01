using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtFirstName.Text == "" || TxtLastName.Text == "")
            {
                MessageBox.Show("Please enter both first and last name.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var chuoi = $"{CboTitle.SelectedItem} {TxtFirstName.Text} {TxtLastName.Text}";
            LstItems.Items.Add(chuoi);
            TxtFirstName.Clear(); TxtLastName.Clear();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            var traLoi = MessageBox.Show("Do you want to close the application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traLoi == DialogResult.Yes)
            {
                Application.Exit();//Đóng ứng dụng
                //this.Close();//Đóng form hiện tại
            }
        }
    }
}
