using Baidu.Aip;
using System.Runtime.ConstrainedExecution;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Drawing.Imaging;
using Newtonsoft.Json.Linq;
using System.Text;

namespace Mocr
{
    public partial class Form1 : Form
    {
        IntPtr nextClipboardViewer;
        public Form1()
        {
            InitializeComponent();
            nextClipboardViewer = (IntPtr)SetClipboardViewer((int)Handle);
        }

        #region WindowsAPI
        [DllImport("User32.dll")]
        protected static extern int SetClipboardViewer(int hWndNewViewer);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
        #endregion

        protected override void WndProc(ref Message m)
        {
            const int WM_DRAWCLIPBOARD = 0x308;
            const int WM_CHANGECBCHAIN = 0x030D;

            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    ClipboardUpdate();
                    SendMessage(nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                    break;
                case WM_CHANGECBCHAIN:
                    if (m.WParam == nextClipboardViewer)
                        nextClipboardViewer = m.LParam;
                    else
                        SendMessage(nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        Image? TryGetClipboardImage()
        {
            Image? bmp = null;
            try
            {
                if (Clipboard.ContainsImage())
                {
                    bmp = Clipboard.GetImage();
                    labelClipboardInfo.Text = "有图像可用";
                }
                else
                {
                    labelClipboardInfo.Text = "剪贴板图像不可用";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return bmp;
        }

        void ClipboardUpdate()
        {
            try
            {
                if (Clipboard.ContainsImage())
                {
                    labelClipboardInfo.Text = "有图像可用";
                }
                else
                {
                    labelClipboardInfo.Text = "剪贴板图像不可用";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void buttonBaiduApi_Click(object sender, EventArgs e)
        {
            FormOCRSetup frm = new FormOCRSetup();
            frm.ShowDialog();
            Properties.Settings.Default.Reload();
        }

        Image? currentImage = null;

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            // 双击进入图片编辑
            if (currentImage == null) { return; }
            buttonEditImg_Click(this, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            switch (Properties.Settings.Default.OCR_MODE)
            {
                case "STANDARD":
                    radioButtonOCRStandard.Checked = true;
                    break;

                case "HIGHACCU":
                    radioButtonOCRHighAccu.Checked = true;
                    break;

                case "HANDWRITE":
                    radioButtonOCRHandwrite.Checked = true;
                    break;

                default:
                    Properties.Settings.Default.OCR_MODE = "STANDARD";
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();
                    radioButtonOCRStandard.Checked = true;
                    break;
            }
            checkBoxAutoDirecton.CheckState = (Properties.Settings.Default.OCR_AUTODIRECTION == true) ? CheckState.Checked : CheckState.Unchecked;
            if (Properties.Settings.Default.OCR_LANGID < 0 || Properties.Settings.Default.OCR_LANGID > 10)
            {
                Properties.Settings.Default.OCR_LANGID = 0;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
            }
            comboBox1.SelectedIndex = Properties.Settings.Default.OCR_LANGID;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChangeClipboardChain(Handle, nextClipboardViewer);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.OCR_LANGID >= 0 && Properties.Settings.Default.OCR_LANGID <= 10)
            {
                Properties.Settings.Default.OCR_LANGID = comboBox1.SelectedIndex;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
            }
        }

        private void radioButtonOCRStandard_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.OCR_MODE = "STANDARD";
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        private void radioButtonOCRHighAccu_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.OCR_MODE = "HIGHACCU";
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        private void radioButtonOCRHandwrite_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.OCR_MODE = "HANDWRITE";
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        private void checkBoxAutoDirecton_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.OCR_AUTODIRECTION = checkBoxAutoDirecton.Checked;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        private void buttonLoadClipboardImg_Click(object sender, EventArgs e)
        {
            currentImage = TryGetClipboardImage();
            if (currentImage == null)
            {
                MessageBox.Show("从剪贴板载入图像失败。", "Mocr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pictureBox1.Image = currentImage;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (running) return;
            if (e.Modifiers == Keys.None && e.KeyCode == Keys.F7)
            { 
                buttonLoadClipboardImg_Click(this, null);
                e.SuppressKeyPress = false;
            }
            else if (e.Modifiers == Keys.None && e.KeyCode == Keys.F8)
            {
                buttonLoadFileImg_Click(this, null);
                e.SuppressKeyPress = false;
            }
            else if (e.Modifiers == Keys.None && e.KeyCode == Keys.F5)
            {
                buttonRun_Click(this, null);
                e.SuppressKeyPress = false;
            }
            else if (e.Modifiers == Keys.None && e.KeyCode == Keys.F6)
            {
                buttonEditImg_Click(this, null);
                e.SuppressKeyPress = false;
            }
        }

        private void buttonLoadFileImg_Click(object sender, EventArgs e)
        {

        }

        string[] LANGID_STR =
        {
            "AUTO?",
            "CHN_ENG",
            "ENG",
            "JAP",
            "KOR",
            "FRE",
            "SPA",
            "POR",
            "GER",
            "ITA",
            "RUS"
        };

        bool running=false;

        private void buttonRun_Click(object sender, EventArgs e)
        {
            var client = new Baidu.Aip.Ocr.Ocr(Properties.Settings.Default.BAIDU_API_KEY, Properties.Settings.Default.BAIDU_SECRET_KEY);
            client.Timeout = 60000;  // 修改超时时间

            if (currentImage == null)
            {
                MessageBox.Show("没有载入图像。", "Mocr", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            running= true;
            buttonRun.Enabled = false;

            MemoryStream memoryStream = new MemoryStream();
            currentImage.Save(memoryStream, ImageFormat.Png);
            byte[] data = memoryStream.ToArray();
            memoryStream.Close();

            JObject? result = null;
            try
            {
                if (Properties.Settings.Default.OCR_MODE == "STANDARD")
                {
                    var options = new Dictionary<string, object>{
                    {"detect_direction", (Properties.Settings.Default.OCR_AUTODIRECTION==true)?"true":"false"},
                    {"detect_language", "true"},
                    {"probability", "false"},
                    {"paragraph", "false"}
                };
                    if (Properties.Settings.Default.OCR_LANGID != 0)
                    {
                        options.Add("language_type", LANGID_STR[Properties.Settings.Default.OCR_LANGID]);
                        options["detect_language"] = "false";
                    }
                    result = client.GeneralBasic(data, options);
                    Console.WriteLine(result);
                }
                else if (Properties.Settings.Default.OCR_MODE == "HIGHACCU")
                {
                    var options = new Dictionary<string, object>{
                    {"detect_direction", (Properties.Settings.Default.OCR_AUTODIRECTION==true)?"true":"false"},
                    {"probability", "false"},
                };
                    result = client.AccurateBasic(data, options);
                    Console.WriteLine(result);
                }
                else if (Properties.Settings.Default.OCR_MODE == "HANDWRITE")
                {
                    var options = new Dictionary<string, object>{
                    {"detect_direction", (Properties.Settings.Default.OCR_AUTODIRECTION==true)?"true":"false"},
                    {"probability", "false"},
                    {"recognize_granularity", "big"}
                };
                    result = client.Handwriting(data, options);
                    Console.WriteLine(result);
                }
                else { return; }
                string? errcode = (string?)result.GetValue("error_code");
                string? errmsg = (string?)result.GetValue("error_msg");
                if (errcode != null)
                { // error
                    MessageBox.Show("百度API报告了错误：\n错误号：" + errcode + "\n错误说明：" + errmsg, "Mocr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    foreach (var item in result["words_result"].Values())
                    {
                        var line = item.Value<JProperty>().Value.ToString();
                        stringBuilder.AppendLine(line);
                    }
                    string result_lines = stringBuilder.ToString();
                    stringBuilder.Clear();
                    FormText form = new FormText();
                    form.instr = result_lines;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生异常：" + ex.Message, "Mocr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                running= false;
                buttonRun.Enabled = true;
            }
        }

        private void buttonEditImg_Click(object sender, EventArgs e)
        {

        }

        void LoadImgFromFile(string filename)
        {

        }

        private void label1_DragDrop(object sender, DragEventArgs e)
        {
            string path = (e.Data.GetData(DataFormats.FileDrop) as Array).GetValue(0).ToString();
            LoadImgFromFile(path);
        }

        private void label1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;                                                              //重要代码：表明是所有类型的数据，比如文件路径
            else
                e.Effect = DragDropEffects.None;

        }
    }
}