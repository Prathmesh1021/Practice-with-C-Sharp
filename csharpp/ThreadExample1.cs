using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ThreadExample1
    {
        void Display() {
            for (int i = 1; i <= 10; i++) {

                Console.WriteLine("process " + i);
                Thread.Sleep(10000);

            }
        }

        public static void Main()
        {
            ThreadExample1 obj = new ThreadExample1();
            ThreadStart th=new ThreadStart(obj.Display);   
            Thread t = new Thread(th);  
            t.Start();  

        }   

    }
}
