using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csharpp
{
    internal class ArrayExample8_2D
    {
        //# Program to sort the element for each row?
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

                for (int j = 0; j < c; j++)
                {

                    for (int k = j + 1; k < c; k++)
                    {
                        if (arr[i, j] > arr[i, k])
                        {
                            int temp = arr[i, j];
                            arr[i, j] = arr[i, k];
                            arr[i, k] = temp;
                        }
                    }
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();


            }

            Console.ReadKey();


        }
    }
}
