using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase3_OOP_Turial
{
    internal class Sale: Employee, General
    {
        private string _area;
        private double commission = 10000;

        public Sale(string name, int salary, string area):base(name, salary)
        {
            this._area = area;
        }
        public override double report_income()
        {
            return (base.Salary * 12) + (commission * 12);
        }

        

        public override void show_Employee()
        {
            Console.WriteLine("Name: " + base.Name);
            Console.WriteLine("Salary: " + base.Salary);
            Console.WriteLine("Area: " + this._area);
            Console.WriteLine("-------------------");
        }

        public void show_Uniform()
        {
            Console.WriteLine("Uniform: Pink Color");
        }

        public string show_bonus()
        {
            return "Bonus 50%";
        }
    }
}
