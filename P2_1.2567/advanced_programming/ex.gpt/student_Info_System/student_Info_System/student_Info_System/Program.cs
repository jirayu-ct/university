using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace test_sakon
{
    class Program
    {
        static void Main()
        {
            int n = 30; // กำหนดค่าขอบเขตที่ต้องการหาจำนวนเฉพาะ
            List<int> primeNumbers = SieveOfEratosthenes(n);

            Console.WriteLine("จำนวนเฉพาะตั้งแต่ 2 ถึง " + n + " คือ:");
            foreach (int prime in primeNumbers)
            {
                Console.Write(prime + " ");
            }

            Console.ReadKey();
        }

        static List<int> SieveOfEratosthenes(int n)
        {
            bool[] primes = new bool[n + 1];
            for (int i = 2; i <= n; i++)
            {
                primes[i] = true;
            }

            for (int p = 2; p * p <= n; p++)
            {
                if (primes[p])
                {
                    for (int i = p * p; i <= n; i += p)
                    {
                        primes[i] = false;
                    }
                }
            }

            List<int> primeNumbers = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                if (primes[i])
                {
                    primeNumbers.Add(i);
                }
            }

            return primeNumbers;
        }
    }
}