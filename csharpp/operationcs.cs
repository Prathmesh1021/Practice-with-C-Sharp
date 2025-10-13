using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class operationcs
    {
        int a, b, c;

        internal void accept()
        {

            Console.WriteLine("Enter Frist Number ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        internal void add()
        {
            c = a + b;
            Console.WriteLine(c);
        }
        internal void sub()
        {
            c = a - b;
            Console.WriteLine(c);
        }
        internal void mul()
        {
            c = a * b;
            Console.WriteLine(c);
        }
        internal void div()
        {
            c = a / b;
            Console.WriteLine(c);
        }
        static void Main() { 
        
            operationcs obj = new operationcs();
            obj.accept();
            obj.add();
            obj.sub();
            obj.mul();
            obj.div();  


        }
    }
}
