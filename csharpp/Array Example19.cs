using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class Array_Example19
    {
            
        object[] arr;
        void AcceptObject(object[] arr)
        {
            this.arr = arr;
        }
        void DisplayObject()
        {
            foreach (object o in arr)
            {
                Console.WriteLine(o);
            }
        }

        public static void Main()
        {
            Array_Example19 obj = new Array_Example19();
            object[] a = { 1001, "XYZ", "CS", 45000.345 };
            obj.AcceptObject(a);
            obj.DisplayObject();
            Console.ReadKey();
        }
    }
}

