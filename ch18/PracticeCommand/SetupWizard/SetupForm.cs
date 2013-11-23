using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DonOfDesign.PracticePatterns.SetupWizard
{
	public class SetupForm : System.Windows.Forms.Form
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnCancle;
		private System.Windows.Forms.Button btnBefore;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Panel panTitle;
		private System.Windows.Forms.Panel panBody;
        private TitleUC titleUC = null;
        private AbortBodyUC abortUC = new AbortBodyUC();

        public ISetupCommand CurrentCommand
        {
            get;
            set;
        }

 		public SetupForm()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.panTitle = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnBefore = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panBody = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panTitle
            // 
            this.panTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitle.Location = new System.Drawing.Point(0, 0);
            this.panTitle.Name = "panTitle";
            this.panTitle.Size = new System.Drawing.Size(456, 63);
            this.panTitle.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(-7, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 8);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(210, 296);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(74, 23);
            this.btnCancle.TabIndex = 6;
            this.btnCancle.Text = "取消(&C)";
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnBefore
            // 
            this.btnBefore.Location = new System.Drawing.Point(290, 296);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(74, 23);
            this.btnBefore.TabIndex = 7;
            this.btnBefore.Text = "< 上一步(&B)";
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(370, 296);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(74, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "下一步(&N) >";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panBody
            // 
            this.panBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.panBody.Location = new System.Drawing.Point(0, 63);
            this.panBody.Name = "panBody";
            this.panBody.Size = new System.Drawing.Size(456, 204);
            this.panBody.TabIndex = 9;
            // 
            // SetupForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(456, 341);
            this.Controls.Add(this.panBody);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBefore);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "安装向导";
            this.Load += new System.EventHandler(this.SetupForm_Load);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new SetupForm());
		}	
	
		private void SetupForm_Load(object sender, System.EventArgs e)
		{
			
			btnBefore.Enabled = false;
            btnNext.Enabled = true;
            btnCancle.Enabled = true;

            AddTitleUC("导入安装包");
            ImportSetupFileCommand command = new ImportSetupFileCommand(this);
            AddBodyUC(command);
            this.CurrentCommand = command;

		}

		private void btnCancle_Click(object sender, System.EventArgs e)
		{
			if (MessageBox.Show("尚未完成安装。确实要退出吗？","提示",MessageBoxButtons.OKCancel,
				MessageBoxIcon.Information) == DialogResult.OK)
			{
				btnCancle.Enabled = false;
				btnBefore.Enabled = false;

				Abort();
			}			
		}

		public void AddTitleUC(string title)
		{
			panTitle.Controls.Clear();
			titleUC = new TitleUC();
			titleUC.Title = title;
			panTitle.Controls.Add(titleUC);
			panTitle.Refresh();
		}

		public void AddBodyUC(UserControl uc)
		{
			panBody.Controls.Clear();
			panBody.Controls.Add(uc);	
			panBody.Refresh();
		}

        public void SetBeforeButtonEnabled(bool value)
        {
            btnBefore.Enabled = value;
        }

        public void SetNextButtonEnabled(bool value)
        {
            btnNext.Enabled = value;
        }

        public void SetCancleButtonEnabled(bool value)
        {
            btnCancle.Enabled = value;
        }

        public void SetNextButtonToClose()
        {
            btnNext.Text = "关闭(&C)...";	
        }

        public void RestoreNextButton()
        {
            btnNext.Text = "下一步(&N) >";
        }

		//被中断或取消;
		public void Abort()
		{
			AddTitleUC("安装被中断");	
			AddBodyUC(abortUC);			

			btnNext.Enabled = true;
			btnNext.Text = "关闭(&C)...";
		}


		private void btnNext_Click(object sender, System.EventArgs e)
		{
			if (btnNext.Text == "关闭(&C)...")
			{
				this.Close();
			}
			else
			{
                CurrentCommand.SetupForward();               
			}
		}

		private void btnBefore_Click(object sender, System.EventArgs e)
		{
            CurrentCommand.SetupBackward();
		}		
	}
}
