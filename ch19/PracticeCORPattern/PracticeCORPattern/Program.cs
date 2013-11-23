using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace DonOfDesign.CORPattern.PracticeCORPattern {
    class Program {
        static void Main(string[] args) {
            Ticket ticket = new Ticket();
            ticket.Cancel();

            Console.Read();
        }

        public static bool Between(DateTime beginTime, DateTime endTime, DateTime currentTime) {
            Debug.Assert(beginTime < endTime);
            return currentTime >= beginTime && currentTime < endTime;
        }
    }
}
