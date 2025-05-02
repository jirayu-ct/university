using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object
            Employee emp1 = new Accounting("jane", 80000, "female");
            Employee emp2 = new Sale("jojo", 100000, "rayong");
            Employee emp3 = new IT("nut", 800000, 5);
            emp1.Name = emp2.Name;


            Console.ReadKey();
        }
    }
}