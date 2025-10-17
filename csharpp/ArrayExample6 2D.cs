using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ArrayExample6_2D
    {
   static void Main()
        {
            int [,] arr = new int[2,2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j <2; j++)
                {
                    Console.WriteLine("enter element for " + i +""+ j+ " index");
                    arr[i,j] =int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Array Element is ");
             for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                 Console.WriteLine();
             }
             Console.ReadKey();
            }
        }

    }

