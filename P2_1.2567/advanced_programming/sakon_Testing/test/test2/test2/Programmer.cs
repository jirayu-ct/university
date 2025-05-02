using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    internal class Programmer : Employee
    {
        public int _exp {  get; set; }

        public override int Income()
        {
            return (base._salary * 12) * _exp;
        }
    }
}