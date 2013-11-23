using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DonOfDesign.IteratorPattern.YieldReturnReverseArrayList {


    public delegate void MyDelegate(string target1,string target2);

    class Program {
        static void Main(string[] args) {
            ReverseArrayList ral = new ReverseArrayList();
            ral.Add(1);
            ral.Add(2);
            ral.Add(3);

            foreach (object i in ral) {
                Console.WriteLine(i);
            }

            Console.Read();
        }
    }
}
