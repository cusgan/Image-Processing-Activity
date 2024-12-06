namespace Image_Processing_Activity
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openImageToolStripMenuItem = new ToolStripMenuItem();
            saveImageToolStripMenuItem = new ToolStripMenuItem();
            dipToolStripMenuItem = new ToolStripMenuItem();
            basicCopyToolStripMenuItem = new ToolStripMenuItem();
            greyscaleToolStripMenuItem = new ToolStripMenuItem();
            colorInversionToolStripMenuItem = new ToolStripMenuItem();
            histogramToolStripMenuItem = new ToolStripMenuItem();
            sepiaToolStripMenuItem = new ToolStripMenuItem();
            convolutionToolStripMenuItem = new ToolStripMenuItem();
            shrinkToolStripMenuItem = new ToolStripMenuItem();
            gaussianBlurToolStripMenuItem = new ToolStripMenuItem();
            sharpenToolStripMenuItem = new ToolStripMenuItem();
            meanRemovalToolStripMenuItem = new ToolStripMenuItem();
            embossToolStripMenuItem = new ToolStripMenuItem();
            cameraToolStripMenuItem = new ToolStripMenuItem();
            enableToolStripMenuItem = new ToolStripMenuItem();
            disableToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            btnSubtract = new Button();
            btnLoadFG = new Button();
            btnLoadBG = new Button();
            pbResult = new PictureBox();
            pbForeground = new PictureBox();
            pbBackground = new PictureBox();
            tabPage3 = new TabPage();
            pbCoins = new PictureBox();
            btnReadCoins = new Button();
            lblCoinsOutput = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbForeground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBackground).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCoins).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, dipToolStripMenuItem, convolutionToolStripMenuItem, cameraToolStripMenuItem });
            menuStrip1.Location = new Point(3, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(886, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openImageToolStripMenuItem, saveImageToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openImageToolStripMenuItem
            // 
            openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            openImageToolStripMenuItem.Size = new Size(174, 26);
            openImageToolStripMenuItem.Text = "Open Image";
            openImageToolStripMenuItem.Click += openImageToolStripMenuItem_Click;
            // 
            // saveImageToolStripMenuItem
            // 
            saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            saveImageToolStripMenuItem.Size = new Size(174, 26);
            saveImageToolStripMenuItem.Text = "Save Image";
            // 
            // dipToolStripMenuItem
            // 
            dipToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { basicCopyToolStripMenuItem, greyscaleToolStripMenuItem, colorInversionToolStripMenuItem, histogramToolStripMenuItem, sepiaToolStripMenuItem });
            dipToolStripMenuItem.Name = "dipToolStripMenuItem";
            dipToolStripMenuItem.Size = new Size(46, 24);
            dipToolStripMenuItem.Text = "DIP";
            dipToolStripMenuItem.Click += dipToolStripMenuItem_Click;
            // 
            // basicCopyToolStripMenuItem
            // 
            basicCopyToolStripMenuItem.Name = "basicCopyToolStripMenuItem";
            basicCopyToolStripMenuItem.Size = new Size(191, 26);
            basicCopyToolStripMenuItem.Text = "Basic Copy";
            basicCopyToolStripMenuItem.Click += basicCopyToolStripMenuItem_Click;
            // 
            // greyscaleToolStripMenuItem
            // 
            greyscaleToolStripMenuItem.Name = "greyscaleToolStripMenuItem";
            greyscaleToolStripMenuItem.Size = new Size(191, 26);
            greyscaleToolStripMenuItem.Text = "Greyscale";
            greyscaleToolStripMenuItem.Click += greyscaleToolStripMenuItem_Click;
            // 
            // colorInversionToolStripMenuItem
            // 
            colorInversionToolStripMenuItem.Name = "colorInversionToolStripMenuItem";
            colorInversionToolStripMenuItem.Size = new Size(191, 26);
            colorInversionToolStripMenuItem.Text = "Color Inversion";
            colorInversionToolStripMenuItem.Click += colorInversionToolStripMenuItem_Click;
            // 
            // histogramToolStripMenuItem
            // 
            histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            histogramToolStripMenuItem.Size = new Size(191, 26);
            histogramToolStripMenuItem.Text = "Histogram";
            histogramToolStripMenuItem.Click += histogramToolStripMenuItem_Click;
            // 
            // sepiaToolStripMenuItem
            // 
            sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            sepiaToolStripMenuItem.Size = new Size(191, 26);
            sepiaToolStripMenuItem.Text = "Sepia";
            sepiaToolStripMenuItem.Click += sepiaToolStripMenuItem_Click;
            // 
            // convolutionToolStripMenuItem
            // 
            convolutionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { shrinkToolStripMenuItem, gaussianBlurToolStripMenuItem, sharpenToolStripMenuItem, meanRemovalToolStripMenuItem, embossToolStripMenuItem });
            convolutionToolStripMenuItem.Name = "convolutionToolStripMenuItem";
            convolutionToolStripMenuItem.Size = new Size(103, 24);
            convolutionToolStripMenuItem.Text = "Convolution";
            // 
            // shrinkToolStripMenuItem
            // 
            shrinkToolStripMenuItem.Name = "shrinkToolStripMenuItem";
            shrinkToolStripMenuItem.Size = new Size(191, 26);
            shrinkToolStripMenuItem.Text = "Swirl";
            shrinkToolStripMenuItem.Click += swirlToolStripMenuItem_Click;
            // 
            // gaussianBlurToolStripMenuItem
            // 
            gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            gaussianBlurToolStripMenuItem.Size = new Size(191, 26);
            gaussianBlurToolStripMenuItem.Text = "Gaussian Blur";
            gaussianBlurToolStripMenuItem.Click += gaussianBlurToolStripMenuItem_Click;
            // 
            // sharpenToolStripMenuItem
            // 
            sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            sharpenToolStripMenuItem.Size = new Size(191, 26);
            sharpenToolStripMenuItem.Text = "Sharpen";
            sharpenToolStripMenuItem.Click += sharpenToolStripMenuItem_Click;
            // 
            // meanRemovalToolStripMenuItem
            // 
            meanRemovalToolStripMenuItem.Name = "meanRemovalToolStripMenuItem";
            meanRemovalToolStripMenuItem.Size = new Size(191, 26);
            meanRemovalToolStripMenuItem.Text = "Mean Removal";
            meanRemovalToolStripMenuItem.Click += meanRemovalToolStripMenuItem_Click;
            // 
            // embossToolStripMenuItem
            // 
            embossToolStripMenuItem.Name = "embossToolStripMenuItem";
            embossToolStripMenuItem.Size = new Size(191, 26);
            embossToolStripMenuItem.Text = "Emboss";
            embossToolStripMenuItem.Click += embossToolStripMenuItem_Click;
            // 
            // cameraToolStripMenuItem
            // 
            cameraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { enableToolStripMenuItem, disableToolStripMenuItem });
            cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            cameraToolStripMenuItem.Size = new Size(74, 24);
            cameraToolStripMenuItem.Text = "Camera";
            // 
            // enableToolStripMenuItem
            // 
            enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            enableToolStripMenuItem.Size = new Size(142, 26);
            enableToolStripMenuItem.Text = "Enable";
            // 
            // disableToolStripMenuItem
            // 
            disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            disableToolStripMenuItem.Size = new Size(142, 26);
            disableToolStripMenuItem.Text = "Disable";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(23, 37);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(407, 382);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(479, 37);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(407, 382);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(900, 480);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(menuStrip1);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(892, 447);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "DIP";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnSubtract);
            tabPage2.Controls.Add(btnLoadFG);
            tabPage2.Controls.Add(btnLoadBG);
            tabPage2.Controls.Add(pbResult);
            tabPage2.Controls.Add(pbForeground);
            tabPage2.Controls.Add(pbBackground);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(892, 447);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Green Screen";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(637, 315);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(159, 29);
            btnSubtract.TabIndex = 5;
            btnSubtract.Text = "Combine Images";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnLoadFG
            // 
            btnLoadFG.Location = new Point(367, 315);
            btnLoadFG.Name = "btnLoadFG";
            btnLoadFG.Size = new Size(159, 29);
            btnLoadFG.TabIndex = 4;
            btnLoadFG.Text = "Select Foreground";
            btnLoadFG.UseVisualStyleBackColor = true;
            btnLoadFG.Click += btnLoadFG_Click;
            // 
            // btnLoadBG
            // 
            btnLoadBG.Location = new Point(89, 315);
            btnLoadBG.Name = "btnLoadBG";
            btnLoadBG.Size = new Size(159, 29);
            btnLoadBG.TabIndex = 3;
            btnLoadBG.Text = "Select Background";
            btnLoadBG.UseVisualStyleBackColor = true;
            btnLoadBG.Click += btnLoadBG_Click;
            // 
            // pbResult
            // 
            pbResult.Location = new Point(587, 37);
            pbResult.Name = "pbResult";
            pbResult.Size = new Size(266, 272);
            pbResult.SizeMode = PictureBoxSizeMode.StretchImage;
            pbResult.TabIndex = 2;
            pbResult.TabStop = false;
            // 
            // pbForeground
            // 
            pbForeground.Location = new Point(315, 37);
            pbForeground.Name = "pbForeground";
            pbForeground.Size = new Size(266, 272);
            pbForeground.SizeMode = PictureBoxSizeMode.StretchImage;
            pbForeground.TabIndex = 1;
            pbForeground.TabStop = false;
            // 
            // pbBackground
            // 
            pbBackground.Location = new Point(43, 37);
            pbBackground.Name = "pbBackground";
            pbBackground.Size = new Size(266, 272);
            pbBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBackground.TabIndex = 0;
            pbBackground.TabStop = false;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lblCoinsOutput);
            tabPage3.Controls.Add(btnReadCoins);
            tabPage3.Controls.Add(pbCoins);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(892, 447);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Coins";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // pbCoins
            // 
            pbCoins.Image = Properties.Resources.Coins;
            pbCoins.Location = new Point(44, 30);
            pbCoins.Name = "pbCoins";
            pbCoins.Size = new Size(338, 396);
            pbCoins.TabIndex = 0;
            pbCoins.TabStop = false;
            // 
            // btnReadCoins
            // 
            btnReadCoins.Location = new Point(426, 30);
            btnReadCoins.Name = "btnReadCoins";
            btnReadCoins.Size = new Size(420, 46);
            btnReadCoins.TabIndex = 1;
            btnReadCoins.Text = "Read Coins";
            btnReadCoins.UseVisualStyleBackColor = true;
            btnReadCoins.Click += btnReadCoins_Click;
            // 
            // lblCoinsOutput
            // 
            lblCoinsOutput.AutoSize = true;
            lblCoinsOutput.Location = new Point(426, 97);
            lblCoinsOutput.Name = "lblCoinsOutput";
            lblCoinsOutput.Size = new Size(176, 20);
            lblCoinsOutput.TabIndex = 2;
            lblCoinsOutput.Text = "(Output will display here)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 504);
            Controls.Add(tabControl1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Image Processing Activity";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbForeground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBackground).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCoins).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openImageToolStripMenuItem;
        private ToolStripMenuItem saveImageToolStripMenuItem;
        private ToolStripMenuItem dipToolStripMenuItem;
        private ToolStripMenuItem basicCopyToolStripMenuItem;
        private ToolStripMenuItem greyscaleToolStripMenuItem;
        private ToolStripMenuItem colorInversionToolStripMenuItem;
        private ToolStripMenuItem histogramToolStripMenuItem;
        private ToolStripMenuItem sepiaToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnLoadBG;
        private PictureBox pbResult;
        private PictureBox pbForeground;
        private PictureBox pbBackground;
        private Button btnSubtract;
        private Button btnLoadFG;
        private ToolStripMenuItem convolutionToolStripMenuItem;
        private ToolStripMenuItem shrinkToolStripMenuItem;
        private ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private ToolStripMenuItem sharpenToolStripMenuItem;
        private ToolStripMenuItem meanRemovalToolStripMenuItem;
        private ToolStripMenuItem embossToolStripMenuItem;
        private TabPage tabPage3;
        private ToolStripMenuItem cameraToolStripMenuItem;
        private ToolStripMenuItem enableToolStripMenuItem;
        private ToolStripMenuItem disableToolStripMenuItem;
        private PictureBox pbCoins;
        private Label lblCoinsOutput;
        private Button btnReadCoins;
    }
}
