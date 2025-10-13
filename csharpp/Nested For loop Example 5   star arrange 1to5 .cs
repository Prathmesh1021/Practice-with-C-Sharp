using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class Nested_For_loop_Example_5___star_arrange_1to5
    {

        static void Main()
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int space = 2; space >= i; space--) {
                    Console.Write(" ");
                   }
                for (int j = 1; j <= 2*i-1; j++) {
                    Console.Write("*");
                   }
                Console.WriteLine();
            }

        }
    }
}
