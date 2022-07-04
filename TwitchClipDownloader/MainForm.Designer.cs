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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cbGame = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bLookupTop = new System.Windows.Forms.Button();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numLimit = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbQue = new System.Windows.Forms.ListBox();
            this.btStartDownloadQue = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chkAddToQue = new System.Windows.Forms.CheckBox();
            this.txtSlug = new System.Windows.Forms.TextBox();
            this.txtSyntax = new System.Windows.Forms.TextBox();
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
            this.lbNewVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtClientSecret = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btLfSavePath = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.fdb_SavePath = new System.Windows.Forms.FolderBrowserDialog();
            this.versionTimer = new System.Windows.Forms.Timer(this.components);
            this.rtLogDetailed = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLimit)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbGame
            // 
            this.cbGame.FormattingEnabled = true;
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
            this.bLookupTop.Location = new System.Drawing.Point(227, 230);
            this.bLookupTop.Name = "bLookupTop";
            this.bLookupTop.Size = new System.Drawing.Size(75, 23);
            this.bLookupTop.TabIndex = 2;
            this.bLookupTop.Text = "Crawl";
            this.bLookupTop.UseVisualStyleBackColor = true;
            this.bLookupTop.Click += new System.EventHandler(this.bLookupTop_Click);
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(64, 17);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(150, 20);
            this.txtSave.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Save Path:";
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Location = new System.Drawing.Point(182, 230);
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
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.bLookupTop);
            this.groupBox1.Controls.Add(this.txtChannel);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLanguage);
            this.groupBox1.Controls.Add(this.cbGame);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 259);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crawler";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numLimit);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.dtTo);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.dtFrom);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(6, 93);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(296, 103);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Time-Filter";
            // 
            // numLimit
            // 
            this.numLimit.Location = new System.Drawing.Point(158, 66);
            this.numLimit.Name = "numLimit";
            this.numLimit.Size = new System.Drawing.Size(132, 20);
            this.numLimit.TabIndex = 19;
            this.numLimit.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "To:";
            // 
            // dtTo
            // 
            this.dtTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtTo.CustomFormat = "DD.MM.YYYY";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtTo.Location = new System.Drawing.Point(158, 40);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(132, 20);
            this.dtTo.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "From:";
            // 
            // dtFrom
            // 
            this.dtFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtFrom.CustomFormat = "DD.MM.YYYY";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtFrom.Location = new System.Drawing.Point(158, 15);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(132, 20);
            this.dtFrom.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Limit:";
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
            // lbQue
            // 
            this.lbQue.FormattingEnabled = true;
            this.lbQue.Location = new System.Drawing.Point(10, 116);
            this.lbQue.Name = "lbQue";
            this.lbQue.Size = new System.Drawing.Size(267, 82);
            this.lbQue.TabIndex = 6;
            // 
            // btStartDownloadQue
            // 
            this.btStartDownloadQue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStartDownloadQue.Location = new System.Drawing.Point(183, 230);
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
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btStartDownloadQue);
            this.groupBox3.Controls.Add(this.chkAddToQue);
            this.groupBox3.Controls.Add(this.txtSlug);
            this.groupBox3.Controls.Add(this.btDownloadByLink);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtLink);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.groupBox3.Location = new System.Drawing.Point(322, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 259);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Direct Download ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Slug:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Name-Syntax:";
            // 
            // chkAddToQue
            // 
            this.chkAddToQue.AutoSize = true;
            this.chkAddToQue.Location = new System.Drawing.Point(197, 70);
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
            // txtSyntax
            // 
            this.txtSyntax.Location = new System.Drawing.Point(9, 114);
            this.txtSyntax.Name = "txtSyntax";
            this.txtSyntax.Size = new System.Drawing.Size(248, 20);
            this.txtSyntax.TabIndex = 3;
            // 
            // btDownloadByLink
            // 
            this.btDownloadByLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDownloadByLink.Location = new System.Drawing.Point(71, 230);
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
            this.label12.Location = new System.Drawing.Point(12, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Log:";
            // 
            // rtLog
            // 
            this.rtLog.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.rtLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.rtLog.Location = new System.Drawing.Point(15, 318);
            this.rtLog.Name = "rtLog";
            this.rtLog.ReadOnly = true;
            this.rtLog.Size = new System.Drawing.Size(429, 233);
            this.rtLog.TabIndex = 13;
            this.rtLog.Text = "";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.ForeColor = System.Drawing.Color.Black;
            this.lbVersion.Location = new System.Drawing.Point(50, 177);
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
            this.label4.Location = new System.Drawing.Point(4, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 108);
            this.label4.TabIndex = 0;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbDownload,
            this.toolTipText,
            this.lbNewVersion,
            this.txtVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 579);
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
            // lbNewVersion
            // 
            this.lbNewVersion.ForeColor = System.Drawing.Color.DarkRed;
            this.lbNewVersion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lbNewVersion.Name = "lbNewVersion";
            this.lbNewVersion.Size = new System.Drawing.Size(336, 17);
            this.lbNewVersion.Spring = true;
            this.lbNewVersion.Text = "VERSION";
            this.lbNewVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVersion
            // 
            this.txtVersion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(336, 17);
            this.txtVersion.Spring = true;
            this.txtVersion.Text = "VERSION";
            this.txtVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtClientSecret);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtClientId);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btLfSavePath);
            this.groupBox2.Controls.Add(this.lbVersion);
            this.groupBox2.Controls.Add(this.txtSyntax);
            this.groupBox2.Controls.Add(this.btSave);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSave);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.groupBox2.Location = new System.Drawing.Point(615, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 259);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // txtClientSecret
            // 
            this.txtClientSecret.Location = new System.Drawing.Point(117, 67);
            this.txtClientSecret.Name = "txtClientSecret";
            this.txtClientSecret.Size = new System.Drawing.Size(140, 20);
            this.txtClientSecret.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Twitch-Client-Secret:";
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(95, 41);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(162, 20);
            this.txtClientId.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Twitch-Client-Id:";
            // 
            // btLfSavePath
            // 
            this.btLfSavePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLfSavePath.Location = new System.Drawing.Point(220, 15);
            this.btLfSavePath.Name = "btLfSavePath";
            this.btLfSavePath.Size = new System.Drawing.Size(37, 23);
            this.btLfSavePath.TabIndex = 13;
            this.btLfSavePath.Text = "...";
            this.btLfSavePath.UseVisualStyleBackColor = true;
            this.btLfSavePath.Click += new System.EventHandler(this.btLfSavePath_Click);
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
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 31);
            this.panel1.TabIndex = 18;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(6, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Twitch Clip Downloader";
            // 
            // versionTimer
            // 
            this.versionTimer.Enabled = true;
            this.versionTimer.Interval = 30000;
            this.versionTimer.Tick += new System.EventHandler(this.versionTimer_TickAsync);
            // 
            // rtLogDetailed
            // 
            this.rtLogDetailed.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtLogDetailed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.rtLogDetailed.Location = new System.Drawing.Point(450, 318);
            this.rtLogDetailed.Name = "rtLogDetailed";
            this.rtLogDetailed.ReadOnly = true;
            this.rtLogDetailed.Size = new System.Drawing.Size(422, 233);
            this.rtLogDetailed.TabIndex = 19;
            this.rtLogDetailed.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(447, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Detailed-Log:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(15, 558);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(697, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "For the TwitchClient-ID and TwitchClient-Secret go to                            " +
    "    and register your application.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(346, 558);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(181, 13);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://dev.twitch.tv/console";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(890, 601);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtLogDetailed);
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLimit)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bLookupTop;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.ToolStripStatusLabel txtVersion;
        private System.Windows.Forms.CheckBox chkAddToQue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox rtLog;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSyntax;
        private System.Windows.Forms.Button btStartDownloadQue;
        private System.Windows.Forms.ListBox lbQue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btLfSavePath;
        private System.Windows.Forms.FolderBrowserDialog fdb_SavePath;
        private System.Windows.Forms.Timer versionTimer;
        private System.Windows.Forms.ToolStripStatusLabel lbNewVersion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox rtLogDetailed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numLimit;
        private System.Windows.Forms.TextBox txtClientSecret;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

