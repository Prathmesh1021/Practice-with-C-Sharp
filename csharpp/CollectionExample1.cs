using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;   

namespace csharpp
{
    internal class CollectionExample1
    {
        internal void ArrayListfun() {
        
            ArrayList A =new ArrayList();
            A.Add(1);
            A.Add(2);
            A.Remove(1);
            A.Add("Hello");
            A.Add("A");
            A.Add(2.5); 
            A.Add(true);

            Console.WriteLine("********Using for loop**********");
            for (int i = 0; i < A.Count; i++) {

                Console.WriteLine(A[i]);
            }
            Console.WriteLine("********Using foreach loop**********");
            foreach (Object A1 in A) {
                Console.WriteLine("data is {0}",A1);
            
            }




        }


    }
}
