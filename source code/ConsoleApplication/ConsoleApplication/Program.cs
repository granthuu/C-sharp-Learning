using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("string test");

            string str = "old string";
            ChangStr(str);
            Console.WriteLine("changed, str: " + str);

            Console.ReadKey();
        }

        public static void ChangStr(string str)
        {
            str = "new string";
            Console.WriteLine(str);
        }
    }
}



