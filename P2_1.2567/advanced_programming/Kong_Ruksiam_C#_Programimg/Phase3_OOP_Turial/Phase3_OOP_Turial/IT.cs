using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase3_OOP_Turial
{
    internal class IT: Employee
    {
        private int _exp;

        public IT(string name, int salary, int exp):base(name, salary)
        {
            this._exp = exp;
        }

        public override double report_income()
        {
            return (base.Salary * 12) * this._exp;
        }

        public override void show_Employee()
        {
            Console.WriteLine("Name: " + base.Name);
            Console.WriteLine("Salary: " + base.Salary);
            Console.WriteLine("Exp: " + this._exp);
            Console.WriteLine("-------------------");
        }

        public void show_Uniform()
        {
            Console.WriteLine("Uniform: Black Color");
        }

        public string show_bonus()
        {
            return "Bonus 90%";
        }
    }
}
