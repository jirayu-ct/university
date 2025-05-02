using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap
{
    public class Refrigerator : Appliance
    {
        public override string Operate()
        {
            return "Operating the refrigerator";
        }

        public void OpenDoor()
        {
            Console.WriteLine("Opening refrigerator door");
        }
    }
}
