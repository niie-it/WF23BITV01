using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentApp
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            cboCustomer.Items.Add("Nguyễn NIIE");
        }

        private void btnSelectPayment_Click(object sender, EventArgs e)
        {
            var form = new frmPayment();
            if (form.ShowDialog() == DialogResult.OK)
            {
                //lblPayment.Text = form.Tag?.ToString() ?? "No payment method selected";
                lblPayment.Text = form.PaymentInfo ?? "No payment method selected";
            }
        }
    }
}
