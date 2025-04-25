
using System.Collections.Generic;
using System.IO; // Para MemoryStream
using ClosedXML.Excel;
using Gestin.Controllers;


namespace Gestin.Model.Service
{
    internal class TeacherService
    {
        loginController loginController = loginController.getInstance();
        careerController careerController = careerController.getInstance();
        sessionController sessionController = sessionController.getInstance();

        public TeacherService() { }

        public byte[] GenerateTeacherExcel(List<Teacher> teachers)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Docentes");

                // Encabezados
                worksheet.Cell(1, 1).Value = "Apellido";
                worksheet.Cell(1, 2).Value = "Nombre";
                worksheet.Cell(1, 3).Value = "CUIL";
                worksheet.Cell(1, 4).Value = "Título";
                worksheet.Cell(1, 5).Value = "Carrera";
                worksheet.Cell(1, 6).Value = "Año";

                // Contenido
                for (int i = 0; i < teachers.Count; i++)
                {
                    worksheet.Cell(i + 2, 1).Value = teachers[i].User.LastName;
                    worksheet.Cell(i + 2, 2).Value = teachers[i].User.Name;
                    worksheet.Cell(i + 2, 3).Value = teachers[i].Cuil;
                    worksheet.Cell(i + 2, 4).Value = teachers[i].Titulo;
                    //worksheet.Cell(i + 2, 4).Value = teachers[i].;
                }

                // Ajuste de columnas
                worksheet.Columns().AdjustToContents();

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    return stream.ToArray();
                }
            }
        }
    }
}







