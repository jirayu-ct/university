using System;
using System.Collections.Generic;
using System.Text;

namespace Phase3_OOP_Turial
{
    //sealed ทำให้ clsss ไม่สามารถสืบทอดได้
    sealed class Company
    {
        public static string cname = "jirayu Studio";
        public static string founder = "Mr.Jirayu";
        public static List<Employee> _employees = new List<Employee>();

        public static void addEmployee(Employee person)
        {
            _employees.Add(person);
        }

        public static void get_Employees()
        {
            foreach (Employee person in _employees)
            {
                person.show_Employee();
            }
        }
    }

    
    
    
}
