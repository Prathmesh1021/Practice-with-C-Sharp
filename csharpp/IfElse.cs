using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class IfElse
    {
        static void Main()
        {
            int a = 7;
            int result;

            if (a % 2 == 0)
            {

                result = a * a;
                Console.WriteLine("squre is " + result);
            }
            else {
                result = a * a * a;
                Console.WriteLine("cube is "+result);

            }


                
        }

        }
    }

