using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp2
{
    internal class Analyst:Employee
    {
        //For 'Analyst' class object is created in the program.cs file.
        public double ClientAllowance = 10000;
        public override double CalculateSalary()
        {
            double salaryPerMonth=ClientAllowance+base.CalculateSalary();
            return salaryPerMonth;
        }
    }

    /*
     Base Keyword:Base keyword is used for access base class(Super class) method and base class constructor functionality from the derived class method and constructor.
     
     */
}
