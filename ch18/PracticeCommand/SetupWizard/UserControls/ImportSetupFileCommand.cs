using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace DonOfDesign.PracticePatterns.SetupWizard
{
	/// <summary>
	/// BodyUC 的摘要说明。
	/// </summary>
	public class ImportSetupFileCommand : System.Windows.Forms.UserControl,ISetupCommand
	{
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnImport;
		private System.Windows.Forms.TextBox txtFileName;
		private System.Windows.Forms.OpenFileDialog openFileDlg;
		/// <summary> 
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label1;
        private SetupForm m_form;

        public ImportSetupFileCommand(SetupForm form)
        {
            // 该调用是 Windows.Forms 窗体设计器所必需的。
            InitializeComponent();

            m_form = form;

        }

		/// <summary> 
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region 组件设计器生成的代码
		/// <summary> 
		/// 设计器支持所需的方法 - 不要使用代码编辑器 
		/// 修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "选择要安装和更新的压缩包:";
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 3);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnImport
            // 
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImport.Location = new System.Drawing.Point(360, 52);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(80, 26);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "导入(&I)...";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtFileName.Location = new System.Drawing.Point(16, 56);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(336, 20);
            this.txtFileName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "提示: 导入的压缩包为发布方提供的安装包或更新包文件。";
            // 
            // ImportSetupFileCommand
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtFileName);
            this.Name = "ImportSetupFileCommand";
            this.Size = new System.Drawing.Size(456, 220);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void btnImport_Click(object sender, System.EventArgs e)
		{
			openFileDlg.Filter = "WinZip压缩包文件(*.zip)|*.zip";
			openFileDlg.RestoreDirectory = true;
			if (openFileDlg.ShowDialog() == DialogResult.OK)
			{
				txtFileName.Text = openFileDlg.FileName;
                m_form.SetNextButtonEnabled(true);
			}
			else
			{
				txtFileName.Text = "";				
			}
		}
		

        #region ISetupCommand Members

        public void SetupForward()
        {            
            if (string.IsNullOrEmpty(txtFileName.Text))
            {
                MessageBox.Show("未选择安装包文件，请选择。", "警告", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                m_form.SetNextButtonEnabled(false);
            }
            else
            {
                PropertySet.AddProperty("zipfile", txtFileName.Text.Trim());

                m_form.AddTitleUC("指定安装目录");
                SelectSetupDirCommand command = new SelectSetupDirCommand(m_form);
                m_form.AddBodyUC(command);
                m_form.SetBeforeButtonEnabled(true);
                m_form.CurrentCommand = command;                
            }
        }

        public void SetupBackward()
        {
           //do nothing
        }

        #endregion
    }
}
