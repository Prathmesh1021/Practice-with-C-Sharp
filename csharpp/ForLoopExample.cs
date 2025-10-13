using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ForLoopExample
    {
        static void Main()
        {

            int x;
            Console.WriteLine("For Loop X is Increment ");
            for (x = 1; x <= 10; x++)
            {
                Console.WriteLine("x is =" + x);
            }
            Console.WriteLine("For Loop X is Decrement");
            for ( x = 10; x >= 1; x--)
            {
                Console.WriteLine("x is =" + x);
            }

        }
    }

   }

