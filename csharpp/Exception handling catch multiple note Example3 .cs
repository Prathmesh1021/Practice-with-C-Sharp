using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class Exception_handling_catch_multiple_note
    {
        static void Main() 
        {
            String s = "success";
            try
            {
                float a, b, c;
              
                Console.WriteLine("Enter first name=");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter second name=");
                b = Convert.ToInt32(Console.ReadLine());

                c = a / b;
                Console.WriteLine("Result = "+c);
                s= "success";   
            }

            catch (FormatException ex1)
            {
                Console.WriteLine("Enter only Numeric value");
                s="fail";   
            }
            catch (DivideByZeroException ex2)
            {
                Console.WriteLine("Denominator can not be 0");
                s = "fail";
            }
            finally { 
            Console.WriteLine(s);
            }
        }
    }
}
