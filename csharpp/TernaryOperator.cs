using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class TernaryOperator
    {
        static void Main() {
            int a = 10;
            int b = 20;
            int c = 100;

            String result=(a > b && a>c) ? "a is grester":(b>c)? "b is greater": "c is greater";    
            Console.WriteLine(result);



        }
    }
}
