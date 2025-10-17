using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp 
{
    internal class ArrayExample5_1D
    {
        static void Main()
        {
            int size;
            Console.WriteLine("Enter size of elements");
            size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter element for " + i + " index");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array elements are");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("Reverse of array elements are");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Max elements");
            int max = arr[0];
            int smax = arr[0];
            for (int i = 1; i < size; i++)
            {
                if (max < arr[i])
                {
                    smax = max;
                    max = arr[i];
                }
                else if (smax < arr[i])
                    smax = arr[i];
            }
            Console.WriteLine(max + " " + smax);
        } 
         
    }
}
