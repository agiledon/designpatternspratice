using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DonOfDesign.CORPattern.PracticeCORPattern {
    internal class CancelActionCreator {
        public virtual CancelAction Create() {
            CancelAction defaultAction = new DefaultAction();
            CancelAction noShowAction = new NoShowAction(defaultAction);
            CancelAction lostAction = new LostAction(noShowAction);
            CancelAction assignAction = new AssignByPriorityAction(lostAction);
            CancelAction sendEmailAction = new SendEmailAction(assignAction);

            return sendEmailAction;
        }
    }
}
