using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Square : Shape
    {
        public double _width {  get; set; }
        public double _length { get; set; }

        public override double CalculateArea()
        {
            return _width * _length;
        }
    }
}
