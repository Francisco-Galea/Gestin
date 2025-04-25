
﻿using OfficeOpenXml;
using Gestin.Model;
using Gestin.Controllers;
using Gestin.Reports.Strategy;
using OfficeOpenXml.Style;

namespace Gestin.Reports
{
    /// <summary>
    /// Generates different reports
    /// </summary>
    public class GenerateReportExcel
    {
        /// <summary>
        /// Exports cathedra reports to excel from cathedra report datagrid
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="filePath"></param>
        /// <param name="careerName"></param>
        /// <param name="subjectName"></param>
        /// <param name="year"></param>
        /// <param name="totalStudents"></param>
        public void ExportDataGridViewToExcel(DataGridView dgv, string filePath, string careerName, string subjectName, int year, int totalStudents)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;

            using (var package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Informe");
                var header = new CathedraReportHeaderStrategy(careerName, subjectName, year, totalStudents);
                header.AddHeader(worksheet);
                FormatColumns(dgv, worksheet);
                AddGridHeaders(dgv, worksheet);
                FillGridData(dgv, worksheet);

                package.SaveAs(new System.IO.FileInfo(filePath));
            }
        }
        /// <summary>
        /// Formats columns of excel worksheet
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="worksheet"></param>
        private void FormatColumns(DataGridView dgv, ExcelWorksheet worksheet)
        {
            for (int col = 1; col <= dgv.Columns.Count; col++)
            {
                worksheet.Column(col).Width = 25;
            }
        }
        /// <summary>
        /// Adds grid headers to excel worksheet
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="worksheet"></param>
        private void AddGridHeaders(DataGridView dgv, ExcelWorksheet worksheet)
        {
            var headerStyle = worksheet.Cells[6, 1, 6, dgv.Columns.Count].Style;
            headerStyle.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
            headerStyle.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);
            headerStyle.Font.Bold = true;
            headerStyle.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;

            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                worksheet.Cells[6, i + 1].Value = dgv.Columns[i].HeaderText;
            }
        }
        /// <summary>
        /// Fills grid data into excel worksheet
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="worksheet"></param>
        private void FillGridData(DataGridView dgv, ExcelWorksheet worksheet)
        {
            for (int row = 0; row < dgv.Rows.Count; row++)
            {
                for (int col = 0; col < dgv.Columns.Count; col++)
                {
                    var cellValue = dgv.Rows[row].Cells[col].Value;
                    if (cellValue != null)
                    {
                        cellValue = cellValue.ToString().ToUpper() == "FALSE" ? "NO" : cellValue.ToString().ToUpper() == "TRUE" ? "SI" : cellValue;
                    }

                    var cell = worksheet.Cells[row + 7, col + 1];
                    cell.Value = cellValue ?? "";
                    cell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                    cell.Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);

                    HandleCellMerge(cell, worksheet, row, col);
                }
            }
        }
        /// <summary>
        /// Handles and merge cells from worksheet
        /// </summary>
        /// <param name="cell"></param>
        /// <param name="worksheet"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        private void HandleCellMerge(ExcelRange cell, ExcelWorksheet worksheet, int row, int col)
        {
            if (cell.Text.Length > 25)
            {
                int colSpan = (int)Math.Ceiling((double)cell.Text.Length / 25);
                worksheet.Cells[row + 7, col + 1, row + 7, col + colSpan].Merge = true;
            }
        }
        /// <summary>
        /// Exports teachers data list to excel file
        /// </summary>
        /// <param name="careerId"></param>
        /// <param name="filePath"></param>
        public void ExportToExcel(int careerId, string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;

            using (var package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Docentes Activos");
                List<Teacher> activeTeachers = GetActiveTeachersByCareerId(careerId);

                var header = new TeacherHeadersStrategy();
                header.AddHeader(worksheet);
                FillTeacherList(worksheet, activeTeachers);

                worksheet.Cells.AutoFitColumns();
                package.SaveAs(new System.IO.FileInfo(filePath));
            }
        }
        /// <summary>
        /// Gets active teachers list, finded by career
        /// </summary>
        /// <param name="careerId"></param>
        /// <returns>
        /// <list type="Teacher">Teachers</list>
        /// </returns>
        private List<Teacher> GetActiveTeachersByCareerId(int careerId)
        {
            teacherController teacherController = teacherController.getInstance();
            return careerId == 0 ? teacherController.GetAllActiveTeachers() : teacherController.GetActiveTeachersByCareer(careerId);
        }
        /// <summary>
        /// Fills teachers data to worksheet
        /// </summary>
        /// <param name="worksheet"></param>
        /// <param name="activeTeachers"></param>
        private void FillTeacherList(ExcelWorksheet worksheet, List<Teacher> activeTeachers)
        {
            int currentRow = 2;
            foreach (var teacher in activeTeachers)
            {
                if (teacher != null)
                {
                    worksheet.Cells[currentRow, 1].Value = teacher.User.LastName;
                    worksheet.Cells[currentRow, 2].Value = teacher.User.Name;
                    worksheet.Cells[currentRow, 3].Value = teacher.Cuil;
                    worksheet.Cells[currentRow, 4].Value = teacher.Titulo;
                    worksheet.Cells[currentRow, 5].Value = teacher.LoginInformation.Email;
                    worksheet.Cells[currentRow, 6].Value = "_______________________"; // Espacio para la firma
                }
                currentRow++;
            }
        }



        /// <summary>
        /// Genera y exporta un archivo Excel con la lista de docentes de una carrera específica
        /// en un año determinado de la carrera.
        /// </summary>
        /// <param name="career">
        /// Objeto <see cref="Career"/> que representa la carrera a consultar.
        /// Incluye el identificador y el nombre de la carrera.
        /// </param>
        /// <param name="filePath">
        /// Ruta completa donde se guardará el archivo Excel generado.
        /// </param>
        /// <param name="yearInCareer">
        /// Año específico dentro de la carrera para filtrar a los docentes (por ejemplo, 1°, 2°, 3° año, etc.).
        /// </param>
        /// <remarks>
        /// Este método utiliza la biblioteca EPPlus para manipular y generar el archivo Excel.
        /// La licencia de EPPlus debe estar configurada antes de usar este método.
        /// </remarks>
        public void ExportToExcelTeachersByYearInCareer(Career career, string filePath, int yearInCareer)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            teacherController teacherController = teacherController.getInstance();

            using (var package = new ExcelPackage())
            {
                // Crear la hoja de Excel
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Docentes por Año de carrera");

                // Obtener la lista de docentes por carrera y año
                List<Teacher> teachersByYear = teacherController.GetTeachersFromCareerByYear(career.Id, yearInCareer);

                // Definir las cabeceras
                worksheet.Cells[1, 1].Value = "Apellido";
                worksheet.Cells[1, 2].Value = "Nombre";
                worksheet.Cells[1, 3].Value = "CUIL";
                worksheet.Cells[1, 4].Value = "Título";
                worksheet.Cells[1, 5].Value = "Carrera";
                worksheet.Cells[1, 6].Value = "Año";

                // Formato de las cabeceras (negrita, centrado, color de fondo)
                using (var range = worksheet.Cells[1, 1, 1, 6])
                {
                    range.Style.Font.Bold = true;
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    range.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                }

                // Llenar los datos de los docentes en las filas siguientes
                int row = 2; // Comienza en la fila 2 después de las cabeceras
                foreach (var teacher in teachersByYear)
                {
                    worksheet.Cells[row, 1].Value = teacher.User.LastName;  // Apellido
                    worksheet.Cells[row, 2].Value = teacher.User.Name; // Nombre
                    worksheet.Cells[row, 3].Value = teacher.Cuil;     // CUIL
                    worksheet.Cells[row, 4].Value = teacher.Titulo;    // Título
                    worksheet.Cells[row, 5].Value = career.Name;      // Carrera
                    worksheet.Cells[row, 6].Value = yearInCareer;     // Año

                    row++;
                }

                // Autoajustar columnas para que todo el contenido se vea bien
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                // Guardar el archivo Excel en la ruta especificada
                FileInfo fileInfo = new FileInfo(filePath);
                package.SaveAs(fileInfo);
            }
        }

        /// <summary>
        /// Genera y exporta un archivo Excel con la lista de docentes activos 
        /// de una carrera específica.
        /// </summary>
        /// <param name="career">
        /// Objeto <see cref="Career"/> que representa la carrera para la cual se desea consultar los docentes.
        /// Incluye información como el identificador y el nombre de la carrera.
        /// </param>
        /// <param name="filePath">
        /// Ruta completa donde se guardará el archivo Excel generado.
        /// </param>
        /// <remarks>
        /// Este método utiliza la biblioteca EPPlus para la creación y manipulación del archivo Excel.
        /// La licencia de EPPlus debe estar configurada como <see cref="LicenseContext.Commercial"/> antes de usar este método.
        /// </remarks>
        public void ExportToExcelTeachersByYearInCareer(Career career, string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            teacherController teacherController = teacherController.getInstance();

            using (var package = new ExcelPackage())
            {
                // Crear la hoja de Excel
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Docentes por carrera");

                // Obtener la lista de docentes por carrera y año
                List<Teacher> teachersByYear = teacherController.GetActiveTeachersByCareer(career.Id);

                // Definir las cabeceras
                worksheet.Cells[1, 1].Value = "Apellido";
                worksheet.Cells[1, 2].Value = "Nombre";
                worksheet.Cells[1, 3].Value = "CUIL";
                worksheet.Cells[1, 4].Value = "Título";
                worksheet.Cells[1, 5].Value = "Carrera";
               
                // Formato de las cabeceras (negrita, centrado, color de fondo)
                using (var range = worksheet.Cells[1, 1, 1, 6])
                {
                    range.Style.Font.Bold = true;
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    range.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                }

                // Llenar los datos de los docentes en las filas siguientes
                int row = 2; // Comienza en la fila 2 después de las cabeceras
                foreach (var teacher in teachersByYear)
                {
                    worksheet.Cells[row, 1].Value = teacher.User.LastName;  // Apellido
                    worksheet.Cells[row, 2].Value = teacher.User.Name; // Nombre
                    worksheet.Cells[row, 3].Value = teacher.Cuil;     // CUIL
                    worksheet.Cells[row, 4].Value = teacher.Titulo;    // Título
                    worksheet.Cells[row, 5].Value = career.Name;      // Carrera
                 

                    row++;
                }

                // Autoajustar columnas para que todo el contenido se vea bien
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                // Guardar el archivo Excel en la ruta especificada
                FileInfo fileInfo = new FileInfo(filePath);
                package.SaveAs(fileInfo);
            }
        }
    }

}
