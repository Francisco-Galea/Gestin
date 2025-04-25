using OfficeOpenXml;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.InkML;
using Gestin.Interfaces;
using Gestin.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Context = Gestin.Model.Context;

namespace Gestin.Controllers.Controllers_Reports
{
    public class ScheduleReportController
    {
        // Singleton para acceder a la instancia del controlador
        public static readonly ScheduleReportController instance = new ScheduleReportController();
        public static ScheduleReportController GetInstance()
        {
            return instance;
        }

        // Constructor privado
        private ScheduleReportController() { }

        // Método para generar el reporte de horarios en un archivo Excel
        public void ExportTeacherSchedulesToExcel(string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;

            using (var package = new ExcelPackage())
            {
                // Crear una nueva hoja de cálculo
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Horarios Docentes");

                // Encabezados de la hoja de cálculo
                worksheet.Cells[1, 1].Value = "Nombre del Docente";
                worksheet.Cells[1, 2].Value = "Día";
                worksheet.Cells[1, 3].Value = "Horario";
                worksheet.Cells[1, 4].Value = "Materia";

                // Estilo para los encabezados
                using (var range = worksheet.Cells[1, 1, 1, 4])
                {
                    range.Style.Font.Bold = true;
                    range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                    range.Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                }

                // Obtener la lista de horarios de docentes
                var schedules = GetTeacherSchedules();

                // Llenar los datos en la hoja de cálculo
                int row = 2;
                foreach (var schedule in schedules)
                {
                    worksheet.Cells[row, 1].Value = schedule.TeacherName;
                    worksheet.Cells[row, 2].Value = schedule.Day;
                    worksheet.Cells[row, 3].Value = schedule.StartingTime.ToString(@"hh\:mm"); 
                    worksheet.Cells[row, 4].Value = schedule.Subject;

                    // Borde alrededor de cada celda
                    for (int col = 1; col <= 4; col++)
                    {
                        worksheet.Cells[row, col].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                    }
                    row++;
                }

                // Ajustar el ancho de las columnas automáticamente
                for (int col = 1; col <= 4; col++)
                {
                    worksheet.Column(col).AutoFit();
                }

                // Guardar el archivo Excel en la ruta especificada
                package.SaveAs(new FileInfo(filePath));
            }
        }
        public List<dynamic> GetTeacherSchedules()
        {
            try
            {
                using (var db = new Context())
                {
                    var query = from teacher in db.Teachers
                                join user in db.Users on teacher.UserId equals user.Id
                                join teacherSubject in db.TeacherSubjects on teacher.Id equals teacherSubject.TeacherId
                                join subject in db.Subjects on teacherSubject.SubjectId equals subject.Id
                                join schedule in db.Schedules on subject.Id equals schedule.SubjectId
                                where teacherSubject.Active == true
                                orderby user.Name, schedule.Day, schedule.StartingTime
                                select new
                                {
                                    TeacherName = user.Name,
                                    Day = schedule.Day,
                                    StartingTime = schedule.StartingTime,
                                    Subject = subject.Name
                                };

                    return query.ToList<dynamic>();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener los horarios de los docentes", ex);
            }
        }
    }
}
