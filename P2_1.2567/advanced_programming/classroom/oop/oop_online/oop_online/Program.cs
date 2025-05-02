using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_online
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //สร้าง oject ของ class Peron
            /*Person person = new Person();
            person.Name = "jirayu";
            person.Age = 19;
            person.Gender = 1;
            person.Speak();

            Car car = new Car();
            car.Color = "red";
            car.Model = "TOYOTA";
            car.Drive();*/

            /*Calculator math = new Calculator();

            math.PrintMessahe();
            int sum = math.Add(5, 10);
            int multi = math.Multiply(5, 5, 5);

            Console.WriteLine(sum);
            Console.WriteLine(multi);*/
            /*
            Person person = new Person();

            person.Introduce(name: "jirayu", age: 10);
            person.Introduce("pompam", 11);
            person.Introduce(age: 99, name: "yami");*/




            Console.ReadKey();
        }
    }

    public class Calculator
    {
        public void PrintMessahe()
        {
            Console.WriteLine("Hello, World!");
        }

        public int Add(int x ,int y)
        {
            return x + y;
        }
        //Method overloading 
        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }

        public int Multiply(int x ,int y, int z)
        {
            return x * y * z;
        }
    }

    public class Person
    {   //Attrubute
        public string Name;
        public int Age;
        public int Gender; //1, 0

        //Method
        public void Speak()
        {
            Console.WriteLine("Hello, My Name is " + Name);
        }

        public void Introduce(string name, int age)
        {
            Console.WriteLine("Myname is " + name + " age " +  age);
        }
    }

    public class Car
    {   //Attrubute
        public string Color;
        public string Model;

        //Method
        public void Drive()
        {
            Console.WriteLine("The car is driving.");
        }
    }
}
