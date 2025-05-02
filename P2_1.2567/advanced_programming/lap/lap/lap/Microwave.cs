using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap
{
    public class Microwave : Appliance
    {
        public override string Operate()
        {
            return "Operating the microwave";
        }

        public void StartingCook()
        {
            Console.WriteLine("Starting cooking");
        }
    }
}
