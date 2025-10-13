using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class TernarywithLeapyear
    {
        static void Main() {

            int year = 2024;

            string output = year%400==0 ||
         (year%4==0)&&(year%100!=0) ? "Leap Year" : "Not a Leap Year";  
            Console.WriteLine(output);  



        }


    }
}
