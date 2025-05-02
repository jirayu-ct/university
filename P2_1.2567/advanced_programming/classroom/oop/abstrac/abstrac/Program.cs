using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car() { _brand = "TOYOTA", _year = "2004"};
            Motocycle myMotocycle = new Motocycle() { _brand = "WAVE", _year = "2015" };


            myCar.ShowInfo();
            myCar.StartEngine();
            myCar.StopEngine();

            Console.WriteLine("-----------------");

            myMotocycle.ShowInfo();
            myMotocycle.StartEngine();
            myMotocycle.StopEngine();

            Console.ReadLine();
        }
    }
}