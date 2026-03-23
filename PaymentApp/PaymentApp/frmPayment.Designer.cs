using System.Drawing;
using System.Windows.Forms;

namespace PaymentApp
{
    partial class frmPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBillCustomber = new System.Windows.Forms.RadioButton();
            this.radCreditCard = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCreditCardType = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboExpirationMonth = new System.Windows.Forms.ComboBox();
            this.cboExpirationYear = new System.Windows.Forms.ComboBox();
            this.chkDefaultBilling = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radBillCustomber);
            this.groupBox1.Controls.Add(this.radCreditCard);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(61, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(797, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Billing";
            // 
            // radBillCustomber
            // 
            this.radBillCustomber.AutoSize = true;
            this.radBillCustomber.Font = new System.Drawing.Font("Tahoma", 12F);
            this.radBillCustomber.Location = new System.Drawing.Point(442, 60);
            this.radBillCustomber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radBillCustomber.Name = "radBillCustomber";
            this.radBillCustomber.Size = new System.Drawing.Size(289, 52);
            this.radBillCustomber.TabIndex = 0;
            this.radBillCustomber.Text = "Bill Customer";
            this.radBillCustomber.UseVisualStyleBackColor = true;
            // 
            // radCreditCard
            // 
            this.radCreditCard.AutoSize = true;
            this.radCreditCard.Checked = true;
            this.radCreditCard.Font = new System.Drawing.Font("Tahoma", 12F);
            this.radCreditCard.Location = new System.Drawing.Point(40, 60);
            this.radCreditCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radCreditCard.Name = "radCreditCard";
            this.radCreditCard.Size = new System.Drawing.Size(254, 52);
            this.radCreditCard.TabIndex = 0;
            this.radCreditCard.TabStop = true;
            this.radCreditCard.Text = "Credit Card";
            this.radCreditCard.UseVisualStyleBackColor = true;
            this.radCreditCard.CheckedChanged += new System.EventHandler(this.radCreditCard_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(61, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Credit card type";
            // 
            // lstCreditCardType
            // 
            this.lstCreditCardType.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lstCreditCardType.FormattingEnabled = true;
            this.lstCreditCardType.ItemHeight = 48;
            this.lstCreditCardType.Items.AddRange(new object[] {
            "VISA",
            "Master Card",
            "American Express"});
            this.lstCreditCardType.Location = new System.Drawing.Point(365, 234);
            this.lstCreditCardType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstCreditCardType.Name = "lstCreditCardType";
            this.lstCreditCardType.Size = new System.Drawing.Size(493, 148);
            this.lstCreditCardType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(68, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "Card number";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtCardNumber.Location = new System.Drawing.Point(365, 431);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(493, 56);
            this.txtCardNumber.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(68, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 48);
            this.label3.TabIndex = 5;
            this.label3.Text = "Expiration Date";
            // 
            // cboExpirationMonth
            // 
            this.cboExpirationMonth.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cboExpirationMonth.FormattingEnabled = true;
            this.cboExpirationMonth.Items.AddRange(new object[] {
            "Select month",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cboExpirationMonth.Location = new System.Drawing.Point(365, 522);
            this.cboExpirationMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboExpirationMonth.Name = "cboExpirationMonth";
            this.cboExpirationMonth.Size = new System.Drawing.Size(205, 56);
            this.cboExpirationMonth.TabIndex = 6;
            // 
            // cboExpirationYear
            // 
            this.cboExpirationYear.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cboExpirationYear.FormattingEnabled = true;
            this.cboExpirationYear.Location = new System.Drawing.Point(653, 522);
            this.cboExpirationYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboExpirationYear.Name = "cboExpirationYear";
            this.cboExpirationYear.Size = new System.Drawing.Size(205, 56);
            this.cboExpirationYear.TabIndex = 6;
            // 
            // chkDefaultBilling
            // 
            this.chkDefaultBilling.AutoSize = true;
            this.chkDefaultBilling.Checked = true;
            this.chkDefaultBilling.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDefaultBilling.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chkDefaultBilling.Location = new System.Drawing.Point(73, 636);
            this.chkDefaultBilling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkDefaultBilling.Name = "chkDefaultBilling";
            this.chkDefaultBilling.Size = new System.Drawing.Size(562, 52);
            this.chkDefaultBilling.TabIndex = 7;
            this.chkDefaultBilling.Text = "Set as default billing method";
            this.chkDefaultBilling.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnOK.Location = new System.Drawing.Point(365, 698);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(205, 60);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnCancel.Location = new System.Drawing.Point(653, 698);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(205, 60);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 798);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkDefaultBilling);
            this.Controls.Add(this.cboExpirationYear);
            this.Controls.Add(this.cboExpirationMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstCreditCardType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPayment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radBillCustomber;
        private RadioButton radCreditCard;
        private Label label1;
        private ListBox lstCreditCardType;
        private Label label2;
        private TextBox txtCardNumber;
        private Label label3;
        private ComboBox cboExpirationMonth;
        private ComboBox cboExpirationYear;
        private CheckBox chkDefaultBilling;
        private Button btnOK;
        private Button btnCancel;
    }
}