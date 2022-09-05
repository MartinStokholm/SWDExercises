using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ReportGeneratorLib.Printers
{
    public class NameFirstPrinter : IReportPrinter
    {
        // Implements the NameFirst version of PrintReport
        public void PrintReport(List<Employee> employees)
        {
            Console.WriteLine("Name-first report");

            foreach (var employee in employees)
            {
                Console.WriteLine("------------------");
                Console.WriteLine($"Name: {employee.Name}");
                Console.WriteLine($"Age: {employee.Age}");
                Console.WriteLine($"Salary: {employee.Salary}");
                Console.WriteLine("------------------");
            }

        }
    }
}
