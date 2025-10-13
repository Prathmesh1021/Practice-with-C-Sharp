using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class MarksheetExample
    {
        static void Main() {
            int phyMarks = 75, chemMarks = 76, mathMarks = 75, hindiMarks = 99, engMarks = 97;
            int count = 0;
            int gm = 0;
            String Subject = "";
            String distinction = "";
            float per;
  if ((phyMarks >= 0 && phyMarks <= 100) && (chemMarks >= 0 && chemMarks <= 100) && (mathMarks >= 0 && mathMarks <= 100) && (hindiMarks >= 0 && hindiMarks <= 100) && (engMarks >= 0 && engMarks <= 100))
            {
                if (phyMarks < 33) 
                { count++;
                    gm = phyMarks;
                    Subject+= "Physics ";   
                }
                if (chemMarks < 33) 
                { count++;
                    gm = chemMarks;
                    Subject += "Cemistry ";

                }
                if (mathMarks < 33) 
                { count++;
                    gm = mathMarks;
                    Subject += "Mathematics ";

                }
                if (hindiMarks < 33) 
                { count++;
                    gm = hindiMarks;
                    Subject += "Hindi";

                }
                if (engMarks < 33) 
                { count++;
                    gm = engMarks;
                    Subject += "English ";

                }
                if (phyMarks >=75)
                {
                    distinction += "Physics ";  
                }
                if (chemMarks >=75)
                {
                   distinction += "Cemistry ";
                }
                if (mathMarks >=75)
                {
                    distinction += "Mathematics ";
                }   
                if (hindiMarks >=75)
                {
                   distinction += "Hindi";
                }
                if (engMarks >=75)
                {
                    distinction += "English ";

                }
                if (count == 0 || (count==1 && gm>=28))
                {
                    if (count == 0)
                    {
                        per = (phyMarks + chemMarks + mathMarks + hindiMarks + engMarks) / 5.0f;
                    }
                    else {
                        per = (phyMarks + chemMarks + mathMarks + hindiMarks + engMarks + (33 - gm)) / 5;
                     }
                    if (per >= 33&& per<=45)
                        Console.WriteLine("Pass with third divition and pertange is "+per+ "%");
                    else  if (per >60)
                        Console.WriteLine("Pass with Second divition and pertange is " + per + "%");
                    else Console.WriteLine("Pass with First divition and pertange is " + per + "%");    
                    
                    if (distinction != "")
                    {
                        Console.WriteLine("Distinction subkect are  " + distinction);
                    }
                    if (count == 1)
                    {
                        Console.WriteLine("Pass by grace & grace subject is" + Subject);
                    }
                }
                else if (count == 1)
                {
                    Console.WriteLine("Supply");
                    Console.WriteLine("Supply subject is "+Subject);
                }
                else {
                    Console.WriteLine("Fail");
                    Console.WriteLine("Fail subject is "+Subject);
                }
            }
            else {
                Console.WriteLine("Invalid Marks, it shoud be between 0 to 100 ");
            }
        }
    }
}
