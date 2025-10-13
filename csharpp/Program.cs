using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace csharpp
{
    internal class Program
    {
        static void Main()
        {
            static void Main()
            {
                int num;
                try
                {
                    Console.WriteLine("Enter Number");
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num < 0)
                    {

                        throw new Exception_handling_negative_number_exceptipn_Example5();


                    }
                    Console.WriteLine("Number is " + num);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Enter only +Ve Numbers");

                }


            }
        }
    }
}