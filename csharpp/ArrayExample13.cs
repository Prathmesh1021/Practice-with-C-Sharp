using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ArrayExample13
    {
        //Q) WAP to replace char array each char to the next consecutive char?
        static void Main()
        {
            char[] arr = { 'c', 'o', 'n', 'c', 'e', 'p', 'z' };

            int v;
            for (int i = 0; i < arr.Length; i++)
            {

                v = arr[i] + 1;
                if (arr[i] == 'z')
                {
                    arr[i] = 'a';
                }
                else
                {
                    arr[i] = (char)v;
                }
                Console.WriteLine(arr[i]);

            }


            Console.ReadKey();

        }
    }
}
