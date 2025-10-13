using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class BreakExample1
    {
        static void Main() {

            for (int i = 1; i <= 10; i++)
            {

                if (i == 5)
                    break;
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
