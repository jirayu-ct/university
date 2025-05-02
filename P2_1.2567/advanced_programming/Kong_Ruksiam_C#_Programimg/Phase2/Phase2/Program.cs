using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase2
{
    struct Employee
    {
        public string name; //ชื่อพนักงาน
        public int age;
        public double salary;
        public string department; //แผนก

        public void set_Employee(string name_value, int age_value, double salary_value, string department_value)
        {
            name = name_value;
            age = age_value;
            salary = salary_value;
            department = department_value;
        }

        public void show_employees()
        {
            Console.WriteLine("Name = " + name);
            Console.WriteLine("Age = " + age);
            Console.WriteLine("Salary = " + salary);
            Console.WriteLine("Department = " + department);
            Console.WriteLine("--------------------------");
        }
    }

    enum Rating
    {
        Veryded,//0
        Bed,//1
        Good,//2
        Greate,//3
        Excellent//4
    }

    internal class Program
    {
        static double balance = 10000; // Global
        static void Main(string[] args)
        {

            //การสร้างArray ไม่มีค่าเริ่มต้น
            /*
            int[] number = new int[4];
            double[] doubles = new double[4];

            //มีค่าเริ่มต้น 
            int[] number1 = {10, 20, 30, 40};
            

            int f = 10;
            // .Length นับจำนวนใน Array
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = f;
                f += 10;
                Console.WriteLine(number[i]);
            }

            //เปลี่ยนค่า
            number1[2] = 3000;
            Console.WriteLine(number1[2]);*/

            //forEach แสดงผลArray
            /*
            string[] students = { "Cat", "dog" };

            foreach (string name in students)
            {
                Console.WriteLine(name);
            }*/

            //การสร้างArray 2 มิติ ไม่มีค่าเริ่มต้น
            /*string[,] student = {
                {"kong", "kam", "khing", "kaew"},
                {"nick", "nook", "nun", "nim"},
                {"supharak", "somchai", "sompong", "sophone"}
            };*/
            /*
            //แสดงจำนวนแถว array2
            Console.WriteLine("row {0}", student.GetLength(0));

            //แสดงจำนวนคอลั่ม array2
            Console.WriteLine("col {0}", student.GetLength(1));

            //แสดงจำนวนสมาชิก array2
            Console.WriteLine("size {0}", student.Length);*/

            //for array 2 miti
            /*
            for (int row = 0; row < student.GetLength(0); row++)
            {
                for (int col = 0; col < student.GetLength(1); col++)
                {
                    Console.WriteLine(student[row, col]);
                }
            }*/

            // Foreach
            /*
            foreach (string name in student)
            {
                Console.WriteLine(name);
            }*/

            //Jagged Array
            /*
            string[][] jaggedArray = {
                new string[] { "kong", "kam", "kaew" },
                new string[] { "nick", "nook"},
                new string[] { "supharak", "somchai" },
                new string[] {"Hello"}
            };

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.WriteLine(jaggedArray[row][col]);
                }
            }*/

            //method
            /*
            int[] score_computer = { 70, 50, 80, 90, 100, };
            int[] score_physic = { 80, 60, 45, 55, 60 };
            int[] score_math = { 50, 85, 99, 55, 89 };

            int[] clon_score = copy_array(score_math);


            show_score(clon_score);
            show_score(score_math);

            Console.WriteLine("Max score math = {0}", findMaxInArray(score_math));*/

            //Defaule Parameter
            /* 
            show_data("jirayu", 2003.5, "Buriram");
            show_data("jirayu", 500000, "satuek");
            show_data("jirayu");*/

            //Global & Local

            //บัญชีธนาคาร
            /*
            double balance = 10000; //local
            Console.WriteLine(balance);

            my_Account();*/

            //structure
            /*
            Employee[] emp = new Employee[3];

            emp[0].set_Employee("jirayu", 19, 19000.50, "Programmer");
            emp[0].show_employees();

            emp[1].set_Employee("gg", 89, 191000.50, "IT");
            emp[1].show_employees();

            emp[2].set_Employee("fd", 900, 99999.50, "Engineer");
            emp[2].show_employees();*/

            //Enumerator
            /*
            Console.WriteLine("Score Rating = " + (int)Rating.Veryded);
            Console.WriteLine("Score Rating = " + (int)Rating.Good);
            Console.ReadKey();*/

            //Exception ดักจับError && Try...Catch && finally
            
            try
            {
                int result;

                Console.Write("Enter Number1: ");
                int number1 = int.Parse(Console.ReadLine());

                Console.Write("Enter Number2: ");
                int number2 = int.Parse(Console.ReadLine());

                result = number1 / number2;
                Console.WriteLine(result);

                int[] score = {100, 200, 300};
                Console.WriteLine(score[10]);
            }
            catch (FormatException)//ประเภทข้อมมูลผิด
            {
                Console.WriteLine("Iinvalid Format, Only Number!!");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Number2 Can't Zero!!");
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of rande!!");
            }
            finally
            {
                Console.WriteLine("Continue Program");
            }

            
            Console.ReadKey();
        }

        static bool checkNumber()
        {
            int number = 50;

            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void show_score(int []arr)
        {
            Console.Write('{');
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine('}');
        }

        static int findMaxInArray(int[] arr)
        {
            int max_value = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max_value)
                {
                    max_value = arr[i];
                }
            }

            return max_value;
        }

        static int[] copy_array(int[] original_arr)
        {
            int[] new_array = new int[original_arr.Length];

            for (int i = 0; i < original_arr.Length; i++)
            {
                new_array[i] = original_arr[i];
            }

            return new_array;
        }

        static void show_data(string name, double salary = 15000, string address = "biriram")
        {
            Console.WriteLine("Name = {0}, Salary = {1}, Address = {2}", name, salary, address);
        }

        static void my_Account()
        {
            Console.WriteLine(balance);
        }
    }
}
