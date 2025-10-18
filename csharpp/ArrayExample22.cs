using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ArrayExample22
    {
        static void Main(string[] args)
        {
            char[] ar = { 'A', 'B', 'C', 'D', 'E', 'X', 'Y', 'Z' };

            Console.WriteLine("Reverse of character array:");
            for (int i = ar.Length - 1; i >= 0; i--)
            {
                Console.Write(ar[i] + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
