namespace TwitchClipDownloader
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cbGame = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bLookupTop = new System.Windows.Forms.Button();
            this.ckTrend = new System.Windows.Forms.CheckBox();
            this.cbPeriod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtLog = new System.Windows.Forms.RichTextBox();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tCrawler = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sTime = new System.Windows.Forms.DomainUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLimit = new System.Windows.Forms.ComboBox();
            this.tDownloader = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btDownloadByLink = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btDownloadBySlug = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSlug = new System.Windows.Forms.TextBox();
            this.tSettings = new System.Windows.Forms.TabPage();
            this.tLog = new System.Windows.Forms.TabPage();
            this.tAbout = new System.Windows.Forms.TabPage();
            this.lbVersion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pbDownload = new System.Windows.Forms.ToolStripProgressBar();
            this.toolTipText = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl.SuspendLayout();
            this.tCrawler.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tDownloader.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tSettings.SuspendLayout();
            this.tLog.SuspendLayout();
            this.tAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbGame
            // 
            this.cbGame.FormattingEnabled = true;
            this.cbGame.Items.AddRange(new object[] {
            "PLAYERUNKNOWN\'S BATTLEGROUNDS",
            "Fortnite"});
            this.cbGame.Location = new System.Drawing.Point(96, 13);
            this.cbGame.Name = "cbGame";
            this.cbGame.Size = new System.Drawing.Size(195, 21);
            this.cbGame.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game:";
            // 
            // bLookupTop
            // 
            this.bLookupTop.Location = new System.Drawing.Point(505, 247);
            this.bLookupTop.Name = "bLookupTop";
            this.bLookupTop.Size = new System.Drawing.Size(75, 23);
            this.bLookupTop.TabIndex = 2;
            this.bLookupTop.Text = "Crawl";
            this.bLookupTop.UseVisualStyleBackColor = true;
            this.bLookupTop.Click += new System.EventHandler(this.bLookupTop_Click);
            // 
            // ckTrend
            // 
            this.ckTrend.AutoSize = true;
            this.ckTrend.Checked = true;
            this.ckTrend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckTrend.Location = new System.Drawing.Point(96, 123);
            this.ckTrend.Name = "ckTrend";
            this.ckTrend.Size = new System.Drawing.Size(68, 17);
            this.ckTrend.TabIndex = 3;
            this.ckTrend.Text = "Trending";
            this.ckTrend.UseVisualStyleBackColor = true;
            // 
            // cbPeriod
            // 
            this.cbPeriod.FormattingEnabled = true;
            this.cbPeriod.Items.AddRange(new object[] {
            "day",
            "week",
            "month",
            "all"});
            this.cbPeriod.Location = new System.Drawing.Point(96, 66);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Size = new System.Drawing.Size(195, 21);
            this.cbPeriod.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Period:";
            // 
            // rtLog
            // 
            this.rtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtLog.Location = new System.Drawing.Point(0, 0);
            this.rtLog.Name = "rtLog";
            this.rtLog.ReadOnly = true;
            this.rtLog.Size = new System.Drawing.Size(583, 273);
            this.rtLog.TabIndex = 6;
            this.rtLog.Text = "";
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(8, 30);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(567, 20);
            this.txtSave.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "SavePath";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(505, 247);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 12;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Language:";
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(96, 40);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(472, 20);
            this.txtLanguage.TabIndex = 14;
            this.txtLanguage.Text = "en,de";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tCrawler);
            this.tabControl.Controls.Add(this.tDownloader);
            this.tabControl.Controls.Add(this.tSettings);
            this.tabControl.Controls.Add(this.tLog);
            this.tabControl.Controls.Add(this.tAbout);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(591, 299);
            this.tabControl.TabIndex = 15;
            // 
            // tCrawler
            // 
            this.tCrawler.Controls.Add(this.groupBox1);
            this.tCrawler.Controls.Add(this.bLookupTop);
            this.tCrawler.Location = new System.Drawing.Point(4, 22);
            this.tCrawler.Name = "tCrawler";
            this.tCrawler.Padding = new System.Windows.Forms.Padding(3);
            this.tCrawler.Size = new System.Drawing.Size(583, 273);
            this.tCrawler.TabIndex = 1;
            this.tCrawler.Text = "Crawler";
            this.tCrawler.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sTime);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtChannel);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbLimit);
            this.groupBox1.Controls.Add(this.cbPeriod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLanguage);
            this.groupBox1.Controls.Add(this.ckTrend);
            this.groupBox1.Controls.Add(this.cbGame);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 238);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // sTime
            // 
            this.sTime.Items.Add("48");
            this.sTime.Items.Add("47");
            this.sTime.Items.Add("46");
            this.sTime.Items.Add("45");
            this.sTime.Items.Add("44");
            this.sTime.Items.Add("43");
            this.sTime.Items.Add("42");
            this.sTime.Items.Add("41");
            this.sTime.Items.Add("40");
            this.sTime.Items.Add("39");
            this.sTime.Items.Add("38");
            this.sTime.Items.Add("37");
            this.sTime.Items.Add("36");
            this.sTime.Items.Add("35");
            this.sTime.Items.Add("34");
            this.sTime.Items.Add("33");
            this.sTime.Items.Add("32");
            this.sTime.Items.Add("31");
            this.sTime.Items.Add("30");
            this.sTime.Items.Add("29");
            this.sTime.Items.Add("28");
            this.sTime.Items.Add("27");
            this.sTime.Items.Add("26");
            this.sTime.Items.Add("25");
            this.sTime.Items.Add("24");
            this.sTime.Items.Add("23");
            this.sTime.Items.Add("22");
            this.sTime.Items.Add("21");
            this.sTime.Items.Add("20");
            this.sTime.Items.Add("19");
            this.sTime.Items.Add("18");
            this.sTime.Items.Add("17");
            this.sTime.Items.Add("16");
            this.sTime.Items.Add("15");
            this.sTime.Items.Add("14");
            this.sTime.Items.Add("13");
            this.sTime.Items.Add("12");
            this.sTime.Items.Add("11");
            this.sTime.Items.Add("10");
            this.sTime.Items.Add("9");
            this.sTime.Items.Add("8");
            this.sTime.Items.Add("7");
            this.sTime.Items.Add("6");
            this.sTime.Items.Add("5");
            this.sTime.Items.Add("4");
            this.sTime.Items.Add("3");
            this.sTime.Items.Add("2");
            this.sTime.Items.Add("1");
            this.sTime.Location = new System.Drawing.Point(378, 66);
            this.sTime.Name = "sTime";
            this.sTime.Size = new System.Drawing.Size(190, 20);
            this.sTime.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(297, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Time in Hours:";
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(378, 13);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(190, 20);
            this.txtChannel.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(297, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Channelname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Limit:";
            // 
            // cbLimit
            // 
            this.cbLimit.FormattingEnabled = true;
            this.cbLimit.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "25",
            "50",
            "100"});
            this.cbLimit.Location = new System.Drawing.Point(96, 96);
            this.cbLimit.Name = "cbLimit";
            this.cbLimit.Size = new System.Drawing.Size(472, 21);
            this.cbLimit.TabIndex = 15;
            // 
            // tDownloader
            // 
            this.tDownloader.Controls.Add(this.groupBox3);
            this.tDownloader.Controls.Add(this.groupBox2);
            this.tDownloader.Location = new System.Drawing.Point(4, 22);
            this.tDownloader.Name = "tDownloader";
            this.tDownloader.Padding = new System.Windows.Forms.Padding(3);
            this.tDownloader.Size = new System.Drawing.Size(583, 273);
            this.tDownloader.TabIndex = 2;
            this.tDownloader.Text = "Downloader";
            this.tDownloader.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btDownloadByLink);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtLink);
            this.groupBox3.Location = new System.Drawing.Point(6, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(571, 56);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "By Link";
            // 
            // btDownloadByLink
            // 
            this.btDownloadByLink.Location = new System.Drawing.Point(490, 21);
            this.btDownloadByLink.Name = "btDownloadByLink";
            this.btDownloadByLink.Size = new System.Drawing.Size(75, 23);
            this.btDownloadByLink.TabIndex = 2;
            this.btDownloadByLink.Text = "Download";
            this.btDownloadByLink.UseVisualStyleBackColor = true;
            this.btDownloadByLink.Click += new System.EventHandler(this.btDownloadByLink_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Link:";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(43, 23);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(441, 20);
            this.txtLink.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btDownloadBySlug);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSlug);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 56);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "By Slug";
            // 
            // btDownloadBySlug
            // 
            this.btDownloadBySlug.Location = new System.Drawing.Point(490, 21);
            this.btDownloadBySlug.Name = "btDownloadBySlug";
            this.btDownloadBySlug.Size = new System.Drawing.Size(75, 23);
            this.btDownloadBySlug.TabIndex = 2;
            this.btDownloadBySlug.Text = "Download";
            this.btDownloadBySlug.UseVisualStyleBackColor = true;
            this.btDownloadBySlug.Click += new System.EventHandler(this.btDownloadBySlug_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Slug:";
            // 
            // txtSlug
            // 
            this.txtSlug.Location = new System.Drawing.Point(43, 23);
            this.txtSlug.Name = "txtSlug";
            this.txtSlug.Size = new System.Drawing.Size(441, 20);
            this.txtSlug.TabIndex = 0;
            // 
            // tSettings
            // 
            this.tSettings.Controls.Add(this.txtSave);
            this.tSettings.Controls.Add(this.label5);
            this.tSettings.Controls.Add(this.btSave);
            this.tSettings.Location = new System.Drawing.Point(4, 22);
            this.tSettings.Name = "tSettings";
            this.tSettings.Size = new System.Drawing.Size(583, 273);
            this.tSettings.TabIndex = 3;
            this.tSettings.Text = "Settings";
            this.tSettings.UseVisualStyleBackColor = true;
            // 
            // tLog
            // 
            this.tLog.Controls.Add(this.rtLog);
            this.tLog.Location = new System.Drawing.Point(4, 22);
            this.tLog.Name = "tLog";
            this.tLog.Size = new System.Drawing.Size(583, 273);
            this.tLog.TabIndex = 4;
            this.tLog.Text = "Log";
            this.tLog.UseVisualStyleBackColor = true;
            // 
            // tAbout
            // 
            this.tAbout.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tAbout.Controls.Add(this.lbVersion);
            this.tAbout.Controls.Add(this.pictureBox1);
            this.tAbout.Controls.Add(this.label9);
            this.tAbout.Controls.Add(this.label4);
            this.tAbout.Location = new System.Drawing.Point(4, 22);
            this.tAbout.Name = "tAbout";
            this.tAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tAbout.Size = new System.Drawing.Size(583, 273);
            this.tAbout.TabIndex = 5;
            this.tAbout.Text = "About";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.ForeColor = System.Drawing.Color.White;
            this.lbVersion.Location = new System.Drawing.Point(68, 108);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(16, 13);
            this.lbVersion.TabIndex = 4;
            this.lbVersion.Text = "---";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(21, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 61);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(90, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(328, 39);
            this.label9.TabIndex = 1;
            this.label9.Text = "Twitch Clip Downloader";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(18, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(381, 182);
            this.label4.TabIndex = 0;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbDownload,
            this.toolTipText,
            this.txtVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 302);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(591, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "mainStatusStrip";
            // 
            // pbDownload
            // 
            this.pbDownload.Name = "pbDownload";
            this.pbDownload.Size = new System.Drawing.Size(200, 16);
            // 
            // toolTipText
            // 
            this.toolTipText.Name = "toolTipText";
            this.toolTipText.Size = new System.Drawing.Size(0, 17);
            // 
            // txtVersion
            // 
            this.txtVersion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(374, 17);
            this.txtVersion.Spring = true;
            this.txtVersion.Text = "VERSION";
            this.txtVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(591, 324);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCD - Twitch Clip Downloader";
            this.tabControl.ResumeLayout(false);
            this.tCrawler.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tDownloader.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tSettings.ResumeLayout(false);
            this.tSettings.PerformLayout();
            this.tLog.ResumeLayout(false);
            this.tAbout.ResumeLayout(false);
            this.tAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bLookupTop;
        private System.Windows.Forms.CheckBox ckTrend;
        private System.Windows.Forms.ComboBox cbPeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtLog;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tCrawler;
        private System.Windows.Forms.TabPage tDownloader;
        private System.Windows.Forms.TabPage tSettings;
        private System.Windows.Forms.TabPage tLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLimit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btDownloadBySlug;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSlug;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btDownloadByLink;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolTipText;
        private System.Windows.Forms.ToolStripProgressBar pbDownload;
        private System.Windows.Forms.TabPage tAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DomainUpDown sTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripStatusLabel txtVersion;
    }
}

