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
    public partial class FormEditImg : Form
    {
        public FormEditImg()
        {
            InitializeComponent();
        }

        public Image? inimg;
        double ratio;
        private void FormEditImg_Load(object sender, EventArgs e)
        {
            if (inimg != null)
            {
                ratio = (double)pictureBox1.Width / inimg.Width;
                Size newSize = new Size(pictureBox1.Width, (int)Math.Round(ratio * inimg.Height + 95));
                this.Size = newSize;
                pictureBox1.Image = inimg;
            }
        }

        private void FormEditImg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.None && e.KeyCode == Keys.F2)
            {
                buttonConfirm_Click(this, null);
                e.SuppressKeyPress = false;
            }
            else if (e.Modifiers == Keys.None && e.KeyCode == Keys.F3)
            {
                buttonSelectZone_Click(this, null);
                e.SuppressKeyPress = false;
            }
            else if (e.Modifiers == Keys.None && e.KeyCode == Keys.F4)
            {
                buttonCrop_Click(this, null);
                e.SuppressKeyPress = false;
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            inimg = null;
            this.Close();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (inimg != null)
            {

            }
        }


        private void buttonSelectZone_Click(object sender, EventArgs e)
        {

        }

        private void buttonCrop_Click(object sender, EventArgs e)
        {

        }
    }
}
