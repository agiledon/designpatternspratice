using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace DonOfDesign.CompositePattern.WordProcessor {
    public class Paragraph : CompositeElement {
        public override void Add(IElement element) {
            if (element is Document) {
                throw new NotSupportedException("Can not add the Document object.");
            }
            else {
                base.Add(element);
            }
        }
        public override void Show() {
            base.Show();
            Console.WriteLine();
        }

    }

}
