using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Person
    {
        private string Name;
        private int Age;
        private string Grade;


        public Person()
        {
            Console.WriteLine("Create person object.");
        }

        //Constructor
        public Person(string name)
        {
            this.Name = name;
        }
         

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }


        public Person(string name, int age, string grade)
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }


        public void ShowPerson()
        {
            Console.Write("name: " + this.Name);
            Console.WriteLine(" Age: " + this.Age);
        }
    }
}
