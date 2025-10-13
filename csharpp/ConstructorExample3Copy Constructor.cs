using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ConstructorExample3
    {
          
        static int x, y;
        int a, b; 
         static ConstructorExample3() 
          {
                x = 100;
                y = 200;
                Console.WriteLine("Static Default Constructor" + (x + y));
        }   
        internal ConstructorExample3()
        {
            a = 100;
            b = 200;
            Console.WriteLine("Default Constructor" + (a - b));
        }
        internal ConstructorExample3(int a, int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine("Parameterized Constructor" + (a * b));
        }
        internal ConstructorExample3(ConstructorExample3 c)
        {
            this.a = c.a;
            this.b = c.b;
            Console.WriteLine("Parameterized Constructor" + (a * b));
        }
    }
}
