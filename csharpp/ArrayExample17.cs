using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ArrayExample17
    {
        //Q) WAP to multiply two matrices?
        static void Main()
        {
            int[,] x = { { 1, 2 }, { 3, 4 } };
            int[,] y = { { 2, 3 }, { 4, 5 } };
            int[,] z = new int[2, 2];
            int i, j, k;
            Console.WriteLine("First Matrix is ");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(x[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Second Matrix is ");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(y[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Multiplication of Matrix is ");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    int sum = 0;
                    for (k = 0; k < 2; k++)
                    {
                        sum = sum + x[i, k] * y[k, j];
                    }
                    z[i, j] = sum;
                    Console.Write(z[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
