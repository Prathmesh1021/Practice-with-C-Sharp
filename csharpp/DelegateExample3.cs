using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class DelegateExample3
    {
        void add(int a, int b)//with parameter
        {
            Console.WriteLine("Addition is :" + (a + b));
        }   
    
        void sub(int a, int b)
        {
            Console.WriteLine("Subtraction is :" + (a - b));
        }
        void mul(int a, int b) { 
               Console.WriteLine("Multiplication is :"+(a*b));

        }
        void div(int a, int b)
        {
            Console.WriteLine("Division is :" + (a / b));
        }

        public delegate void MathOperation(int a, int b);//with parameter   
        static void Main() {

            DelegateExample3 obj = new DelegateExample3();
            MathOperation M = new MathOperation(obj.add);
            
            M += obj.sub;//attach    
            M -= obj.mul;   //dettach  
            M += obj.div; // attach 

            M(10, 2);
        }

    }
}
