using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Triangle(height = 20, base_triangle = 35),
                new Square(){_length = 40, _width = 20},
                new Circle(){_radius = 21}
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape.GetType().Name}: {shape.CalculateArea()}");
            }

            Console.ReadLine();
        }
    }
}
