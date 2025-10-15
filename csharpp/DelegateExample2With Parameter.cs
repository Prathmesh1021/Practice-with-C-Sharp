  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class DelegateExample2With_Parameter
    {

        void Welcome1(String msg)//with parameter    
        {

            Console.WriteLine(msg);
        }
        public delegate void WelcomeHandler(String msg);//with parameter    

        static void Main()
        {
            DelegateExample2With_Parameter obj = new DelegateExample2With_Parameter();
            WelcomeHandler handler = new WelcomeHandler(obj.Welcome1);
            handler("Welcome In C#");
            handler("Welcome In .NET");
            handler("Welcome in Java");
            handler("Welcome In Paythan");
            handler("Welcome in C");
            handler("Welcome in C++");

        }
    }
}
