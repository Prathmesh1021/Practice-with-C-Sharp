using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class DateDiff
    {

        static void Main()
        { 
        String date1 = "12052016";  
        String date2 = "13062019";
            int d1 = Convert.ToInt32(date1); 
            int d2 = Convert.ToInt32(date2);    
            int y1 = d1 % 10000; // Extract year from date1
            int y2 = d2 % 10000; // Extract year from date2
            Console.WriteLine("diffrences of date in year{0}",y2-  y1);

        }
    }
}
