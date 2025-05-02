using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Chapter_4_Polymorrhism
{
    internal class Circle : Shape
    {
        
        public double _radius { get; set; }
        public override double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}