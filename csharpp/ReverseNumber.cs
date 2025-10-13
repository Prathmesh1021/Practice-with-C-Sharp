using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ReverseNumber
    {
        int num, rev;

        internal void ReverseThreeDigit()
        {
            num = 123; // Example 3-digit number
            rev = (num % 10) * 100 + ((num / 10) % 10) * 10 + (num / 100);

            Console.WriteLine("ORIGINAL NUMBER = {0}", num);
            Console.WriteLine("REVERSED NUMBER = {0}", rev);
        }
    }
}
