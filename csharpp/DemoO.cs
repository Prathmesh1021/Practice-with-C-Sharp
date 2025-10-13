using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class DemoO
    {
        int a, b, c;

        internal void accept()
        {
            Console.WriteLine("Enter Frist number=");
            a = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter Second number=");
            b = Convert.ToInt32(Console.ReadLine());


        }
        internal void add()
        {
            c = a + b;
            Console.WriteLine("Addtion is =" + c);
        }

        internal void sub()
        {
            c = a - b;
            Console.WriteLine("Substraction is =" + c);
        }
        internal void mul()
        {
            c = a * b;
            Console.WriteLine("Multiplication is =" + c);
        }
        internal void div()
        {
            c = a / b;
            Console.WriteLine("Divition is =" + c);
        }
        internal void mod()
        {
            c = a % b;
            Console.WriteLine("Reminder is =" + c);
        }

    }
        
}
