using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage_UC3_Day9
{
    class EmpWageUC3
    {
        public static void AddPartTimeEmpW()
        {
            // Constant variables
            int IsPartTime = 1;
            int EmpRatePerHour = 20;

            //Variables
            int EmpHrs = 0;
            int EmpWage = 0;
            Random random = new Random();

            int EmpCheck = random.Next(1, 2);
            Console.WriteLine("Random number :" + EmpCheck);

            if (EmpCheck == IsPartTime)
            {
                EmpHrs = 8;
            }
            else
            {
                EmpHrs = 0;

            }
            EmpWage = EmpHrs * EmpRatePerHour;
            Console.WriteLine("Emp Wage :" + EmpWage);
        }
    }
}
