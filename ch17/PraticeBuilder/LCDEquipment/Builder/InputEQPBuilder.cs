using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.PraticeBuilder.LCDEquipment
{
    public class InputEQPBuilder : EQPBuilder
    {
        public override void BuildPort()
        {
            Port port = new InputPort();
            m_equipment.AddPort(port);
        }
        public override void BuildMachine(string name)
        {
            base.BuildMachine(name);
            m_machine.PortType = "Input";
        }
    }
}
