using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Chapter_4_Polymorrhism
{
    internal class Rectangle : Shape
    {
        public double _width { get; set; }
        public double _height { get; set; }
        public override double CalculateArea()
        {
            return _width * _height;
        }
    }
}
