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
            //st.Age = -5;
            st.Age = 5;
            Console.WriteLine("name: {0}, age: {1}", st.Name, st.Age);

            Console.WriteLine("hello world");
            Console.ReadKey();
        }
    }

    public class Person
    {
        // 1. 定义私有数据字段
        private string _name;
        private int _age;

        // 2. 利用属性，封装私有字段。
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if ((value < 0) || (value > 120))
                {
                    throw (new ArgumentOutOfRangeException("ageIntPropery", value, "age must more than 0, less than 120."));
                }
                else
                    _age = value;
            }
        }
    }

}
