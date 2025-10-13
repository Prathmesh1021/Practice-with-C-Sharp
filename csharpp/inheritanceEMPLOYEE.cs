using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class inheritanceEMPLOYEE:inheritanceMANAGER
    {
        int Incentive = 2000;
        internal void fun2() {
            Console.WriteLine("Insentive = " + Incentive);
        }
    }
}
