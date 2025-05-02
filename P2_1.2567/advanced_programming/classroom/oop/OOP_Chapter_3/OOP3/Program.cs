using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ractangle ractangle1 = new Ractangle(width: 50, height: -5);

            ractangle1.Width = -5;
            ractangle1.Height = 50;

            Console.WriteLine("Width: " + ractangle1.Width);
            Console.WriteLine("Height: " + ractangle1.Height);
            Console.WriteLine("Ractangle = " + ractangle1.Area);

            Console.ReadLine();
        }
    }
} 