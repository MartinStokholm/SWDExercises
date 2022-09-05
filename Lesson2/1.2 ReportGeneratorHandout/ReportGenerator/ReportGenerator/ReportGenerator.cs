using System;
using System.Collections.Generic;

namespace ReportGenerator
{
    
    internal class ReportGenerator
    {
        private readonly EmployeeDB _employeeDb;
        private ReportOutputFormatType _currentOutputFormat;

        public ReportGenerator(EmployeeDB employeeDb)
        {
            if (employeeDb == null) throw new ArgumentNullException("employeeDb");
            _currentOutputFormat = ReportOutputFormatType.NameFirst;
            _employeeDb = employeeDb;
        }
        
        public void CompileReport()
        {
            var employees = new List<Employee>();
            Employee employee;

            _employeeDb.Reset();

            // Get all employees
            while ((employee = _employeeDb.GetNextEmployee()) != null)
            {
                employees.Add(employee);
            }

            // All employees collected - let's output them
            switch (_currentOutputFormat)
            {
                case ReportOutputFormatType.NameFirst:
                    Console.WriteLine("Name-first report");
                    foreach (var e in employees)
                    {
                        Console.WriteLine("------------------");
                        Console.WriteLine("Name: {0}", e.Name);
                        Console.WriteLine("Salary: {0}", e.Salary);
                        Console.WriteLine("------------------");
                    }
                    break;

                case ReportOutputFormatType.SalaryFirst:
                    Console.WriteLine("Salary-first report");
                    foreach (var e in employees)
                    {
                        Console.WriteLine("------------------");
                        Console.WriteLine("Salary: {0}", e.Salary);
                        Console.WriteLine("Name: {0}", e.Name);
                        Console.WriteLine("------------------");
                    }
                    break;
            }
        }


        public void SetOutputFormat(ReportOutputFormatType format)
        {
            _currentOutputFormat = format;
        }
    }
}