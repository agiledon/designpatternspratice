using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.PraticeBuilder.LCDEquipment
{
    public static class LCDFactory
    {
        public static Equipment CreateEQP(EQPBuilder buider,string name)
        {
            buider.BuildPort();
            buider.BuildMachine(name);
            return buider.GetEQP();
        }
    }
}
