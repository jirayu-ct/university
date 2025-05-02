using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Chapter_4_Polymorrhism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { 
                new Circle { _radius = 5 }, 
                new Rectangle { _width = 4, _height = 6 },
                new Triangle { _base = 10, _height = 15}
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Area of {shape.GetType().Name}: {shape.CalculateArea()}");
            }

            Console.ReadLine();
        }
    }
}