using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.IteratorPattern.ListCollection {
    public class ReverseList : List {
        public override IListIterator CreateIterator() {
            return new ReverseListIterator(this);
        }
    }

}
