using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    public class WageTillCondition
    {
          public static void MaxHours()
            {
                const double HOURLY_WAGE = 20.0;
                const int WORKING_DAYS_PER_MONTH = 20;
                const int MAX_HOURS_PER_MONTH = 100;

                Console.WriteLine("Enter employee name:");
                string name = Console.ReadLine();

                int daysWorked = 0;
                int hoursWorked = 0;
                double wage = 0.0;
                while (daysWorked < WORKING_DAYS_PER_MONTH && hoursWorked < MAX_HOURS_PER_MONTH)
                {
                    Console.WriteLine("Enter hours worked on day {0}:", daysWorked + 1);
                    int dailyHours = int.Parse(Console.ReadLine());

                    if (hoursWorked + dailyHours > MAX_HOURS_PER_MONTH)
                    {
                        dailyHours = MAX_HOURS_PER_MONTH - hoursWorked;
                    }

                    hoursWorked += dailyHours;
                    daysWorked++;

                    wage += dailyHours * HOURLY_WAGE;
                }

                Console.WriteLine("{0}'s wage for {1} days and {2} hours is: {3:C}", name, daysWorked, hoursWorked, wage);
            }
        }
    }
