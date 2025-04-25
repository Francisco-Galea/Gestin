using Gestin.Model;
using Gestin.Model.Dao;
using Gestin.Model.Model_Internal;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace Gestin.Controllers
{
    internal class gradeController
    {
        subjectEnrolmentController subjectEnrolmentController = subjectEnrolmentController.getInstance();
        sessionController sessionController = sessionController.getInstance();
        GradeDao gradeDao = GradeDao.getInstance();

        #region Singleton

        static gradeController? Instance;
        private gradeController() { }
        public static gradeController getInstance()
        {
            if (Instance == null)
            {
                Instance = new gradeController();
            }
            return Instance;
        }
        #endregion


        #region Grades

        #region Insert methods
        /// <summary>
        /// Adds a new grade for a student in a specified subject and stores it in the database. 
        /// Also updates the student's enrolment status for subjects with "Libre" accreditation type based on the grade obtained.
        /// </summary>
        /// <param name="studentid">The ID of the student receiving the grade.</param>
        /// <param name="subject">
        /// An object representing the subject in which the grade is being assigned. 
        /// This object must be cast to a <see cref="Subject"/> before use.
        /// </param>
        /// <param name="grade">The numeric value of the grade being assigned, typically an integer.</param>
        /// <param name="bookRecord">The record of the grade in the academic book, as a string.</param>
        /// <param name="accreditation">The date when the accreditation for the grade was granted.</param>
        /// <param name="accreditationType">
        /// The type of accreditation being awarded for this grade. Common values include "Libre" and other predefined types.
        /// </param>
        /// <returns>
        /// A boolean value indicating whether the grade was successfully added to the database. 
        /// Returns <c>true</c> if the grade was added successfully; otherwise, returns <c>false</c>.
        /// </returns>
        /// <remarks>
        /// This method performs the following actions:
        /// <list type="bullet">
        /// <item><description>Creates a new <see cref="Grade"/> object using the provided information.</description></item>
        /// <item><description>Saves the grade in the database by invoking <see cref="GradeDao.InsertGrade(Grade)"/>.</description></item>
        /// <item><description>
        /// If the accreditation type is "Libre", it calls <see cref="getTypeOfAcreditation(Grade, int)"/> to determine the student's approval status
        /// and updates their enrolment for the subject accordingly by invoking <see cref="subjectEnrolmentController.changeApprovalEnrolledLibreSubject"/>.
        /// </description></item>
        /// </list>
        /// This ensures that students enrolled under "Libre" accreditation types are automatically updated based on their grade.
        /// </remarks>
        public bool addGrade(int studentid, object subject, int grade, string bookRecord, DateTime accreditation, string accreditationType)
        {
            try
            {
                Subject thisSubject = (Subject)subject;
                Grade grade_ = new Grade();
                bool change = false;

                grade_.StudentId = studentid;
                grade_.SubjectId = thisSubject.Id;
                grade_.Grade1 = grade;
                grade_.BookRecord = bookRecord;
                grade_.AccreditationDate = accreditation;
                grade_.AccreditationType = accreditationType;
                grade_.CreatedAt = DateTime.Now;
                grade_.LastModificationBy = sessionController.getSessionedUserData();
              
                gradeDao.InsertGrade(grade_);
                change = true;
                getTypeOfAcreditation(grade_, thisSubject.Id);
                
                return change;
            }
            catch (SqlException) { throw; }
        }
        #endregion

        #region Update Methods
        /// <summary>
        /// Updates the grade information for a specific record in the database, including the grade value and associated book record.
        /// Also updates the student's enrolment status for subjects with "Libre" accreditation type if necessary.
        /// </summary>
        /// <param name="grade">The existing <see cref="Grade"/> object that needs to be updated.</param>
        /// <param name="grade_">The new numeric value of the grade to be assigned.</param>
        /// <param name="bookRecord_">The new book record associated with the grade, as a string.</param>
        /// <returns>
        /// A boolean value indicating whether the grade was successfully updated in the database. 
        /// Returns <c>true</c> if the update was successful; otherwise, returns <c>false</c>.
        /// </returns>
        /// <remarks>
        /// This method performs the following actions:
        /// <list type="bullet">
        /// <item><description>Updates the properties of the provided <see cref="Grade"/> object, including the grade value, book record, and modification data.</description></item>
        /// <item><description>Saves the updated grade information to the database by invoking <see cref="GradeDao.UpdateGrade(Grade)"/>.</description></item>
        /// <item><description>
        /// If the accreditation type of the grade is "Libre", it calls <see cref="getTypeOfAcreditation(Grade, int)"/> to check if the student passes the subject
        /// and updates their enrolment status accordingly by invoking <see cref="subjectEnrolmentController.changeApprovalEnrolledLibreSubject"/>.
        /// </description></item>
        /// </list>
        /// </remarks>
        public bool updateGrade(Grade grade, int grade_, string bookRecord_)
        {
            bool change = false;
            grade.Grade1 = grade_;
            grade.BookRecord = bookRecord_;
            grade.UpdatedAt = DateTime.Now;
            grade.LastModificationBy = sessionController.getSessionedUserData();

            try
            {
                gradeDao.UpdateGrade(grade);
                change = true;

                getTypeOfAcreditation(grade, grade.SubjectId);
                return change;
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Updates an existing grade record in the database with new values based on the provided grade ID.
        /// </summary>
        /// <param name="gradeId">The ID of the grade to be updated.</param>
        /// <param name="grade">The new grade value as a string, which will be converted to an integer.</param>
        /// <param name="bookrecord">The new book record associated with the grade.</param>
        /// <param name="accDate">The new accreditation date for the grade.</param>
        /// <param name="accType">The new accreditation type (e.g., "Libre").</param>
        /// <returns>
        /// A boolean indicating whether the grade was successfully updated in the database. Returns <c>true</c> if the update was successful, otherwise <c>false</c>.
        /// </returns>
        /// <remarks>
        /// This method first finds the grade by its ID. If the grade is found, it updates its values (including the grade, book record, accreditation date, and accreditation type) 
        /// and saves the changes to the database. If the grade's accreditation type is "Libre", it will update the student's approval status for the subject accordingly.
        /// </remarks>
        /// Revisar metodo
        public bool updateGrade(int gradeId, string grade, string bookrecord, DateTime accDate, string accType)
        {
            try
            {
                using (var db = new Context())
                {
                    var result = findGrade(gradeId);
                    if (result != null)
                    {
                        result.Grade1 = Int32.Parse(grade);
                        result.BookRecord = bookrecord;
                        result.AccreditationDate = accDate; //DateTime.ParseExact(accDate, "dd/MM/yyyy", null); 
                        result.AccreditationType = accType;
                        result.UpdatedAt = DateTime.Now;
                        result.LastModificationBy = sessionController.getSessionedUserData();
                        db.Update(result);
                        return db.SaveChanges() > 0;
                    }
                }
                return false;
            }
            catch (SqlException) { throw; }
        }
        #endregion

        #region Get Methods
        /// <summary>
        /// Retrieves the list of grades for a student based on their DNI (identification number).
        /// </summary>
        /// <param name="dni">The student's DNI used to find their grade records.</param>
        /// <returns>
        /// A list of <see cref="Grade"/> objects representing the student's grades. Returns an empty list if no grades are found for the given DNI.
        /// </returns>
        /// <remarks>
        /// This method queries the database for all grade records associated with the specified student's DNI. 
        /// Each <see cref="Grade"/> object includes information about the subject the grade is related to, as this data is eagerly loaded using the <see cref="Include"/> method.
        /// If the query encounters a database-related issue, a <see cref="SqlException"/> is thrown.
        /// 
        /// <b>Note:</b> This method appears to be outdated and may no longer be actively used in the current system. 
        /// Consider reviewing its usage before relying on it for new functionality.
        /// </remarks>
        public List<Grade> getStudentGrades(int dni)
        {
            using (var db = new Context())
            {
                try
                {
                    return db.Grades.Where(x => x.Student.User.Dni == dni).Include(x => x.Subject).ToList();
                }
                catch (SqlException) { throw; }
            }
        }

        /// <summary>
        /// Retrieves a specific grade for a student in a particular subject based on the exam date.
        /// </summary>
        /// <param name="studentId">The ID of the student whose grade is being retrieved.</param>
        /// <param name="subjectId">The ID of the subject for which the grade is being retrieved.</param>
        /// <param name="examDate">The date of the exam for which the grade is being retrieved.</param>
        /// <returns>
        /// A <see cref="Grade"/> object representing the student's grade for the specified exam. 
        /// If no grade is found, <c>null</c> is returned.
        /// </returns>
        /// <remarks>
        /// This method calls <see cref="GradeDao.GetStudentGradeForExams(int, int, DateTime)"/> to query the database for a grade 
        /// that matches the specified student ID, subject ID, and exam date. 
        /// If multiple grades are found for the same exam, only the first one is returned.
        /// If the query encounters a database-related issue, a <see cref="SqlException"/> is thrown.
        /// </remarks>
        public Grade? getStudentGradeForExams(int studentId, int subjectId, DateTime examDate)
        {
            try
            {
                return gradeDao.GetStudentGradeForExams(studentId, subjectId, examDate);    
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Finds and retrieves a grade from the database based on the provided ID.
        /// </summary>
        /// <param name="Gradeid">The ID of the grade to find.</param>
        /// <returns>
        /// A <see cref="Grade"/> object if a grade with the specified ID is found; otherwise, <c>null</c>.
        /// </returns>
        /// <remarks>
        /// This method calls <see cref="GradeDao.GetGrade(int)"/> to query the database using the provided grade ID.
        /// If the grade exists, the corresponding <see cref="Grade"/> object is returned; if no grade is found, <c>null</c> is returned.
        /// If the query encounters a database-related issue, a <see cref="SqlException"/> is thrown.
        /// </remarks>
        public Grade? findGrade(int Gradeid)
        {          
             try
                {
                    return gradeDao.GetGrade(Gradeid);
                }
             catch (SqlException) { throw; }         
        }


        /// <summary>
        /// Finds and retrieves a grade from the database based on the provided student and subject IDs.
        /// </summary>
        /// <param name="studentId">The ID of the student for whom the grade is being retrieved.</param>
        /// <param name="subjectId">The ID of the subject associated with the grade.</param>
        /// <returns>
        /// The <see cref="Grade"/> object if a grade matching the provided student and subject IDs is found; 
        /// otherwise, <c>null</c>.
        /// </returns>      
        /// <remarks>
        /// This method queries the database using both the student ID and subject ID and returns the 
        /// corresponding grade if it exists, or <c>null</c> if no matching grade is found.
        /// <b>Note:</b> This method appears to be outdated and may no longer be actively used in the current system. 
        /// Consider reviewing its usage before relying on it for new functionality.
        /// </remarks>
        public Grade? findGrade(int studentId, int subjectId)
        {
            using (var db = new Context())
            {
                try
                {
                    return db.Grades.Where(x => x.StudentId == studentId && x.SubjectId == subjectId).FirstOrDefault();
                }
                catch (SqlException) { throw; }
            }
        }


        public int getLastGrade(Subject subject, int studentId)
        {
            using (var db = new Context())
            {
                try
                {
                    return db.Grades.Where(x => (x.SubjectId == subject.Id && x.StudentId == studentId)).OrderByDescending(x => x.AccreditationDate).First().Grade1;
                }
                catch (SqlException) { throw; }
            }
        }

        /// <summary>
        /// Retrieves a list of grades for a student based on their DNI and career ID.
        /// </summary>
        /// <param name="dni">The DNI of the student whose grades are being retrieved.</param>
        /// <param name="idCarrer">The ID of the career for which the student's grades are being retrieved.</param>
        /// <returns>
        /// A list of <see cref="Grade"/> objects representing the grades of the specified student in the specified career. 
        /// If no grades are found, an empty list is returned.
        /// </returns>
        /// <remarks>
        /// This method calls <see cref="GradeDao.GetStudentGradesByCareer(int, int)"/> to query the database for the grades 
        /// that match the specified DNI and career ID. 
        /// If the query encounters a database-related issue, a <see cref="SqlException"/> is thrown.
        /// </remarks>
        public List<Grade> getStudentGradesByCareer(int dni, int idCarrer)
        {
            try
            {
                return gradeDao.GetStudentGradesByCareer(dni, idCarrer);
            }
            catch (SqlException) { throw; }
        }

        public List<Grade> getStudentGradesForCareerAndYear(int dni, int idCarrer, int yearCarrer)
        {
            using (var db = new Context())
            {
                try
                {
                    return db.Grades.Where(x => x.Student.User.Dni == dni && x.Subject.CareerId == idCarrer && x.Subject.YearInCareer == yearCarrer && x.DeletedAt == null).Include(x => x.Subject).ToList();
                }
                catch (SqlException) { throw; }
            }
        }
        
        public List<Grade> getStudentGradesById(int careerId, int studentId)
        {
            using (var db = new Context())
            {
                try
                {
                    return db.Grades.Where(x => x.Student.Id == studentId && x.Subject.CareerId == careerId).Include(x => x.Subject).ToList();
                }
                catch (SqlException) { throw; }
            }
        }

        public List<Grade> getStudentGradesFromCareer(int dni, int idCareer)
        {
            using (var db = new Context())
            {
                try
                {
                    return db.Grades.Where(x => x.Student.User.Dni == dni && x.Subject.CareerId == idCareer && x.Grade1 >= 4).Include(x => x.Subject).ToList();
                }
                catch (SqlException) { throw; }
            }
        }

        /// <summary>
        /// Retrieves a list of grades for a student based on their DNI and career ID.
        /// </summary>
        /// <param name="dni">The DNI of the student whose grades are being retrieved.</param>
        /// <param name="idCarrer">The ID of the career for which the student's grades are being retrieved.</param>
        /// <returns>
        /// A list of <see cref="Grade"/> objects representing the grades of the specified student in the specified career. 
        /// If no grades are found, an empty list is returned.
        /// </returns>
        /// <remarks>
        /// This method calls <see cref="GradeDao.GetStudentGradesByCareer(int, int)"/> to query the database for the grades 
        /// that match the specified DNI and career ID. 
        /// If the query encounters a database-related issue, a <see cref="SqlException"/> is thrown.
        /// </remarks>
        internal List<Grade> requestStudentGrades(int dni, object careerEnrolment)
        {
            try
            {
                CareerEnrolment thisCareerEnrolment = (CareerEnrolment)careerEnrolment;
                return gradeDao.GetStudentGradesByCareer(dni, thisCareerEnrolment.CareerId);
            }
            catch (SqlException) { throw; }
        }
       
        internal List<StudentRecord> getAllStudentRecords(int dni, object careerEnrolment)
        {
            var grades = requestStudentGrades(dni, careerEnrolment)
                          .Where(g => !g.DeletedAt.HasValue) 
                          .ToList();

            CareerEnrolment thisCareerEnrolment = (CareerEnrolment)careerEnrolment;
            var listSubjectsEnrolled = subjectEnrolmentController.getEnrolments(dni, thisCareerEnrolment)
                                     .Where(se => !se.DeletedAt.HasValue) 
                                     .ToList();

            var resultList = new List<StudentRecord>();

            listSubjectsEnrolled.RemoveAll(x => grades.Any(y => y.Subject.Name == x.Subject.Name));

            foreach (Grade grade in grades)
            {
                var subjectTaken = subjectEnrolmentController.getEnrolment(dni, grade.Subject, careerEnrolment);

                if (subjectTaken != null)
                {
                    StudentRecord studentRecord = new StudentRecord();
                    studentRecord.Grade = grade;
                    studentRecord.SubjectEnrolment = subjectTaken;

                    if (studentRecord.Grade.AccreditationDate.HasValue)
                    {
                        studentRecord.Grade.AccreditationDate = formatDateTime(studentRecord.Grade.AccreditationDate);
                    }

                    resultList.Add(studentRecord);
                }
            }

            foreach (SubjectEnrolment enrolledSubjects in listSubjectsEnrolled)
            {
                StudentRecord studentRecord = new();
                studentRecord.SubjectEnrolment = enrolledSubjects;
                studentRecord.Grade = new Grade(); 

                studentRecord.Grade.AccreditationType = enrolledSubjects.Presential ? "Presencial" : "Libre";

                resultList.Add(studentRecord);
            }

            return resultList.OrderBy(x => x.SubjectEnrolment.Subject.YearInCareer).ThenBy(x => x.SubjectEnrolment.Subject.Name).ToList();
        }


        internal List<StudentRecord> getCurrentStudentRecords(List<object> studentRecords)
        {
            return studentRecords.ConvertAll(x => (StudentRecord)x).Where(x => x.SubjectEnrolment.Year == DateTime.Now.Year || x.SubjectEnrolment.Approved).ToList();
        }


        public List<dynamic?> studentRecordValues(object record)
        {
            StudentRecord studentRecord = (StudentRecord)record;

            string? recordGrade = string.Empty;
            string? accreditationDate = string.Empty;

            if (studentRecord.Grade != null)
            {
                recordGrade = studentRecord.Grade.Grade1.ToString();

                if (studentRecord.Grade.AccreditationDate.HasValue)
                {
                    studentRecord.Grade.AccreditationDate = formatDateTime(studentRecord.Grade.AccreditationDate);
                }
            }

            List<dynamic?> studentRecordValues = new()
            {
                studentRecord.SubjectEnrolment.Subject.Name,
                Convert.ToString(studentRecord.SubjectEnrolment.Year),
                studentRecord.SubjectEnrolmentPresential,
                recordGrade,
                studentRecord.Grade.BookRecord,
                accreditationDate,
                Convert.ToString(studentRecord.Grade.AccreditationType),
                studentRecord.SubjectEnrolment.Approved,
                studentRecord.SubjectEnrolment.Subject,
                studentRecord.Grade.Id,
                studentRecord.SubjectEnrolment.Id,
                studentRecord.Grade.AccreditationDate
            };
            return studentRecordValues;
        }

        #endregion

        #region Delete methods
        /// <summary>
        /// Marks a <see cref="Grade"/> as deleted by setting the <c>DeletedAt</c> field and updating the record in the database.
        /// </summary>
        /// <param name="GradeId">The ID of the grade to be marked as deleted.</param>
        /// <returns>
        /// A boolean indicating whether the grade was successfully marked as deleted. 
        /// Returns <c>true</c> if the grade was found and updated; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// This method does not physically delete the grade from the database. Instead, it updates the 
        /// <c>DeletedAt</c> field to mark the grade as deleted and records the user making the modification.
        /// If the grade with the specified ID is found, it calls <see cref="GradeDao.DeleteGrade(Grade)"/> 
        /// to update the record in the database. If the specified grade is not found, the method returns <c>false</c>.
        /// </remarks>
        public bool deleteGrade(int GradeId)
        {
            bool result;
            try
            {
                var Grade = findGrade(GradeId);
                if (Grade != null)
                {
                    Grade.DeletedAt = DateTime.Now;
                    Grade.LastModificationBy = sessionController.getSessionedUserData();
                    gradeDao.DeleteGrade(Grade);
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (SqlException) { throw; }

            return result;
        }
        #endregion

        #region Utility Methods
        internal StudentRecord rebuildStudentRecord(int gradeId, int subjectEnrolmentId)
        {
            Grade? grade = findGrade(gradeId);
            SubjectEnrolment? subjectEnrolment = subjectEnrolmentController.findEnrolment(subjectEnrolmentId);

            if (grade == null)
            {
                grade = new Grade();
            }
            else
            {
                grade.AccreditationDate = formatDateTime(grade.AccreditationDate);
            }

            if(subjectEnrolment == null)
            {
                subjectEnrolment = new SubjectEnrolment();
            }

            StudentRecord studentRecord = new StudentRecord(grade, subjectEnrolment);
            return studentRecord;
        }


        /// <summary>
        /// Counts the number of passed subjects for a specific student in a particular career.
        /// </summary>
        /// <param name="dni">The DNI (identification number) of the student.</param>
        /// <param name="idCareer">The ID of the career to filter the subjects.</param>
        /// <returns>
        /// An integer representing the number of passed subjects where the grade is 4 or higher.
        /// </returns>
        /// <remarks>
        /// This method delegates the counting logic to the data access object <see cref="gradeDao"/>.
        /// </remarks>
        public int countPassedSubjects(int dni, int idCareer)
        {
            try
            {
                return gradeDao.CountPassedSubjects(dni, idCareer);
            }
            catch (Exception ex) { throw; }
        }

        /// <summary>
        /// Counts the number of approved subjects for a specific student in a given career.
        /// </summary>
        /// <param name="careerId">The ID of the career to filter the subjects.</param>
        /// <param name="studentId">The ID of the student whose approved subjects are being counted.</param>
        /// <returns>
        /// An integer representing the number of approved subjects where the grade is 4 or higher.
        /// </returns>
        /// <remarks>
        /// This method delegates the counting logic to the data access object <see cref="gradeDao"/>.
        /// </remarks>
        public int countApprovedSubjects(int careerId, int studentId)
        {
            try
            {
                return gradeDao.CountApprovedSubjects(careerId, studentId);
            }
            catch(Exception ex) { throw; }
        }

        /// <summary>
        /// Metodo para calcular el promedio de un estudiante
        /// </summary>
        internal double calculateAverage(List<object> gradeList)
        {
            try
            {
                double avg = gradeList.Average(x => Convert.ToDouble(x.GetType().GetProperty("Grade1").GetValue(x)));
                return Math.Round(avg, 2);
            }
            catch (ArgumentNullException) { return 0; }
            catch (InvalidCastException) { return 0; }
        }

        /// <summary>
        /// Determines the type of accreditation for a given grade and updates the student's enrolment status for the subject if the accreditation type is "Libre".
        /// </summary>
        /// <param name="grade">The <see cref="Grade"/> object containing the accreditation details.</param>
        /// <param name="SubjectId">The ID of the subject in which the accreditation is being evaluated.</param>
        /// <remarks>
        /// This method performs the following steps:
        /// <list type="bullet">
        /// <item><description>Checks if the accreditation type for the provided <see cref="Grade"/> is "Libre".</description></item>
        /// <item><description>If the accreditation type is "Libre", it evaluates the student's passing status based on whether the grade is 4 or higher.</description></item>
        /// <item><description>
        /// Invokes <see cref="subjectEnrolmentController.changeApprovalEnrolledLibreSubject"/> to update the student's enrolment status in the subject based on the grade. 
        /// The student's enrolment is updated to reflect whether they have passed or failed the subject.
        /// </description></item>
        /// </list>
        /// </remarks>
        public void getTypeOfAcreditation(Grade grade, int SubjectId)
        {
            if (grade.AccreditationType == "Libre")
            {
                bool status = grade.Grade1 >= 4;
                subjectEnrolmentController.changeApprovalEnrolledLibreSubject(grade.StudentId, SubjectId, status);
            }
        }

        private DateTime formatDateTime(DateTime? dt)
        {
            if (dt.HasValue)
            {
                return Convert.ToDateTime(dt.Value.Date);
            }
            return DateTime.MinValue;
        }
        #endregion

        #endregion
    }
}
