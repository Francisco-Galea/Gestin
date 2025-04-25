using DocumentFormat.OpenXml.Spreadsheet;
using Gestin.Reports.Interfaces;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestin.Reports.Strategy
{
    public class TeacherHeadersStrategy: IHeader
    {
        /// <summary>
        /// Adds teachers excel worksheet headers
        /// </summary>
        /// <param name="worksheet"></param>
        public void AddHeader(ExcelWorksheet worksheet)
        {
            worksheet.Cells[1, 1].Value = "Apellido";
            worksheet.Cells[1, 2].Value = "Nombre";
            worksheet.Cells[1, 3].Value = "CUIL";
            worksheet.Cells[1, 4].Value = "Título";
            worksheet.Cells[1, 5].Value = "Correo Electrónico";
            worksheet.Cells[1, 6].Value = "Firma";
        }
    }
}
