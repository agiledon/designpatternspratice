using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.IteratorPattern.ListCollection {
    public class SequenceListIterator : IListIterator {
        private List list = null;
        private int index;

        public SequenceListIterator(List list) {
            index = -1;
            this.list = list;
        }
        public void First() {
            index = 0;
        }
        public void Last() {
            index = list.Count - 1;
        }
        public object Current {
            get { return list[index]; }
        }
        public bool MoveNext() {
            index++;
            return list.Count > index;
        }
    }

}
