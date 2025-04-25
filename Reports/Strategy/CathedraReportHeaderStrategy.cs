using DocumentFormat.OpenXml.Bibliography;
using Gestin.Reports.Interfaces;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestin.Reports.Strategy
{
    public class CathedraReportHeaderStrategy : IHeader
    {
        private readonly string careerName;
        private readonly string subjectName;
        private readonly int year;
        private readonly int totalStudents;
        public CathedraReportHeaderStrategy(string careerName, string subjectName, int year, int totalStudents) 
        {
            this.careerName = careerName;
            this.subjectName = subjectName;
            this.year = year;
            this.totalStudents = totalStudents;
        }
        /// <summary>
        /// Adds cathedra report excel worksheet headers
        /// </summary>
        /// <param name="worksheet"></param>
        public void AddHeader(ExcelWorksheet worksheet)
        {
            worksheet.Cells[1, 1].Value = $"Carrera: {careerName}";
            worksheet.Cells[2, 1].Value = $"Materia: {subjectName}";
            worksheet.Cells[3, 1].Value = $"Año: {year}";
            worksheet.Cells[4, 1].Value = $"Cantidad de Estudiantes: {totalStudents}";
            worksheet.Cells[5, 1].Value = " ";
        }
    }
}
