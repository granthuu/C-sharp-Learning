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
            st.PrintString("grant");
            st.PrintString(32);
            st.PrintString("grant", 33);


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
        //public void PrintString(string name)  
        public void PrintString(string name)
        {
            Console.WriteLine("name: " + name);
        }

        // 不属于方法重载: 含有返回值
        //public int PrintString(string name)
        //{
        //    Console.WriteLine("name: " + name);
        //    return 1;
        //}

        public void PrintString(int age)
        {
            Console.WriteLine("age: " + age);
        }

        public void PrintString(string name, int age)
        {
            Console.WriteLine("name: {0}, age: {1}", name, age);
        }
    }

}
