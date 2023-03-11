using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    public class SwitchCase
    {
       public static void SwitchCaseWage()
        {
            const double HOURLY_WAGE = 20.0;

            Console.WriteLine("Enter employee name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter hours worked:");
            int hoursWorked = int.Parse(Console.ReadLine());

            double wage = 0.0;
            switch (hoursWorked)
            {
                case 0:
                    wage = 0.0;
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                    wage = hoursWorked * HOURLY_WAGE;
                    break;
                default:
                    wage = 4 * HOURLY_WAGE + (hoursWorked - 4) * HOURLY_WAGE * 1.5;
                    break;
            }

            Console.WriteLine("{0}'s wage is: {1:C}", name, wage);
        }
    }
}
    