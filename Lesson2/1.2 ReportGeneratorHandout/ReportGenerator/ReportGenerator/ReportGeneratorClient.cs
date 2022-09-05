using System;

namespace ReportGenerator
{
    internal class ReportGeneratorClient
    {
        private static void Main()
        {
            var db = new EmployeeDB();

            // Add some employees
            db.AddEmployee(new Employee("Anne", 3000));
            db.AddEmployee(new Employee("Berit", 2000));
            db.AddEmployee(new Employee("Christel", 1000));

            var reportGenerator = new ReportGenerator(db);

            // Create a default (name-first) report
            reportGenerator.CompileReport();

            Console.WriteLine("");
            Console.WriteLine("");

            // Create a salary-first report
            reportGenerator.SetOutputFormat(ReportOutputFormatType.SalaryFirst);
            reportGenerator.CompileReport();
        }
    }
}