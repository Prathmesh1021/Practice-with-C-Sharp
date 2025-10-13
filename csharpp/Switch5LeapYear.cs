using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class Switch5LeapYear
    {
        static void Main() {
            int year = 2021;

            switch (year % 4 == 0 || ((year % 400 == 0) && (year % 100 != 0)))
            {
                case true:
                    Console.WriteLine("Leap Year");
                    break;

                default:
                    Console.WriteLine("Not a Leap Year");
                    break;
            }
        }
    }
}
