using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Reflection.Emit;
using System.Runtime.Remoting.Services;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Phase1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //แปลงข้อความ หรือ อื่นๆ เป็นตัวเลข
            Console.WriteLine("Int");
            string mystring = "120";
            byte myByte = (byte)Convert.ToSByte(mystring);
            short myshoty = Convert.ToInt16(mystring);
            int myint = Convert.ToInt32(mystring);
            long mylong = Convert.ToInt64(mystring);

            Console.WriteLine("String = {0}", mystring);
            Console.WriteLine("Byte = {0}", myByte);
            Console.WriteLine("Short = {0}", myshoty);
            Console.WriteLine("Int = {0}", myint);
            Console.WriteLine("Long = {0}", mylong);

            //ทศนิยม
            Console.WriteLine("Float");
            float myfloat = Convert.ToSingle(mystring);
            double mydouble = Convert.ToDouble(mystring);
            string result = Convert.ToString(mystring);

            Console.WriteLine("Float = {0}", myfloat);
            Console.WriteLine("Double = {0}", mydouble);
            Console.WriteLine("Double to String = {0}", result + 1.2); */

            /*
            bool myBoolean = true;
            string myConvert = Convert.ToString(myBoolean);
            Console.WriteLine("Mybool to str = {0}", myConvert);

            //Parse แปลงเฉพาะstrเป็นตัวเลข

            // input
            string mystring = "127";

            //process
            byte mybyte = Byte.Parse(mystring);
            short myshort = Int16.Parse(mystring);
            int myint = Int32.Parse(mystring);
            long mylong  = Int64.Parse(mystring);
            float myfloat = float.Parse(mystring);
            double mydouble = Double.Parse(mystring);

            //output
            Console.WriteLine("String = {0}", mystring);
            Console.WriteLine("Byte = {0}", mybyte);
            Console.WriteLine("Short = {0}", myshort + 100);
            Console.WriteLine("Int = {0}", myint + 100);
            Console.WriteLine("Long = {0}", mylong + 100);
            Console.WriteLine("Float = {0}", myfloat + 100);
            Console.WriteLine("Double = {0}", mydouble + 100); */

            /*Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number + 100);*/

            //TryParse
            /*string mystring = "127.22";

            double mydouble;
            bool check = double.TryParse(mystring, out mydouble);
            
            Console.WriteLine("Int = {0}", mydouble);
            Console.WriteLine("success = {0}", check);*/
            /*
            double x = 100.15;
            int y = (int)x;
            Console.WriteLine(y);*/

            //BMI
            /*float height, weight;
            float BMI;

            Console.Write("Input Height(cm.): ");
            height = float.Parse(Console.ReadLine()) / 100;

            Console.Write("Input weight(kg.): ");
            weight = float.Parse(Console.ReadLine());

            BMI = weight / (height*height);

            Console.WriteLine("height(cm.) = {0}", height);
            Console.WriteLine("weight(kg.) = {0}", weight);
            Console.WriteLine("BMI = {0:F2}", BMI);*/

            //if else
            /*int score;

            Console.Write("Enter score: ");
            int.TryParse(Console.ReadLine(), out score);

            if (score >= 80)
            {
                Console.WriteLine("Grade A");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Grade B");
            }
            else if(score >= 60)
            {
                Console.WriteLine("Grade C");
            }
            else if (score >= 50)
            {
                Console.WriteLine("Grade D");
            }
            else
            {
                Console.WriteLine("Grade F");
            }*/

            /*
            string sex;
            int height;

            Console.Write("Enter your Sex: ");
            sex = Console.ReadLine();

            Console.Write("Enter your height: ");
            int.TryParse(Console.ReadLine(), out height);

            if (sex == "male" && height >= 160)
            {
                Console.WriteLine("pass");
            }
            else if (sex == "male" || height >= 160) 
            {
                Console.WriteLine("pass");
            }
            else
            {
                Console.WriteLine("Not pass");
            }*/

            /* int score;
             string grade;

             Console.Write("Enter your Score: ");
             int.TryParse(Console.ReadLine(), out score);

             if(score >= 80 && score <= 100)
             {
                 grade = "A";
             }
             else if(score >= 70 && score <= 79)
             {
                 grade = "B";
             }
             else if(score >= 60 && score <= 69)
             {
                 grade = "C";
             }
             else if(score >= 50 && score <= 59)
             {
                 grade = "D";
             }
             else if(score < 50 && score >= 0)
             {
                 grade = "F";
             }
             else
             {
                 grade = "Not grade";               
             }
             Console.WriteLine(grade);*/

            //ลดรูปif
            /*int score = 60;
            string result;

            result = (score >= 50) ? "Pass" : "Not Pass";

            Console.WriteLine("Status = {0}", result);*/

            //if if

            /*int money, result, discount;

            Console.Write("Enter your Money: ");
            int.TryParse(Console.ReadLine(), out money);

            if (money >= 15000)
            {
                if (money < 20000)
                {
                    discount = 10;
                    result = money - ((money * discount) / 100);
                }
                else if(money < 30000)
                {
                    discount = 20;
                    result = money - ((money * discount) / 100);
                }
                else
                {
                    discount = 30;
                    result = money - ((money * discount) / 100);
                }

                Console.WriteLine("money {0:N0} Bath discount {1}% sum {2:N0} Bath", money, discount, result);
            }
            else
            {
                Console.WriteLine("คุณไม่ได้ส่วนลด");
            }*/


            //switch case
            /*int num1, num2, select, sum = 0;

            Console.Write("Enter your num1: ");
            int.TryParse(Console.ReadLine(), out num1);

            Console.Write("Enter your num2: ");
            int.TryParse(Console.ReadLine(), out num2);

            Console.Write("Input Select (1 = '+')or(2 = '-'): ");
            int.TryParse(Console.ReadLine(), out select);

            switch (select)
            {
                case 1:
                    sum = num1 + num2;
                    Console.WriteLine("sum = {0}", sum);
                    break;

                case 2:
                    sum = num1 - num2;
                    Console.WriteLine( "sum = {0}", sum);
                    break ;

                default: 
                    Console.WriteLine("Error: Number is 1 or 2");
                    break;
            }*/


            //While loop
            /*int count = 1;
            int num;

            Console.Write("Input nuber: ");
            int.TryParse(Console.ReadLine(), out num);

            while(count <= 12)
            {
                
                Console.WriteLine("{0} x {1} = {2}", num, count, num*count);
                count++;
            }*/

            //for loop
            /*int num;

            Console.Write("Input nuber: ");
            int.TryParse(Console.ReadLine(), out num);

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
                i++;
            }*/

            //Do While
            /*int count = 1;

            do
            {
                Console.WriteLine("Hello World {0}", count);
                count++;
            }
            while (count < 3);
                Console.WriteLine("End Program");*/

            //break & continue

            /*int num;

            Console.Write("Input nuber: ");
            int.TryParse(Console.ReadLine(), out num);

            for (int i = 1; i <= 12; i++)
            {
                if(i == 5)
                {
                    continue;
                }
                Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
            }
            Console.WriteLine("End program");*/

            //Ex1.
            /*int n = 5;
            float number, agv, sum = 0;

            for(int i = 0; i < n; i++)
            {
                Console.Write("enter your number{0}: ", i+1);
                float.TryParse(Console.ReadLine(), out number);

                sum += number;
            }

            agv = sum / n;
            
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("agv = {0}", agv);*/

            //Ex2.
            /*int n = 0;
            float number, avg = 0, sum = 0;

            while (true)
            {
                Console.Write("enter your number{0}: ", n+1);
                float.TryParse(Console.ReadLine(), out number);

                if (number < 0)
                {
                    break;
                }

                sum += number;
                n++;
            }
            avg = sum / n;

            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0}", avg);*/

            //Ex3.max min
            /*int n = 0;
            float number = 0, max = 0, min = float.MaxValue;

            while (true)
            {
                Console.Write("enter your number{0}: ", n + 1);
                float.TryParse(Console.ReadLine(), out number);

                if (number < 0)
                {
                    break;
                }

                if (number > max)
                {
                    max = number;
                }
                
                if (number < min)
                {
                    min = number;
                }
                
                n++;
            }

            Console.WriteLine("max = {0}", max);
            Console.WriteLine("min = {0}", min);*/

            //Ex4.ATM

            int money;

            do
            {
                Console.Write("Input Money: ");
                int.TryParse (Console.ReadLine(), out money);

            } while (money%100 != 0 || money > 20000);

            Console.WriteLine("Money = {0}", money);
            Console.WriteLine("1000 Baht = {0}", money/1000);
            money %= 1000;

            Console.WriteLine("500 Baht = {0}", money / 500);
            money %= 500;

            Console.WriteLine("100 Baht = {0}", money / 100);


            Console.ReadKey();
        }
    }
}
