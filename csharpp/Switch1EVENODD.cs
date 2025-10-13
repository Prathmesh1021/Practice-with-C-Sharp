using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class Switch1EVENODD
    {
        static void Main() 
        {
            int num = 43;

            switch (num % 2)
            {
                case 0:
                    Console.WriteLine("Even Number");
                    break;

                case 1:
                    Console.WriteLine("ODD Number");
                    break;

                case 2:
                    Console.WriteLine("Invalid Number");
                    break;
                 

            }
        
        
        }
    }
}
