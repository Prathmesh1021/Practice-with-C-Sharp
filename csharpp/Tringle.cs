using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class Tringle
    {
        float b, h, area;

        internal void CalcTriangleArea()
        {
            b = 10f; // base
            h = 5f;  // height
            area = 0.5f * b * h;
            Console.WriteLine("AREA OF TRIANGLE = {0}", area);
        }
    }
}
