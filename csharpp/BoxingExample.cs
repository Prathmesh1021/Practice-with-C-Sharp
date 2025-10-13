using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class BoxingExample
    {
        internal  void boxingfun() // Boxing Example with int to object 
        {

            int a = 10;
            Object o;
            o = a;
            Console.WriteLine(o);
        }

        internal void unboxingfun()// Unboxing Example  with object to int
        {
            object o = 13;
            int a = (int)o;
            Console.WriteLine(a);    
        }

        internal void BoxingFun1()// Boxing Example with String to object   

        {
          string str = "Hello, World!";
            Object obj ;
            obj = str;  
            Console.WriteLine(obj);

        }

        internal void unboxingFun1() {
            object a = "prathmesh";
            string b = (string)a;
            Console.WriteLine(b);
        
        
        }
    }
}
