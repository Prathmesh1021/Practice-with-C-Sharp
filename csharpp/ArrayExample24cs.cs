using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ArrayExample24cs
    {
        static void Main() {

            int[] A = { 1, 2, 3, 4, 5, 6, 7 };
            int SE = 0, SO = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    SE = SE + A[i];
                }
                else
                {
                    SO = SO + A[i];
                }
            }
            Console.WriteLine("Sum of Odd : {0} \nSum of Even {1}", SO, SE);
        }
    }
    }

