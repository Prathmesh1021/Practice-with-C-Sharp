using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class DoWhile2ExampleNormal
    {
        public static int X { get; private set; }

        static void Main() {

            int x = 100;
            do
            {
                Console.WriteLine(x);
            } while (X > 200);
        }
    }
}
