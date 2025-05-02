using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new WashingMachine().StartWash();
            new Microwave().StartingCook();
            new Refrigerator().OpenDoor();


            Appliance[] appliances = 
            { 
                new WashingMachine(), 
                new Microwave(), 
                new Refrigerator()
            };

            foreach (Appliance appliance in appliances)
            {
                Console.WriteLine(appliance.Operate());
            }

            Console.ReadKey();
        }
    }
}