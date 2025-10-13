using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class Switch2Vowel1
    {
        static void Main() {
            char ch = 'a';

            switch (ch)
            {
               case 'a':
                   case 'e':    
                    case 'i':
                    case 'o':
                    case 'u':

                    Console.WriteLine("Vowel");
                    break;

                default: {
                        Console.WriteLine("invalid ");
                        break;
                    
                    }
            }


}

} }

