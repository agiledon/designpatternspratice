using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DonOfDesign.IteratorPattern.YieldReturnReverseArrayList {
    public class ReverseArrayList : ArrayList {
        public override IEnumerator GetEnumerator() {
            for (int i = this.Count - 1; i >= 0; --i) {
                yield return this[i];
            }

        }
    }
}
