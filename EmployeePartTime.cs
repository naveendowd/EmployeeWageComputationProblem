using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeWageComputationProblem
{
     public class EmployeePartTime
    {
        public static void HoursWorked()
        {
            const int PART_TIME_HOURS = 4;
            const double HOURLY_WAGE = 20.0;

            Console.WriteLine("Enter employee name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter hours worked:");
            int hoursWorked = int.Parse(Console.ReadLine());

            double wage = 0.0;
            if (hoursWorked <= PART_TIME_HOURS)
            {
                wage = hoursWorked * HOURLY_WAGE;
            }
            else
            {
                wage = PART_TIME_HOURS * HOURLY_WAGE + (hoursWorked - PART_TIME_HOURS) * HOURLY_WAGE * 1.5;
            }

            Console.WriteLine("{0}'s wage is: {1:C}", name, wage);
        }
    }
}
