using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class ArrayExample3
    {
        static void Main()
        {
            int size;
            Console.WriteLine("Enter Size of Array ");
            size = Convert.ToInt32(Console.ReadLine());
            String[] arr = new String[size];
            Console.WriteLine("for loop ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter Item ");
                arr[i]= Console.ReadLine(); 
            }
            Console.WriteLine("Array element are ");
            foreach (String i in arr)
            {
                Console.WriteLine(i);

            }
        }
    }
}
