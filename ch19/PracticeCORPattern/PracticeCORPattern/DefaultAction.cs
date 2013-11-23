using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DonOfDesign.CORPattern.PracticeCORPattern {
    internal class DefaultAction : CancelAction {
        public override void Execute(Ticket ticket, Timeline timeline, DateTime cancelTime) {
            ticket.CurrentState = "CANCEL";
            Console.WriteLine("Default Action is {0}",ticket.CurrentState);
        }
    }
}
