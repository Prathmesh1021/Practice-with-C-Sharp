using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpp
{
    internal class EmployeeForClass
    {
        private int Empid;
        private String Empname;
        private int age;

        internal void Accept(int Empid, String Empname, int age)
        {
            this.Empid = Empid;
            this.Empname = Empname;
            this.age = age;
        }
        internal void Display()
        {
           Console.WriteLine("Employee id " + Empid);   
              Console.WriteLine("Employee Name " + Empname);    
               Console.WriteLine("Employee Age " + age);
        }
    }
}