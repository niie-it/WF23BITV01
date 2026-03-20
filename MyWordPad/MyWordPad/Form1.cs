using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWordPad
{
    public partial class Form1 : Form
    {
        string fileName = string.Empty;
        bool isChanged = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void XuLyClickOpen(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Text files|*.txt|My Word|*.rtf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName.EndsWith(".txt"))
                {
                    richTextBox1.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                    //richTextBox1.Text = File.ReadAllText(ofd.FileName);
                }
                else
                {
                    richTextBox1.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText);
                }
            }
        }

        private void XuLySaveFile(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                var sfd = new SaveFileDialog();
                sfd.Filter = "Text files|*.txt|My Word|*.rtf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (sfd.FileName.EndsWith(".txt"))
                    {
                        richTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                        //File.WriteAllText(sfd.FileName, richTextBox1.Text);
                    }
                    else
                    {
                        richTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.RichText);
                    }
                }
            }
            else
            {
                if (fileName.EndsWith(".txt"))
                {
                    richTextBox1.SaveFile(fileName, RichTextBoxStreamType.PlainText);
                }
                else
                {
                    richTextBox1.SaveFile(fileName, RichTextBoxStreamType.RichText);
                }
            }
        }
    }
}
