using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrac
{
    internal class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Start Car!");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Stop Car!");
        }
    }
}
