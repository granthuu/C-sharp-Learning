using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication
{
    interface Interface
    {
        int compareTo(object other);
    }

    interface IChineseGreeting
    {
        void SayHello();
    }

    interface IAmericanGreeting
    {
        void SayHello();
    }
}
