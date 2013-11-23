using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.PraticeBuilder.LCDEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            EQPBuilder builder = new InputEQPBuilder();
            Equipment eqp = LCDFactory.CreateEQP(builder,"InputMachine");
            eqp.Run();

            builder = new IOPutEQPBuilder();
            eqp = LCDFactory.CreateEQP(builder,"InputOutputMachine");
            eqp.Run();

            Console.Read();
        }
    }
}
