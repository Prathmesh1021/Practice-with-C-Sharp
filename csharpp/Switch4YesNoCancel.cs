using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class Switch4YesNoCancel
    {
        static void Main()
        {
            Console.WriteLine("Enter your: ");
            char choice = Convert.ToChar(Console.ReadLine());

            switch (choice)
            {
                case 'y':
                case 'Y':
                    Console.WriteLine("Yes");
                    break;

                case 'n':
                case 'N':
                    Console.WriteLine("No");
                    break;

                case 'c':
                case 'C':
                    Console.WriteLine("Cancel");
                    break;

                default:
                    Console.WriteLine("Invalid input, please enter y, n, or c.");
                    break;
            }
        }
    }
}
