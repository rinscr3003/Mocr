namespace Mocr
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBaiduApi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonLoadClipboardImg = new System.Windows.Forms.Button();
            this.labelClipboardInfo = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoadFileImg = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEditImg = new System.Windows.Forms.Button();
            this.checkBoxAutoDirecton = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonOCRHandwrite = new System.Windows.Forms.RadioButton();
            this.radioButtonOCRHighAccu = new System.Windows.Forms.RadioButton();
            this.radioButtonOCRStandard = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBaiduApi
            // 
            this.buttonBaiduApi.Location = new System.Drawing.Point(515, 83);
            this.buttonBaiduApi.Name = "buttonBaiduApi";
            this.buttonBaiduApi.Size = new System.Drawing.Size(117, 29);
            this.buttonBaiduApi.TabIndex = 6;
            this.buttonBaiduApi.Text = "百度API接入";
            this.buttonBaiduApi.UseVisualStyleBackColor = true;
            this.buttonBaiduApi.Click += new System.EventHandler(this.buttonBaiduApi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonLoadClipboardImg);
            this.groupBox2.Controls.Add(this.labelClipboardInfo);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "来自剪贴板的图像";
            // 
            // buttonLoadClipboardImg
            // 
            this.buttonLoadClipboardImg.Location = new System.Drawing.Point(6, 71);
            this.buttonLoadClipboardImg.Name = "buttonLoadClipboardImg";
            this.buttonLoadClipboardImg.Size = new System.Drawing.Size(188, 23);
            this.buttonLoadClipboardImg.TabIndex = 1;
            this.buttonLoadClipboardImg.Text = "导入剪贴板图像（F7）";
            this.buttonLoadClipboardImg.UseVisualStyleBackColor = true;
            this.buttonLoadClipboardImg.Click += new System.EventHandler(this.buttonLoadClipboardImg_Click);
            // 
            // labelClipboardInfo
            // 
            this.labelClipboardInfo.Location = new System.Drawing.Point(6, 30);
            this.labelClipboardInfo.Name = "labelClipboardInfo";
            this.labelClipboardInfo.Size = new System.Drawing.Size(188, 23);
            this.labelClipboardInfo.TabIndex = 0;
            this.labelClipboardInfo.Text = "剪贴板图像不可用";
            this.labelClipboardInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.buttonLoadFileImg);
            this.groupBox3.Location = new System.Drawing.Point(218, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "来自文件的图像";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "[也可将图像文件拖入本区域]";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.DragDrop += new System.Windows.Forms.DragEventHandler(this.label1_DragDrop);
            this.label1.DragEnter += new System.Windows.Forms.DragEventHandler(this.label1_DragEnter);
            // 
            // buttonLoadFileImg
            // 
            this.buttonLoadFileImg.Location = new System.Drawing.Point(6, 71);
            this.buttonLoadFileImg.Name = "buttonLoadFileImg";
            this.buttonLoadFileImg.Size = new System.Drawing.Size(180, 23);
            this.buttonLoadFileImg.TabIndex = 1;
            this.buttonLoadFileImg.Text = "打开图像文件（F8）";
            this.buttonLoadFileImg.UseVisualStyleBackColor = true;
            this.buttonLoadFileImg.Click += new System.EventHandler(this.buttonLoadFileImg_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(638, 12);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(150, 59);
            this.buttonRun.TabIndex = 7;
            this.buttonRun.Text = "识别\r\n（F5）";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 485);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // buttonEditImg
            // 
            this.buttonEditImg.Location = new System.Drawing.Point(638, 77);
            this.buttonEditImg.Name = "buttonEditImg";
            this.buttonEditImg.Size = new System.Drawing.Size(150, 35);
            this.buttonEditImg.TabIndex = 8;
            this.buttonEditImg.Text = "修剪图像（F6）";
            this.buttonEditImg.UseVisualStyleBackColor = true;
            this.buttonEditImg.Click += new System.EventHandler(this.buttonEditImg_Click);
            // 
            // checkBoxAutoDirecton
            // 
            this.checkBoxAutoDirecton.AutoSize = true;
            this.checkBoxAutoDirecton.Location = new System.Drawing.Point(515, 12);
            this.checkBoxAutoDirecton.Name = "checkBoxAutoDirecton";
            this.checkBoxAutoDirecton.Size = new System.Drawing.Size(99, 21);
            this.checkBoxAutoDirecton.TabIndex = 3;
            this.checkBoxAutoDirecton.Text = "自动识别旋转";
            this.checkBoxAutoDirecton.UseVisualStyleBackColor = true;
            this.checkBoxAutoDirecton.CheckedChanged += new System.EventHandler(this.checkBoxAutoDirecton_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "自动语言",
            "中英混合",
            "英文",
            "日语",
            "韩语",
            "法语",
            "西班牙语",
            "葡萄牙语",
            "德语",
            "意大利语",
            "俄语"});
            this.comboBox1.Location = new System.Drawing.Point(527, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 25);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonOCRHandwrite);
            this.groupBox1.Controls.Add(this.radioButtonOCRHighAccu);
            this.groupBox1.Controls.Add(this.radioButtonOCRStandard);
            this.groupBox1.Location = new System.Drawing.Point(416, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(93, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "识别模式";
            // 
            // radioButtonOCRHandwrite
            // 
            this.radioButtonOCRHandwrite.AutoSize = true;
            this.radioButtonOCRHandwrite.Location = new System.Drawing.Point(6, 73);
            this.radioButtonOCRHandwrite.Name = "radioButtonOCRHandwrite";
            this.radioButtonOCRHandwrite.Size = new System.Drawing.Size(50, 21);
            this.radioButtonOCRHandwrite.TabIndex = 2;
            this.radioButtonOCRHandwrite.TabStop = true;
            this.radioButtonOCRHandwrite.Text = "手写";
            this.radioButtonOCRHandwrite.UseVisualStyleBackColor = true;
            this.radioButtonOCRHandwrite.CheckedChanged += new System.EventHandler(this.radioButtonOCRHandwrite_CheckedChanged);
            // 
            // radioButtonOCRHighAccu
            // 
            this.radioButtonOCRHighAccu.AutoSize = true;
            this.radioButtonOCRHighAccu.Location = new System.Drawing.Point(6, 47);
            this.radioButtonOCRHighAccu.Name = "radioButtonOCRHighAccu";
            this.radioButtonOCRHighAccu.Size = new System.Drawing.Size(62, 21);
            this.radioButtonOCRHighAccu.TabIndex = 1;
            this.radioButtonOCRHighAccu.TabStop = true;
            this.radioButtonOCRHighAccu.Text = "高精度";
            this.radioButtonOCRHighAccu.UseVisualStyleBackColor = true;
            this.radioButtonOCRHighAccu.CheckedChanged += new System.EventHandler(this.radioButtonOCRHighAccu_CheckedChanged);
            // 
            // radioButtonOCRStandard
            // 
            this.radioButtonOCRStandard.AutoSize = true;
            this.radioButtonOCRStandard.Location = new System.Drawing.Point(6, 22);
            this.radioButtonOCRStandard.Name = "radioButtonOCRStandard";
            this.radioButtonOCRStandard.Size = new System.Drawing.Size(50, 21);
            this.radioButtonOCRStandard.TabIndex = 0;
            this.radioButtonOCRStandard.TabStop = true;
            this.radioButtonOCRStandard.Text = "标准";
            this.radioButtonOCRStandard.UseVisualStyleBackColor = true;
            this.radioButtonOCRStandard.CheckedChanged += new System.EventHandler(this.radioButtonOCRStandard_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "标准模式语言";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBoxAutoDirecton);
            this.Controls.Add(this.buttonBaiduApi);
            this.Controls.Add(this.buttonEditImg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 661);
            this.MinimumSize = new System.Drawing.Size(816, 661);
            this.Name = "Form1";
            this.Text = "Mocr";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button buttonRun;
        private PictureBox pictureBox1;
        private Button buttonEditImg;
        private Button buttonBaiduApi;
        private Button buttonLoadClipboardImg;
        private Label labelClipboardInfo;
        private Button buttonLoadFileImg;
        private CheckBox checkBoxAutoDirecton;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private RadioButton radioButtonOCRHandwrite;
        private RadioButton radioButtonOCRHighAccu;
        private RadioButton radioButtonOCRStandard;
        private Label label1;
        private Label label2;
    }
}