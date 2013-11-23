using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DonOfDesign.CORPattern.PracticeCORPattern {
    public class Timeline {
        public DateTime TicketAssignedTime {
            get;
            set;
        }
        public DateTime PODeadline {
            get;
            set;
        }
        public DateTime ManagerDeadline {
            get;
            set;
        }
        public DateTime NoShowDeadline {
            get;
            set;
        }
        public DateTime TrainingEndTime {
            get;
            set;
        }
    }
}
