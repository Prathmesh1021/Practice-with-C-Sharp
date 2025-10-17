using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ArrayExample12
    {
        // Q) WAP to count total vowel and consonant in Char Array?
        static void Main()
        {
            // char[] arr = { 'c', 'o', 'n', 'c', 'e', 'p', 't' };
            Console.WriteLine("Enter name");
            string arr = Console.ReadLine();
            int v = 0, c = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 'a' || arr[i] == 'e' || arr[i] == 'i' || arr[i] == 'o' || arr[i] == 'u')
                {
                    v++;
                }
                else
                {
                    c++;
                }

            }

            Console.WriteLine("Total Vowel is {0} and Consonent is {1}", v, c);
            Console.ReadKey();

        }
    }
}
