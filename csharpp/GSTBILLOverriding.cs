using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class GSTBILLOverriding: BILLOverriding    
    {
        //overhiding
        public double calcBill(int amount)
        {
            return amount + amount * 0.05F;
        }
    }
}
