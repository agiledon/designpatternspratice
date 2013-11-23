using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.IteratorPattern.ListCollection {
    public interface IListIterator {
        void First();
        void Last();
        bool MoveNext();
        object Current { get; }
    }
}
