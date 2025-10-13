using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ConversionIToF_FToI
    {
        float feet, inch;

        internal void FeetToInch()
        {
            feet = 5f; // example value
            inch = feet * 12;
            Console.WriteLine("{0} FEET = {1} INCHES", feet, inch);
        }

        internal void InchToFeet()
        {
            inch = 120f; // example value
            feet = inch / 12;
            Console.WriteLine("{0} INCHES = {1} FEET", inch, feet);
        }
    }
}
