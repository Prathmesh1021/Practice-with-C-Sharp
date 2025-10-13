using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class SI
    {
        float p, r, t, si;
        internal void CalcSI()
        {
            p = 12000;
            r = 2.2F;
            t = 4.5F;
            si= (p * r * t) / 100;
            Console.WriteLine("RESULT IN {0}", si);
        }

    }
}
 