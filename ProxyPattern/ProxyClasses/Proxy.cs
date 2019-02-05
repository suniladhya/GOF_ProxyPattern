using ProxyPattern.OriginalClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern.ProxyClasses
{
    class Proxy
    {
        ConcreteSubject cs;
        
        public void doSomeWork()
        {
            Console.WriteLine("Proxy call happening now");
            //Lazy initialization
            if (cs == null)
            {
                cs = new ConcreteSubject();
            }
            cs.doSomeWork();
        }
    }
}
