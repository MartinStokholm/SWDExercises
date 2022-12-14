using System;
using ReportGeneratorLib;
using ReportGeneratorLib.Printers;

namespace ReportGeneratorConsoleApp
{
    // Responsibility is determine what type of format is desired for printing the report
    internal class ReportGeneratorClient
    {
        private static void Main()
        {
            // Create instance of database
            var db = new EmployeeDB();

            // Add some employees to db
            db.AddEmployee(new Employee("Anne", 3000, 42));
            db.AddEmployee(new Employee("Berit", 2000, 69));
            db.AddEmployee(new Employee("Christel", 1000,17));

            // Create instance of ReportGenerator using db 
            var reportGenerator = new ReportGenerator(db);
            
            // Create a name-first printer which is passed to CompileReport() 
            IReportPrinter p = new NameFirstPrinter();
            reportGenerator.CompileReport(p);

            Console.WriteLine("");
            Console.WriteLine("");

            // Create a salary-first printer which is passed to CompileReport()
            p = new SalaryFirstPrinter();
            reportGenerator.CompileReport(p);

            Console.WriteLine("");
            Console.WriteLine("");

            // Create a age-first printer which is passed to CompileReport()
            p = new AgeFirstPrinter();
            reportGenerator.CompileReport(p);


        }
    }
}