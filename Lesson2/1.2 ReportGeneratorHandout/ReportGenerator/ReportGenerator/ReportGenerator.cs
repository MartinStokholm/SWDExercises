using System;
using System.Collections.Generic;
using ReportGeneratorLib.Printers;

namespace ReportGeneratorLib
{
    public class ReportGenerator 
    {
        private readonly EmployeeDB _employeeDb;
        
        public ReportGenerator(EmployeeDB employeeDb)
        {
            _employeeDb = employeeDb ?? throw new ArgumentNullException(nameof(employeeDb));
        }
        
        // Responsibility make list of employees (from db) and print them using IPrintReport
        // Format/type of printer is determined by what printer is passed from client that calls.
        public void CompileReport(IReportPrinter reportPrinter)
        {
            var employees = new List<Employee>();

            _employeeDb.Reset();

            // Get all employees
            while (_employeeDb.GetNextEmployee() is { } employee)
            {
                employees.Add(employee);
            }
            reportPrinter.PrintReport(employees);
            
        }

    }
}