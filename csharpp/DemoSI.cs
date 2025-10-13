using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class DemoSI
    {
        internal void CALSI()
        {
            float p, r, t, si;
            p = 1000;
            r = 2.3f;
            t = 7.4f;

            si = p * r * t / 100;
            {
                Console.WriteLine("Simple intrest =" + si);
            }
        }

    }
}
