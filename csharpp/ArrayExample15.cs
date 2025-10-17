using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ArrayExample15
    {//Q)  WAP to merge two arrays in one array?
        static void Main()
        {
            int[] a = { 1, 2 };
            int[] b = { 3, 4 };
            int[] c = new int[a.Length + b.Length];
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                c[index] = a[i];
                index++;
            }

            for (int i = 0; i < b.Length; i++)
            {
                c[index] = b[i];
                index++;
            }

            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }
            Console.ReadKey();

        }
    }
}
