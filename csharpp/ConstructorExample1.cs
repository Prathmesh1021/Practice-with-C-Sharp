using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ConstructorExample1
    {
        static ConstructorExample1() // Removed 'internal' access modifier
        {
            Console.WriteLine("static Default Constructor");
        }

        internal ConstructorExample1()
        {
            Console.WriteLine("Default Constructor");
        }

        internal ConstructorExample1(int x)
        {
            Console.WriteLine("Parameterised" + x);
        }
    }
}