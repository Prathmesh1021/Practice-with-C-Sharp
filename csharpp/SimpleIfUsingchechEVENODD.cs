using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class SimpleIfUsingchechEVENODD
    {

        static void Main() { 
        
            int a = 4;

            string result = "odd";
            if (a % 2 == 0) {

                result = "even";

            }
                Console.WriteLine(result); 
        
        }
    }
}
