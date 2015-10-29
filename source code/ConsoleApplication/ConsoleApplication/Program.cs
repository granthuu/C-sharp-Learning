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
            Program p = new Program();
            p.Greeting("Lucy", p.EnglishGreeting);
            p.Greeting("张三",  p.ChineseGreeting);

            Console.WriteLine("\r\nhello world");
            Console.ReadKey();
        }

        public delegate void GreetingDelegate(string name);

        public void Greeting(string name, GreetingDelegate callback)
        {
            callback(name);
        }

        public void EnglishGreeting(string name)
        {
            Console.WriteLine("hello "+name);
        }

        public void ChineseGreeting(string name)
        {
            Console.WriteLine("你好 "+name);
        }
    }
}



