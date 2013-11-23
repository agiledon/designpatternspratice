using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DonOfDesign.CORPattern.PracticeCORPattern {
    internal class NoShowAction : CancelAction {
        public NoShowAction(CancelAction action)
            : base(action) {
        }

        public override void Execute(Ticket ticket, Timeline timeline, DateTime cancelTime) {
            if (Between(timeline.NoShowDeadline, timeline.TrainingEndTime, cancelTime)) {
                ticket.Owner.IsAttended = false;
                Console.WriteLine("No Show.");
            }
            else {
                if (m_hasNextAction) {
                    m_nextAction.Execute(ticket, timeline, cancelTime);
                }
            }
        }
    }
}
