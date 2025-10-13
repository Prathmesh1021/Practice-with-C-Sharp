using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class inheritanceMANAGER:inheritanceADMIN
    {
        string salary = "50000";
        internal void fun1() {

            Console.WriteLine("Salary = "+ salary);
        }

    }
}
