using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class CollectionExample5
    {
        internal void DictionaryFun()
        {
            Dictionary<String, Int32> obj1 = new Dictionary<String, Int32>();

            obj1.Add("A", 101);

            obj1.Add("D", 455);

            obj1.Add("B", 201);

            obj1.Add("C", 301);

            foreach (KeyValuePair<String, Int32> o in obj1)

            {

                Console.WriteLine(o.Key + " " + o.Value);

            }
        }
    }
}
