using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DonOfDesign.CORPattern.PracticeCORPattern {
    internal class AssignByPriorityAction : CancelAction {
        public AssignByPriorityAction(CancelAction action)
            : base(action) {
        }

        public override void Execute(Ticket ticket, Timeline timeline, DateTime cancelTime) {
            if (Between(timeline.PODeadline, timeline.ManagerDeadline, cancelTime)) {
                //查找最高优先级的后备员工
                Employee highPriority = new Employee();
                highPriority.Name = "Back Up";

                ticket.Owner = highPriority;

                Console.WriteLine("Assign by priority.");
            }
            else {
                if (m_hasNextAction) {
                    m_nextAction.Execute(ticket, timeline, cancelTime);
                }
            }
        }

    }
}
