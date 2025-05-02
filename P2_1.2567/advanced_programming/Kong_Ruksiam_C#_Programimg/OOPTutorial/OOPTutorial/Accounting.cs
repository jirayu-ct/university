using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutorial
{
    internal class Accounting: Employee
    {
        private string gender;

        public Accounting(string name, int salary, string gender):base(name, salary)
        {
            this.gender = gender;                  // การเข้าถึง field in BaseClass
            Console.WriteLine(name + " working " + base.officeName);
        }
    }
}
