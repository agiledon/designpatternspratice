using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.PraticeBuilder.LCDEquipment
{
    public abstract class Port
    {
        public abstract void Transfer();
    }

    public class InputPort:Port
    {
        public override void Transfer()
        {
            Console.WriteLine("Input");
        }
    }
    public class OutputPort : Port
    {
        public override void Transfer()
        {
            Console.WriteLine("Output");
        }
    }
}
