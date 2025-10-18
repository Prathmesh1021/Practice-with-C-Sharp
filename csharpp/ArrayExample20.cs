using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ArrayExample20
    {//WAP to print reverse of Char Array?
        static void Main(string[] args)
        {
            char[] arr = { 'A', 'a', 'd', 'a', 'r', 's', 'h' };
            Console.WriteLine("Reverse of char ");

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadKey();

        }
    }
}

