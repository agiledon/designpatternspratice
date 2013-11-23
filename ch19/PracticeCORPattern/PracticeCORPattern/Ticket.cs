using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DonOfDesign.CORPattern.PracticeCORPattern {
    public class Ticket {
        public int TicketID {
            get;
            set;
        }

        public TrainingPlan TrainingPlan {
            get;
            set;
        }
        public Employee ProgramOwner {
            get;
            set;
        }
        public Employee Manager {
            get;
            set;
        }
        public Employee Owner {
            get;
            set;
        }
        public string CurrentState {
            get;
            set;
        }

        public void Cancel() {
            //根据Ticket的TrainingPlan查询TimeLine表,获得Timeline领域对象
            Timeline timeline = new Timeline();

            CancelAction action = new CancelActionCreator().Create();

            action.Execute(this, timeline, DateTime.Now);
        }

    }

    public class TrainingPlan {
    }

    public class Employee {
        public Employee() {
            this.IsAttended = false;
        }

        public string EmployeeID {
            get;
            set;
        }
        public string Name {
            get;
            set;
        }
        public string Email {
            get;
            set;
        }
        public bool IsAttended {
            get;
            set;
        }
    }
}
