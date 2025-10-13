using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ArrayExample2
    {
        static void Main()
        {
            int size;
            Console.WriteLine("Enter Size of Array ");
            size = Convert.ToInt32(Console.ReadLine()); 
            int[] arr = new int [size];
            Console.WriteLine("for loop ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("foreachloop");
            foreach (int i in arr)
            {
                Console.WriteLine(i);

            }
        }
    }
}
