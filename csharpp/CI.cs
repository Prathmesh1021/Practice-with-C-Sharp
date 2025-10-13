using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class CI
    {
        float p, r, t, a, ci; 
        int n;

        internal void CalcCI()
        {
            p = 12000;   // Principal
            r = 2.2F;    // Rate (%)
            t = 4.5F;    // Time (years)
            n = 4;       // Compounded quarterly

            a = (float)(p * Math.Pow((1 + (r / 100) / n), n * t)); // Final amount
            ci = a - p;  // Compound Interest

            Console.WriteLine("FINAL AMOUNT = {0}", a);
            Console.WriteLine("COMPOUND INTEREST = {0}", ci);
        }
    }
}
