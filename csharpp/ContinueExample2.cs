using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ContinueExample2
    {
        static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i==5||i==7)
                    continue;
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
