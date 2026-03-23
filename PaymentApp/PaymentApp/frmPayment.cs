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
    public partial class frmPayment : Form
    {
        public string PaymentInfo { get; set; }

        public frmPayment()
        {
            InitializeComponent();
            
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            //set năm hết hạn
            var year = DateTime.Now.Year;
            for (int i = 0; i < 6; i++)
            {
                cboExpirationYear.Items.Add(year + i);
            }

            this.CancelButton = btnCancel;
        }

        private void SaveData()
        {
            string msg = "";
            if (radCreditCard.Checked)
            {
                msg += "Charge to credit card." + "\n\n";
                msg += "Card type: " + lstCreditCardType.Text +
                       "\n";
                msg += "Card number: " + txtCardNumber.Text +
                       "\n";
                msg += "Expiration date: "
                    + cboExpirationMonth.Text + "/"
                    + cboExpirationYear.Text + "\n";
            }
            else
            {
                msg += "Send bill to customer." + "\n\n";
            }
            bool isDefaultBilling = chkDefaultBilling.Checked;
            msg += "Default billing: " + isDefaultBilling;
            //Tag = msg;
            PaymentInfo = msg;
            DialogResult = DialogResult.OK;
        }

        private void EnableControls(bool value = true)
        {
            lstCreditCardType.Enabled = value;
            txtCardNumber.Enabled = value;
            cboExpirationMonth.Enabled = value;
            cboExpirationYear.Enabled = value;
        }

        private void radCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            if (radCreditCard.Checked)
            {
                EnableControls();
            }
            else
            {
                EnableControls(false);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
