using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication
{
    public class Bridegroom
    {
        // 定义委托事件
        public delegate void MarryHandler(string msg);

        // 使用自定义委托类型定义事件
        public event MarryHandler MarryEvent;

        // 发出事件
        public void OnMarriageComing(string msg)
        {
            if (MarryEvent != null)
            {
                MarryEvent(msg);
            }
        }

        static void Main(string[] args)
        {
            Bridegroom bridegroom = new Bridegroom();

            // 实例化朋友对象
            Friend friend1 = new Friend("张三");
            Friend friend2 = new Friend("李四");
            Friend friend3 = new Friend("王五");

            bridegroom.MarryEvent += new MarryHandler(friend1.SendMessage);
            bridegroom.MarryEvent += new MarryHandler(friend2.SendMessage);
            //bridegroom.MarryEvent += new MarryHandler(friend3.SendMessage);

            bridegroom.OnMarriageComing("朋友们，我结婚了，到时候准时参加！");
            Console.WriteLine("---------------------------------------------");

            bridegroom.MarryEvent -= new MarryHandler(friend2.SendMessage);
            bridegroom.MarryEvent += new MarryHandler(friend3.SendMessage);

            bridegroom.OnMarriageComing("朋友们，我结婚了。");
            Console.ReadKey();
        }

        public class Friend
        {
            public string Name;

            public Friend(string name)
            {
                Name = name;
            }

            public void SendMessage(string msg)
            {
                Console.WriteLine(msg);

                Console.WriteLine(this.Name + "收到了，到时候准时参加。");
            }
        }

    }
}



