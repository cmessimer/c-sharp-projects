using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProgramCDM
{
    public class Utilities
    {
        // Using Optional Parameters (OP3)
        public static void UsingOptionalParameters()
        {
            int monthlyWage1 = 1234;
            int months1 = 12;

            int yearlyWageForEmployee1 = CalculateYearlyWageWithOptional2(monthlyWage1, months1);
            Console.WriteLine($"Yearly wage for employee 1 (optional) (Chad): {yearlyWageForEmployee1}");
        }

        //Need to set CalculateyearlyWageWithNamed to be used in Using Opitional Parameters (OP3)

        public static int CalculateYearlyWageWithOptional2(int monthlyWage, int numberOfMonthsWorked, int bonus = 0)
        {
            Console.WriteLine($"The yearly wage is (Optional) {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        // Adding functionality using optional parameters (OP1)
        public static void UsingNamedArguments()
        {
            int monthlyWage1 = 1234;
            int months1 = 12;

            int yearlyWageForEmployee1 = CalculateYearlyWageWithOptional(monthlyWage1, months1);
                Console.WriteLine($"Yearly wage for employee 1 (Bethany): {yearlyWageForEmployee1}"); 
        }

        //used in conjuction with optional parameters (OP1)
        public static int CalculateYearlyWageWithOptional(int monthlyWage, int numberOfMonthsWorked, int bonus = 0)
        {
            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            if (numberOfMonthsWorked == 12) //let's add a bonus month
                return monthlyWage * (numberOfMonthsWorked + 1);
            return monthlyWage * numberOfMonthsWorked;
        }

        //Overloading the method CalculateYearlyWage, but different number of parameters
        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
                return monthlyWage * numberOfMonthsWorked + bonus;
        }

        //Different than the first method due to different parameters and different parameters types
        public static double CalculateYearlyWage(double monthlyWage, double numberOfMonthsWorked, double bonus)
        {
            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }
    }
}