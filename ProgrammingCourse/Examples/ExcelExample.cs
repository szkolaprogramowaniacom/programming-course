using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples
{
    internal class ExcelExample
    {
        public void Run()
        {
            var folder = @"C:\Projekty\SzkolaProgramowania.com\Pliki";

            // excell operations
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("This is a test");
            worksheet.Cell(1, 1).Value = "John";
            worksheet.Column("A").AdjustToContents();

            // save to file
            var filePath = Path.Combine(folder, "Created Excel.xlsx");
            workbook.SaveAs(filePath);
        }
    }
}
