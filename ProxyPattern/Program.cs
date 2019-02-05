using ProxyPattern.ProxyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Proxy Pattern Demo***\n");
            Proxy px = new Proxy();
            px.doSomeWork();
        }
    }
}
