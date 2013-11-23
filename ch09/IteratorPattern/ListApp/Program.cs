using System;
using System.Collections.Generic;
using System.Text;

using DonOfDesign.IteratorPattern.ListCollection;

namespace DonOfDesign.IteratorPattern.ListApp {
    class Program {
        static void Main(string[] args) {
            List list = new List();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            IListIterator iterator = list.CreateIterator();
            while (iterator.MoveNext()) {
                Console.WriteLine(iterator.Current);
            }

            ReverseList revList = new ReverseList();
            revList.Add(1);
            revList.Add(2);
            revList.Add(3);

            IListIterator revIterator = revList.CreateIterator();

            while (revIterator.MoveNext()) {
                Console.WriteLine(revIterator.Current);
            }


            Console.Read();
        }
    }
}
