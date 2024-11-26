namespace Image_Processing_Activity
{
    public partial class Form1 : Form
    {
        Bitmap loaded, processed;
        public Form1()
        {
            InitializeComponent();
        }

        private void dipToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loaded;
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
            //processed = new Bitmap(loaded.Width, loaded.Height);

            //// Lower Left: Basic Copy
            //for (int x = 0; x < loaded.Width/2; x++)
            //{
            //    for (int y = loaded.Height / 2; y < loaded.Height; y++)
            //    {
            //        Color c = loaded.GetPixel(x, y);
            //        processed.SetPixel(x, y, c);
            //    }
            //}

            //// Upper Left: Inversion
            //for (int x = 0; x < loaded.Width / 2; x++)
            //{
            //    for (int y = 0; y < loaded.Height / 2; y++)
            //    {
            //        Color c = loaded.GetPixel(x, y);
            //        int r, g, b;
            //        r = 255 - c.R;
            //        g = 255 - c.G;
            //        b = 255 - c.B;
            //        Color nc = Color.FromArgb(255, r, g, b);
            //        processed.SetPixel(x, y, nc);
            //    }
            //}

            //// Upper Right: Grayscale
            //for (int x = loaded.Width / 2; x < loaded.Width; x++)
            //{
            //    for (int y = 0; y < loaded.Height / 2; y++)
            //    {
            //        Color c = loaded.GetPixel(x, y);
            //        int gray = (c.R + c.G + c.B) / 3;
            //        Color nc = Color.FromArgb(255, gray, gray, gray);
            //        processed.SetPixel(x, y, nc);
            //    }
            //}

            //// Lower Right: Vertical Mirror
            //for (int x = loaded.Width / 2; x < loaded.Width; x++)
            //{
            //    for (int y = loaded.Height / 2; y < loaded.Height; y++)
            //    {
            //        Color c = loaded.GetPixel(x, y);

            //        int center = loaded.Height * 3 / 4;

            //        processed.SetPixel(x, 2*center - y - 1, c);
            //    }
            //}
            processed = new Bitmap(800, 600);

            for (int x = 0; x < 800; x++)
            {
                for (int y = 0; y < 600; y++)
                {
                    Color c = loaded.GetPixel(x, y);
                    Color cnew = c;

                    if (x < 400 && y < 300)
                    {           // upper left inversion
                        cnew = Color.FromArgb(255, 255 - c.R, 255 - c.G, 255 - c.B);

                    }
                    else if (x >= 400 && y < 300)
                    {   // upper right greyscale
                        int avg = (c.R + c.G + c.B) / 3;
                        cnew = Color.FromArgb(255, avg, avg, avg);

                    }
                    else if (x >= 400 && y >= 300)
                    {   // lower right vertical mirror
                        processed.SetPixel(x, 899 - y, c);
                        continue;

                    }

                    processed.SetPixel(x, y, cnew);
                }
            }

            pictureBox2.Image = processed;
        }
    }
}