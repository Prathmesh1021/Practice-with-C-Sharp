using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class Circle
    {  
        float radius, area;

        internal void CalcCircleArea()
        {
            radius = 7f;
            area = (float)(Math.PI * radius * radius);
            Console.WriteLine("AREA OF CIRCLE = {0}", area);
        }
    }
}
