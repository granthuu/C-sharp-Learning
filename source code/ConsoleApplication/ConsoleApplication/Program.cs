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
            Person person = Person.GetInstance();
            Console.WriteLine("name: {0}", person.Name);


            Console.WriteLine("hello world");
            Console.ReadKey();
        }
    }

    public class Person
    {
        private string name;
        public static Person person;

        public string Name
        {
            get { return name; }
        }

        // 私有构造函数，只能在类内部调用。
        // 也就是说类的实例化，只能在类定义时被实例化
        private Person()
        {
            Console.WriteLine("私有构造函数被调用。");
            this.name = "grant";
        }

        // 静态方法：用于返回类的实例
        public static Person GetInstance()
        {
            person = new Person();

            return person;
        }
    }

}
