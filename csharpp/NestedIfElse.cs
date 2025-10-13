using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class NestedIfElse
    {
        static void Main()
        {

            int a = 10, b = 34, c = 25;
            if (a > b) 
            {
                if (a > c)
                {
                    Console.WriteLine("a is gretest number");
                }
                else
                {
                    Console.WriteLine("C is gretest number ");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("b is gretest number");
                }
                else
                {

                    Console.WriteLine("c is gretest number ");
                }
            }
        }

    }
}
