using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ContinueExample3
    {
        static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i==7 && i==5)//dammy condition to illustrate the use of
                    continue;
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
