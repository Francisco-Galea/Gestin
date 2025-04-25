using Gestin.Model;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Gestin.Controllers;

namespace Gestin.Reports
{
    /// <summary>
    /// Class <c>GenerateUnofficialTranscript</c> Clase usada para crear actas volantes
    /// </summary>
    internal class GenerateUnofficialTranscript
    {
        examEnrolmentController cntExamEnrol = examEnrolmentController.getInstance();
        subjectEnrolmentController cntSubEnrol = subjectEnrolmentController.getInstance();
        examController cntExam = examController.getInstance();
        UnofficialTranscriptFormat format = new UnofficialTranscriptFormat();
        List<Student> Presentials = new List<Student>();
        List<Student> free = new List<Student>();


        /// <summary>
        /// Method <c>produceName</c> Retorna un string formateado basado en un examen y su tipo de acreditación
        /// </summary>
        private string produceName(string accType,Exam exam)
        {
            string name=accType.ToUpper() + "-" +
                                exam.IdSubjectNavigation.Career.Name + "-" +
                                exam.IdSubjectNavigation.Name + "-" +
                                exam.Date.ToString("dd-MM-yyyy");
            return name.Replace(" ", "");
        }
        /// <summary>
        /// Method <c>produceExamInfo</c> Retorna un string formateado basado en la información de un examen
        /// </summary>
        private string produceExamInfo(Exam exam)
        {
            string result=format.getInfo().Replace("@career", exam.IdSubjectNavigation.Career.Name);
            result = result.Replace("@subject", exam.IdSubjectNavigation.Name);
            result = result.Replace("@titular", exam.TitularNavigation?.User.fullName());
            result = result.Replace("@vowels", exam.FirstVowelNavigation?.User.fullName() +
                                               verifyExamVowel(exam.SecondVowelNavigation) +
                                               exam.SecondVowelNavigation?.User.fullName() +
                                               verifyExamVowel(exam.ThirdVowelNavigation) +
                                               exam.ThirdVowelNavigation?.User.fullName());
            result = result.Replace("@yearInCareer", exam.IdSubjectNavigation.YearInCareer.ToString());
            result = result.Replace("@date", exam.Date.ToString("dd/MM/yyyy"));
            result = result.Replace("@place", exam.Place);
            return result;
        }
        /// <summary>
        /// Method <c>produceStudentRowToAdd</c> Retorna un string formateado basado en la información de un estudiante
        /// </summary>
        private string produceStudentRowToAdd(int nrRow, string accType, Student us)
        {
            string row = string.Empty;
            row += "<tr style='border: 1px solid black;border-collapse: collapse;'>";
            row += "<td style='border: 1px solid black;border-collapse: collapse;'><p style='margin:2px;'>" + nrRow + "</p></td>";
            row += "<td style='border: 1px solid black;border-collapse: collapse;'><p style='margin:2px;'>" + us.User.LastName + ", " + us.User.Name + "</p></td>";
            row += "<td style='border: 1px solid black;border-collapse: collapse;'><p style='margin:2px;'>" + us.User.Dni + "</p></td>";
            row += "<td style='border: 1px solid black;border-collapse: collapse;'><p style='margin-top:20px;'>" + accType + "</p></td>";
            row += "<td style='border: 1px solid black;border-collapse: collapse'></td>";
            row += "<td style='border: 1px solid black;border-collapse: collapse'></td>";
            row += "<td style='border: 1px solid black;border-collapse: collapse'></td>";
            row += "</tr>";
            return row;
        }
       
        /// <summary>
        /// Method <c>verifyExamVowel</c> Retorna un string basado en la verificación del vocal de un examen
        /// </summary>
        string verifyExamVowel(Teacher vowel)
        {
            return !string.IsNullOrEmpty(vowel?.User.fullName()) ? " - " : "";
        }


        /// <summary>
        /// Method <c>getActaVolante</c> Retorna un byte[] y crea las actas volantes para alumnos preciales y libres de un examen
        /// </summary>
        public byte[] getActaVolantePresential(int examId)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Presentials.Clear();
                free.Clear();
                Exam exam = cntExam.findExam(examId);

                foreach (Student us in cntExamEnrol.getEnroledStudent(exam.Id))
                {
                    if (cntSubEnrol.getAccreditationType(us.User.Dni, exam.IdSubject) == "Presencial")
                    {
                        Presentials.Add(us);
                    }
                }

                if (Presentials.Count > 0)
                    generate(exam, Presentials, "Presencial", ms);

                return ms.ToArray(); // Devolver el contenido del MemoryStream como un byte[]
            }
        }
        public byte[] getActaVolanteFree(int examId)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Presentials.Clear();
                free.Clear();
                Exam exam = cntExam.findExam(examId);

                foreach (Student us in cntExamEnrol.getEnroledStudent(exam.Id))
                {
                    if (cntSubEnrol.getAccreditationType(us.User.Dni, exam.IdSubject) != "Presencial")
                    {
                        free.Add(us);
                    }
                }

                if (free.Count > 0)
                    generate(exam, free, "Libre", ms);

                return ms.ToArray(); // Devolver el contenido del MemoryStream como un byte[]
            }
        }

        /// <summary>
        /// Method <c>generate</c> Crea un acta volante de un examen en un archivo PDF
        /// </summary>
        void generate(Exam _exam, List<Student> stds, string accType, MemoryStream ms)
        {
            string name = produceName(accType, _exam);

            string header_ = format.getHeader().Replace("@ExamId", _exam.Id.ToString());
            string info_ = produceExamInfo(_exam);

            string filas = string.Empty;
            int nrRow = 1;
            foreach (Student us in stds)
            {
                filas += produceStudentRowToAdd(nrRow, accType, us);
                nrRow++;
            }

            using (Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25))
            {
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, ms);
                pdfDoc.Open();
                pdfDoc.Add(new Phrase(""));

                using (StringReader sr = new StringReader(header_ + format.getTitle() + info_ + format.getTable() + filas + format.getSign() + format.getData()))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                }

                pdfDoc.Close();
            }
        }

    }
}
