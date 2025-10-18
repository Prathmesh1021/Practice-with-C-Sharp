using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ArrayExample23
    {//Lowercase to uppercase & uppercase to lowercase
        static void Main(string[] args)
        {
            char[] aa = { 'i' };
            char ab = '\0'; // use char instead of int for character manipulation

            for (int i = 0; i < aa.Length; i++)
            {
                if (aa[i] >= 'A' && aa[i] <= 'Z')  // if uppercase
                {
                    ab = (char)(aa[i] + 32);       // convert to lowercase
                }
                else if (aa[i] >= 'a' && aa[i] <= 'z')  // if lowercase
                {
                    ab = (char)(aa[i] - 32);       // convert to uppercase
                }
                else
                {
                    ab = aa[i];                    // unchanged for non-alphabetic
                }
            }

            Console.WriteLine("Result is: {0}", ab);
            Console.ReadKey();
        }
    }
}    

