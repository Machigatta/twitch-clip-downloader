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
            this.txtSave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sTime = new System.Windows.Forms.DomainUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLimit = new System.Windows.Forms.ComboBox();
            this.lbQue = new System.Windows.Forms.ListBox();
            this.btStartDownloadQue = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkUbs = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chkAddToQue = new System.Windows.Forms.CheckBox();
            this.txtSlug = new System.Windows.Forms.TextBox();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.btDownloadByLink = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rtLog = new System.Windows.Forms.RichTextBox();
            this.lbVersion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pbDownload = new System.Windows.Forms.ToolStripProgressBar();
            this.toolTipText = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btLfSavePath = new System.Windows.Forms.Button();
            this.fdb_SavePath = new System.Windows.Forms.FolderBrowserDialog();
            this.chk_useGame = new System.Windows.Forms.CheckBox();
            this.chk_useChannel = new System.Windows.Forms.CheckBox();
            this.btLookUpTopOnly = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbGame
            // 
            this.cbGame.FormattingEnabled = true;
            this.cbGame.Items.AddRange(new object[] {
            "PLAYERUNKNOWN\'S BATTLEGROUNDS",
            "Fortnite"});
            this.cbGame.Location = new System.Drawing.Point(96, 14);
            this.cbGame.Name = "cbGame";
            this.cbGame.Size = new System.Drawing.Size(195, 21);
            this.cbGame.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game:";
            // 
            // bLookupTop
            // 
            this.bLookupTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLookupTop.Location = new System.Drawing.Point(227, 262);
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
            this.ckTrend.Location = new System.Drawing.Point(96, 176);
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
            this.cbPeriod.Location = new System.Drawing.Point(96, 96);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Size = new System.Drawing.Size(195, 21);
            this.cbPeriod.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Period:";
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(9, 41);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(205, 20);
            this.txtSave.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Save Path:";
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Location = new System.Drawing.Point(185, 262);
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
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Language:";
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(96, 67);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(195, 20);
            this.txtLanguage.TabIndex = 14;
            this.txtLanguage.Text = "en,de";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btLookUpTopOnly);
            this.groupBox1.Controls.Add(this.chk_useChannel);
            this.groupBox1.Controls.Add(this.chk_useGame);
            this.groupBox1.Controls.Add(this.sTime);
            this.groupBox1.Controls.Add(this.bLookupTop);
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
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 291);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crawler";
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
            this.sTime.Location = new System.Drawing.Point(96, 123);
            this.sTime.Name = "sTime";
            this.sTime.Size = new System.Drawing.Size(195, 20);
            this.sTime.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Time in Hours:";
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(96, 41);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(195, 20);
            this.txtChannel.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Channelname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 152);
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
            this.cbLimit.Location = new System.Drawing.Point(96, 149);
            this.cbLimit.Name = "cbLimit";
            this.cbLimit.Size = new System.Drawing.Size(195, 21);
            this.cbLimit.TabIndex = 15;
            // 
            // lbQue
            // 
            this.lbQue.FormattingEnabled = true;
            this.lbQue.Location = new System.Drawing.Point(10, 116);
            this.lbQue.Name = "lbQue";
            this.lbQue.Size = new System.Drawing.Size(267, 108);
            this.lbQue.TabIndex = 6;
            // 
            // btStartDownloadQue
            // 
            this.btStartDownloadQue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStartDownloadQue.Location = new System.Drawing.Point(183, 262);
            this.btStartDownloadQue.Name = "btStartDownloadQue";
            this.btStartDownloadQue.Size = new System.Drawing.Size(98, 23);
            this.btStartDownloadQue.TabIndex = 5;
            this.btStartDownloadQue.Text = "Download Que";
            this.btStartDownloadQue.UseVisualStyleBackColor = true;
            this.btStartDownloadQue.Click += new System.EventHandler(this.btStartDownloadQue_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbQue);
            this.groupBox3.Controls.Add(this.chkUbs);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btStartDownloadQue);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.chkAddToQue);
            this.groupBox3.Controls.Add(this.txtSlug);
            this.groupBox3.Controls.Add(this.txtPre);
            this.groupBox3.Controls.Add(this.btDownloadByLink);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtLink);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.groupBox3.Location = new System.Drawing.Point(322, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 291);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Direct Download ";
            // 
            // chkUbs
            // 
            this.chkUbs.AutoSize = true;
            this.chkUbs.Location = new System.Drawing.Point(43, 93);
            this.chkUbs.Name = "chkUbs";
            this.chkUbs.Size = new System.Drawing.Size(148, 17);
            this.chkUbs.TabIndex = 5;
            this.chkUbs.Text = "Use Broadcaster as Prefix";
            this.chkUbs.UseVisualStyleBackColor = true;
            this.chkUbs.CheckedChanged += new System.EventHandler(this.chkUseBroadcasterAsPre_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Slug:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Prefix:";
            // 
            // chkAddToQue
            // 
            this.chkAddToQue.AutoSize = true;
            this.chkAddToQue.Location = new System.Drawing.Point(197, 93);
            this.chkAddToQue.Name = "chkAddToQue";
            this.chkAddToQue.Size = new System.Drawing.Size(80, 17);
            this.chkAddToQue.TabIndex = 2;
            this.chkAddToQue.Text = "Add to Que";
            this.chkAddToQue.UseVisualStyleBackColor = true;
            this.chkAddToQue.CheckedChanged += new System.EventHandler(this.chkAddToQue_CheckedChanged);
            // 
            // txtSlug
            // 
            this.txtSlug.Location = new System.Drawing.Point(43, 41);
            this.txtSlug.Name = "txtSlug";
            this.txtSlug.Size = new System.Drawing.Size(234, 20);
            this.txtSlug.TabIndex = 0;
            // 
            // txtPre
            // 
            this.txtPre.Location = new System.Drawing.Point(43, 67);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(234, 20);
            this.txtPre.TabIndex = 3;
            // 
            // btDownloadByLink
            // 
            this.btDownloadByLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDownloadByLink.Location = new System.Drawing.Point(71, 262);
            this.btDownloadByLink.Name = "btDownloadByLink";
            this.btDownloadByLink.Size = new System.Drawing.Size(106, 23);
            this.btDownloadByLink.TabIndex = 2;
            this.btDownloadByLink.Text = "Download Single";
            this.btDownloadByLink.UseVisualStyleBackColor = true;
            this.btDownloadByLink.Click += new System.EventHandler(this.btDownloadByLink_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Location = new System.Drawing.Point(7, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Link:";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(43, 15);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(234, 20);
            this.txtLink.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label12.Location = new System.Drawing.Point(12, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Log:";
            // 
            // rtLog
            // 
            this.rtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rtLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.rtLog.Location = new System.Drawing.Point(12, 346);
            this.rtLog.Name = "rtLog";
            this.rtLog.ReadOnly = true;
            this.rtLog.Size = new System.Drawing.Size(863, 157);
            this.rtLog.TabIndex = 13;
            this.rtLog.Text = "";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.ForeColor = System.Drawing.Color.Black;
            this.lbVersion.Location = new System.Drawing.Point(73, 160);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(16, 13);
            this.lbVersion.TabIndex = 4;
            this.lbVersion.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 96);
            this.label4.TabIndex = 0;
            this.label4.Text = "This program was written to make downloading \r\nclips, provided by twitch, easier." +
    "\r\n\r\nVersion: \r\n\r\nFeatures: \r\n- Crawling Top Seen/Trending Clips filtered\r\n- Down" +
    "loading by Slug / Link";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbDownload,
            this.toolTipText,
            this.txtVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 514);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(890, 22);
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
            this.txtVersion.Size = new System.Drawing.Size(673, 17);
            this.txtVersion.Spring = true;
            this.txtVersion.Text = "VERSION";
            this.txtVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btLfSavePath);
            this.groupBox2.Controls.Add(this.lbVersion);
            this.groupBox2.Controls.Add(this.btSave);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSave);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.groupBox2.Location = new System.Drawing.Point(615, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 291);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Location = new System.Drawing.Point(862, 4);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(22, 23);
            this.btClose.TabIndex = 17;
            this.btClose.Text = "X";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 31);
            this.panel1.TabIndex = 18;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btLfSavePath
            // 
            this.btLfSavePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLfSavePath.Location = new System.Drawing.Point(220, 40);
            this.btLfSavePath.Name = "btLfSavePath";
            this.btLfSavePath.Size = new System.Drawing.Size(37, 23);
            this.btLfSavePath.TabIndex = 13;
            this.btLfSavePath.Text = "...";
            this.btLfSavePath.UseVisualStyleBackColor = true;
            this.btLfSavePath.Click += new System.EventHandler(this.btLfSavePath_Click);
            // 
            // chk_useGame
            // 
            this.chk_useGame.AutoSize = true;
            this.chk_useGame.Location = new System.Drawing.Point(96, 199);
            this.chk_useGame.Name = "chk_useGame";
            this.chk_useGame.Size = new System.Drawing.Size(76, 17);
            this.chk_useGame.TabIndex = 22;
            this.chk_useGame.Text = "Use Game";
            this.chk_useGame.UseVisualStyleBackColor = true;
            // 
            // chk_useChannel
            // 
            this.chk_useChannel.AutoSize = true;
            this.chk_useChannel.Location = new System.Drawing.Point(96, 222);
            this.chk_useChannel.Name = "chk_useChannel";
            this.chk_useChannel.Size = new System.Drawing.Size(113, 17);
            this.chk_useChannel.TabIndex = 23;
            this.chk_useChannel.Text = "Use Channelname";
            this.chk_useChannel.UseVisualStyleBackColor = true;
            // 
            // btLookUpTopOnly
            // 
            this.btLookUpTopOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLookUpTopOnly.Location = new System.Drawing.Point(6, 262);
            this.btLookUpTopOnly.Name = "btLookUpTopOnly";
            this.btLookUpTopOnly.Size = new System.Drawing.Size(114, 23);
            this.btLookUpTopOnly.TabIndex = 24;
            this.btLookUpTopOnly.Text = "Crawl top only";
            this.btLookUpTopOnly.UseVisualStyleBackColor = true;
            this.btLookUpTopOnly.Click += new System.EventHandler(this.btLookUpTopOnly_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(890, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.rtLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCD - Twitch Clip Downloader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing_1);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLimit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSlug;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btDownloadByLink;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolTipText;
        private System.Windows.Forms.ToolStripProgressBar pbDownload;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DomainUpDown sTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripStatusLabel txtVersion;
        private System.Windows.Forms.CheckBox chkAddToQue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox rtLog;
        private System.Windows.Forms.CheckBox chkUbs;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPre;
        private System.Windows.Forms.Button btStartDownloadQue;
        private System.Windows.Forms.ListBox lbQue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btLfSavePath;
        private System.Windows.Forms.FolderBrowserDialog fdb_SavePath;
        private System.Windows.Forms.CheckBox chk_useChannel;
        private System.Windows.Forms.CheckBox chk_useGame;
        private System.Windows.Forms.Button btLookUpTopOnly;
    }
}

