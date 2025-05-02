using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Chapter_4
{
    internal class Vehicle
    {
        public string _brand { get; set; }
        public string _model { get; set; }
        public int _year { get; set; }
        public void StartEngine()
        {
            Console.WriteLine("Engine started.");
        }
        public void StopEngine()
        {
            Console.WriteLine("Engine stopped.");
        }
    }
}