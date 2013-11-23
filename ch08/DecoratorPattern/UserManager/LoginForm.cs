using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DonOfDesign.DecoratorPattern.UserDomain;

namespace DonOfDesign.DecoratorPattern.UserManager {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private string m_name;
        private string m_password;

        private void GetTextBoxValues() {
            m_name = txtName.Text;
            m_password = txtPwd.Text;
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            GetTextBoxValues();
            User user = new User(m_name, m_password);

            user.SignIn();
        }

        private void btnSecurityLogin_Click(object sender, EventArgs e) {
            try {
                GetTextBoxValues();
                User user = new User(m_name, m_password);

                var securityDec = new SafeUser(user);

                securityDec.SignIn();
            }
            catch (NotAuthorizatedException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoggingSecurityLogin_Click(object sender, EventArgs e) {
            try {
                GetTextBoxValues();
                User user = new User(m_name, m_password);

                var loggingDec = new UserWithLog(new SafeUser(user));

                loggingDec.SignIn();
            }
            catch (NotAuthorizatedException ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}