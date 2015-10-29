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
            Speaker speaker = new Speaker();
            // 1. 类直接调用方法。
            speaker.SayHello();

            // 2. 接口调用方法。
            IChineseGreeting iChineseG = (IChineseGreeting)speaker;
            iChineseG.SayHello();

            IAmericanGreeting iAmericanG = (IAmericanGreeting)speaker;
            iAmericanG.SayHello();


            Console.WriteLine("\r\nhello world");
            Console.ReadKey();
        }
    }

    public class Speaker : IChineseGreeting, IAmericanGreeting
    {
        // 隐式接口实现，SayHello函数并没有制定是哪一个接口实现。
        // 隐式接口是public，类和接口可以直接访问。
        public void SayHello()
        {
            Console.WriteLine("hello");
        }
    }

}



