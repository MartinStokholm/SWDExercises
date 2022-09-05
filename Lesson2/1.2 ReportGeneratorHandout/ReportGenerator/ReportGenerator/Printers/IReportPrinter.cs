using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGeneratorLib.Printers
{
    public interface IReportPrinter
    {
        void PrintReport(List<Employee> employees);
    }
}
