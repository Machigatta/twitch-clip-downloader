namespace TwitchClipDownloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbGame = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bLookupTop = new System.Windows.Forms.Button();
            this.ckTrend = new System.Windows.Forms.CheckBox();
            this.cbPeriod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtLog = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbDownload = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbGame
            // 
            this.cbGame.FormattingEnabled = true;
            this.cbGame.Items.AddRange(new object[] {
            "PLAYERUNKNOWN\'S BATTLEGROUNDS",
            "Fortnite"});
            this.cbGame.Location = new System.Drawing.Point(53, 12);
            this.cbGame.Name = "cbGame";
            this.cbGame.Size = new System.Drawing.Size(203, 21);
            this.cbGame.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game:";
            // 
            // bLookupTop
            // 
            this.bLookupTop.Location = new System.Drawing.Point(551, 69);
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
            this.ckTrend.Location = new System.Drawing.Point(562, 14);
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
            this.cbPeriod.Location = new System.Drawing.Point(308, 12);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Size = new System.Drawing.Size(89, 21);
            this.cbPeriod.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Period:";
            // 
            // rtLog
            // 
            this.rtLog.Location = new System.Drawing.Point(15, 111);
            this.rtLog.Name = "rtLog";
            this.rtLog.Size = new System.Drawing.Size(611, 129);
            this.rtLog.TabIndex = 6;
            this.rtLog.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Log:";
            // 
            // pbDownload
            // 
            this.pbDownload.Location = new System.Drawing.Point(15, 69);
            this.pbDownload.Name = "pbDownload";
            this.pbDownload.Size = new System.Drawing.Size(530, 23);
            this.pbDownload.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Download-Progress";
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(12, 259);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(533, 20);
            this.txtSave.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "SavePath";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(551, 259);
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
            this.label6.Location = new System.Drawing.Point(403, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Language:";
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(467, 13);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(89, 20);
            this.txtLanguage.TabIndex = 14;
            this.txtLanguage.Text = "en,de";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(638, 291);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbDownload);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPeriod);
            this.Controls.Add(this.ckTrend);
            this.Controls.Add(this.bLookupTop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Twitch Clip Downloader";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pbDownload;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLanguage;
    }
}

