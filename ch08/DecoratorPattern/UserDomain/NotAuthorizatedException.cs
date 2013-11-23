using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.DecoratorPattern.UserDomain {
    public class NotAuthorizatedException : System.Exception {
        public NotAuthorizatedException(string message)
            : base(message) {
        }
    }
}
