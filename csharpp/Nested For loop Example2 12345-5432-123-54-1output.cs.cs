using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class Nested_For_loop_Example2_12345_5432_123_54_1output
    {
        static void Main()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 6-i; j++)
                {
                    if (i % 2 != 0)
                        Console.Write(j);
                    else
                        Console.Write(6-j);
                }
                Console.WriteLine();
            }
        }
    }
}
