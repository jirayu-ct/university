using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Chapter_4 //INHERITANCE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car() { 
                _brand = "Totota",
                _model = "Camry",
                _year = 2023,
                _numberOfDoors = 4,
            };

            Motorcycle motorcycle = new Motorcycle() {
                _brand = "Harley-Davidson",
                _model = "Sportster",
                _year = 2020,
                _hasSidecar = false,
            };

            Truck truck = new Truck() {
                _brand = "Sacania",
                _model = "Bmc",
                _year = 2017,
                _cargoCapacity = 50
            };

            Boat boat = new Boat()
            {
                _brand = "RMS",
                _model = "Titanic",
                _year = 1912,
                _lenght = 269.1,
                _maxSpeed = 39
            };


            Console.WriteLine("-----Car-----");
            car.StartEngine();
            car.Honk();
            car.StopEngine();

            Console.WriteLine("--Motorcycle--");
            motorcycle.StartEngine();
            motorcycle.RevEngine();
            motorcycle.StopEngine();

            Console.WriteLine("-----truck-----");
            truck.StartEngine();
            truck.LoadCargo();
            truck.UnloadCargo();
            truck.StopEngine();

            Console.WriteLine("-----Boat-----");
            boat.StartEngine();
            boat.DropAnchor();
            boat.RaiseAnchor();
            boat.StopEngine();

            Console.ReadLine();
        }
    }
}