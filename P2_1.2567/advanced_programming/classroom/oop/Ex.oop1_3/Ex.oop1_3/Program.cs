//แบบฝึกหัดที่1 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.oop1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            animal.Name = "bukdum";
            animal.Species = "Dog";
            animal.MakeSound();

            Console.ReadKey();
        }
    }

    public class Animal
    {
        public string Name;
        public string Species;

        public void MakeSound()
        {
            Console.WriteLine(Name + " the " + Species + " makes a sound!");
        }
    }
}