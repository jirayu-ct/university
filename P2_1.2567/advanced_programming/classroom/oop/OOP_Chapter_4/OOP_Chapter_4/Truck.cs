using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Chapter_4
{
    internal class Truck : Vehicle
    {
        public int _cargoCapacity {  get; set; }

        public void LoadCargo()
        {
            Console.WriteLine("Truck lode cargo.");
        }

        public void UnloadCargo()
        {
            Console.WriteLine("Truck un lode cargo.");
        }
    }
}
