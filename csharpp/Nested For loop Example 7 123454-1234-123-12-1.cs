using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class Nested_For_loop_Example_7_123454_1234_123_12_1
    {
        static void Main()
        {

            for (int i = 1; i <= 5; i++)
            {
                for (int space = 1; space < i; space++)

                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 6- i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
