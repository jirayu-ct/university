using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Triangle : Shape
    {
        private double _height {  get; set; }
        private double _base {  get; set; }

        public override double CalculateArea()
        {
            return 0.5 * _height * _base;
        }

        public Triangle(double height, double base_triangle)
        {
            _base = base_triangle;
            _height = height;
        }
    }
}