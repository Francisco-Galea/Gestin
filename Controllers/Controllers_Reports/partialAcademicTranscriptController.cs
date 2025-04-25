using Gestin.LocalFiles;
using Gestin.Model;
using Gestin.Properties;
using Gestin.Reports;
using HtmlAgilityPack;
using System.Globalization;
using System.Reflection;

namespace Gestin.Controllers
{
    internal class PartialAcademicTranscriptController //Analítico parcial
    {
        ImageSelectionController cntSetting = ImageSelectionController.getInstance();
        subjectEnrolmentController cntSubjetEnrol = subjectEnrolmentController.getInstance();
        subjectController cntSubject = subjectController.getInstance();
        careerController cntCareer = careerController.getInstance();
        gradeController cntGrades = gradeController.getInstance();
        string templateHtmlAnalytical = Resources.analiticoParcial2.ToString();
        CultureInfo culture = LocalGestinSettings.LocalLanguage;

        #region Singleton

        private static PartialAcademicTranscriptController? Instance;
        private PartialAcademicTranscriptController() { }

        public static PartialAcademicTranscriptController getInstance()
        {
            if (Instance == null)
            {
                Instance = new PartialAcademicTranscriptController();
            }
            return Instance;
        }
        #endregion

        #region Partial Analytic

        public void generateAnalyticPartial(string rutaDestino, string numInst, string nameStudent, string resolution, string cantOfApprovedSubjects, string dni, Object speciality, string city, string percentageOfSubjects, string course)
        {
            // Ruta al archivo 
            string resourceName = "Gestin.Resources.analiticoParcial2.html";
            // Acceder al recurso desde el ensamblado
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                if (stream != null)
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string htmlContent = reader.ReadToEnd();

                        HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                        doc.LoadHtml(htmlContent);

                        for (var i = 0; i < 3; i++)
                        {
                            fillTablesHTMLByYearInCareer(i + 1, doc, (CareerEnrolment)speciality, Convert.ToInt32(dni));
                            string modifiedHtml = doc.DocumentNode.OuterHtml;
                            templateHtmlAnalytical = modifiedHtml;
                        }
                        setFormValuesInHtmlTemplate(numInst, nameStudent, resolution, cantOfApprovedSubjects, dni, ((CareerEnrolment)speciality).Career.Name, city, percentageOfSubjects, course);
                    }
                }
                GenerateReportPDF.ConvertHtmlPdfItextSharp(templateHtmlAnalytical, rutaDestino,20,20,20,10);
            }
        }


        public void setFormValuesInHtmlTemplate(string numInst, string nameStudent, string resolution, string cantOfApprovedSubjects, string dni, string speciality, string city, string percentageOfSubjects, string course)
        {
            templateHtmlAnalytical = templateHtmlAnalytical.Replace("@NROINSTI", numInst);
            templateHtmlAnalytical = templateHtmlAnalytical.Replace("@NOMBRE", nameStudent);
            templateHtmlAnalytical = templateHtmlAnalytical.Replace("@RESOLUCION", resolution);
            templateHtmlAnalytical = templateHtmlAnalytical.Replace("@MATERIASAPROBADAS", cantOfApprovedSubjects);
            templateHtmlAnalytical = templateHtmlAnalytical.Replace("@DNI", dni);
            templateHtmlAnalytical = templateHtmlAnalytical.Replace("@ESPECIALIDAD", speciality);
            templateHtmlAnalytical = templateHtmlAnalytical.Replace("@CIUDAD", city);
            templateHtmlAnalytical = templateHtmlAnalytical.Replace("@PORCENTAJE", percentageOfSubjects);
            templateHtmlAnalytical = templateHtmlAnalytical.Replace("@CURSO",course);

            templateHtmlAnalytical = templateHtmlAnalytical.Replace("@DIAS", DateTime.Now.Day.ToString(culture)) ;
            templateHtmlAnalytical = templateHtmlAnalytical.Replace("@MES", DateTime.Now.ToString("MMMM", culture).ToUpper());
            templateHtmlAnalytical = templateHtmlAnalytical.Replace("@ANIO", DateTime.Now.Year.ToString(culture));
            if (cntSetting.ReadSelectedImagePathFromConfig() != null)
            {
                templateHtmlAnalytical = templateHtmlAnalytical.Replace("@RUTA", "file:///" + cntSetting.ReadSelectedImagePathFromConfig());
            }
            templateHtmlAnalytical = templateHtmlAnalytical.Replace("@META", "</meta>");
            templateHtmlAnalytical = templateHtmlAnalytical.Replace("@IMG", "</img>");
            templateHtmlAnalytical = templateHtmlAnalytical.Replace("@BR", "</br>");

        }

        private void fillTablesHTMLByYearInCareer(int anioCarrera, HtmlAgilityPack.HtmlDocument doc, CareerEnrolment careerEnrolment, int dni)
        {
            HtmlNode table = doc.DocumentNode.SelectSingleNode($"//table[@class='tblDatos{anioCarrera}']");
            HtmlNode fila = table.SelectSingleNode($".//tr[@class='fila{anioCarrera}']");


            var listSubjects = cntSubject.getSubjectsFromCareerAndYearInCarrer(careerEnrolment.CareerId, anioCarrera);
            var listGrade = cntGrades.getStudentGradesForCareerAndYear(dni, careerEnrolment.CareerId, anioCarrera);

            if (fila != null)
            {
                foreach (var subject in listSubjects)
                {
                    HtmlNode nuevaFila = fila.Clone();
                    var celdas = fila.SelectNodes(".//td");
                    var subjetEnrol = cntSubjetEnrol.getEnrolment(dni, subject, careerEnrolment);

                    if (subjetEnrol != null && subjetEnrol.Approved)
                    {
                        var grade = listGrade.Find(x => x.Grade1 >= 4 && x.SubjectId == subject.Id);
                        if (grade != null)
                        {
                            if (celdas != null && celdas.Count >= 4)
                            {
                                // Asigna los valores a las celdas en la nueva fila
                                celdas[0].InnerHtml = grade.Subject.Name;
                                celdas[1].InnerHtml = grade.Grade1.ToString();
                                celdas[2].InnerHtml = grade.AccreditationDate.Value.ToShortDateString();
                                celdas[3].InnerHtml = grade.BookRecord;
                            }
                        }
                        else
                        {
                            JoinTableCellsInHTMLTemplate(table, fila, subject, $"CURSADA APROBADA EN {subjetEnrol.Year} ADEUDA FINAL");
                        }
                    }
                    else
                    {
                        JoinTableCellsInHTMLTemplate(table, fila, subject, "ADEUDA CURSADA Y FINAL");
                    }

                    // Inserta la nueva fila debajo de la fila anterior
                    table.InsertAfter(nuevaFila, fila);

                    // Actualiza la fila anterior para que sea la recién agregada
                    fila = nuevaFila;
                }
            }
        }


        private void JoinTableCellsInHTMLTemplate(HtmlNode table, HtmlNode fila, Subject subject, string mensaje)
        {
            if (table != null)
            {
                var sub = subject.Grades;
                var celdas = fila.SelectNodes(".//td");

                if (celdas != null && celdas.Count >= 4)
                {
                    // Crear un nuevo nodo <td> que ocupará el lugar de las tres celdas
                    HtmlNode mergedCell = HtmlNode.CreateNode("<td></td>");
                    // Obtener el contenido de las tres celdas y unirlo
                    celdas[0].InnerHtml = subject.Name;
                    // Establecer el contenido unido en la celda fusionada
                    mergedCell.InnerHtml = $"{mensaje}";

                    // Establecer el atributo colspan en 3 para que ocupe el espacio de las tres celdas originales
                    mergedCell.Attributes.Add("colspan", "3");

                    // Reemplazar la segunda celda con la celda fusionada
                    celdas[1].ParentNode.ReplaceChild(mergedCell, celdas[1]);

                    mergedCell.Attributes.Add("style", "border: 1px solid black;");

                    // Eliminar las celdas de la tercera y cuarta columna
                    celdas[2].Remove();
                    celdas[3].Remove();
                }
            }
        }

        #endregion

    }
}
