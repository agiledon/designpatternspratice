using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.PraticeBuilder.LCDEquipment
{
    public class IOPutEQPBuilder : EQPBuilder
    {
        public override void BuildPort()
        {
            Port inputPort = new InputPort();
            m_equipment.AddPort(inputPort);
            Port outputPort = new OutputPort();
            m_equipment.AddPort(outputPort);
        }
        public override void BuildMachine(string name)
        {
            base.BuildMachine(name);
            m_machine.PortType = "InputOutput";
        }
    }
}
