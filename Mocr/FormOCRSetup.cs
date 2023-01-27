using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mocr
{
    public partial class FormOCRSetup : Form
    {
        public FormOCRSetup()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe","https://console.bce.baidu.com/ai/#/ai/ocr/app/list");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BAIDU_API_KEY = textBoxApiKey.Text.Trim();
            Properties.Settings.Default.BAIDU_SECRET_KEY = textBoxSecKey.Text.Trim();
            Properties.Settings.Default.Save();
            //var client = new Baidu.Aip.Ocr.Ocr(Properties.Settings.Default.BAIDU_API_KEY, Properties.Settings.Default.BAIDU_SECRET_KEY);
            //client.Timeout = 60000;
            MessageBox.Show("API设置已保存。", "OCR设置");
        }

        private void FormOCRSetup_Load(object sender, EventArgs e)
        {
            textBoxApiKey.Text = Properties.Settings.Default.BAIDU_API_KEY;
            textBoxSecKey.Text = Properties.Settings.Default.BAIDU_SECRET_KEY;
        }
    }
}
