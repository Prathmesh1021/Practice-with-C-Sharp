using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ArrayExample7_2D
    {
        //Program to find max element for each row under 2-D Array:-
        static void Main()
        {
            int r = 2, c = 3;
            int[,] arr = new int[r, c];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine("Enter element for {0}{1} index", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Array Elements Are");
            for (int i = 0; i < r; i++)
            {
                int max = arr[i, 0];
                for (int j = 0; j < c; j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                    }
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine(" Max: " + max);

            }

            Console.ReadKey();


        }
    }
}
