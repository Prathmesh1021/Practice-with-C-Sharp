using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class SwapProgram
    {
        static int a = 5, b = 10;
        internal static void Swap() {

            int temp = a; // Using a temporary variable to hold the value of 'a'    
            a = b; // Assigning the value of 'b' to 'a' 
            b= temp; // Assigning the value of 'temp' (original 'a') to 'b' 
            Console.WriteLine("value a={0} and b={1}",a,b);    
        }
    }
}
