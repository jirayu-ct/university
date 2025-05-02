using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Circle : Shape
    {
        public double _radius {  get; set; }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
