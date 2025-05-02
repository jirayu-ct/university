using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dev_Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 1;

            List<int> numList = new List<int>();

            
            while (true)
                .3
            {

                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == 0)
                {
                    string userSelect = Console.ReadLine();
                    if (userSelect.ToLower() == "max")
                    {
                        numList.Sort();
                        numList.Reverse();
                        foreach (int i in numList)
                        {
                            Console.Write(i + " ");
                        }
                        break;
                    }
                    else if (userSelect.ToLower() == "min")
                    {
                        numList.Sort();
                        foreach (int i in numList)
                        {
                            Console.Write(i + " ");
                        }
                        break;
                    }
                }
                else
                {
                    numList.Add(userInput);
                }
            }
            Console.ReadLine();
        }
    }
}
