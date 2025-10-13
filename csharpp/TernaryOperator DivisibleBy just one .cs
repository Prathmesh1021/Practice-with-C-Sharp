using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class TernaryOperator_DivisibleBy_just_one
    {
        static void Main()
        {

            int num = 15; 
       

            string output = (num % 2 == 0 && num % 3 == 0) ? "Divisible by both 2 " +
                "and 3" :
                           (num % 2 == 0) ? "Divisible by 2 only" :
                          (num % 3 == 0) ? "Divisible by 3 only" :
                           "Not divisible by either 2 or 3";
            Console.WriteLine(output);
        }
    }
}
