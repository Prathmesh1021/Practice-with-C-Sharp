using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class Exception_handling_negative_number_exceptipn_Example5 : Exception
    {

        private string _message="Enter only positive Number";

        public string Message
        {
            get { return _message; }
        }   
    }
}