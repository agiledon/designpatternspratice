using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.IteratorPattern.ListCollection {
    public class ReverseListIterator : IListIterator {
        private List list = null;
        private int index;

        public ReverseListIterator(List list) {
            index = list.Count;
            this.list = list;
        }
        public void First() {
            index = list.Count - 1;
        }
        public void Last() {
            index = 0;
        }
        public object Current {
            get { return list[index]; }
        }
        public bool MoveNext() {
            index--;
            return index >= 0;
        }
    }
}
