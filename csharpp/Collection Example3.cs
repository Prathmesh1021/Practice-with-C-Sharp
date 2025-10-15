using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;   

namespace csharpp
{
    internal class Collection_Example3
    {//Non-Generic Collection : SortedList Example  
        internal void SortedListFun() { 
        
        SortedList S= new SortedList();
            S.Add(3, "Thor");
            S.Add(1, "Odin");
            S.Add(4, "Force Man");
            S.Add(2, "Iron Man ");
            foreach (DictionaryEntry Obj in S) {
                Console.WriteLine("Key is {0} and value is {1}",Obj.Key,Obj.Value);

            }   
        }

        internal void SortedListFun1()
        {//Generic Collection : SortedList Example  
            SortedList<String,Object> S1 = new SortedList<String,Object>();
            { 
            S1.Add("Adim", "Thor");
                S1.Add("Zodin", "Odin");
                S1.Add("Dforce", "Force");
                S1.Add("Biron", "Iron   "); 
                foreach (KeyValuePair<String,Object> obj1 in S1) {

                    Console.WriteLine("Key is {0} And Value is {1} ",obj1.Key,obj1.Value);
                }




            }


        }
    }

}
