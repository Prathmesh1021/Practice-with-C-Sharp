using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class Ternarydivisibale2_numbers
    {
        static void Main() {

            int num = 15; 

            string output = (num % 3 == 0 && num % 5 == 0) ? "Divisible by both 3 and 5":
                           "Not divisible by either 3 or 5";    
            Console.WriteLine(output);  
        }
    }
}
