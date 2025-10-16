using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; 
using System.Diagnostics;

namespace csharpp
{
    internal class ThreadExample2
    {
        void Display()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("process " + i);
                Thread.Sleep(1000);
            }
        }
        void Display1()
        {
            for (int i = 11 ; i <= 20; i++)
            {
                Console.WriteLine("process " + i);
                Thread.Sleep(1000);
            }
        }
        public static void Main()
        {
            ThreadExample2 obj = new ThreadExample2();
            ThreadStart th = new ThreadStart(obj.Display);
            Thread t = new Thread(th);
            t.Start();
            ThreadStart th1 = new ThreadStart(obj.Display1);
            Thread t1 = new Thread(th1);
            t1.Start();

        }
    }
}
