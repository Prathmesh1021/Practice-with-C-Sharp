using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class Exception_handling_Throw_Example4
    {
        static void Main()
        {
            int num;
            try
            {
                Console.WriteLine("Enter Number");
                num = Convert.ToInt32(Console.ReadLine());

                if (num < 0)
                {

                    throw new Exception();
                    

                }Console.WriteLine("Number is " + num);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Enter only +Ve Numbers");

            }

        }
    }
}