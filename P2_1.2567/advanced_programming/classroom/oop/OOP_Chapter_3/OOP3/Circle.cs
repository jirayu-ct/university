using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Circle
    {
        private double _radius;
        private const double pi = Math.PI;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        { 
            get { return _radius; }
            set
            {
                if (value >= 0)
                {
                    _radius = value;
                }
                else
                {
                    _radius = 0;
                    Console.WriteLine("The radius value must always be positive.!");
                }
            }
        }

        public double Area
        {
            get
            {
                _radius = pi * Math.Pow(_radius, 2);
                _radius = Math.Round(_radius, 2);
                return _radius;
            }

        }

    }
}
/*
 Circle circle1 = new Circle(-5);
            circle1.Radius = 99;
            Console.WriteLine("Area = {0}", circle1.Area);
 */