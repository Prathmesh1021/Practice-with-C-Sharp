using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class EventDemo
    {
        public delegate void EventHandler(); //create delegate
        public event EventHandler MyEvent // create event with add and remove event
        {
            add
            {
                Console.WriteLine("add operation");
            }
            remove
            {
                Console.WriteLine("remove operation");
            }
        }
    }
}
