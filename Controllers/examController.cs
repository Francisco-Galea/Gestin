using Gestin.LocalFiles;
using Gestin.Model;
using Gestin.Model.Dao;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace Gestin.Controllers
{
    internal class examController
    {
        private readonly ExamDAO examDAO;
        careerController cntCareer = careerController.getInstance();
        examEnrolmentController cntExamEnrolment = examEnrolmentController.getInstance();
        teacherController teacherController = teacherController.getInstance();
        sessionController sessionController = sessionController.getInstance();

        #region Singleton

        private static examController? Instance;
        
        private examController() {
            examDAO = new ExamDAO();
        }
        
        public static examController getInstance()
        {
            if (Instance == null)
            {
                Instance = new examController();
            }
            return Instance;
        }

        #endregion


        #region Loaders

        /// <summary>
        /// Loads all exams from the database.
        /// </summary>
        /// <returns>A list of <see cref="Exam"/> objects scheduled on or after today's date.</returns>
        /// <remarks>
        /// This method retrieves the list of exams from the data access object (DAO) by calling <c>getListExams</c>.
        /// </remarks>
        public List<Exam> loadExams()
        {
            return examDAO.getListExams();
        }

        /// <summary>
        /// Loads exams scheduled on a specific date.
        /// </summary>
        /// <param name="_date">The date for which exams are retrieved.</param>
        /// <returns>A list of <see cref="Exam"/> objects scheduled on the specified date.</returns>
        /// <remarks>
        /// This method calls the data access object (DAO) to retrieve exams scheduled on the specified date by invoking <c>getListExamsByDate</c>.
        /// </remarks>
        public List<Exam> loadExamsByDate(DateTime _date)
        {
            return examDAO.getListExamsByDate(_date);
        }

        #endregion


        #region Exams

        /// <summary>
        /// Devuelve la controladora de exámenes de Gestín
        /// </summary>

        #region Insert Methods

        /// <summary>
        /// Creates a new exam entry in the database.
        /// </summary>
        /// <param name="subject">The subject for which the exam is being created. Must be of type <see cref="Subject"/>.</param>
        /// <param name="titular">The main teacher for the exam. Can be null. Must be of type <see cref="Teacher"/> if provided.</param>
        /// <param name="firstVowel">The first vowel teacher for the exam. Can be null. Must be of type <see cref="Teacher"/> if provided.</param>
        /// <param name="secondVowel">The second vowel teacher for the exam. Can be null. Must be of type <see cref="Teacher"/> if provided.</param>
        /// <param name="thirdVowel">The third vowel teacher for the exam. Can be null. Must be of type <see cref="Teacher"/> if provided.</param>
        /// <param name="dateTime">The date and time when the exam will take place.</param>
        /// <param name="place">The location where the exam will be held.</param>
        /// <returns>
        /// Returns true if the exam was successfully created and saved to the database; otherwise, false.
        /// </returns>
        /// <remarks>
        /// This method performs the following steps:
        /// 1. Casts the input parameters to their respective types.
        /// 2. Creates a new <see cref="Exam"/> object with the provided information.
        /// 3. Assigns the exam period based on the date.
        /// 4. Sets the creation time and the user who last modified the exam.
        /// 5. Attempts to save the exam to the database using the <see cref="ExamDAO"/>.
        /// 6. Updates the exam call number.
        /// 7. Returns true if the process completes without exceptions.
        /// </remarks>
        /// <exception cref="SqlException">
        /// Thrown when a SQL error occurs during the database operation. This exception is re-thrown to be handled by the caller.
        /// </exception>
        /// <seealso cref="Exam"/>
        /// <seealso cref="ExamDAO"/>
        /// <seealso cref="SessionController"/>
        public bool createExam(object subject, object? titular, object? firstVowel, object? secondVowel, object? thirdVowel, DateTime dateTime, string place)
        {
            try
            {

                Subject thisSubject = (Subject)subject;
                Teacher? thisTitular = titular as Teacher;
                Teacher? thisFirstVowel = firstVowel as Teacher;
                Teacher? thisSecondVowel = secondVowel as Teacher;
                Teacher? thisThirdVowel = thirdVowel as Teacher;
                bool change = false;
                var exam = new Exam
                {
                    IdSubject = thisSubject.Id,
                    Date = dateTime,
                    Period = assignExamPeriod(dateTime),
                    Titular = thisTitular?.Id,
                    FirstVowel = thisFirstVowel?.Id,
                    SecondVowel = thisSecondVowel?.Id,
                    ThirdVowel = thisThirdVowel?.Id,
                    Place = place,
                    CreatedAt = DateTime.Now,
                    LastModificationBy = sessionController.getSessionedUserData()
                };
                examDAO.createdExam(exam);
                change = true;
                updateExamCallNumber(exam);
                return change;
            }
            catch (SqlException) { throw; }
        }
        #endregion

        /// <summary>
        /// Updates the details of an existing exam in the database.
        /// </summary>
        /// <param name="examCode">The unique code of the exam to update.</param>
        /// <param name="subject">The <see cref="Subject"/> associated with the exam.</param>
        /// <param name="titular">The primary <see cref="Teacher"/> for the exam, or null if not specified.</param>
        /// <param name="firstVowel">The first vowel <see cref="Teacher"/> for the exam, or null if not specified.</param>
        /// <param name="secondVowel">The second vowel <see cref="Teacher"/> for the exam, or null if not specified.</param>
        /// <param name="thirdVowel">The third vowel <see cref="Teacher"/> for the exam, or null if not specified.</param>
        /// <param name="dateTime">The scheduled date and time for the exam.</param>
        /// <param name="place">The location where the exam will take place.</param>
        /// <returns>
        /// True if the exam was successfully updated in the database; otherwise, false.
        /// </returns>
        /// <remarks>
        /// This method updates the exam’s details by setting properties like subject, date, period, assigned teachers, and location.
        /// It then saves changes to the database and logs the modification time and user. 
        /// Calls <c>findExam</c> to retrieve the existing exam by its code, and <c>assignExamPeriod</c> to set the appropriate exam period.
        /// Finally, <c>updateExamCallNumber</c> is invoked to refresh any related call numbers.
        /// </remarks>
        public bool updateExam(int examCode, object subject, object? titular, object? firstVowel, object? secondVowel, object? thirdVowel, DateTime dateTime, string place)
        {
            try
            {
            bool change = false;
            Subject thisSubject = (Subject)subject;
            Teacher? thisTitular = titular as Teacher;
            Teacher? thisFirstVowel = firstVowel as Teacher;
            Teacher? thisSecondVowel = secondVowel as Teacher;
            Teacher? thisThirdVowel = thirdVowel as Teacher;
            
                var exam = findExam(examCode);
                exam.IdSubjectNavigation = thisSubject;
                exam.Date = dateTime;
                exam.Period = assignExamPeriod(exam.Date);
                exam.TitularNavigation = thisTitular;
                exam.FirstVowelNavigation = thisFirstVowel;
                exam.SecondVowelNavigation = thisSecondVowel;
                exam.ThirdVowelNavigation = thisThirdVowel;
                exam.Place = place;
                exam.UpdatedAt = DateTime.Now;
                exam.LastModificationBy = sessionController.getSessionedUserData();
                change = examDAO.updatedExam(exam);
                updateExamCallNumber(exam);
                return change;
            }catch (SqlException) { throw; }
        }

        /// <summary>
        /// Deletes an exam by its unique identifier and updates the call number of the deleted exam.
        /// </summary>
        /// <param name="ExamCode">The unique identifier of the exam to delete.</param>
        /// <returns>Returns `true` if the exam was deleted and the call number was updated; otherwise, `false`.</returns>
        /// <exception cref="SqlException">Thrown if a database interaction error occurs.</exception>
        /// <remarks>
        /// This method attempts to find the exam using `findExam`. If deletion succeeds via `deleteExamByCode`,
        /// it calls `updateExamCallNumber` to update the associated call number.
        /// </remarks>
        public bool deleteExam(int ExamCode)
        {
            bool status = false;
            try
            {  
                Exam? exam = findExam(ExamCode);
                status = examDAO.deleteExamByCode(ExamCode);
                if (status)
                {
                    updateExamCallNumber(exam);
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
            return status;
        }

        /// <summary>
        /// Checks if an exam exists for the specified subject and date/time.
        /// </summary>
        /// <param name="subject">The <see cref="Subject"/> associated with the exam.</param>
        /// <param name="dateTime">The date and time to check for an existing exam.</param>
        /// <returns>
        /// True if an exam with the same subject and date/time exists; otherwise, false.
        /// </returns>
        /// <remarks>
        /// This method uses the data access object (DAO) to check if an exam with the specified subject and date/time already exists
        /// by invoking <c>existSameExamByDateTime</c>.
        /// </remarks>
        internal bool examExistsSameDateTime(object subject, DateTime dateTime)
        {
            return examDAO.existSameExamByDateTime(subject, dateTime);
        }

        /// <summary>
        /// Checks if an exam exists for the specified subject and date/time, excluding a specified exam by its code.
        /// </summary>
        /// <param name="examCode">The unique code of the exam to exclude from the check.</param>
        /// <param name="subject">The <see cref="Subject"/> associated with the exam.</param>
        /// <param name="dateTime">The date and time to check for an existing exam.</param>
        /// <returns>
        /// True if an exam with the same subject and date/time exists (excluding the specified exam); otherwise, false.
        /// </returns>
        /// <remarks>
        /// This method uses the data access object (DAO) to determine if an exam with the specified subject and date/time exists,
        /// excluding the exam identified by <paramref name="examCode"/>. It calls <c>existSameExamByIdDateTime</c> for this purpose.
        /// </remarks>
        internal bool examExistsSameDateTimeExceptSame(int examCode, object subject, DateTime dateTime)
        {
            return examDAO.existSameExamByIdDateTime(examCode, subject, dateTime);
        }

        private string assignExamPeriod(DateTime date)
        {
            if(1 <= date.Month && date.Month <= 3)
            {
                return "Marzo";
            }
            else if(4 <= date.Month && date.Month <= 5)
            {
                return "Mayo";
            }
            else if (6 <= date.Month && date.Month <= 8)
            {
                return "Agosto";
            }
            else if (9 <= date.Month && date.Month <= 10)
            {
                return "Octubre";
            }
            else
            {
                return "Diciembre";
            }
        }

        public string getExamSubjectName(object thisExam)
        {
            Exam exam = (Exam)thisExam;
            return exam.IdSubjectNavigation.Name;
        }

        public void updateExamCallNumber(Exam thisExam)
        {
            List<Exam> exams = getExamsByYearPeriod(thisExam);
            updateAffectedExamsCallNumber(exams);
        }

        /// <summary>
        /// Retrieves a list of exams for the same subject, year, and period as the specified exam.
        /// </summary>
        /// <param name="thisExam">The <see cref="Exam"/> object used to match the subject, year, and period criteria.</param>
        /// <returns>A list of <see cref="Exam"/> objects that match the subject, year, and period of the specified exam.</returns>
        /// <remarks>
        /// This method calls the data access object (DAO) to retrieve exams that belong to the same subject,
        /// year, and period as <paramref name="thisExam"/> by invoking <c>getListExamsByYearPeriod</c>.
        /// </remarks>
        private List<Exam> getExamsByYearPeriod(Exam thisExam)
        {
            return examDAO.getListExamsByYearPeriod(thisExam);
        }

        /// <summary>
        /// Retrieves a list of exams scheduled for the current year.
        /// </summary>
        /// <returns>A list of <see cref="Exam"/> objects scheduled within the current year.</returns>
        /// <remarks>
        /// This method calls the data access object (DAO) to retrieve exams occurring within the current calendar year
        /// by invoking <c>getListExamsOfThisYear</c>.
        /// </remarks>
        private List<Exam> getExamsOfThisYear()
        {
            return examDAO.getListExamsOfThisYear();
        }

        private bool updatePeriodsForExistingExams(List<Exam> exams)
        {
            var examsWithoutPeriods = exams.Where(x => string.IsNullOrEmpty(x.Period)).ToList();
            bool status = false;
            foreach (Exam exam in examsWithoutPeriods)
                {
                    exam.Period = assignExamPeriod(exam.Date);
                    status = examDAO.updatedExam(exam);
                }
                return status;
        }

        private bool updateAffectedExamsCallNumber(List<Exam> exams)
        {
            for (int i = 0; i < exams.Count; i++)
            {
                exams[i].assignExamCallNumberInDomain(i);
            }

            using (var db = new Context())
            {
                foreach (var exam in exams)
                {
                    db.Exams.Update(exam);
                }
                return db.SaveChanges() > 0;
            }
        }

        private bool updateAllExamsCallNumber(List<Exam> exams)
        {
            List<Exam> distinctSubjectExam = exams.DistinctBy(x => x.IdSubject).ToList();
            List<Exam> getExamsBySubject = new();
            List<Exam> examUpdates = new();

            foreach (Exam exam in distinctSubjectExam)
            {
                foreach (int yearExam in getExistingExamsYears(exam))
                {
                    foreach (string examPeriod in getExistingExamsPeriod(exam, yearExam))
                    {
                        getExamsBySubject = this.getExamsBySpecifiedPeriodOrdered(exam, yearExam, examPeriod);

                        for (int i = 0; i < getExamsBySubject.Count; i++)
                        {
                            getExamsBySubject[i].assignExamCallNumberInDomain(i);
                            examUpdates.Add(getExamsBySubject[i]);
                        }
                    }
                }
            }

            using (var db = new Context())
            {
                db.Exams.UpdateRange(examUpdates);
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        /// <summary>
        /// Retrieves a list of years for which exams exist associated with a specific subject.
        /// </summary>
        /// <param name="exam">The <see cref="Exam"/> object used to filter exams by subject.</param>
        /// <returns>A list of years in which exams exist for the specified subject.</returns>
        /// <remarks>
        /// This method calls the <see cref="examDAO"/> to retrieve the years of existing exams related to the specified subject.
        /// </remarks>
        private List<int> getExistingExamsYears(Exam exam)
        {
            return examDAO.getYearsOfExistingExams(exam);
        }

        /// <summary>
        /// Retrieves a list of distinct periods for existing exams associated with a specific subject and year.
        /// </summary>
        /// <param name="exam">The <see cref="Exam"/> object used to filter exams by subject.</param>
        /// <param name="yearExam">The year for which to retrieve the periods of exams.</param>
        /// <returns>A list of distinct periods in which exams exist for the specified subject and year.</returns>
        /// <remarks>
        /// This method retrieves the periods of existing exams related to the specified subject and year using the <see cref="examDAO"/>.
        /// </remarks>
        private List<string> getExistingExamsPeriod(Exam exam, int yearExam)
        {
            return examDAO.getPeriodOfExistingExams(exam, yearExam);
        }

        /// <summary>
        /// Retrieves a list of exams for a specific subject, year, and period, ordered by date.
        /// </summary>
        /// <param name="exam">The <see cref="Exam"/> object used to filter exams by subject.</param>
        /// <param name="yearExam">The year for which to retrieve exams.</param>
        /// <param name="period">The period for which to retrieve exams.</param>
        /// <returns>A list of exams matching the specified criteria, ordered by date.</returns>
        /// <remarks>
        /// This method retrieves exams associated with the specified subject, year, and period, 
        /// calling the <see cref="examDAO"/> to obtain the results.
        /// </remarks>
        private List<Exam> getExamsBySpecifiedPeriodOrdered(Exam exam, int yearExam, string period)
        {
            return examDAO.getExamsListBySpecifiedPeriod(exam, yearExam, period);
        }

        public bool updateExamsPeriods(List<Exam> exams)
        {
            if (exams.Any(x => string.IsNullOrEmpty(x.Period)))
            {
                if (updatePeriodsForExistingExams(exams))
                {
                    return true;
                }
            }
            return false;
        }

        public bool updateExamsCalls(List<Exam> exams)
        {
            if (exams.Any(x => string.IsNullOrEmpty(x.Call)))
            {
                if (updateAllExamsCallNumber(exams))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Finds an exam by its unique code.
        /// </summary>
        /// <param name="code">The unique code of the exam to be retrieved.</param>
        /// <returns>
        /// An <see cref="Exam"/> object if an exam with the specified code exists; otherwise, null.
        /// </returns>
        /// <remarks>
        /// This method calls the data access object (DAO) to find and retrieve an exam based on the provided code
        /// by invoking <c>findExamByCode</c>.
        /// </remarks>
        public Exam? findExam(int code)
        {
            return examDAO.findExamByCode(code);
        }

        /// <summary>
        /// Retrieves an exam based on the provided <see cref="Exam"/> object.
        /// </summary>
        /// <param name="exam">The <see cref="Exam"/> object containing the exam details to be retrieved.</param>
        /// <returns>The <see cref="Exam"/> object if found; otherwise, null.</returns>
        /// <remarks>
        /// This method calls the <see cref="examDAO"/> to fetch the exam details based on the specified <see cref="Exam"/> object.
        /// </remarks>
        public Exam? findExam(object exam)
        {
            return examDAO.getExam(exam);
        }

        /// <summary>
        /// Retrieves an exam based on the specified subject name.
        /// </summary>
        /// <param name="subjectName">The name of the subject associated with the exam to be retrieved.</param>
        /// <returns>The <see cref="Exam"/> object if found; otherwise, null.</returns>
        /// <remarks>
        /// This method calls the <see cref="examDAO"/> to fetch the exam details based on the provided subject name.
        /// </remarks>
        public Exam? findExam(string subjectName)
        {
            return examDAO.getExamBySubjectName(subjectName);
        }

        /// <summary>
        /// Retrieves the exam details, including the associated teachers, based on the exam code.
        /// </summary>
        /// <param name="code">The unique code of the exam to retrieve.</param>
        /// <returns>The <see cref="Exam"/> object if found; otherwise, null.</returns>
        /// <remarks>
        /// This method calls the <see cref="examDAO"/> to obtain the exam details along with the associated teachers using the specified exam code.
        /// </remarks>
        public Exam? getExamTeachers(int code)
        {
            return examDAO.getExamTecherByCode(code);
        }
        
        public bool generateAllExamsFromCareer(object career, DateTime datetime)
        {
            try
            {
                Career car = (Career)career;
                List<Subject> subjects = cntCareer.loadSubjectsFromCareer(car.Id);
                foreach (Subject s in subjects)
                {
                    createExam(s, null, null, null, null, datetime, "");
                }
                return true;
            }
            catch
            {
                return false;
            }

        }
        public (List<Exam>?, string) loadEnableEnrolmentExams(int studentDni)
        {
            using (var db = new Context())
            {
                try
                {
                    var currentDate = DateTime.Today;

                    //Trae unicamente las materias que tenga cursada aprobada
                    List<SubjectEnrolment> enrollment = db.SubjectEnrolments.Where(x => (x.Student.User.Dni == studentDni && (x.Approved == true || x.Presential == false))).ToList();

                    //Trae las materia en las que ya aprobo el examen
                    List<Grade> approvedExams = db.Grades.Where(x => x.Student.User.Dni == studentDni && x.Grade1 > 3).ToList();

                    // trae las materia en las que ya se inscribio al examen y la fecha es mayor a la actual
                    List<ExamEnrolment> alreadyEnroledExams = db.ExamEnrolments.Where(x => (x.Student.User.Dni == studentDni && x.Exam.Date > currentDate && x.DeletedAt == null)).ToList();

                    if (enrollment != null)
                    {
                        /*
                        var result = db.Exams.Where(
                            x => (x.Date >= DateTime.Today
                            && enrolment.Contains(x.IdSubject)
                            && !aprovedExams.Contains(x.IdSubject)
                            && !alreadyEnroledExams.Contains(x.IdSubject)))
                            .Include(x => x.IdSubjectNavigation)
                            .Include(x => x.IdSubjectNavigation.Career)
                            .ToList();
                        */
                        
                        var result = db.Exams.Where(x => x.Date >= currentDate)
                            .Include(x => x.IdSubjectNavigation)
                            .Include(x => x.IdSubjectNavigation.Career)
                            .ToList();

                        result.RemoveAll(x => !enrollment.Any(e => e.SubjectId == x.IdSubject));
                        //removes active exams whose titular hasen't enrolled

                        result.RemoveAll(x => approvedExams.Any(e => e.SubjectId == x.IdSubject));
                        //removes active exams whose titular has passed with a adequate grade

                        result.RemoveAll(x => alreadyEnroledExams.Any(e => e.Exam.IdSubject == x.IdSubject));
                        //removes active exams whose titular has already enrolled in said exams


                        return (result, null);
                    }
                    return (null, "El estudiante no esta en condiciones en ninguna cursada");
                }
                catch (SqlException exception)
                {
                    return (null, exception.Message);
                }
            }

        }
        public List<Exam> getAllExams()
        {
            return examDAO.getExamsList();
        }


        public void updateAllExamsTitular()
        {
            using (var db = new Context())
            {
                var list = getAllExams();
                foreach (Exam e in list)
                {
                    e.Titular = teacherController.getMostResentActiveTeacher(e.IdSubjectNavigation)?.Id;
                    db.Update(e);

                }
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Retrieves a list of exams associated with the specified subject name.
        /// </summary>
        /// <param name="subjectName">The name of the subject for which to retrieve the associated exams.</param>
        /// <returns>A list of <see cref="Exam"/> objects associated with the specified subject.</returns>
        /// <remarks>
        /// This method calls the <see cref="examDAO"/> to obtain a list of exams filtered by the provided subject name,
        /// only including those exams that are scheduled for the future.
        /// </remarks>
        public List<Exam> obtainTheExamsToWhichASubject(string subjectName) 
        {
            return examDAO.getExamsListBySubjectName(subjectName);
        }

        /// <summary>
        /// Retrieves a list of exams associated with a specific career.
        /// </summary>
        /// <param name="careerName">The name of the career for which to retrieve exams.</param>
        /// <returns>A list of <see cref="Exam"/> objects associated with the specified career and scheduled on or after today's date.</returns>
        /// <remarks>
        /// This method calls the data access object (DAO) to obtain exams linked to the specified career by invoking <c>getListExamsToWhichACareer</c>.
        /// The exams are filtered to include only those scheduled for future dates or today.
        /// </remarks>
        public List<Exam> obtainTheExamsToWhichACareer(string careerName)
        {
            return examDAO.getListExamsToWhichACareer(careerName);
        }

        /// <summary>
        /// Retrieves a list of exams scheduled on a specific date.
        /// </summary>
        /// <param name="date">The date for which to retrieve exams.</param>
        /// <returns>A list of <see cref="Exam"/> objects scheduled on the specified date.</returns>
        /// <remarks>
        /// This method calls the data access object (DAO) to obtain exams that match the provided date
        /// by invoking <c>getListExamsBySearchDate</c>.
        /// </remarks>
        public List<Exam> obtainExamBySearchDate(DateTime date)
        {
            return examDAO.getListExamsBySearchDate(date);
        }

        public List<dynamic> loadExamDataForTable(object thisExam)
        {
            Exam exam = (Exam)thisExam;

            List<dynamic> examData = new()
            {
                exam.Id,
                exam.IdSubjectNavigation.Career.Name,
                exam.IdSubjectNavigation.YearInCareer,
                exam.IdSubjectNavigation.Name,
                exam.Date.ToString("dd/MM/yyyy HH:mm", LocalGestinSettings.LocalLanguage),
                Convert.ToString(exam.Call),
                cntExamEnrolment.countEnroledStudent(exam.Id),
                exam.IdSubject,
                exam.SubjectEnrolmentCareerId(),
            };
            return examData;
        }

        public List<string> loadExamData(object thisExam)
        {
            Exam exam = (Exam)thisExam;
            List<string> examData = new()
            {
                Convert.ToString(exam.IdSubjectNavigation.Career.Name),
                Convert.ToString(exam.Date.ToString("dd/MM/yyyy")),
                Convert.ToString(exam.Date.ToString("HH:mm")),
                Convert.ToString(exam.Place),
                Convert.ToString(exam.IdSubjectNavigation.Name),
                Convert.ToString(exam.FirstVowelNavigation?.User.fullName()),
                Convert.ToString(exam.SecondVowelNavigation?.User.fullName()),
                Convert.ToString(exam.ThirdVowelNavigation?.User.fullName()),
                Convert.ToString(exam.TitularNavigation?.User.fullName()),
            };
            return examData;
        }
        #endregion
    }
}

