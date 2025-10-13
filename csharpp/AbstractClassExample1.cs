using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal abstract class AbstractClassExample1
    {

        internal int p1, p2;
        internal float area;

        internal void Accept(int p1, int p2) {

            this.p1 = p1;
            this.p2 = p2;
        }
       internal  abstract void trangle();//abstract method hideing
        internal abstract void rectangle();//abstract method hideing
        internal void Display() {
            Console.WriteLine("Area is {0} ",area);
        }
    }
    }

