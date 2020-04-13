namespace VidDownloader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDestLoc = new System.Windows.Forms.TextBox();
            this.btnDestLoc = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ArgContainer = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbAdvancedParams = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbArg11 = new VidDownloader.CBArg();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbArg7 = new VidDownloader.CBArg();
            this.cbArg4 = new VidDownloader.CBArg();
            this.cbArg5 = new VidDownloader.CBArg();
            this.cbArg6 = new VidDownloader.CBArg();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbArg3 = new VidDownloader.CBArg();
            this.cbArg2 = new VidDownloader.CBArg();
            this.cbArg1 = new VidDownloader.CBArg();
            this.tbConsoleOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ArgContainer.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLink
            // 
            this.tbLink.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLink.Location = new System.Drawing.Point(20, 120);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(406, 22);
            this.tbLink.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Link of the video:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Download to location:";
            // 
            // tbDestLoc
            // 
            this.tbDestLoc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDestLoc.Location = new System.Drawing.Point(20, 179);
            this.tbDestLoc.Name = "tbDestLoc";
            this.tbDestLoc.ReadOnly = true;
            this.tbDestLoc.Size = new System.Drawing.Size(361, 22);
            this.tbDestLoc.TabIndex = 2;
            // 
            // btnDestLoc
            // 
            this.btnDestLoc.Image = ((System.Drawing.Image)(resources.GetObject("btnDestLoc.Image")));
            this.btnDestLoc.Location = new System.Drawing.Point(387, 178);
            this.btnDestLoc.Name = "btnDestLoc";
            this.btnDestLoc.Size = new System.Drawing.Size(39, 24);
            this.btnDestLoc.TabIndex = 4;
            this.btnDestLoc.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(153, 517);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(141, 40);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = "Download Now";
            this.btnDownload.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ArgContainer
            // 
            this.ArgContainer.AutoScroll = true;
            this.ArgContainer.Controls.Add(this.groupBox4);
            this.ArgContainer.Controls.Add(this.groupBox3);
            this.ArgContainer.Controls.Add(this.groupBox2);
            this.ArgContainer.Controls.Add(this.groupBox1);
            this.ArgContainer.Location = new System.Drawing.Point(20, 208);
            this.ArgContainer.Name = "ArgContainer";
            this.ArgContainer.Padding = new System.Windows.Forms.Padding(3);
            this.ArgContainer.Size = new System.Drawing.Size(406, 301);
            this.ArgContainer.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbAdvancedParams);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 245);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox4.Size = new System.Drawing.Size(400, 53);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Advanced Parameters";
            // 
            // tbAdvancedParams
            // 
            this.tbAdvancedParams.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdvancedParams.Location = new System.Drawing.Point(9, 20);
            this.tbAdvancedParams.Name = "tbAdvancedParams";
            this.tbAdvancedParams.Size = new System.Drawing.Size(382, 22);
            this.tbAdvancedParams.TabIndex = 1;
            this.tbAdvancedParams.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbArg11);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox3.Size = new System.Drawing.Size(400, 53);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Additional Options";
            // 
            // cbArg11
            // 
            this.cbArg11.Arg = "--skip-download";
            this.cbArg11.AutoSize = true;
            this.cbArg11.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbArg11.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArg11.Location = new System.Drawing.Point(10, 21);
            this.cbArg11.Name = "cbArg11";
            this.cbArg11.Size = new System.Drawing.Size(387, 18);
            this.cbArg11.TabIndex = 0;
            this.cbArg11.Text = "Skip Video Download";
            this.cbArg11.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbArg7);
            this.groupBox2.Controls.Add(this.cbArg4);
            this.groupBox2.Controls.Add(this.cbArg5);
            this.groupBox2.Controls.Add(this.cbArg6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(400, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Post-processing Options";
            // 
            // cbArg7
            // 
            this.cbArg7.Arg = "--embed-thumbnail";
            this.cbArg7.AutoSize = true;
            this.cbArg7.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbArg7.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArg7.Location = new System.Drawing.Point(10, 75);
            this.cbArg7.Name = "cbArg7";
            this.cbArg7.Size = new System.Drawing.Size(387, 18);
            this.cbArg7.TabIndex = 3;
            this.cbArg7.Text = "Embed thumbnail as cover";
            this.cbArg7.UseVisualStyleBackColor = true;
            // 
            // cbArg4
            // 
            this.cbArg4.Arg = "--embed-subs";
            this.cbArg4.AutoSize = true;
            this.cbArg4.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbArg4.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArg4.Location = new System.Drawing.Point(10, 57);
            this.cbArg4.Name = "cbArg4";
            this.cbArg4.Size = new System.Drawing.Size(387, 18);
            this.cbArg4.TabIndex = 2;
            this.cbArg4.Text = "Embed subtitles";
            this.cbArg4.UseVisualStyleBackColor = true;
            // 
            // cbArg5
            // 
            this.cbArg5.Arg = "-k";
            this.cbArg5.AutoSize = true;
            this.cbArg5.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbArg5.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArg5.Location = new System.Drawing.Point(10, 39);
            this.cbArg5.Name = "cbArg5";
            this.cbArg5.Size = new System.Drawing.Size(387, 18);
            this.cbArg5.TabIndex = 1;
            this.cbArg5.Text = "Keep video file (Automatically deleted after post-processing)";
            this.cbArg5.UseVisualStyleBackColor = true;
            // 
            // cbArg6
            // 
            this.cbArg6.Arg = "-x";
            this.cbArg6.AutoSize = true;
            this.cbArg6.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbArg6.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArg6.Location = new System.Drawing.Point(10, 21);
            this.cbArg6.Name = "cbArg6";
            this.cbArg6.Size = new System.Drawing.Size(387, 18);
            this.cbArg6.TabIndex = 0;
            this.cbArg6.Text = "Extract Audio";
            this.cbArg6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbArg3);
            this.groupBox1.Controls.Add(this.cbArg2);
            this.groupBox1.Controls.Add(this.cbArg1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(400, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subtitle Options";
            // 
            // cbArg3
            // 
            this.cbArg3.Arg = "--all-subs";
            this.cbArg3.AutoSize = true;
            this.cbArg3.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbArg3.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArg3.Location = new System.Drawing.Point(10, 57);
            this.cbArg3.Name = "cbArg3";
            this.cbArg3.Size = new System.Drawing.Size(387, 18);
            this.cbArg3.TabIndex = 2;
            this.cbArg3.Text = "Download all available subtitles";
            this.cbArg3.UseVisualStyleBackColor = true;
            // 
            // cbArg2
            // 
            this.cbArg2.Arg = "--write-auto-sub";
            this.cbArg2.AutoSize = true;
            this.cbArg2.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbArg2.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArg2.Location = new System.Drawing.Point(10, 39);
            this.cbArg2.Name = "cbArg2";
            this.cbArg2.Size = new System.Drawing.Size(387, 18);
            this.cbArg2.TabIndex = 1;
            this.cbArg2.Text = "Write auto-subtitle file (YouTube only)";
            this.cbArg2.UseVisualStyleBackColor = true;
            // 
            // cbArg1
            // 
            this.cbArg1.Arg = "--write-sub";
            this.cbArg1.AutoSize = true;
            this.cbArg1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbArg1.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArg1.Location = new System.Drawing.Point(10, 21);
            this.cbArg1.Name = "cbArg1";
            this.cbArg1.Size = new System.Drawing.Size(387, 18);
            this.cbArg1.TabIndex = 0;
            this.cbArg1.Text = "Write subtitle file";
            this.cbArg1.UseVisualStyleBackColor = true;
            // 
            // tbConsoleOutput
            // 
            this.tbConsoleOutput.Location = new System.Drawing.Point(431, 60);
            this.tbConsoleOutput.Multiline = true;
            this.tbConsoleOutput.Name = "tbConsoleOutput";
            this.tbConsoleOutput.ReadOnly = true;
            this.tbConsoleOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbConsoleOutput.Size = new System.Drawing.Size(381, 497);
            this.tbConsoleOutput.TabIndex = 8;
            this.tbConsoleOutput.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Console Output:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 576);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbConsoleOutput);
            this.Controls.Add(this.ArgContainer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnDestLoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDestLoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLink);
            this.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(15, 27, 15, 16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  youtube-dl GUI by MeowthK";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ArgContainer.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDestLoc;
        private System.Windows.Forms.Button btnDestLoc;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel ArgContainer;
        private System.Windows.Forms.GroupBox groupBox1;
        private CBArg cbArg1;
        private CBArg cbArg2;
        private CBArg cbArg3;
        private System.Windows.Forms.GroupBox groupBox2;
        private CBArg cbArg4;
        private CBArg cbArg5;
        private CBArg cbArg6;
        private CBArg cbArg7;
        private System.Windows.Forms.GroupBox groupBox3;
        private CBArg cbArg11;
        private System.Windows.Forms.TextBox tbConsoleOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAdvancedParams;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

