using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ExceptionTryCatch__BASIC_Example1
    {
        static void Main() {
            try
            {
                int a, b, c;


                a = 10;
                b = 0;
                c = a / b;
                Console.WriteLine( c);
            }
            catch (Exception ex)
            {
            Console.Write (ex.ToString());  
            }


        }
    }
}
