using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class DEMO_INTERFACE_IMPLEMENTATION : DEMOFIRST_cs, DEMO_SECOND
    {
        public void fun1()
        {
           Console.WriteLine("Fun1");
        }

        public void fun2()
        {
            Console.WriteLine("Fun2");
        }

        public void fun3()
        {
            Console.WriteLine("Fun3");
        }
    }
}
