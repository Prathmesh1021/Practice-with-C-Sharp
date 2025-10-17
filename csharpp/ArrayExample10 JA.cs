using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ArrayExample10_JA
    {
        static void Main()
        {
            int r, c;
            Console.WriteLine("Enter number of rows");
            r = int.Parse(Console.ReadLine());

            int[][] arr = new int[r][];

            for (int i = 0; i < r; i++)
            {
                Console.WriteLine("Enter number of column elements");
                c = int.Parse(Console.ReadLine());
                arr[i] = new int[c];
                for (int j = 0; j < c; j++)
                {
                    arr[i][j] = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("Jagged Array Elements Is");
            for (int i = 0; i < r; i++)
            {

                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();

            }
            Console.ReadKey();

        }
    }
}
