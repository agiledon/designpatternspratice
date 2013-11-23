using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DonOfDesign.CORPattern.PracticeCORPattern {
    internal class SendEmailAction : CancelAction {
        public SendEmailAction(CancelAction action)
            : base(action) {
        }

        public override void Execute(Ticket ticket, Timeline timeline, DateTime cancelTime) {
            if (Between(timeline.TicketAssignedTime, timeline.PODeadline, cancelTime)) {
                //发送邮件给PO;
                Console.WriteLine("Send the email to PO");
            }
            else {
                if (m_hasNextAction) {
                    m_nextAction.Execute(ticket, timeline, cancelTime);
                }
            }
        }
    }
}
