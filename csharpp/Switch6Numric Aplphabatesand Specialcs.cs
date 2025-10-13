using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace csharpp
{
    internal class Switch6Numric_Aplphabatesand_Specialcs
    {
        static void Main()
        {
            Console.Write("Enter any character: ");
            char ch = Convert.ToChar(Console.ReadLine());  // User input

            switch (ch)
            {
                // Case for digits (0–9)
                case char n when (n >= '0' && n <= '9'):
                    Console.WriteLine(ch + " is a Numeric Character.");
                    break;

                // Case for alphabets (A–Z, a–z)
                case char n when ((n >= 'A' && n <= 'Z') || (n >= 'a' && n <= 'z')):
                    Console.WriteLine(ch + " is an Alphabet.");
                    break;

                // Default → Special character
                default:
                    Console.WriteLine(ch + " is a Special Character.");
                    break;
            }
        }
    }
}
