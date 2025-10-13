using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class INTERFACE_implement_Example3 : IFIRST, ISECOND
    {
        public void fun1()
        {
            Console.WriteLine("fun1");
        }

        public void fun2()
        {
          Console.WriteLine ("fun2");
        }

        public void fun3()
        {
            Console.WriteLine("fun3");
        }
    }
}
