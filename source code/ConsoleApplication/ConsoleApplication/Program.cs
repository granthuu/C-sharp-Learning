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
            Person p1 = new Person();
            p1.Age = 18;

            Person p2 = new Person();
            p2.Age = 22;

            if (p1.compareTo(p2) > 0)
                Console.WriteLine("p1 > p2");
            else if (p1.compareTo(p2) < 0)
                Console.WriteLine("p1 < p2");
            else
                Console.WriteLine("p1 = p2");


            Console.WriteLine("\r\nhello world");
            Console.ReadKey();
        }
    }

    public class Person : Interface
    {
        int age;

        public int Age
        {
            get { return age;  }
            set { age = value; }
        }

        public int compareTo(object value)
        {
            if (value == null)
                return 1;

            Person otherP = (Person)value;
            if (this.Age < otherP.Age)
                return -1;
            else if (this.Age > otherP.Age)
                return 1;

            return 0;
        }
    }

}



