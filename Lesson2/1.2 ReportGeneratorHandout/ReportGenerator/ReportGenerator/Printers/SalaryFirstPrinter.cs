using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGeneratorLib.Printers
{
    public class SalaryFirstPrinter : IReportPrinter
    {
        // Implements the SalaryFirst version of PrintReport
        public void PrintReport(List<Employee> employees)
        {
            Console.WriteLine("Salary-first report");

            foreach (var employee in employees)
            {
                Console.WriteLine("------------------");
                Console.WriteLine($"Salary: {employee.Salary}");
                Console.WriteLine($"Name: {employee.Name}");
                Console.WriteLine($"Age: {employee.Age}");
                Console.WriteLine("------------------");
            }

        }
    }
}
