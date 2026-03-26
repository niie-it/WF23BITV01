using System.Drawing;
//using System.Windows.Forms;

namespace PaymentApp
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.label1 = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectPayment = new System.Windows.Forms.Button();
            this.lblPayment = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // cboCustomer
            // 
            this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomer.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Items.AddRange(new object[] {
            "Lê Li La",
            "Trần Anh Hùng",
            "Nguyễn Xao Xuyến"});
            this.cboCustomer.Location = new System.Drawing.Point(277, 40);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(582, 56);
            this.cboCustomer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(53, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Payment";
            // 
            // btnSelectPayment
            // 
            this.btnSelectPayment.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSelectPayment.Location = new System.Drawing.Point(286, 175);
            this.btnSelectPayment.Name = "btnSelectPayment";
            this.btnSelectPayment.Size = new System.Drawing.Size(573, 65);
            this.btnSelectPayment.TabIndex = 3;
            this.btnSelectPayment.Text = "Select Payment";
            this.btnSelectPayment.UseVisualStyleBackColor = true;
            this.btnSelectPayment.Click += new System.EventHandler(this.btnSelectPayment_Click);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblPayment.ForeColor = System.Drawing.Color.Red;
            this.lblPayment.Location = new System.Drawing.Point(62, 290);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(124, 48);
            this.lblPayment.TabIndex = 4;
            this.lblPayment.Text = "label3";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSave.Location = new System.Drawing.Point(355, 527);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(204, 84);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnExit.Location = new System.Drawing.Point(622, 527);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(204, 84);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 641);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.btnSelectPayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.label1);
            this.Name = "frmCustomer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectPayment;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;

        #endregion
    }
}

