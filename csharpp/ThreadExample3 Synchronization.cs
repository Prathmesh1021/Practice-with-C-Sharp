using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ThreadExample3_Synchronization
    {
        void Display()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Process " + i);
                Thread.Sleep(1000); 
            }
        } 
        void Display1()
            {
                for (int i = 11; i <= 20; i++)
            { 
                    Console.WriteLine("Process " + i);
                Thread.Sleep(1000);
            }
            } 
    static void Main() {
            ThreadExample3_Synchronization obj = new ThreadExample3_Synchronization();
            ThreadStart thread = new ThreadStart(obj.Display); 
            Thread t = new Thread(thread); 
            t.Start();
            t.Join(); // Synchronization point  
            ThreadStart thread1 = new ThreadStart(obj.Display1);
            Thread t1 = new Thread(thread1);
            t1.Start();

        } }
    }

