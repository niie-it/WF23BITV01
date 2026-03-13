namespace Lab04
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
            this.CboTitle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LstItems = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // CboTitle
            // 
            this.CboTitle.FormattingEnabled = true;
            this.CboTitle.Items.AddRange(new object[] {
            "Mr.",
            "Miss.",
            "Mrs.",
            "Sir.",
            "Dr."});
            this.CboTitle.Location = new System.Drawing.Point(31, 63);
            this.CboTitle.Name = "CboTitle";
            this.CboTitle.Size = new System.Drawing.Size(121, 39);
            this.CboTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "First name";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(230, 63);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(283, 38);
            this.TxtFirstName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last name";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(540, 64);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(198, 38);
            this.TxtLastName.TabIndex = 5;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(31, 125);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(171, 53);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(324, 125);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(171, 53);
            this.BtnReset.TabIndex = 6;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(617, 125);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(171, 53);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LstItems
            // 
            this.LstItems.FormattingEnabled = true;
            this.LstItems.ItemHeight = 31;
            this.LstItems.Location = new System.Drawing.Point(31, 220);
            this.LstItems.Name = "LstItems";
            this.LstItems.Size = new System.Drawing.Size(757, 221);
            this.LstItems.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LstItems);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboTitle);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.ListBox LstItems;
    }
}

