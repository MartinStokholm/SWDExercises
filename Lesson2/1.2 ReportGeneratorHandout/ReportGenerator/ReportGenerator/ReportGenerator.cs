using System;
using System.Collections.Generic;
using ReportGeneratorLib.Printers;

namespace ReportGeneratorLib
{
    public class ReportGenerator 
    {
        // database class from which report is generated
        private readonly EmployeeDB _employeeDb;
        
        public ReportGenerator(EmployeeDB employeeDb)
        {
            _employeeDb = employeeDb ?? throw new ArgumentNullException(nameof(employeeDb));
        }
        
        // Responsibility make list of employees (from db) and print them using IPrintReport
        // Format/type of printer is determined by what printer is passed from client that calls.
        public void CompileReport(IReportPrinter rp)
        {
            var employees = new List<Employee>();

            _employeeDb.Reset();

            // Get all employees from db and add to list
            while (_employeeDb.GetNextEmployee() is { } employee)
            {
                employees.Add(employee);
            }
            // finally print report
            rp.PrintReport(employees);
            
        }

    }
}