using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrac
{
    internal abstract class Vehicle : IVehicle
    {
        public string _brand { get; set; }
        public string _year { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {_brand}\nYear: {_year}");
        }

        public abstract void StartEngine();
        public abstract void StopEngine();
    }
}