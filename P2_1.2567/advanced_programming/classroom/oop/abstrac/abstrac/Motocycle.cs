using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrac
{
    internal class Motocycle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Start Motocycle!");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Stop Motocycle!");
        }
    }
}
