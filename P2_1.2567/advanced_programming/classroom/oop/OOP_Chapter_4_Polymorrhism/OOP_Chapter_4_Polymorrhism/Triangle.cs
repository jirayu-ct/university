using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Chapter_4_Polymorrhism
{
    internal class Triangle : Shape
    {
        public double _base { get; set;}
        public double _height { get; set;}
        public override double CalculateArea()
        {
            return 0.5 * _base * _height;
        }
    }
}