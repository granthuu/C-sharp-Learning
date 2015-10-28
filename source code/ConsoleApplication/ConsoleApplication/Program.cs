using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Person.Name);
            Console.WriteLine(Person.Name);

            Console.WriteLine("hello world");
            Console.ReadKey();
        }
    }

    public class Person
    {
        private static string name;

        // 静态构造函数，仅执行一次。
        static Person()
        {
            Console.WriteLine("私有构造函数被调用。");
            //this.name = "grant";
            name = "grant";
        }

        public static string Name
        {
            get { return name; }
        }
    }

}
