using System.Windows.Forms;

namespace Image_Processing_Activity
{
    public partial class Form1 : Form
    {
        Bitmap loaded, processed;
        Bitmap bg, fg;
        int mode = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void dipToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 0;
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Bitmap opened_file = new Bitmap(openFileDialog1.FileName);
            switch (mode)
            {
                case 0:
                    loaded = opened_file;
                    pictureBox1.Image = loaded;
                    break;
                case 1:
                    bg = opened_file;
                    pbBackground.Image = bg;
                    break;
                case 2:
                    fg = opened_file;
                    pbForeground.Image = fg;
                    break;
            }
        }

        private void basicCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    processed.SetPixel(x, y, pixel);
                }
            }
            pictureBox2.Image = loaded;
        }

        private void greyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            int ave;
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    ave = (int)(pixel.R + pixel.G + pixel.B) / 3;
                    Color gray = Color.FromArgb(ave, ave, ave);
                    processed.SetPixel(x, y, gray);
                }
            }
            pictureBox2.Image = processed;
        }

        private void colorInversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    Color inv = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    processed.SetPixel(x, y, inv);
                }
            }
            pictureBox2.Image = processed;
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap original = new Bitmap(loaded.Width, loaded.Height);
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    Color pixel = loaded.GetPixel(x, y);
                    original.SetPixel(x, y, pixel);
                }
            }
            Bitmap temp = original;
            original = loaded;
            loaded = temp;
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    Color sample = loaded.GetPixel(x, y);
                    byte greydata = (byte)((sample.R + sample.G + sample.B) / 3);
                    Color grey = Color.FromArgb(greydata, greydata, greydata);
                    loaded.SetPixel(x, y, grey);
                }
            }
            int[] histdata = new int[256];
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    Color sample = loaded.GetPixel((int)x, (int)y);
                    ++histdata[sample.R];
                }
            }
            processed = new Bitmap(256, 800);
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < 800; y++)
                {
                    processed.SetPixel(x, y, Color.White);
                }
            }
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < Math.Min(histdata[x] / 5, processed.Height - 1); y++)
                {
                    processed.SetPixel(x, (processed.Height - 1) - y, Color.Black);
                }
            }
            pictureBox2.Image = processed;
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    int sr = (int)Math.Min(255, 0.40 * pixel.R + 0.77 * pixel.G + 0.19 * pixel.B);
                    int sg = (int)Math.Min(255, 0.35 * pixel.R + 0.69 * pixel.G + 0.17 * pixel.B);
                    int sb = (int)Math.Min(255, 0.27 * pixel.R + 0.53 * pixel.G + 0.13 * pixel.B);
                    Color sepia = Color.FromArgb(sr, sg, sb);
                    processed.SetPixel(x, y, sepia);
                }
            }
            pictureBox2.Image = processed;
        }

        private void btnLoadBG_Click(object sender, EventArgs e)
        {
            mode = 1;
            openFileDialog1.ShowDialog();
        }

        private void btnLoadFG_Click(object sender, EventArgs e)
        {
            mode = 2;
            openFileDialog1.ShowDialog();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Color green = Color.FromArgb(0, 0, 255);
            int threshold = 5;

            int avg = (green.R + green.G + green.B) / 3;
            processed = new Bitmap(fg.Width, fg.Height);

            for (int x = 0; x < fg.Width; x++)
            {
                for (int y = 0; y < fg.Height; y++)
                {
                    Color fgpx = fg.GetPixel(x, y);
                    Color bgpx = bg.GetPixel(x, y);

                    int grey = (fgpx.R + fgpx.G + fgpx.B) / 3;
                    int subval = Math.Abs(grey - avg);

                    if (subval < threshold)
                    {
                        processed.SetPixel(x, y, bgpx);
                    }
                    else
                    {
                        processed.SetPixel(x, y, fgpx);
                    }
                }
            }

            pbResult.Image = processed;
        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = (Bitmap)loaded.Clone();
            ImageProcess2.BitmapFilter.GaussianBlur(processed, 4);
            pictureBox2.Image = processed;
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = (Bitmap)loaded.Clone();
            ImageProcess2.BitmapFilter.Sharpen(processed, 11);
            pictureBox2.Image = processed;
        }

        private void meanRemovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = (Bitmap)loaded.Clone();
            ImageProcess2.BitmapFilter.MeanRemoval(processed, 9);
            pictureBox2.Image = processed;
        }

        private void embossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = (Bitmap)loaded.Clone();
            ImageProcess2.BitmapFilter.EmbossLaplacian(processed);
            pictureBox2.Image = processed;
        }

        private void swirlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = (Bitmap)loaded.Clone();
            ImageProcess2.BitmapFilter.Swirl(processed, 0.05, true);
            pictureBox2.Image = processed;
        }
    }
}