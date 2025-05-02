using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Chapter_4
{
    internal class Motorcycle : Vehicle
    {
        public bool _hasSidecar { get; set; }
        public void RevEngine()
        {
            Console.WriteLine("Vroom vroom!");
        }
    }
}