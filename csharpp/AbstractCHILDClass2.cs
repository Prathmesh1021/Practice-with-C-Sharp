using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class AbstractCHILDClass2 : AbstractClassExample1
    {
        internal override void rectangle()
        {
            area =p1*p2;
        }

        internal override void trangle()
        {
            area = (p1 * p2) / 2;
        }
    }
}
