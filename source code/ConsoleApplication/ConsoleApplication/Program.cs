using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication
{
    public class RefClass
    {
        public int addNum;
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            RefClass refclass = new RefClass();
            refclass.addNum = 1;

            Program program = new Program();
            program.AddOn(refclass);

            Console.WriteLine("before, num: " + refclass.addNum);

            Console.ReadKey();
        }

        private void AddOn(RefClass refclass)
        {
            refclass.addNum = 5;
            Console.WriteLine("after, num: " + refclass.addNum);
        }
    }
}



