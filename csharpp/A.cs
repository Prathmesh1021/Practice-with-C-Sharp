using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class A
    {
        internal static void fun()
        {
            int a = 10;// static
            Console.WriteLine("Values =" + a);
        }
        internal void fun1() {

            int b = 20;// non static or non static
            Console.WriteLine("Values=" +b);
        }

    }
}
