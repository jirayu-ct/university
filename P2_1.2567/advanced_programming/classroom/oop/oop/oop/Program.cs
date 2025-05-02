using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Brand = "Toyota";
            myCar.Model = "Corolla";
            myCar.Year = 2020;
            myCar.DisplayInfo();

            Console.ReadKey();
        }
    }
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}");
        }
    }
}
