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
            Dog dog = new Dog();
            dog.EatFood();
            dog.Walk();
            dog.show();

            // 无法创建抽象类接口。
            Animal animal = new Animal();


            Console.WriteLine("\r\nhello world");
            Console.ReadKey();
        }
    }

    // abstract：抽象类，不能实例化
    public abstract class Animal
    {
        public void EatFood()
        {
            Console.WriteLine("eat food");
        }

        public void Walk()
        {
            Console.WriteLine("walk");
        }
    }

    public class Dog : Animal, IAnimalShow
    {
        public void show()
        {
            Console.WriteLine("dog show");
        }
    }

}



