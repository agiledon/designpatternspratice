using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace DonOfDesign.CompositePattern.WordProcessor {
    public abstract class CompositeElement : IElement {
        protected IList<IElement> elements = new List<IElement>();

        public virtual void Add(IElement element) {
            elements.Add(element);
        }
        public virtual void Remove(IElement element) {
            elements.Remove(element);
        }

        #region IElement Members

        public virtual void ChangeFont(Font font) {
            foreach (IElement element in elements) {
                element.ChangeFont(font);
            }
        }

        public virtual void Show() {
            foreach (IElement element in elements) {
                element.Show();
            }
        }

        public virtual void Print() {
            foreach (IElement element in elements) {
                element.Print();
            }
        }

        #endregion
    }
}
