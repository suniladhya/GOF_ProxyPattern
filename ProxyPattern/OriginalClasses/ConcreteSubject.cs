using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern.OriginalClasses
{
    class ConcreteSubject: Subject
    {
        public override void doSomeWork()
        {
            Console.WriteLine(" I am from concrete subject");

        }
    }
}
