using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Assignment = 2*/

            Console.WriteLine("enter the data :");

            string file = @"D:\file2.txt";
            FileStream fileStream = new FileStream(file, FileMode.Append, FileAccess.Write);
            bool flag = true;
            while (flag)
            {
                string data = Console.ReadLine();

                if (data == "stop" || data == "Stop" || data == "")
                {
                    flag = false;







                }
                else
                {
                    data += "\n";
                    byte[] writeArr = Encoding.UTF8.GetBytes(data);
                    fileStream.Write(writeArr, 0, writeArr.Length);
                    Console.WriteLine("Data added!");
                }
                Console.WriteLine("write stop to quit the program ");
            }
            fileStream.Close();
        }
    }
}
