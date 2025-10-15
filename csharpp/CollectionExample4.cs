using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;   

namespace csharpp
{
    internal class CollectionExample4
    {
        internal void StackFun()
        {

            Stack Sk = new Stack();
            Sk.Push("playear 1001");
            Sk.Push("playear 1004");
            Sk.Push("playear 1005");
            Sk.Push("playear 1009");
            Sk.Push("playear 1010");

             Console.WriteLine(Sk.Pop());//1010  
             Console.WriteLine(Sk.Peek());//1009   
            while (Sk.Count != 0)
            {

                Console.WriteLine(Sk.Pop());//

            }

        }
       internal void QueueFub() {
            Queue Qu = new Queue();
            Qu.Enqueue("playear 1001");
            Qu.Enqueue("playear 1004");
            Qu.Enqueue("playear 1005");
            Qu.Enqueue("playear 1009");
            Qu.Enqueue("playear 1010");

             Console.WriteLine(Qu.Dequeue());//1010  
            Console.WriteLine(Qu.Peek());//1009   
           while (Qu.Count != 0)
            {

                Console.WriteLine(Qu.Dequeue());//
         }
            




        }
    }
    
}

