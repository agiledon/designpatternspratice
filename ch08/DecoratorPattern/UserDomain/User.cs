using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.DecoratorPattern.UserDomain {
    public class User {
        public User() {
            this.Name = string.Empty;
            this.Password = string.Empty;
        }
        public User(string name, string password) {
            this.Name = name;
            this.Password = password;
        }

        public string Name {
            get;
            set;
        }
        public string Password {
            get;
            set;
        }
        public virtual void SignIn() {
            System.Windows.Forms.MessageBox.Show(string.Format("The User {0} Signs In.", Name));
        }
    }
}
