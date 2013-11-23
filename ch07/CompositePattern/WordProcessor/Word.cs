using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace DonOfDesign.CompositePattern.WordProcessor {
    public class Word : IElement {
        private Font m_font;
        public Font Font {
            get { return m_font; }
        }

        #region IElement Members

        public void ChangeFont(Font font) {
            m_font = font;
        }
        public void Show() {
            Console.WriteLine(this);
        }
        public void Print() {
            Console.WriteLine("Print Word");
        }

        #endregion
    }
}
