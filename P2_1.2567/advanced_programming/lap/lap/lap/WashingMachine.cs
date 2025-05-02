using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap
{
    public class WashingMachine : Appliance
    {
        public override string Operate()
        {
            return "Operating the washing machine";
        }

        public void StartWash()
        {
            Console.WriteLine("Starting wash cycle");
        }
    }
}
