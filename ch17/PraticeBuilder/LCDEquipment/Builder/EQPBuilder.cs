using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.PraticeBuilder.LCDEquipment
{
    public abstract class EQPBuilder
    {        
        protected Equipment m_equipment;
        protected Machine m_machine;

        public EQPBuilder()
        {
            m_equipment = new Equipment();
        }

        public abstract void BuildPort();
        public virtual void BuildMachine(string name)
        {
            m_machine = new Machine(name);            
            m_equipment.Name = name;
            m_equipment.Machine = m_machine;
        }
        public Equipment GetEQP()
        {
            return m_equipment;
        }
    }
}
