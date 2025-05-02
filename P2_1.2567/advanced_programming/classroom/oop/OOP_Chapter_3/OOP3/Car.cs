using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Car
    {
        //Attribute
        public string color = "red";
        public int maxSpeed = 200;

        //Method
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }
}
