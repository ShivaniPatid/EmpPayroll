using System;

namespace EmployeePayroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Welcome to employee Wage");
            Console.WriteLine("Choose Option\n 1. Check absent present\n 2. Daily emp wage\n 3. part time wage\n 4. check part time using switch case\n 5. calculate Wage For Month\n 6. Calculate wage for month using while loop\n 7. Compute Employee Wage\n 8. Employee wage for multiple company\n 9.Compute Employee Wage and Save Total Wage for each Company\n 10. Ability to manage Employee Wage of multiple companies\n 11. Employee Wage for Multiple Company using Interface approach");            
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
                case 9:
                    EmpWageBuilderObject dmart = new EmpWageBuilderObject("D-Mart", 20, 20, 100);
                    EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 20, 20, 100);
                    dmart.ComputeEmployeeWage();
                    Console.WriteLine(dmart.ToString());
                    reliance.ComputeEmployeeWage();
                    Console.WriteLine(reliance.ToString());
                    break;
                case 10:
                    EmpWageBuilderArray empWageBuilderArray = new EmpWageBuilderArray();
                    empWageBuilderArray.addCompanyEmpWage("D-Mart", 20, 2, 10);
                    empWageBuilderArray.addCompanyEmpWage("Reliance", 10, 4, 20);
                    empWageBuilderArray.computeEmpWage();
                    break;
                case 11:
                    EmpWageBuilder empWageBuilder = new EmpWageBuilder();
                    empWageBuilder.AddCompanyEmpWage("D-Mart", 20, 20, 100);
                    empWageBuilder.AddCompanyEmpWage("Reliance", 20, 20, 100);
                    empWageBuilder.ComputeEmpWage();
                    break;
                default:
                    Console.WriteLine("Entered Wrong choice");
                    break;

            }
            Console.ReadLine();

        }
    }
}

            