using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class NumbertoDecimal
    {
        static void Main() {
            int num = 43;
            String data = "";
            while (num != 0) {

                data = num % 2 + data;
                num =(int)num / 2;
            
            }

            Console.WriteLine(data);
        }
    }
}
