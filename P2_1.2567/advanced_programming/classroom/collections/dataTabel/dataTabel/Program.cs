using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace dataTabel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STD_ID", typeof(string));
            dt.Columns.Add("STD_Password", typeof(string));
            dt.Columns.Add("STD_Name", typeof(string));
            dt.Columns.Add("STD_Surname", typeof(string));
            dt.Columns.Add("STD_Gender", typeof(char));

            dt.Rows.Add("ST001", "azrK3MED", "Freeman", "Monte", "M");
            dt.Rows.Add("ST002", "VV8qFE58", "Ulric", "Cletis", "M");
            dt.Rows.Add("ST003", "bnFTTrEP", "Carlton", "Dane", "M");
            dt.Rows.Add("ST004", "23CPnxXM", "Alec", "Rene", "M");
            dt.Rows.Add("ST005", "tfhrND2Z", "Graeme", "Jermaine", "M");
            dt.Rows.Add("ST006", "ye2J6WKf", "Merlw", "Edwin", "F");
            dt.Rows.Add("ST007", "6KZMpxVs", "Morton", "Swquoia", "M");
            dt.Rows.Add("ST008", "MDUPMuns", "Percival", "Andie", "M");
            dt.Rows.Add("ST009", "jkDWuw5d", "Mattie", "Fran", "F");
            dt.Rows.Add("ST010", "xp32ScEF", "Bertrand", "Georgie", "M");

            
            string std_id = "ST010t";
            string std_password = "xp32ScEF";

            bool result = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if ((string)dt.Rows[i][0] == std_id && (string)dt.Rows[i][1] == std_password)
                {
                    Console.WriteLine("STD_ID: " + dt.Rows[i][0]);
                    Console.WriteLine("STD_Password: " + dt.Rows[i][1]);
                    Console.WriteLine("STD_Name: " + dt.Rows[i][2]);
                    Console.WriteLine("STD_Surname: " + dt.Rows[i][3]);
                    Console.WriteLine("STD_Gender: " + dt.Rows[i][4]);
                    result = true;
                    break;
                }
            }
            if (!result)
            {
                Console.WriteLine("Not Found Data!!");
            }

            Console.ReadLine();
        }
    }
}
