using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class Array_Examplw4
    {
          static void Main()
        {
            int []  arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter element for " + i + " index");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array Element is ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] +" ");
            }
            Console.ReadKey();
        }
    }
}
