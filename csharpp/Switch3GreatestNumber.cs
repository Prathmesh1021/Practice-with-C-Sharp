using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class Switch3GreatestNumber
    {
        static void Main()
        {
            int a = 32, b = 45;

            switch (a > b)
            {
                case true:
                    Console.WriteLine("a is grether than b");
                    break;

                default:
                    Console.WriteLine("b is grether than a");
                    break;

            }
        }
    }
}
