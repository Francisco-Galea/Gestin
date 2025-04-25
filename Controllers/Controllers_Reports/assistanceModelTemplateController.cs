using Gestin.Model;
using Gestin.Properties;
using Gestin.Reports;
using Gestin.UI.Commons;

namespace Gestin.Controllers.Controllers_Report
{
    internal class assistanceModelTemplateController
    {
        subjectEnrolmentController subjectEnrolmentController = subjectEnrolmentController.getInstance();
        subjectController subjectController = subjectController.getInstance();
        careerController careerController = careerController.getInstance();
        List<SubjectEnrolment> enrolments;
        List<string>? presentialStudentList;
        Dictionary<string, string> pages = new();
        static int fullPageHardCount = 18;
        static int headerHardCount = 16;
        int studentGlobalCounter = 0;
        int pageNumber = 0;
        string destinationRoute;
        string AssistanceModelHtmlTemplate;
        bool allPages = false;
        bool hardLimitReached = false;

        #region Singleton

        private static assistanceModelTemplateController? Instance;

        private assistanceModelTemplateController() { }

        public static assistanceModelTemplateController getInstance()
        {
            if (Instance == null)
            {
                Instance = new assistanceModelTemplateController();
            }
            return Instance;
        }

        public static void destroyInstance()
        {
            if (Instance != null)
            {
                Instance = null;
            }
        }
        #endregion


        #region Assistance Model Template

        private void Initialize(string requestedRoute, dynamic[] parameters)
        {
            destinationRoute = requestedRoute;
            enrolments = subjectEnrolmentController.GetSubjectEnrolments(parameters[2], Convert.ToInt32(parameters[4]));
            presentialStudentList = presentialStudentList = enrolments.Where(x => x.Presential).Select(x => x.Student.getUserFullName()).ToList();
        }

        public void setupAssistanceModelTemplate(string requestedRoute, params dynamic[] parameters) //HEADER 
        {
            //string institute 0, object career 1, object subject 2, string teachersubject 3, string year 4, string yearInCourse 5
            AssistanceModelHtmlTemplate = Resources.AsistenciaStyles;
            AssistanceModelHtmlTemplate += assignHeaderResourceToHtmlDocument(parameters);
            Initialize(requestedRoute, parameters);
            bool newPageAfter = false;

            List<string>? presentialActual = new();

            if (presentialStudentList != null && presentialStudentList.Any())
            {
                if (presentialStudentList.Count > headerHardCount) // Limit due to header
                {
                    presentialActual = presentialStudentList.Take(headerHardCount).ToList();
                    newPageAfter = true;
                }
                else
                {
                    presentialActual = new(presentialStudentList);
                }
                presentialStudentList.RemoveRange(0, presentialActual.Count);
                pageNumber++;
            }
            createAssistancePreModel(presentialActual, newPageAfter, parameters);
        }

        private void newPageAssistanceModelTemplate(bool newPage, dynamic[] parameters)
        {
            //string institute 0, object career 1, object subject 2, string teachersubject 3, string year 4, string yearInCourse 5

            List<string> presentialActual = new();
            AssistanceModelHtmlTemplate = Resources.AsistenciaStyles; // reset
            newPage = false; //Assume no new pages

            if (presentialStudentList != null)
            {
                if (presentialStudentList.Count > fullPageHardCount) // limit fill full page
                {
                    presentialActual = presentialStudentList.Take(fullPageHardCount).ToList();
                    presentialStudentList.RemoveRange(0, fullPageHardCount);
                }
                else if (presentialStudentList.Count > 0)
                {
                    presentialActual = new(presentialStudentList);
                    presentialStudentList.RemoveRange(0, presentialActual.Count);

                }
                newPage = true;
                pageNumber++;
            }

            createAssistancePreModel(presentialActual, newPage, parameters);
        }

        private string setPagePartDestination(bool newPageAfter, dynamic[] parameters)
        {
            string pageRoute = $"Asistencia-{subjectController.getSubjectName(parameters[2]).Replace(" ", "_")}-{parameters[4]}";

            if (newPageAfter || pageNumber > 1)
            {
                pageRoute += $"-{pageNumber}";
            }
            pageRoute += ".pdf";

            return pageRoute;
        }

        private void createAssistancePreModel(List<string>? presentialActual, bool newPageAfter, dynamic[] parameters)
        {
            string pageRoute = setPagePartDestination(newPageAfter, parameters);
            bool allStudentsInModel = noRemainingStudentsInList();
            generateAssistanceModelTemplate(presentialActual, pageRoute, allStudentsInModel);

            if (newPageAfter && !allStudentsInModel)
            {
                newPageAssistanceModelTemplate(newPageAfter, parameters);
            }
        }

        public void generateAssistanceModelTemplate(List<string>? presentialActual, string pageRoute, bool allStudentsInModel)
        {
            AssistanceModelHtmlTemplate += Resources.AsistenciaTemplateBody;
            AssistanceModelHtmlTemplate = setStudentValuesInHtmlTemplate(presentialActual);
            pages.Add(pageRoute, AssistanceModelHtmlTemplate);

            if (allStudentsInModel)
            {
                if (hardLimitReached)
                {
                    string footerPage = Resources.AsistenciaStyles;
                    string route = pages.Keys.Last();
                    route += $"footer";

                    footerPage = assignFooterResourceToHtmlDocument(footerPage);
                    pages.Add(route, footerPage);
                }
                else
                {
                    string lastRoute = pages.Last().Key;
                    string lastPage = pages.Last().Value;

                    lastPage = assignFooterResourceToHtmlDocument(lastPage);
                    pages.Remove(pages.Keys.Last());
                    pages.Add(lastRoute, lastPage);
                }

                if (GenerateReportPDF.GenerateCombinedPDFDocument(pages, destinationRoute))
                {
                    formShowInfo formInfo = new formShowInfo("El modelo de asistencia fue generado exitosamente", Resources.Done);
                    formInfo.ShowDialog();
                }
            }
        }

        private bool noRemainingStudentsInList()
        {
            return presentialStudentList.Count == 0;
        }

        private string setStudentValuesInHtmlTemplate(List<string>? presentialActual)
        {
            //string institute 0, object career 1, object subject 2, string teachersubject 3, string year 4, string yearInCourse 5

            string template = AssistanceModelHtmlTemplate;
            int studentInnerCounter = 0;
            string accumulatedRows = "";
            string AssistanceStudentRow = Resources.AsistenciaStudentRow.ToString();

            if (presentialActual != null && presentialActual.Any())
            {
                foreach (string presentialStudent in presentialActual)
                {
                    ++studentGlobalCounter;

                    ++studentInnerCounter;

                    string studentRow = AssistanceStudentRow.Replace("@studentCount", studentGlobalCounter.ToString()).Replace("@enrolledStudent", presentialStudent);

                    accumulatedRows += studentRow;
                }
                template = template.Replace("@enrolledStudentList", accumulatedRows);

                if (noRemainingStudentsInList()) //If there are no elements to be added in the global list
                {
                    if (pageNumber > 1 && studentInnerCounter == fullPageHardCount)
                    {
                        hardLimitReached = true; //If n amount of students is the same as the set limit for a non header page, then create a new page for footer.
                    }
                }
            }
            return template;
        }

        private string assignHeaderResourceToHtmlDocument(dynamic[] parameters)
        {
            string headerTemplate = Resources.AsistenciaTemplateHeader;

            headerTemplate = headerTemplate.Replace("@institute", $"{parameters[0]}");
            headerTemplate = headerTemplate.Replace("@career", $"{careerController.getCareerName(parameters[1])}");
            headerTemplate = headerTemplate.Replace("@subject", $"{subjectController.getSubjectName(parameters[2])}");
            headerTemplate = headerTemplate.Replace("@teacherSubject", $"{parameters[3]}");
            headerTemplate = headerTemplate.Replace("@yearSubjectEnrolment", $"{parameters[4]}");
            headerTemplate = headerTemplate.Replace("@yearInCourse", $"{parameters[5]}");
            headerTemplate = headerTemplate.Replace("@src", $"{parameters[6]}");

            return headerTemplate;
        }

        private string assignBodyResourceToHtmlDocument()
        {
            string body = Resources.AsistenciaTemplateBody.ToString();
            AssistanceModelHtmlTemplate = AssistanceModelHtmlTemplate.Replace("@body", body);

            return AssistanceModelHtmlTemplate;
        }

        private string assignFooterResourceToHtmlDocument(string document)
        {
            string template = document;
            template += Resources.AsistenciaTemplateFooter.ToString();
            int nameCount = 0;
            string nameCumulative = string.Empty;

            List<string> libreStudentList = enrolments.Where(x => !x.Presential).Select(x => x.Student.getUserFullName()).ToList();

            foreach (string libreStudent in libreStudentList)
            {
                nameCumulative += $"{libreStudent}";
                nameCount++;

                if (nameCount < libreStudentList.Count)
                {
                    nameCumulative += "<strong> | </strong>";
                }
            }
            template = template.Replace("@libreStudentList", nameCumulative);

            return template;
        }


        #endregion

    }
}
