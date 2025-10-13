using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class Nested_For_loop_Example_4_AaBbC
    {

        static void Main()
        {
            for (int i = 1; i <= 50; i++)
            {
                char ch = 'A';
                for (int j = 1; j <= 52-i; j++)
                {
                    if (j % 2 != 0) 
                    Console.Write(ch + " ");
                    else {
                        Console.Write((char)(ch + 32)+ " ");
                        ch++;
                    }
                }
                Console.WriteLine();

            } }   } }
        
    
