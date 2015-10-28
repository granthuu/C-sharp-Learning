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
            // Horse horse = new Horse();
            Animal horse = new Horse();
            horse.Age = 1;
            Console.WriteLine("horse age is: {0}", horse.Age);
            horse.Voice();

            // Sheep sheep = new Sheep();
            Animal sheep = new Sheep();
            sheep.Age = 2;
            Console.WriteLine("sheep age is: {0}", sheep.Age);
            sheep.Voice();


            Console.WriteLine("\r\nhello world");
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

        // 对于每个动物的子类来说，每个子类发出的声音是不一样的
        // 每个动物的子类需要对该方法进行重新定义：多态。
        public virtual void Voice()
        {
            Console.WriteLine("animal voice.");
        }
    }

    // 定义子类： 继承
    // 子类应该重写基类的方法，每个子类发出的声音是不一样的。
    public class Horse : Animal
    { 
        // 通过override关键字来重写父类方法
        public override void Voice()
        {
            // 调用基类的方法
            base.Voice();
            Console.WriteLine("horse voice .....");
        }
    }

    // 子类：重写方法
    public class Sheep : Animal
    {
        public override void Voice()
        {
            base.Voice();
            Console.WriteLine("sheep voice ........");
        }
    }

}
