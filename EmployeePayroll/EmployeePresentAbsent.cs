﻿using System;


namespace EmployeePayroll
{
    internal class EmployeePresentAbsent
    {

        public static void EmployeeAttendance()
        {
       
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            
            if (empCheck == 0)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }

    }
}
