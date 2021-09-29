using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage_UC2_Day9
{
    class EmpWageUC2
    {
        public static void CalculateDailyEmpWage()
        {
            //Constant
            int IsFullTime = 1;
            int EMPRATEPERHOUR = 20;
            // Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            // Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IsFullTime)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMPRATEPERHOUR;
            Console.WriteLine("Emp Wage :" + empWage);
        }
    }
}
