using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase3_OOP_Turial
{
    abstract internal class Employee
    {
        //field
        private String _name;
        private int _salary;
        //protected class ลูกใช้ได้เท่านั้น
        protected string _email = "pram0940603006@gmail.com";

        //default constructor
        public Employee() 
        {
            Console.WriteLine("Create Employee Object");
        }

        /*
        public Employee()
        {
            Console.WriteLine("ID: " + this._id);
            Console.WriteLine("Name: " + this._name);
            Console.WriteLine("Salary: {0} Bath", this._salary);

            Console.WriteLine("Create Empty object");
        }

        //parameter constructor
        public Employee(String name_value)
        {
            Console.WriteLine("Create object: " + name_value);
        }*/

        public Employee(string name, int salary)
        {
            this.Name = name;
            this.Salary = salary;
        }
        //สร้างอัตโนมัติ Encapsulate Field
        public string Name { get => _name; set => _name = value; }
        public int Salary { get => _salary; set => _salary = value; }

        public virtual void show_Employee()
        {
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Salary: " + this.Salary);
            Console.WriteLine("-------------------");
        }

        //abstract ต้องทำให้เป็น abstract class
        public abstract double report_income();


        /*
public void show_detail()
{
Console.WriteLine("Name: " + this._name);
Console.WriteLine("Salary: " + this._salary);
}*/


        //setter => เขียนข้อมูล
        /*
        public void set_name(String new_name) 
        { 
            this._name = new_name;
        }

        public void set_salary(int new_salary)
        {
            this._salary = new_salary;
        }*/

        //getter => อ่านข้อมูล
        /*
        public string get_name()
        {
            return this._name;
        }
        public int get_salary()
        {
            return this._salary;
        }*/

        //property
        /*public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }*/

        //property แบบลดรูป
        /*public string Name { get; set; }
        public int Salary { get; set; }*/


    }
}
