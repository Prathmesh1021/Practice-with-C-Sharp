using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class inheritanceCRICLE
    {
       internal int p1;
       internal float area;
        internal void Accept(int p1) {
            this.p1 = p1;
        }
      internal void CircleArea() { 
            area=3.14F * p1 * p1;    
        }
        internal void Display() {
             
            Console.WriteLine("Area is{0}",area);
        }
    }
}
 