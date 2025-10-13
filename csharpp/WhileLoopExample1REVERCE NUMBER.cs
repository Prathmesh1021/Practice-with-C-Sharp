using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class WhileLoopExample1REVERCE_NUMBER
    {
        static void Main() 
        
        { int num = 1234567;
            String r = "";

            while (num != 0) {
                r = r + num % 10;
                num = num / 10;
            }
            Console.WriteLine("Reverce Number is "+r);

            int num1= 7654321;
            String r1 = "";

            while (num1 != 0) {

                r1 = r1 + num1 % 10;
                num1 = num1 / 10;
                {
                    Console.WriteLine("Reverce number that"+r1);
                }
            }

        }
    }
}
