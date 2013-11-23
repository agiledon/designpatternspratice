namespace DonOfDesign.AdapterPattern.MediaPlayer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPlayMedia = new System.Windows.Forms.Button();
            this.btnStopMedia = new System.Windows.Forms.Button();
            this.btnForwardMedia = new System.Windows.Forms.Button();
            this.btnBackwardMedia = new System.Windows.Forms.Button();
            this.btnBackwardRadio = new System.Windows.Forms.Button();
            this.btnForwardRadio = new System.Windows.Forms.Button();
            this.btnStopRadio = new System.Windows.Forms.Button();
            this.btnPlayRadio = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBackwardMedia);
            this.groupBox1.Controls.Add(this.btnForwardMedia);
            this.groupBox1.Controls.Add(this.btnStopMedia);
            this.groupBox1.Controls.Add(this.btnPlayMedia);
            this.groupBox1.Location = new System.Drawing.Point(34, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Media Player";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBackwardRadio);
            this.groupBox2.Controls.Add(this.btnForwardRadio);
            this.groupBox2.Controls.Add(this.btnStopRadio);
            this.groupBox2.Controls.Add(this.btnPlayRadio);
            this.groupBox2.Location = new System.Drawing.Point(34, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 119);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Radio Player";
            // 
            // btnPlayMedia
            // 
            this.btnPlayMedia.Location = new System.Drawing.Point(42, 29);
            this.btnPlayMedia.Name = "btnPlayMedia";
            this.btnPlayMedia.Size = new System.Drawing.Size(75, 23);
            this.btnPlayMedia.TabIndex = 0;
            this.btnPlayMedia.Text = "Play";
            this.btnPlayMedia.UseVisualStyleBackColor = true;
            this.btnPlayMedia.Click += new System.EventHandler(this.btnPlayMedia_Click);
            // 
            // btnStopMedia
            // 
            this.btnStopMedia.Location = new System.Drawing.Point(42, 74);
            this.btnStopMedia.Name = "btnStopMedia";
            this.btnStopMedia.Size = new System.Drawing.Size(75, 23);
            this.btnStopMedia.TabIndex = 1;
            this.btnStopMedia.Text = "Stop";
            this.btnStopMedia.UseVisualStyleBackColor = true;
            this.btnStopMedia.Click += new System.EventHandler(this.btnStopMedia_Click);
            // 
            // btnForwardMedia
            // 
            this.btnForwardMedia.Location = new System.Drawing.Point(188, 29);
            this.btnForwardMedia.Name = "btnForwardMedia";
            this.btnForwardMedia.Size = new System.Drawing.Size(75, 23);
            this.btnForwardMedia.TabIndex = 2;
            this.btnForwardMedia.Text = "Forward";
            this.btnForwardMedia.UseVisualStyleBackColor = true;
            this.btnForwardMedia.Click += new System.EventHandler(this.btnForwardMedia_Click);
            // 
            // btnBackwardMedia
            // 
            this.btnBackwardMedia.Location = new System.Drawing.Point(188, 74);
            this.btnBackwardMedia.Name = "btnBackwardMedia";
            this.btnBackwardMedia.Size = new System.Drawing.Size(75, 23);
            this.btnBackwardMedia.TabIndex = 3;
            this.btnBackwardMedia.Text = "Backward";
            this.btnBackwardMedia.UseVisualStyleBackColor = true;
            this.btnBackwardMedia.Click += new System.EventHandler(this.btnBackwardMedia_Click);
            // 
            // btnBackwardRadio
            // 
            this.btnBackwardRadio.Location = new System.Drawing.Point(142, 70);
            this.btnBackwardRadio.Name = "btnBackwardRadio";
            this.btnBackwardRadio.Size = new System.Drawing.Size(154, 23);
            this.btnBackwardRadio.TabIndex = 7;
            this.btnBackwardRadio.Text = "Backward(Modulate Down)";
            this.btnBackwardRadio.UseVisualStyleBackColor = true;
            this.btnBackwardRadio.Click += new System.EventHandler(this.btnBackwardRadio_Click);
            // 
            // btnForwardRadio
            // 
            this.btnForwardRadio.Location = new System.Drawing.Point(142, 25);
            this.btnForwardRadio.Name = "btnForwardRadio";
            this.btnForwardRadio.Size = new System.Drawing.Size(154, 23);
            this.btnForwardRadio.TabIndex = 6;
            this.btnForwardRadio.Text = "Forward(Modulate Up)";
            this.btnForwardRadio.UseVisualStyleBackColor = true;
            this.btnForwardRadio.Click += new System.EventHandler(this.btnForwardRadio_Click);
            // 
            // btnStopRadio
            // 
            this.btnStopRadio.Location = new System.Drawing.Point(30, 70);
            this.btnStopRadio.Name = "btnStopRadio";
            this.btnStopRadio.Size = new System.Drawing.Size(91, 23);
            this.btnStopRadio.TabIndex = 5;
            this.btnStopRadio.Text = "Stop(Stop)";
            this.btnStopRadio.UseVisualStyleBackColor = true;
            this.btnStopRadio.Click += new System.EventHandler(this.btnStopRadio_Click);
            // 
            // btnPlayRadio
            // 
            this.btnPlayRadio.Location = new System.Drawing.Point(30, 25);
            this.btnPlayRadio.Name = "btnPlayRadio";
            this.btnPlayRadio.Size = new System.Drawing.Size(91, 23);
            this.btnPlayRadio.TabIndex = 4;
            this.btnPlayRadio.Text = "Play(Receive)";
            this.btnPlayRadio.UseVisualStyleBackColor = true;
            this.btnPlayRadio.Click += new System.EventHandler(this.btnPlayRadio_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 326);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBackwardMedia;
        private System.Windows.Forms.Button btnForwardMedia;
        private System.Windows.Forms.Button btnStopMedia;
        private System.Windows.Forms.Button btnPlayMedia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBackwardRadio;
        private System.Windows.Forms.Button btnForwardRadio;
        private System.Windows.Forms.Button btnStopRadio;
        private System.Windows.Forms.Button btnPlayRadio;
    }
}

