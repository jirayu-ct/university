using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Ractangle
    {
        private double _width;
        private double _height;
        private double _area;


        public Ractangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        private double CheckNumber(double value)
        {
            if (value >= 0)
            {
                return value;
            }
            else
            {
                return 1;
            }
        }


        public double Width
        {
            get { return _width; }
            set
            {
                _width = CheckNumber(value);
            }
        }

        public double Height
        {
            get { return _height; }
            set
            {
                _height = CheckNumber(value);
            }
        }

        public double Area
        {
            get {
                _area = _height * _width;
                return _area;
            }
        }
    }
}

/*Ractangle ractangle1 = new Ractangle(width: 50, height: -5);
            
            ractangle1.Width = -5;
            ractangle1.Height = 50;

            Console.WriteLine("Width: " + ractangle1.Width); 
            Console.WriteLine("Height: " + ractangle1.Height);
            Console.WriteLine("Ractangle = " + ractangle1.Area);*/

