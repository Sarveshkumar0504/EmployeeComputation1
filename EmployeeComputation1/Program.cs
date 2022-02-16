using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComputation1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation 1");
            EmployeeWage employee = new EmployeeWage();
            employee.EmployeeAttendance();
            //employee.DailyWage();
            //employee.PartTimeEmpWage();
            employee.SwitchCase();
            Console.ReadLine();
        }
    }
}
