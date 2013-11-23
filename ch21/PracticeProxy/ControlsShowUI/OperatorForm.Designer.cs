namespace DonOfDesign.PracticeProxy.ControlsShowUI
{
    partial class OperatorForm
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
            this.gbEQPControls = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gbEQPControls
            // 
            this.gbEQPControls.Location = new System.Drawing.Point(12, 12);
            this.gbEQPControls.Name = "gbEQPControls";
            this.gbEQPControls.Size = new System.Drawing.Size(410, 255);
            this.gbEQPControls.TabIndex = 0;
            this.gbEQPControls.TabStop = false;
            this.gbEQPControls.Text = "Controls";
            // 
            // OperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 279);
            this.Controls.Add(this.gbEQPControls);
            this.Name = "OperatorForm";
            this.Text = "Operator Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OperatorForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEQPControls;
    }
}

