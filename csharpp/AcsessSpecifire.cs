using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    public class AcsessSpecifire
    {
        private void fun1(){
            Console.WriteLine("Private fun1");

        }
        internal void fun2() {
            Console.WriteLine("Internal fun2");
        
        }
        protected void fun3() {
            Console.WriteLine("Protected fun3");
        }
        protected internal void fun4() { 
        Console.WriteLine("Internal Protected fun4");
        }
        public void fun5() {
            Console.WriteLine("Public fun5");
        }
    }
}
