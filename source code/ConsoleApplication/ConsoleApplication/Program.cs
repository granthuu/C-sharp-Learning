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
            Horse horse = new Horse();
            horse.Age = 1;
            Console.WriteLine("horse age is: {0}", horse.Age);

            Sheep sheep = new Sheep();
            sheep.Age = 2;
            Console.WriteLine("sheep age is: {0}", sheep.Age);


            Console.WriteLine("hello world");
            Console.ReadKey();
        }
    }

    // 定义父类
    public class Animal
    {
        private int _age;
        public int Age 
        {
            get { return _age; }
            set 
            {
                if(value <0 || value > 10)
                    throw(new ArgumentOutOfRangeException("ageIntPropery", value, "age must between [0,10]."));
                else
                    _age = value;
            }
        }
    }

    // 定义子类： 继承
    public class Horse : Animal
    { 
        
    }

    public class Sheep : Animal
    { 
    
    }

}
