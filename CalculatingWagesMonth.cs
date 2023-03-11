using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
   public class CalculatingWagesMonth
    {
        public static void HourlyWage()
        {
            const int PART_TIME_HOURS = 8;
            const double HOURLY_WAGE = 10.0;
            const int WORKING_DAYS_PER_MONTH = 20;

            Console.WriteLine("Enter employee name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter total hours worked in a month:");
            int hoursWorked = int.Parse(Console.ReadLine());

            double wage = 0.0;
            if (hoursWorked <= PART_TIME_HOURS * WORKING_DAYS_PER_MONTH)
            {
                wage = hoursWorked * HOURLY_WAGE;
            }
            else
            {
                int extraHours = hoursWorked - PART_TIME_HOURS * WORKING_DAYS_PER_MONTH;
                wage = PART_TIME_HOURS * WORKING_DAYS_PER_MONTH * HOURLY_WAGE + extraHours * HOURLY_WAGE * 1.5;
            }

            Console.WriteLine("{0}'s monthly wage is: {1:C}", name, wage);
        }
    }
}
  
