using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.DecoratorPattern.UserDomain {
    public class SafeUser : User {
        private User m_user;

        public SafeUser(User user) {
            m_user = user;
        }

        public override void SignIn() {
            if (IsValid()) {
                m_user.SignIn();
            }
            else {
                throw new NotAuthorizatedException("Not Authorizated");
            }
        }
        private bool IsValid() {
            if ((m_user.Name == "admin") && (m_user.Password == "admin")) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
