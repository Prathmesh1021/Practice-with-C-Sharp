using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class Static_Poly_Overloading_Example1
    {
        void add(int a ,int b) {
            Console.WriteLine(a+b);
        }
        void add(int a, int b, int c) {
            Console.WriteLine(a + b + c);
        }
        void add(float a, float b) {
            Console.WriteLine(a+b);
        }
        public static void Main() { 
        
            Static_Poly_Overloading_Example1 obj= new Static_Poly_Overloading_Example1();
            obj.add(1, 2);
            obj.add(1,5,3);
            obj.add(16.3f,1.6f);
        }
    }
}
