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
            int num = 2;
            Program program = new Program();
            program.AddOn(num);

            Console.WriteLine("before, num: " + num);

            Console.ReadKey();
        }

        private void AddOn(int num)
        {
            num = num + 2;
            Console.WriteLine("after, num: " + num);
        }

    }

    
}



