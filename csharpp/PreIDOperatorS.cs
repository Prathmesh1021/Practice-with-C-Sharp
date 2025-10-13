using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class PreIDOperatorS
    {
        static void Main()
        { 
            
            int a = 10;
            int b = ++a + ++a + ++a;
           

            Console.WriteLine("a={0} and b={1}", ++a, ++b);

        }
    }
}