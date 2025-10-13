using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class forLoopExample2
    {
        static void Main() {
            int num = 23;
            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine(num*x);
            }
            
            int k = 12;
            for (int y = 1; y <= 10; y++) {
                Console.WriteLine(y * k);
            }
        
        }


    }
}
