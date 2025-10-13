using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class SumDateDigit
    {
        static void Main() {

      
            String date1 = "12052016";
            int d1= Convert.ToInt32(date1);
            int sum = 0;
            while (d1 != 0) {
                int first = d1 % 10;//6
                d1 = (int)(d1 / 10);//1205201
                sum += first;  
            }
          Console.WriteLine(sum);
            
                /*
            int second = d1 % 10;//1
            d1 = (int)(d1 / 10);//120520
            int third = d1 % 10;//0
            d1 = (int)(d1 / 10);//12052    
            int fourth = d1 % 10;//2
            d1 = (int)(d1 / 10); // 1205
            int fifth = d1 % 10;//5
            d1 = (int)(d1 / 10);//120  
            int Sixth= d1 % 10;//0
            d1 = (int)(d1 / 10);//12
            int seventh = d1 % 10;//2
            d1 = (int)(d1 / 10);   //1    
            int eighth = d1;   
          Console.WriteLine(first+second+third+fourth+fifth+Sixth+seventh+eighth);

                */
        }

    }
}
