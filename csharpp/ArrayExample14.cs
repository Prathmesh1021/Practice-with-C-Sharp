using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csharpp
{
    internal class ArrayExample14
    {
        // Q)  WAP to sort the elements of the array?
        static void Main()
        {
            int[] arr = { 10, 11, 23, 34, 67, 89, 2, 67 };
            int c;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        c = arr[i];
                        arr[i] = arr[j];
                        arr[j] = c;
                    }
                }
            }

            Console.WriteLine("Sorted array is ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


            Console.ReadKey();

        }
    }
}
