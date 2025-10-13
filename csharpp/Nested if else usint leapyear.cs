using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class Nested_if_else_usint_leapyear
    {
        static void Main()
        {
           int year = 1000;

            if (year % 400 == 0)
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                if (year % 4 == 0)
                    if (year % 100 != 0)

                    { Console.WriteLine("Leap Year"); }
                    else
                    {
                        Console.WriteLine("Not a Leap Year");
                    }
                else
                {

                    Console.WriteLine("Not a Leap Year");
            }
             }    
              

        }
    }
}
