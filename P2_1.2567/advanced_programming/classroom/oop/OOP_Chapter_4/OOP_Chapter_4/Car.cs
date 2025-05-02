using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Chapter_4
{
    internal class Car : Vehicle
    {
        public int _numberOfDoors { get; set; }
        public void Honk()
        {
            Console.WriteLine("Beep beep!");
        }
    }
}
