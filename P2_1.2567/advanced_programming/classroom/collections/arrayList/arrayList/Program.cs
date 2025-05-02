using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayList
{
    internal class Program
    {
        static void DisplayArrayList(ArrayList list)
        {
            foreach (int i in list)
            {
                Console.Write(i + " ");
            };
        }
        static void Main(string[] args)
        {
            /*สร้าง ArrayList ขึ้นมาโดยมีการกำหนดข้อมูลให้ 
            ArrayList ดังนี้ 15, 17, 12, 19, 16, 20, 51, 11, 9, 3, 12 เรียงข้อมูลจากน้อยไปหามาก แล้วแสดงข้อมูลออกทางหน้าจอ*/
            

            ArrayList myList = new ArrayList();
            myList.Add(15);
            myList.Add(17);
            myList.Add(12);
            myList.Add(19);
            myList.Add(16);
            myList.Add(20);
            myList.Add(51);
            myList.Add(11);
            myList.Add(9);
            myList.Add(3);
            myList.Add(12);

            myList.Sort();
            Console.Write("Array List: ");
            DisplayArrayList(myList);
            Console.WriteLine();

            /*
             สร้าง ArrayList ขึ้นมาเพิ่มอีก 1 อัน แล้วนำข้อมูลเฉพาะเลขคี่จาก ArrayList อันแรก มาใส่
             ใน ArrayList อันที่ 2 แล้วแสดงข้อมูลใน ArrayList อันที่ 2 ออกมาทางหน้าจอ
             */

            ArrayList oddList = new ArrayList();

            foreach (int i in myList)
            {
                if(i % 2 != 0)
                {
                    oddList.Add(i);
                }
            }

            Console.Write("Odd Array List: ");
            DisplayArrayList(oddList);

            Console.ReadLine();
        }
    }
}
