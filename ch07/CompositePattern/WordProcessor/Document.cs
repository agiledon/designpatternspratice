using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace DonOfDesign.CompositePattern.WordProcessor {
    public class Document : CompositeElement {
        public override void Add(IElement element) {
            if (element is Document) {
                throw new NotSupportedException("Can't add the Document object.");
            }
            //如果添加的元素为Word
            //则必须以Paragraph的形式加入
            if (element is Word) {
                var para = new Paragraph();
                para.Add(element);
                base.Add(para);
            }
            else {
                base.Add(element);
            }
        }
    }
}
