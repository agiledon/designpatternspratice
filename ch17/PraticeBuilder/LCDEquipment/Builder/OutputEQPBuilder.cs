using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.PraticeBuilder.LCDEquipment
{
    public class OutputEQPBuilder : EQPBuilder
    {
        public override void BuildPort()
        {
            Port port = new OutputPort();
            m_equipment.AddPort(port);
        }
        public override void BuildMachine(string name)
        {
            base.BuildMachine(name);
            m_machine.PortType = "Output";
        }
    }
}
