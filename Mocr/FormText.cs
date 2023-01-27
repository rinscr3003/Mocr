using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mocr
{
    public partial class FormText : Form
    {
        public FormText()
        {
            InitializeComponent();
        }

        public string? instr;

        private void FormText_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = instr;
        }

        private void buttonCopyAll_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
        }

        private void buttonCopyAllClose_Click(object sender, EventArgs e)
        {
            buttonCopyAll_Click(sender, e);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string buf = richTextBox1.Text.Trim();
            buf=buf.Replace(" ", "");
            richTextBox1.Text=buf;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string buf = richTextBox1.Text.Trim();
            buf = buf.Replace("\r\n", "");
            buf = buf.Replace("\n", "");
            richTextBox1.Text = buf;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string buf = richTextBox1.Text.Trim();
            buf = buf.Replace("!", "！");
            buf = buf.Replace("?", "？");
            buf = buf.Replace(",", "，");
            buf = buf.Replace(":", "：");
            buf = buf.Replace(";", "；");
            richTextBox1.Text = buf;
        }
    }
}
