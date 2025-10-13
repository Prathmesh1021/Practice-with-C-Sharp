using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class Nested_For_loop_Example_3_ABCDE
    {
        static void Main()
        {
            for (int i = 1; i <= 26; i++)
            {
                char ch = 'A';  
                for (int j = 1; j <= 27-i; j++)
                {
                    Console.Write(ch++);
                }
                Console.WriteLine();
            }
        }
    }
}
