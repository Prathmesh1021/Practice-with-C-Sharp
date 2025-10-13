using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ExceptionTryCatch_USER_IP_Example2
    {
        static void Main()
        {
            try
            {
               float a, b, c;
                Console.WriteLine("Enter first name=");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter second name=");
                b = Convert.ToInt32(Console.ReadLine());

                c = a / b;
                Console.WriteLine(c);
            }
            catch (Exception pv)
            {
                Console.Write(pv.ToString());
            }


        }
    }
}
