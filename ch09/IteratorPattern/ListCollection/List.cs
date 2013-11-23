using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.IteratorPattern.ListCollection {
    public class List {
        private ArrayList m_list = new ArrayList();

        public virtual IListIterator CreateIterator() {
            return new SequenceListIterator(this);
        }

        public void Add(object value) {
            m_list.Add(value);
        }
        public void Remove(object value) {
            m_list.Remove(value);
        }
        public void Clear() {
            m_list.Clear();
        }

        public int Count {
            get { return m_list.Count; }
        }

        public object this[int index] {
            get { return m_list[index]; }
        }
    }

}
