using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutorial
{
    internal class Sale: Employee
    {
        private string area;

        public Sale(string name, int salary, string area):base(name, salary)
        {
            this.area = area;
        }
    }
}
