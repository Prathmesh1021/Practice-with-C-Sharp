using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class EmployeeSalaryAssignment10
    {
        static void Main() {
            int salary = 20000;
            for (int empid = 1001; empid <= 1020; empid++) 
            {
                if (salary > 30000 && empid >= 1017)
                    break;
                else if (empid==1003||empid==1005||empid==1007)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Empid {0} and salary {1} ", empid, salary);
                }
            }
        }
    }
}
