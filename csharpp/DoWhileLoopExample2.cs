using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class DoWhileLoopExample2
    {
        static void Main()
        {
            int num = 653243465;
            String s = "";

            do {
                s = s + num % 10;
                num = num / 10;
            } while (num != 0);
            Console.WriteLine("Reverce number is =" + s);       
        
        }
    }
}
 