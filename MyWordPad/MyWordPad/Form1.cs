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
                    fileName = sfd.FileName;
                    this.Text = "Document: " + fileName;
                    saveDataToFile(fileName, richTextBox1);
                }
            }
            else
            {
                saveDataToFile(fileName, richTextBox1);
            }
        }

        private void saveDataToFile(string fileName, RichTextBox richTextBox1)
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

        private void selectFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fd = new FontDialog();
            fd.ShowColor = true;
            fd.ShowApply = true;
            fd.Apply += new EventHandler(XuLyApplyFont);
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font;
                richTextBox1.SelectionColor = fd.Color;
            }
        }

        private void XuLyApplyFont(object sender, EventArgs e)
        {
            var fd = sender as FontDialog;
            richTextBox1.SelectionFont = fd.Font;
            richTextBox1.SelectionColor = fd.Color;
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = cd.Color;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Text files|*.txt|My Word|*.rtf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fileName = sfd.FileName;
                this.Text = "Document: " + fileName;
                saveDataToFile(fileName, richTextBox1);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileName = string.Empty;
            this.Text = "New document";
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
    }
}
