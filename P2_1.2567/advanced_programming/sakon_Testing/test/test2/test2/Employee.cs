using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    internal abstract class Employee
    {
        public string _name {  get; set; }
        public int _salary { get; set; }

        public abstract int Income();
    }
}