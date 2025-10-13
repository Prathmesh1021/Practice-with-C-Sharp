using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    class Encapsulation_Example1
    {

        private int a = 100;

        //public int A{get { return a;}, set { a=value}}
        void FUNCTION() {
            Console.WriteLine(a);
        }
    
    public static void Main() {
        
            Encapsulation_Example1  obj= new Encapsulation_Example1();  
            obj.FUNCTION();
        }
    }
}