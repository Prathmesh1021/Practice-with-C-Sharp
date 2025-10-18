using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ArrayExample21
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[5];
            int i, j, temp;
            for (i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine("enter element of array" + i + "Index");
                Arr[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < Arr.Length; i++)
            {
                for (j = i + 1; j < Arr.Length; j++)
                {
                    if (Arr[i] < Arr[j])
                    {
                        temp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = temp;
                    }
                }
            }
            for (i = 0; i <= Arr.Length; i++)
            {
                Console.WriteLine("sort of array is " + Arr[i]);
            }

            Console.ReadKey();
        }
    }
}

