using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageConverter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void open(object sender, EventArgs e)
        {
            if (opnDialog.ShowDialog() == DialogResult.OK)
            {
                var img = Image.FromFile(opnDialog.FileName);
                if (img.Width != 1280 || img.Height != 720)
                {
                    MessageBox.Show("The image must be sized 1280x720.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                picPreview.Image = img;
            }
        }

        private void convert(object sender, EventArgs e)
        {
            if (picPreview.Image == null)
            {
                MessageBox.Show("An image must be opened first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            var img = (Image)picPreview.Image.Clone();
            img.RotateFlip(RotateFlipType.RotateNoneFlipX);

            var bmp = new Bitmap(img);
            var file = new Byte[8 + (img.Height * img.Width * 4) + (img.Width * 192)];
            var i = 8;

            file[0] = 0x30;
            file[1] = 0x30;
            file[2] = 0x39;
            file[3] = 0x32;
            file[4] = 0x31;
            file[5] = 0x36;
            file[6] = 0x30;
            file[7] = 0x30;

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    var pixel = bmp.GetPixel(x, y);
                    file[i] = 0x00;
                    file[i + 1] = pixel.R;
                    file[i + 2] = pixel.G;
                    file[i + 3] = pixel.B;
                    i = i + 4;
                }

                for (int y = 0; y < 192; y++)
                {
                    file[i] = 0x00;
                    i++;
                }
            }

            if (savDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(savDialog.FileName, file);

                picPreview.Image = null;
            }
        }
    }
}
