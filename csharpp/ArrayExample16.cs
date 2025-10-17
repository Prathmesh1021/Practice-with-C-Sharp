using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ArrayExample16
    {//Q)  WAP to perform the addition of two matrices?
        static void Main()
        {
            int[,] x = { { 1, 2, 3 }, { 3, 4, 5 } };
            int[,] y = { { 2, 3, 5 }, { 4, 5, 9 } };
            int[,] z = new int[2, 3];
            int i, j;
            Console.WriteLine("First Matrix is ");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(x[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Second Matrix is ");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(y[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Addition of Matrix is ");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    //   Console.Write((x[i,j]+y[i, j]) + " ");
                    z[i, j] = x[i, j] + y[i, j];
                    Console.Write(z[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
