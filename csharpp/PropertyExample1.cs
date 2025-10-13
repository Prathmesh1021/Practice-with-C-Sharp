using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{  internal class PropertyExample1
    {
        private int width;
        public int Height { get; set; }// direct property declare 
        string x = "hello welcome to my channel";
        internal PropertyExample1()
        {
            Console.WriteLine(x.Length);
        }   
        public int Width { get => width; set => width = value; }

        private int width1
        {
            get { return width1; }
            set { width = value; }
        }
        private int width2;
public int Width2 {
get { return width; }
set { width2 = value; }

}     //  public int Width { get => width; set => width = value; }
    }
    }

