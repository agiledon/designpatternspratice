using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace DonOfDesign.CompositePattern.WordProcessor {
    public interface IElement {
        void ChangeFont(Font font);
        void Show();
        void Print();
    }

}
