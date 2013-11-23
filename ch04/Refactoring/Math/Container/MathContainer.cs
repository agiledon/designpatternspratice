using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace DonOfDesign.Refactoring.Math {
    public abstract class MathContainer {
        public MathContainer() {
            m_mathList = new List<long>();
        }
        public MathContainer(int capacity) {
            m_mathList = new List<long>(capacity);
        }

        protected IList<long> m_mathList;

        public long this[int index] {
            get { return (long)m_mathList[index]; }
            set { m_mathList[index] = (long)value; }
        }
        public void Add() {
            m_mathList.Add(Count());
        }
        public void RemoveAt(int index) {
            m_mathList.RemoveAt(index);
        }
        public void Clear() {
            m_mathList.Clear();
        }
        protected abstract long Count();
    }

}
