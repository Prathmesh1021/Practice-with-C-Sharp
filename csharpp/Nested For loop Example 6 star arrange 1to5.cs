using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class Nested_For_loop_Example_6_star_arrange_1to5
    {
        static void Main()
        {
            int n = 3; // number of rows in the top half (excluding bottom)

            // Top half (including middle row)
            for (int i = 1; i <= n; i++)
            {
                // spaces
                for (int space = i; space < n; space++)
                {
                    Console.Write("  ");
                }
                // stars
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            // Bottom half
            for (int i = n - 1; i >= 1; i--)
            {
                // spaces
                for (int space = i; space < n; space++)
                {
                    Console.Write("  ");
                }
                // stars
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
