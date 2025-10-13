using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class LadderElseif
    {
        static void Main()

        {
            int year = 3464453;

            if (year % 400 == 0)
            {
                Console.WriteLine("Leap Year");

            }
            else if (year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("Not a leap year ");
            }
        }

    }
}



