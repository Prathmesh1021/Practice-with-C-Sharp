using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class CollectionExample2
    {
        internal void HasdhtableFun() {
        
        Hashtable Ht = new Hashtable();
            Ht.Add("Roll No.",1001);
            Ht.Add("Name","John the Don");
            Ht.Add("Branch", "ECS");
            Ht.Add("Fees",120000);

            foreach (DictionaryEntry Obj in Ht)
            {
                Console.WriteLine("Key is {0} and value is {1}",Obj.Key,Obj.Value);
            
            }

        }
    }
}
