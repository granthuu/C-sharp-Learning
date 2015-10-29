using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication
{
    class Program
    {
        // 1. 定义一个委托类型
        delegate void MyDelegate(int para1, int para2);

        static void Main(string[] args)
        {
            // 2. 声明委托变量
            MyDelegate d;

            // 3. 实体化委托变量
            d = new MyDelegate(new Program().Add);

            // 4. 委托变量直接调用
            d(1, 2);

            // 5. 间接利用方法调用委托定义的函数。委托相当于函数指针作用。
            MyMethod(d);

            Console.WriteLine("\r\nhello world");
            Console.ReadKey();
        }

        private void Add(int para1, int para2)
        {
            int sum = para1 + para2;
            Console.WriteLine("sum: "+sum);
        }

        // 传入的参数为委托类型，相当于函数指针。
        private static void MyMethod(MyDelegate mydelegate)
        {
            mydelegate(1, 2);
        }
    }
}



