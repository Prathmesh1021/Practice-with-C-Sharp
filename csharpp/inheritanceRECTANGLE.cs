using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class inheritanceRECTANGLE:inheritanceCRICLE
    {
       internal int p2;
        internal   void Accept1(int p2)
        {
            this.p2 = p2;
        }
        internal void RectArea() 
        {
        area=p1*p2; 
        }

    }
} 
