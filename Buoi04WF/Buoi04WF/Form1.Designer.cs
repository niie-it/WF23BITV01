namespace Buoi04WF
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
            this.TxtHoTen = new System.Windows.Forms.TextBox();
            this.TxtKetQua = new System.Windows.Forms.TextBox();
            this.BtnChao = new System.Windows.Forms.Button();
            this.LblChuoi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtHoTen
            // 
            this.TxtHoTen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHoTen.ForeColor = System.Drawing.Color.Red;
            this.TxtHoTen.Location = new System.Drawing.Point(226, 33);
            this.TxtHoTen.Name = "TxtHoTen";
            this.TxtHoTen.Size = new System.Drawing.Size(442, 53);
            this.TxtHoTen.TabIndex = 1;
            this.TxtHoTen.TextChanged += new System.EventHandler(this.TxtHoTen_TextChanged);
            this.TxtHoTen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtHoTen_KeyUp);
            // 
            // TxtKetQua
            // 
            this.TxtKetQua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtKetQua.ForeColor = System.Drawing.Color.Blue;
            this.TxtKetQua.Location = new System.Drawing.Point(20, 204);
            this.TxtKetQua.Name = "TxtKetQua";
            this.TxtKetQua.Size = new System.Drawing.Size(834, 53);
            this.TxtKetQua.TabIndex = 2;
            // 
            // BtnChao
            // 
            this.BtnChao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChao.ForeColor = System.Drawing.Color.Red;
            this.BtnChao.Location = new System.Drawing.Point(702, 33);
            this.BtnChao.Name = "BtnChao";
            this.BtnChao.Size = new System.Drawing.Size(165, 78);
            this.BtnChao.TabIndex = 3;
            this.BtnChao.Text = "Chào";
            this.BtnChao.UseVisualStyleBackColor = true;
            this.BtnChao.Click += new System.EventHandler(this.BtnChao_Click);
            // 
            // LblChuoi
            // 
            this.LblChuoi.AutoSize = true;
            this.LblChuoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChuoi.ForeColor = System.Drawing.Color.Blue;
            this.LblChuoi.Location = new System.Drawing.Point(218, 122);
            this.LblChuoi.Name = "LblChuoi";
            this.LblChuoi.Size = new System.Drawing.Size(124, 45);
            this.LblChuoi.TabIndex = 4;
            this.LblChuoi.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 299);
            this.Controls.Add(this.LblChuoi);
            this.Controls.Add(this.BtnChao);
            this.Controls.Add(this.TxtKetQua);
            this.Controls.Add(this.TxtHoTen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bài tập đầu tiên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtHoTen;
        private System.Windows.Forms.TextBox TxtKetQua;
        private System.Windows.Forms.Button BtnChao;
        private System.Windows.Forms.Label LblChuoi;
    }
}

