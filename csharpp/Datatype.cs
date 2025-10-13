using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
  internal class Datatype
    {
        internal void PDatatype() {

            int a = 10;//4bytes
            byte b = 20; //1 byte
            float c = 30.5f; //4 bytes
            double d = 40.5; //8 bytes
            char e = 'A'; //2 bytes
            string f = "hello"; // Variable length  
            Console.WriteLine("int a={0}, byte b={1}, float c={2}, double d={3}, char e={4}, string f={5}", a, b, c, d, e, f);
        }
        internal void DDatatype()
        {
             Int32 a = 20;
            Byte b = 40;//1 byte  
            Double d = 80.5; //8 bytes
            Char e ='D'; //2 bytes
            String f = "hello"; // Variable length  
            Object o = 13; // Object can hold any data type 
            Console.WriteLine("Int32 a={0}, Byte b={1}, Double d={2}, Char e={3}, String f={4}, Object o={5}", a, b, d, e, f, o);
        }
    }
}
