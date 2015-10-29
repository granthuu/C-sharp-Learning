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
            // 1. 不能利用类来直接调用方法。
            // speaker.

            // 2. 只能利用接口调用方法。
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
        // 显式接口，方法定义
        void IChineseGreeting.SayHello()
        {
            Console.WriteLine("你好");
        }

        void IAmericanGreeting.SayHello()
        {
            Console.WriteLine("hello");
        }
    }

}



