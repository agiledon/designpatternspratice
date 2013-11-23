using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DonOfDesign.DecoratorPattern.UserDomain {
    public class UserWithLog : User {
        private User m_user;

        public UserWithLog(User user) {
            m_user = user;
        }

        public override void SignIn() {
            m_user.SignIn();
            Logging();
        }
        private void Logging() {
            using (StreamWriter writer = new StreamWriter("log.txt", true)) {
                writer.WriteLine("{0} had signed in at {1}", m_user.Name, DateTime.Now);
            }
        }
    }

}
