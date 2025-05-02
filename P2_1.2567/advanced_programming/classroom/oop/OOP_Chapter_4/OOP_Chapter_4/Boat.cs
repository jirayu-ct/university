using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Chapter_4
{
    internal class Boat : Vehicle
    {
        public double _lenght { get; set; }
        public double _maxSpeed { get; set; }

        public void DropAnchor()
        {
            Console.WriteLine("Drop anchor.");
        }

        public void RaiseAnchor()
        {
            Console.WriteLine("Raise anchor.");
        }
    }
}
