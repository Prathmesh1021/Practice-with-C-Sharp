using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class Binary_to_decimal
    {
        static void Main()
        {
            int num = 1001;//1002!=0
            int b, e=0,s=0;
            while (num != 0) {

                b = num % 10;//1
                s=s+b*(int )(Math.Pow(2,e));
                num = (int)num / 10;//100
                e++;//1
            }
            Console.WriteLine(s);
        }
    }
}
