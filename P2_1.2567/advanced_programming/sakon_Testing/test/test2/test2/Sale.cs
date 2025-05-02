using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    internal class Sale : Employee
    {
        public int commission {  get; set; }

        public override int Income()
        {
            return (base._salary * 12) + (commission * 12);
        }
    }
}