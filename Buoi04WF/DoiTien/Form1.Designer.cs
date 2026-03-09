namespace DoiTien
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSoTien = new System.Windows.Forms.TextBox();
            this.BtnDoiTien = new System.Windows.Forms.Button();
            this.TxtKetQua = new System.Windows.Forms.TextBox();
            this.LblKetQua = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tiền";
            // 
            // TxtSoTien
            // 
            this.TxtSoTien.Font = new System.Drawing.Font("Tahoma", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSoTien.Location = new System.Drawing.Point(402, 73);
            this.TxtSoTien.Name = "TxtSoTien";
            this.TxtSoTien.Size = new System.Drawing.Size(423, 64);
            this.TxtSoTien.TabIndex = 1;
            // 
            // BtnDoiTien
            // 
            this.BtnDoiTien.Font = new System.Drawing.Font("Tahoma", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDoiTien.Location = new System.Drawing.Point(862, 70);
            this.BtnDoiTien.Name = "BtnDoiTien";
            this.BtnDoiTien.Size = new System.Drawing.Size(270, 67);
            this.BtnDoiTien.TabIndex = 2;
            this.BtnDoiTien.Text = "Đổi tiền";
            this.BtnDoiTien.UseVisualStyleBackColor = true;
            this.BtnDoiTien.Click += new System.EventHandler(this.BtnDoiTien_Click);
            // 
            // TxtKetQua
            // 
            this.TxtKetQua.Enabled = false;
            this.TxtKetQua.Font = new System.Drawing.Font("Tahoma", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtKetQua.Location = new System.Drawing.Point(403, 319);
            this.TxtKetQua.Name = "TxtKetQua";
            this.TxtKetQua.Size = new System.Drawing.Size(422, 64);
            this.TxtKetQua.TabIndex = 3;
            // 
            // LblKetQua
            // 
            this.LblKetQua.AutoSize = true;
            this.LblKetQua.Font = new System.Drawing.Font("Tahoma", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKetQua.Location = new System.Drawing.Point(155, 326);
            this.LblKetQua.Name = "LblKetQua";
            this.LblKetQua.Size = new System.Drawing.Size(149, 57);
            this.LblKetQua.TabIndex = 4;
            this.LblKetQua.Text = "label2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "VND",
            "AUD",
            "HKD",
            "CAD",
            "SGD"});
            this.comboBox1.Location = new System.Drawing.Point(403, 181);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 39);
            this.comboBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 57);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sang";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 714);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LblKetQua);
            this.Controls.Add(this.TxtKetQua);
            this.Controls.Add(this.BtnDoiTien);
            this.Controls.Add(this.TxtSoTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSoTien;
        private System.Windows.Forms.Button BtnDoiTien;
        private System.Windows.Forms.TextBox TxtKetQua;
        private System.Windows.Forms.Label LblKetQua;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}

