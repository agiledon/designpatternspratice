namespace DonOfDesign.DecoratorPattern.MediaPlayer
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnTune = new System.Windows.Forms.Button();
            this.btnShowScript = new System.Windows.Forms.Button();
            this.btnPlayAdCR = new System.Windows.Forms.Button();
            this.btnPlayAd = new System.Windows.Forms.Button();
            this.btnPlayCR = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(379, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(94, 22);
            this.mnuOpen.Text = "&Open";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(91, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(94, 22);
            this.mnuExit.Text = "&Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(30, 76);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(111, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnTune
            // 
            this.btnTune.Location = new System.Drawing.Point(30, 116);
            this.btnTune.Name = "btnTune";
            this.btnTune.Size = new System.Drawing.Size(111, 23);
            this.btnTune.TabIndex = 2;
            this.btnTune.Text = "Tune";
            this.btnTune.UseVisualStyleBackColor = true;
            this.btnTune.Click += new System.EventHandler(this.btnTune_Click);
            // 
            // btnShowScript
            // 
            this.btnShowScript.Location = new System.Drawing.Point(30, 161);
            this.btnShowScript.Name = "btnShowScript";
            this.btnShowScript.Size = new System.Drawing.Size(111, 23);
            this.btnShowScript.TabIndex = 3;
            this.btnShowScript.Text = "Show Script";
            this.btnShowScript.UseVisualStyleBackColor = true;
            this.btnShowScript.Click += new System.EventHandler(this.btnShowScript_Click);
            // 
            // btnPlayAdCR
            // 
            this.btnPlayAdCR.Location = new System.Drawing.Point(212, 161);
            this.btnPlayAdCR.Name = "btnPlayAdCR";
            this.btnPlayAdCR.Size = new System.Drawing.Size(155, 45);
            this.btnPlayAdCR.TabIndex = 6;
            this.btnPlayAdCR.Text = "Play With Advertisement and Copyright";
            this.btnPlayAdCR.UseVisualStyleBackColor = true;
            this.btnPlayAdCR.Click += new System.EventHandler(this.btnPlayAdCR_Click);
            // 
            // btnPlayAd
            // 
            this.btnPlayAd.Location = new System.Drawing.Point(212, 116);
            this.btnPlayAd.Name = "btnPlayAd";
            this.btnPlayAd.Size = new System.Drawing.Size(155, 23);
            this.btnPlayAd.TabIndex = 5;
            this.btnPlayAd.Text = "Play With Advertisement";
            this.btnPlayAd.UseVisualStyleBackColor = true;
            this.btnPlayAd.Click += new System.EventHandler(this.btnPlayAd_Click);
            // 
            // btnPlayCR
            // 
            this.btnPlayCR.Location = new System.Drawing.Point(212, 76);
            this.btnPlayCR.Name = "btnPlayCR";
            this.btnPlayCR.Size = new System.Drawing.Size(155, 23);
            this.btnPlayCR.TabIndex = 4;
            this.btnPlayCR.Text = "Play With Copyright";
            this.btnPlayCR.UseVisualStyleBackColor = true;
            this.btnPlayCR.Click += new System.EventHandler(this.btnPlayCR_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 266);
            this.Controls.Add(this.btnPlayAdCR);
            this.Controls.Add(this.btnPlayAd);
            this.Controls.Add(this.btnPlayCR);
            this.Controls.Add(this.btnShowScript);
            this.Controls.Add(this.btnTune);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "MeidaPlayer";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnTune;
        private System.Windows.Forms.Button btnShowScript;
        private System.Windows.Forms.Button btnPlayAdCR;
        private System.Windows.Forms.Button btnPlayAd;
        private System.Windows.Forms.Button btnPlayCR;
    }
}

