using System;

namespace Phase3_OOP_Turial
{
    class Program
    {
        static void Main(string[] args)
        {
            //object

            Accounting emp1 = new Accounting("jirayu", 80000, "famale");
            Sale emp2 = new Sale("pompam", 100000, "biriram");
            IT emp3 = new IT("prame", 80000, 5);

            //static file ไม่สร้าง object
            /*Console.WriteLine("Name = " + Company.name);
            Console.WriteLine("Founder = " + Company.founder);*/

            //static method
            /*
            Company.addEmployee(emp1);
            Company.addEmployee(emp2);
            Company.addEmployee(emp3);
            Company.addEmployee(new Accounting("Boss", 8000, "mail"));

            Company.get_Employees();*/

            emp1.show_Uniform();
            emp2.show_Uniform();
            emp3.show_Uniform();


            /*
            Employee emp1 = new Employee("Jirayu", 55000);
            Employee emp2 = new Employee("pompam", 15000);
            Employee emp3 = new Employee("jojo", 9000);*/

            /*
            emp1.set_name("jirayu chomthong");
            emp1.set_salary(150000);

            Console.WriteLine(emp1.get_name());
            Console.WriteLine(emp1.get_salary());



            Employee emp2 = new Employee("pompam", 90000);
            Employee emp3 = new Employee("gogogi", 15000);*/


            Console.ReadKey();
        }
    }
}