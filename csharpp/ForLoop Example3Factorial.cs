using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ForLoop_Example3Factorial
    {
        static void Main() {
            int num = 4;
            int r = 1;
            for (int xy = num; xy > 1; xy--) {
                r = r * xy;
                { Console.WriteLine("Factorial is " + r); }
             }
        
        
        }

    }
}
