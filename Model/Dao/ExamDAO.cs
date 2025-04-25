using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestin.Model.Dao
{
    public class ExamDAO
    {
        /// <summary>
        /// Adds a new exam to the database.
        /// </summary>
        /// <param name="exam">The <see cref="Exam"/> object to be added to the database.</param>
        /// <remarks>
        /// This method uses a new instance of the database context to add the exam and immediately save changes.
        /// The context is disposed of after the operation is complete due to the use of the 'using' statement.
        /// </remarks>
        public bool createdExam(Exam exam)
        {
            try
            {
                using var db = new Context();
                db.Exams.Add(exam);
                return db.SaveChanges() > 0;
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Updates an existing exam in the database.
        /// </summary>
        /// <param name="exam">The <see cref="Exam"/> object with updated information to be saved in the database.</param>
        /// <remarks>
        /// This method uses a new instance of the database context to update the exam and immediately save changes.
        /// The context is disposed of after the operation is complete due to the use of the 'using' statement.
        /// It assumes that the exam object already exists in the database and has a valid Id.
        /// </remarks>
        public bool updatedExam(Exam exam)
        {
            try
            {
                using var db = new Context();
                db.Exams.Update(exam);
                return db.SaveChanges() > 0;
            }
            catch (SqlException) { throw; };
        }

        /// <summary>
        /// Retrieves a list of  exams ordered by date, subject year, and name.
        /// </summary>
        /// <returns>A list of <see cref="Exam"/> objects scheduled on or after today's date.</returns>
        /// <remarks>
        /// This method fetches exams using the database context, ordering by date, subject year in career, and subject name.
        /// </remarks>
        public List<Exam> getListExams()
        {
            try
            {
                using var db = new Context();
                var exams = db.Exams
                    .Where(x => x.Date >= DateTime.Today)
                    .OrderBy(x => x.Date)
                    .ThenBy(x => x.IdSubjectNavigation.YearInCareer)
                    .ThenBy(x => x.IdSubjectNavigation.Name)
                    .Include(x => x.IdSubjectNavigation)
                    .Include(x => x.IdSubjectNavigation.Career).ToList();
                return exams;
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Retrieves a list of exams scheduled on a specific date.
        /// </summary>
        /// <param name="_date">The date for which exams are retrieved.</param>
        /// <returns>A list of <see cref="Exam"/> objects for the specified date.</returns>
        /// <remarks>
        /// This method queries exams by the exact date specified, including related subject and career data.
        /// </remarks>
        public List<Exam> getListExamsByDate(DateTime _date)
        {
            try
            {
                using var db = new Context();
                var result = db.Exams
                    .Where(x => x.Date.Date == _date.Date.Date)
                    .Include(x => x.IdSubjectNavigation)
                    .Include(x => x.IdSubjectNavigation.Career)
                    .ToList();
                return result;
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Checks if an exam already exists for a given subject and date-time.
        /// </summary>
        /// <param name="subject">The <see cref="Subject"/> object to check.</param>
        /// <param name="dateTime">The date and time to verify.</param>
        /// <returns>True if an exam exists for the specified subject and date-time; otherwise, false.</returns>
        public bool existSameExamByDateTime(object subject, DateTime dateTime)
        {
            try
            {
                Subject sub = (Subject)subject;
                using (var db = new Context())
                {
                    return db.Exams.Any(x => x.IdSubject == sub.Id && x.Date == dateTime);
                }
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Checks if an exam with a different ID exists for the specified subject and date-time.
        /// </summary>
        /// <param name="examCode">The unique code of the exam to exclude.</param>
        /// <param name="subject">The <see cref="Subject"/> object to check.</param>
        /// <param name="dateTime">The date and time to verify.</param>
        /// <returns>True if another exam exists for the subject and date-time; otherwise, false.</returns>
        public bool existSameExamByIdDateTime(int examCode, object subject, DateTime dateTime)
        {
            try
            {
                Subject sub = (Subject)subject;
                using var db = new Context();

                // Verifica si existe un examen distinto al actual con el mismo horario y materia
                return db.Exams.Any(x =>
                    x.Id != examCode && // Excluir el examen que se está actualizando
                    x.IdSubject == sub.Id && // Materia coincidente
                    x.Date == dateTime); // Fecha y hora coincidentes
            }
            catch (SqlException)
            {
                throw;
            }
        }

        /// <summary>
        /// Finds an exam by its unique code.
        /// </summary>
        /// <param name="code">The unique code of the exam to retrieve.</param>
        /// <returns>The <see cref="Exam"/> object with the specified code, or null if not found.</returns>
        /// <remarks>
        /// Includes related subject, career, and user information for exam participants.
        /// </remarks>
        public Exam? findExamByCode(int code)
        {
            try
            {
                using var db = new Context();
#pragma warning disable CS8602
                return db.Exams.Where(x => x.Id == code)
                .Include(x => x.IdSubjectNavigation)
                .Include(x => x.IdSubjectNavigation.Career)
                .Include(x => x.TitularNavigation.User)
                .Include(x => x.FirstVowelNavigation.User)
                .Include(x => x.SecondVowelNavigation.User)
                .Include(x => x.ThirdVowelNavigation.User)
                .FirstOrDefault();
#pragma warning restore CS8602
            }
            catch (SqlException) { throw new Exception("examen no encontrado"); }
        }

        /// <summary>
        /// Retrieves exams scheduled in the same year and period as a given exam.
        /// </summary>
        /// <param name="thisExam">The <see cref="Exam"/> object used for filtering exams by year and period.</param>
        /// <returns>A list of <see cref="Exam"/> objects with the same subject, year, and period as the specified exam.</returns>
        public List<Exam> getListExamsByYearPeriod(Exam thisExam)
        {
            try
            {
                using var db = new Context();
                var exams = db.Exams
                   .Where(x => x.IdSubject == thisExam.IdSubject && x.Date.Year == thisExam.Date.Year && x.Period == thisExam.Period)
                   .OrderBy(x => x.Date)
                   .ThenBy(x => x.Date.Month)
                   .ThenBy(x => x.Date.Day)
                   .ThenBy(x => x.Date.Hour)
                   .ThenBy(x => x.Date.Minute)
                   .ThenBy(x => x.Date.Second)
                   .ToList();

                return exams;
            }
            catch (SqlException) { throw; }

        }

        /// <summary>
        /// Retrieves all exams scheduled in the current year.
        /// </summary>
        /// <returns>A list of <see cref="Exam"/> objects scheduled within the current year.</returns>
        public List<Exam> getListExamsOfThisYear()
        {
            try
            {
                using var db = new Context();
                var exams = db.Exams
                   .Where(x => x.Date.Year == DateTime.Now.Year)
                   .OrderBy(x => x.Date)
                   .ThenBy(x => x.Date.Month)
                   .ThenBy(x => x.Date.Day)
                   .ThenBy(x => x.Date.Hour)
                   .ToList();
                return exams;

            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Retrieves exams for a specified date, including related subject and career information.
        /// </summary>
        /// <param name="date">The date for which to retrieve exams.</param>
        /// <returns>A list of <see cref="Exam"/> objects scheduled on the specified date.</returns>
        public List<Exam> getListExamsBySearchDate(DateTime date)
        {
            try
            {
                using var db = new Context();
                return db.Exams.Where(x => x.Date.Date == date.Date)
                    .Include(x => x.IdSubjectNavigation)
                    .Include(x => x.IdSubjectNavigation.Career)
                    .ToList();
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Retrieves exams associated with a specific career that are scheduled on or after today.
        /// </summary>
        /// <param name="careerName">The name of the career for which to retrieve exams.</param>
        /// <returns>A list of <see cref="Exam"/> objects associated with the specified career and scheduled on or after today.</returns>
        public List<Exam> getListExamsToWhichACareer(string careerName)
        {
            try
            {
                using var db = new Context();
                return db.Exams.
                    Where(x => (x.IdSubjectNavigation.Career.Name == careerName) && x.Date >= DateTime.Today)
                    .OrderBy(x => x.IdSubjectNavigation.YearInCareer)
                    .ThenBy(x => x.IdSubjectNavigation.YearInCareer)
                    .Include(x => x.IdSubjectNavigation)
                    .Include(x => x.IdSubjectNavigation.Career)
                    .ToList();
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Retrieves a list of years in which exams associated with the same subject as the given exam exist.
        /// </summary>
        /// <param name="exam">An instance of <see cref="Exam"/> used to filter the years based on the subject.</param>
        /// <returns>A list of integers representing the years in which exams for the specified subject were conducted.</returns>
        /// <exception cref="SqlException">Thrown if a database interaction error occurs.</exception>
        /// <remarks>
        /// Uses `Distinct()` to obtain unique years and `Select()` to project only the year from the exam date.
        /// This method may return an empty list if no exams are found for the given subject.
        /// </remarks>
        public List<int> getYearsOfExistingExams(Exam exam)
        {
            try
            {
                using var db = new Context();
                var years = db.Exams.Where(x => x.IdSubject == exam.IdSubject).Select(x => x.Date.Year).Distinct().ToList();
                return years;
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Retrieves a list of distinct periods for existing exams associated with a specific subject and year.
        /// </summary>
        /// <param name="exam">The <see cref="Exam"/> object used to filter exams by subject.</param>
        /// <param name="yearExam">The year for which to retrieve the periods of exams.</param>
        /// <returns>A list of distinct periods in which exams exist for the specified subject and year.</returns>
        /// <remarks>
        /// This method queries the database for exams related to the specified subject and year, 
        /// then returns a list of distinct periods.
        /// </remarks>
        public List<string> getPeriodOfExistingExams(Exam exam, int yearExam)
        {
            try
            {
                using var db = new Context();
                var periods = db.Exams.Where(x => x.IdSubject == exam.IdSubject && x.Date.Year == yearExam).Select(x => x.Period).Distinct().ToList();
                return periods;
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Retrieves a list of exams for a specific subject, year, and period.
        /// </summary>
        /// <param name="exam">The <see cref="Exam"/> object used to filter exams by subject.</param>
        /// <param name="yearExam">The year for which to retrieve exams.</param>
        /// <param name="period">The period for which to retrieve exams.</param>
        /// <returns>A list of exams matching the specified criteria.</returns>
        /// <remarks>
        /// This method queries the database for exams related to the specified subject, year, and period, 
        /// and returns them ordered by date.
        /// </remarks>
        public List<Exam> getExamsListBySpecifiedPeriod(Exam exam, int yearExam, string period)
        {
            try
            {
                using var db = new Context();
                var exams = db.Exams.Where(x => x.IdSubject == exam.IdSubject && x.Date.Year == yearExam && x.Period == period).OrderBy(x => x.Date).ToList();
                return exams;
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Retrieves a specific exam based on its ID.
        /// </summary>
        /// <param name="exam">The <see cref="Exam"/> object containing the ID of the exam to be retrieved.</param>
        /// <returns>The <see cref="Exam"/> object if found; otherwise, null.</returns>
        /// <remarks>
        /// This method fetches an exam from the database using its ID, including related subject and user information.
        /// </remarks>
        public Exam? getExam(object exam)
        {
            Exam thisExam = (Exam)exam;
            try
            {
                using var db = new Context();
                return db.Exams.Where(x => x.Id == thisExam.Id)
#pragma warning disable CS8602
                .Include(x => x.IdSubjectNavigation)
                .Include(x => x.IdSubjectNavigation.Career)
                .Include(x => x.TitularNavigation.User)
                .Include(x => x.FirstVowelNavigation.User)
                .Include(x => x.SecondVowelNavigation.User)
                .Include(x => x.ThirdVowelNavigation.User)
                .FirstOrDefault();
#pragma warning restore CS8602
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Retrieves a specific exam based on the subject name.
        /// </summary>
        /// <param name="subjectName">The name of the subject used to filter the exam.</param>
        /// <returns>The <see cref="Exam"/> object if found; otherwise, null.</returns>
        /// <remarks>
        /// This method searches for an exam in the database based on the subject's name, 
        /// including related subject and user information.
        /// </remarks>
        public Exam? getExamBySubjectName(string subjectName)
        {
            try
            {
                using var db = new Context();
                return db.Exams.Where(x => x.IdSubjectNavigation.Name == subjectName)
#pragma warning disable CS8602
               .Include(x => x.IdSubjectNavigation)
               .Include(x => x.IdSubjectNavigation.Career)
               .Include(x => x.TitularNavigation.User)
               .Include(x => x.FirstVowelNavigation.User)
               .Include(x => x.SecondVowelNavigation.User)
               .Include(x => x.ThirdVowelNavigation.User)
               .FirstOrDefault();
#pragma warning restore CS8602
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Retrieves a specific exam for a teacher by its code.
        /// </summary>
        /// <param name="code">The unique identifier of the exam.</param>
        /// <returns>The <see cref="Exam"/> object if found; otherwise, null.</returns>
        /// <remarks>
        /// This method retrieves an exam based on its code, including related teacher information.
        /// </remarks>
        public Exam? getExamTecherByCode(int code)
        {
            try
            {
                using var db = new Context();
                return db.Exams.Where(x => x.Id == code)
                .Include(x => x.TitularNavigation)
                .Include(x => x.FirstVowelNavigation)
                .Include(x => x.SecondVowelNavigation)
                .Include(x => x.ThirdVowelNavigation)
                .FirstOrDefault();
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Retrieves a list of all exams in the database.
        /// </summary>
        /// <returns>A list of all <see cref="Exam"/> objects.</returns>
        /// <remarks>
        /// This method fetches all exams from the database, including their associated subjects.
        /// </remarks>
        public List<Exam> getExamsList()
        {
            try
            {
                using var db = new Context();
                return db.Exams.Include(x => x.IdSubjectNavigation).ToList();
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Retrieves a list of exams associated with a specific subject name that are scheduled for today or later.
        /// </summary>
        /// <param name="subjectName">The name of the subject used to filter exams.</param>
        /// <returns>A list of exams for the specified subject name.</returns>
        /// <remarks>
        /// This method queries the database for exams related to the specified subject name, 
        /// ordering them by the year in career and filtering for exams that occur today or later.
        /// </remarks>
        public List<Exam> getExamsListBySubjectName(string subjectName)
        {
            try
            {
                using var db = new Context();
                return db.Exams.Where(x => (x.IdSubjectNavigation.Name == subjectName) && x.Date >= DateTime.Today)
                    .OrderBy(x => x.IdSubjectNavigation.YearInCareer)
                    .ThenBy(x => x.IdSubjectNavigation.YearInCareer)
                    .Include(x => x.IdSubjectNavigation)
                    .Include(x => x.IdSubjectNavigation.Career)
                    .ToList();
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Deletes an exam from the database by its unique identifier (ID).
        /// </summary>
        /// <param name="examCode">The unique identifier of the exam to delete.</param>
        /// <returns>Returns `true` if the exam was successfully deleted; otherwise, `false`.</returns>
        /// <exception cref="SqlException">Thrown if a database interaction error occurs.</exception>
        /// <remarks>
        /// This method searches for the exam in the database using `First()`, which will throw an exception
        /// if the exam with the specified code does not exist. It uses `SaveChanges()` to confirm the deletion.
        /// </remarks>
        public bool deleteExamByCode(int examCode)
        {
            try
            {
                using var db = new Context();
                Exam exam = db.Exams.Where(x => x.Id == examCode).First();
                db.Exams.Remove(exam);
                return db.SaveChanges() > 0;
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
