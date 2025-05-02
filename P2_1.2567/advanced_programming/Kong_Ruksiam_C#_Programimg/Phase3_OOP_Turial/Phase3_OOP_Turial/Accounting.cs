using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase3_OOP_Turial
{
    internal class Accounting: Employee, General
    {
        private string _gender;

        public Accounting(string name, int salary, string gender):base(name, salary)
        {
            this._gender = gender;
        }

        public override double report_income()
        {
            return base.Salary * 12;
        }

        

        public override void show_Employee()
        {
            Console.WriteLine("Name: " + base.Name);
            Console.WriteLine("Salary: " + base.Salary);
            Console.WriteLine("Gender: " + this._gender);
            Console.WriteLine("-------------------");
        }

        public void show_Uniform()
        {
            Console.WriteLine("Uniform: White Color");
        }

        public string show_bonus()
        {
            return "Bonus 20%";
        }
    }
}
