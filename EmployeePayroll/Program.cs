using System;

namespace EmployeePayroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Welcome to employee Wage");
            Console.WriteLine("Choose Option\n 1. Check absent present\n 2. Daily emp wage\n 3. part time wage\n 4. check part time using switch case\n 5. calculate Wage For Month\n 6. Calculate wage for month using while loop\n 7. Compute Employee Wage\n 8. Employee wage for multiple company");            
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    EmployeePresentAbsent.EmployeeAttendance();
                    break;
                case 2:
                    DailyWage.CalculateDailyWage();
                    break;
                case 3:
                    PartTimeWage.CalculatePercentage();
                    break;
                case 4:
                    PartTimeWageSwitchCase.CalculateWage();
                    break;
                case 5:
                    WageForMonth.CalculateWageForMonth();
                    break;
                case 6:
                    WageForMonthWhileLoop.CalculateWage();
                    break;
                case 7:
                    ComputeEmployeeWage.ComputeEmpWage();
                    break;
                case 8:
                    WageForMultipleCompany.ComputeWaageForMultipleCompany("D-Mart", 20, 20, 100);
                    WageForMultipleCompany.ComputeWaageForMultipleCompany("Reliance", 20, 20, 100);
                    break;
                default:
                    Console.WriteLine("Entered Wrong choice");
                    break;

            }

        }
    }
}

            