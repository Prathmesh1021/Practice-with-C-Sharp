using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;   

namespace csharpp
{
    internal class CollectionExample6
    {

        internal void HAshSet() { 
        
       HashSet<String>st= new HashSet<String>();    
            

            st.Add("A");
            st.Add("B");    
            st.Add("C");    
            st.Add("D"); 
            st.Add("E");    
            st.Add("A");//duplicate not allowed 
            foreach (String s in st) { 
            
                Console.WriteLine(s);
            }   


        }


        }
    }

