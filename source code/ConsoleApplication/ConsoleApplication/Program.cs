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
            Person st = new Person();
            st.Name = "grant";
            st.PrintString(st.Name);

            Console.WriteLine("hello world");
            Console.ReadKey();
        }
    }

    public class Person
    {
        private string name;
        private int age;

        // add attribute
        public string Name
        {
            get { return name;  }
            set { name = value; }
        }

        // add method
        public void PrintString(string name)
        {
            Console.WriteLine("name: " + name);
        }
    }

}
