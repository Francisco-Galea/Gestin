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
    public class studentReportController
    {
        public static studentReportController getInstance()
        {
            return new studentReportController();
        }

        public static readonly studentReportController instance = new studentReportController();
        private loginController loginController = loginController.getInstance();


        // Constructor privado
        public studentReportController() { }

        // Propiedad pública para acceder a la instancia
        public static studentReportController Instance
        {
            get { return instance; }
        }

       

        public void ExportActiveStudentsToExcel(string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;

            using (var package = new ExcelPackage())
            {
                // Añadir una nueva hoja de cálculo
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Estudiantes");

                // Definir los encabezados de la hoja de cálculo
                worksheet.Cells[1, 1].Value = "DNI";
                worksheet.Cells[1, 2].Value = "Nombre";
                worksheet.Cells[1, 3].Value = "Apellido";
                worksheet.Cells[1, 4].Value = "Email";
                worksheet.Cells[1, 5].Value = "Carrera";
                worksheet.Cells[1, 6].Value = "Año de Inscripción";

                // Aplicar estilo a los encabezados (color y negrita)
                using (var range = worksheet.Cells[1, 1, 1, 6])
                {
                    range.Style.Font.Bold = true;
                    range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                    range.Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                }

                // Obtener la lista de estudiantes
                var students = GetActiveStudents();
                int row = 2;

                // Llenar los datos de los estudiantes en la hoja de cálculo
                foreach (var student in students)
                {
                    worksheet.Cells[row, 1].Value = student.DNI;
                    worksheet.Cells[row, 2].Value = student.Name;
                    worksheet.Cells[row, 3].Value = student.LastName;
                    worksheet.Cells[row, 4].Value = student.Email;
                    worksheet.Cells[row, 5].Value = student.CareerName;
                    worksheet.Cells[row, 6].Value = student.Year;

                    // Aplicar borde a cada celda
                    for (int col = 1; col <= 6; col++)
                    {
                        worksheet.Cells[row, col].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                    }

                    row++;
                }

                // Ajustar automáticamente el ancho de las columnas
                for (int col = 1; col <= 6; col++)
                {
                    worksheet.Column(col).AutoFit();
                }

                // Guardar el archivo Excel en la ruta especificada
                package.SaveAs(new FileInfo(filePath));
            }
        }

        public List<dynamic> GetActiveStudents()
        {
            try
            {
                using (var db = new Context())
                {
                    var query = from student in db.Students
                                join user in db.Users on student.UserId equals user.Id
                                join login in db.LoginInformations on student.LoginInformationId equals login.Id
                                join enrollment in db.CareerEnrolments on student.Id equals enrollment.StudentId
                                join career in db.Careers on enrollment.CareerId equals career.Id
                                where enrollment.DeletedAt == null
                                orderby enrollment.YearOfRegistration ascending
                                select new
                                {
                                    DNI = user.Dni,
                                    Name = user.Name,
                                    LastName = user.LastName,
                                    Email = login.Email,
                                    CareerName = career.Name,
                                    Year = enrollment.YearOfRegistration
                                };

                    return query.ToList<dynamic>();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener los estudiantes activos", ex);
            }
        }
    }
}


