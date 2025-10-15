using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class DelegateExample1
    {

        void Welcome()//without parameter
        { 
        
        Console.WriteLine("Welcome to C# Programming");
        }
        public delegate void WelcomeHandler();//without parameter   

        static void Main()
        {
            DelegateExample1 obj = new DelegateExample1();
            WelcomeHandler handler = new WelcomeHandler(obj.Welcome);
            handler();
            handler();
            handler();
            handler();
            handler();
            handler();

        }
    }
}
