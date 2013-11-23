using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DonOfDesign.CORPattern.PracticeCORPattern {
    internal class LostAction : CancelAction {
        public LostAction(CancelAction action)
            : base(action) {
        }

        public override void Execute(Ticket ticket, Timeline timeline, DateTime cancelTime) {
            if (Between(timeline.ManagerDeadline, timeline.NoShowDeadline, cancelTime)) {
                ticket.CurrentState = "LOST";
                Console.WriteLine(ticket.CurrentState);
            }
            else {
                if (m_hasNextAction) {
                    m_nextAction.Execute(ticket, timeline, cancelTime);
                }
            }
        }
    }
}
