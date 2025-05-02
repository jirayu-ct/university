using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Employee
    {
        private string _name;
        private decimal _salary;
        private string _department;

        public Employee(string name, decimal salary, string department)
        {
            _name = name;
            _salary = CheckNumber(salary);
            _department = department;
        }

        private decimal CheckNumber(decimal value)
        {
            if (value >= 0)
            {
                return value;
            }
            else
            {
                return 0;
            }
        }


        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
        public decimal Salary
        {
            get { return _salary; }
        }
        public string Department
        {
            set
            {
                _department = value;
            }
        }

        public void Display()
        {
            Console.WriteLine("" +
                "Name: {0}\n" +
                "Salary: {1} Bath\n" +
                "Department: {2}",
                _name, _salary,  _department);
        }
    }
}
/*
 Employee emp1 = new Employee(name: "jiray", salary: 25000, department: "Sale");
            emp1.Name = "jirayu";
            emp1.Department = "programmer";
            Console.WriteLine("Employee1 salary = {0} bath", emp1.Salary);
            emp1.Display();
 */