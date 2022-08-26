using System;

namespace EmployeePayroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Welcome to employee Wage");
            Console.WriteLine("Choose Option\n 1. Check absent present\t 2. Daily emp wage\t 3. part time wage\t 4. check part time using switch case\t 5. Total Wage For Month");
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
                default:
                    Console.WriteLine("Entered Wrong choice");
                    break;

            }

        }
    }
}

            