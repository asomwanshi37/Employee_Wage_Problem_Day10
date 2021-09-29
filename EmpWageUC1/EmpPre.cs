using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageUC1
{
    public class EmpPre
    {
        public static void CheckPresentAbsent()
        {
            // Constant
            int IsFullTime = 1; 
            Random random = new Random();
            // Computation
            int empCheck = random.Next(0, 2);

            if (empCheck == IsFullTime)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
    
}
