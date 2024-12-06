using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Image_Processing_Activity
{
    public partial class Form1 : Form
    {
        Bitmap coins;
        Bitmap loaded, processed;
        Bitmap bg, fg;
        int mode = 0;
        public Form1()
        {
            InitializeComponent();
            coins = (Bitmap)pbCoins.Image;
            pbCoins.SizeMode = PictureBoxSizeMode.Zoom;
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
        unsafe byte* initP;
        int nOffset, stride;
        string output = "";
        private void btnReadCoins_Click(object sender, EventArgs e)
        {
            ImageProcess2.BitmapFilter.Contrast(coins, 100);
            ImageProcess2.BitmapFilter.GaussianBlur(coins, 3);
            coins = ImageProcess2.BitmapFilter.Resize(coins, 419, 553, false);
            ImageProcess2.BitmapFilter.GaussianBlur(coins, 3);
            ImageProcess2.BitmapFilter.Contrast(coins, 100);
            pbCoins.Image = (Bitmap)coins;//.Clone();
            BitmapData bmData = coins.LockBits(new Rectangle(0, 0, coins.Width, coins.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            List<int> sizes = new List<int>();

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                initP = p;
                nOffset = stride - coins.Width * 3;
                bool unvisited, coin;

                for (int y = 0; y < coins.Height; ++y)
                {
                    for (int x = 0; x < coins.Width; ++x)
                    {
                        if (p[2] < 120)
                            p[2] = 1;
                        else
                            p[2] = 0;
                        p[1] = 0;
                        p[0] = 0;
                        p += 3;
                    }
                    p += nOffset;
                }
                p = initP;
                for (int y = 0; y < coins.Height; ++y)
                {
                    for (int x = 0; x < coins.Width; ++x)
                    {
                        unvisited = (p[1] == 0);
                        coin = (p[2] == 1);
                        if (coin && unvisited){
                            sizes.Add(DfsSize(x, y));
                        }
                        p += 3;
                    }
                    p += nOffset;
                }
                
            }
            int[] counts = { 0, 0, 0, 0, 0 };
            foreach (int size in sizes)
            {
                if (size < 400)
                    continue;
                else if (size < 800)
                    counts[0]++;
                else if (size < 1100)
                    counts[1]++;
                else if (size < 1500)
                    counts[2]++;
                else if (size < 2000)
                    counts[3]++;
                else
                    counts[4]++;
            }
            double[] denoms = { 0.05, 0.10, 0.25, 1.0, 5.0 };
            double[] values = { 0, 0, 0, 0, 0 };
            double total = 0.0;
            for(int i=0; i<5; i++)
            {
                values[i] = Math.Round(counts[i] * denoms[i], 2);
                total += Math.Round(values[i],2);
                output += $"{denoms[i]} - Count: {counts[i]} - Value Sum: {values[i]} \n";
            }
            output += $"\nTotal: {total}";
            pbCoins.Image = coins;

            coins.UnlockBits(bmData);
            lblCoinsOutput.Text = output;
        }
        Stack<int> xFringe;
        Stack<int> yFringe;
        private unsafe int DfsSize(int x, int y)
        {
            int size = 0, i, dx, dy;
            byte r, g, b;
            byte* p;
            xFringe = new Stack<int>();
            yFringe = new Stack<int>();
            int[,] dir = { { 0, -1 }, { 0, 1 }, { -1, 0 }, { 1, 0 } };
            xFringe.Push(x); yFringe.Push(y);
            while (xFringe.Count > 0)
            {
                x = xFringe.Pop(); y = yFringe.Pop();

                p = getP(x, y);
                g = p[1]; r = p[2];

                if (g == 1)
                    continue;
                p[0] = 255;
                p[1] = 1;
                size++;

                for (i = 0; i < 4; i++)
                {
                    dx = x + dir[i, 0];
                    dy = y + dir[i, 1];
                    p = getP(dx, dy);
                    g = p[1]; r = p[2];
                    if (r == 1 && g == 0)
                    {
                        xFringe.Push(dx); 
                        yFringe.Push(dy);
                    }
                }
            }
            return size;
        }
        private unsafe byte* getP(int tx, int ty)
        {
            return initP + ty * stride + tx * 3;
        }
    }
}