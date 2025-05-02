using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutorial
{
    internal class Employee
    {
        //field
        private string name;
        private int salary;

        protected string officeName = "Jiray Studio";

        //constructor
        public Employee() 
        {
            Console.WriteLine("Create employee object.");
        }
        
        //parameter constructor
        public Employee(string name, int salary)
        {
            this.Name = name;
            this.Salary = salary;

        }

        
        //property ลดรูป
        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }
    }
}
