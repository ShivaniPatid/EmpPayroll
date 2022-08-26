using System;
using System.Globalization;

namespace EmployeePayroll
{
    internal class PartTimeWage
    {
        public static void CalculatePercentage()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            Random random=new Random();
            int empCheck = random.Next(1,3);

            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
                Console.WriteLine("Employee is present for full time");
            }
            else if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
                Console.WriteLine("Employee is present for part time");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is absent");
            }
            int empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee daily wage including the part time : "+empWage);
        }   
    }
}
