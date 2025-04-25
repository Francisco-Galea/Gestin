using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestin.Model.Dao
{
    public class GradeDao
    {
        private static GradeDao instanceGradeDao;

        private GradeDao() { }

        #region Singleton
        public static GradeDao getInstance()
        {
            if (instanceGradeDao == null)
            {
                instanceGradeDao = new GradeDao();
            }
            return instanceGradeDao;
        }
        #endregion


        /// <summary>
        /// Inserts a new <see cref="Grade"/> record into the database.
        /// </summary>
        /// <param name="grade">The <see cref="Grade"/> object to be inserted into the database.</param>
        /// <remarks>
        /// This method adds a new <see cref="Grade"/> entity to the database using the <c>Add</c> method 
        /// and commits the changes by calling <c>SaveChanges</c>. It is intended for creating new grade records.
        /// </remarks>
        public void InsertGrade(Grade grade)
        {
            using (var db = new Context())
            {
                db.Grades.Add(grade);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Updates an existing <see cref="Grade"/> record in the database.
        /// </summary>
        /// <param name="grade">The <see cref="Grade"/> object containing updated information to be saved.</param>
        /// <remarks>
        /// This method updates the specified <see cref="Grade"/> entity in the database using the <c>Update</c> method
        /// and commits the changes by calling <c>SaveChanges</c>. It is intended for modifying an existing grade record.
        /// </remarks>
        public void UpdateGrade(Grade grade)
        {
            using (var db = new Context())
            {
                db.Grades.Update(grade);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Retrieves a <see cref="Grade"/> record from the database based on the provided grade ID.
        /// </summary>
        /// <param name="GradeId">The ID of the grade to be retrieved.</param>
        /// <returns>
        /// The <see cref="Grade"/> object if a grade with the specified ID is found; otherwise, <c>null</c>.
        /// </returns>
        /// <remarks>
        /// This method queries the database for a grade with the matching ID and returns it. 
        /// If no matching grade is found, it returns <c>null</c>.
        /// </remarks>
        public Grade? GetGrade(int GradeId)
        {
            using (var db = new Context())
            {
                return db.Grades.Where(grade => grade.Id == GradeId)
                                .FirstOrDefault();
            }
        }

        /// <summary>
        /// Retrieves a list of <see cref="Grade"/> objects for a specific student and career.
        /// </summary>
        /// <param name="dni">The student's DNI (Documento Nacional de Identidad).</param>
        /// <param name="idCarrer">The ID of the career to filter the grades.</param>
        /// <returns>
        /// A list of <see cref="Grade"/> objects representing the student's grades for the specified career.
        /// </returns>
        /// <remarks>
        /// This method queries the database for grades associated with the specified student's DNI and career ID. 
        /// It also includes the related <see cref="Subject"/> for each grade.
        /// </remarks>
        public List<Grade> GetStudentGradesByCareer(int dni, int idCarrer)
        {
            using (var db = new Context())
            {
                return db.Grades.Where(grade => grade.Student.User.Dni == dni && grade.Subject.CareerId == idCarrer && grade.Grade1 >= 4 && grade.DeletedAt == null)
                                .Include(grade => grade.Subject)
                                .ToList();
            }
        }

        /// <summary>
        /// Retrieves a specific <see cref="Grade"/> for a student in a particular subject based on the exam date.
        /// </summary>
        /// <param name="studentId">The ID of the student whose grade is being retrieved.</param>
        /// <param name="subjectId">The ID of the subject for which the grade is being retrieved.</param>
        /// <param name="examDate">The date of the exam for which the grade is being retrieved.</param>
        /// <returns>
        /// A <see cref="Grade"/> object representing the student's grade for the specified exam, 
        /// or <c>null</c> if no matching grade is found.
        /// </returns>
        /// <remarks>
        /// This method queries the database for a grade that matches the specified student ID, subject ID, and exam date. 
        /// It returns the first grade found, or <c>null</c> if no grade matches the criteria.
        /// </remarks>
        public Grade? GetStudentGradeForExams(int studentId, int subjectId, DateTime examDate)
        {
            using (var db = new Context())
            {
                return db.Grades.Where(grade => grade.StudentId == studentId && grade.SubjectId == subjectId && grade.AccreditationDate == examDate && grade.DeletedAt == null)
                                .FirstOrDefault();
            }
        }

        /// <summary>
        /// Updates the provided <see cref="Grade"/> in the database to mark it as deleted.
        /// </summary>
        /// <param name="grade">The <see cref="Grade"/> object to be updated, typically marked with a deleted timestamp.</param>
        /// <remarks>
        /// This method updates the given <see cref="Grade"/> entity in the database by calling the <c>Update</c> method. 
        /// It assumes that the <see cref="Grade"/> object has already been modified (e.g., the <c>DeletedAt</c> field is set) 
        /// before calling this method. The method commits the changes to the database by calling <c>SaveChanges</c>.
        /// <para>
        /// Note: This method does not physically delete the grade record; instead, it performs a soft delete by updating the entity.
        /// </para>
        /// If the database operation encounters an issue, an exception may be thrown.
        /// </remarks>
        public void DeleteGrade(Grade grade)
        {
            using (var db = new Context())
            {
                db.Grades.Update(grade);
                db.SaveChanges();
            }
        }



        /// <summary>
        /// Counts the number of passed subjects for a specific student in a particular career from the database.
        /// </summary>
        /// <param name="dni">The DNI (identification number) of the student.</param>
        /// <param name="idCareer">The ID of the career to filter the subjects.</param>
        /// <returns>
        /// An integer representing the number of passed subjects where the grade is 4 or higher.
        /// </returns>
        /// <remarks>
        /// This method queries the database directly. 
        /// A subject is considered passed if its grade is 4 or higher and it is not marked as deleted (<c>DeletedAt</c> is <c>null</c>).
        /// </remarks>
        public int CountPassedSubjects(int dni, int idCareer)
        {

            int passedSubjects = 0;

            try
            {
                using (var db = new Context())
                {
                    passedSubjects =  db.Grades.Where(x => x.Student.User.Dni == dni 
                                                        && x.Subject.CareerId == idCareer && x.Grade1 >= 4 && x.DeletedAt == null)
                                                        .Include(x => x.Subject)
                                                        .Count();
                    
                }
                
            }
            catch(SqlException) 
            {
                throw;
            }

            return passedSubjects;

        }

        /// <summary>
        /// Counts the number of approved subjects for a specific student in a given career directly from the database.
        /// </summary>
        /// <param name="careerId">The ID of the career to filter the subjects.</param>
        /// <param name="studentId">The ID of the student whose approved subjects are being counted.</param>
        /// <returns>
        /// An integer representing the number of approved subjects where the grade is 4 or higher.
        /// </returns>
        /// <remarks>
        /// This method queries the database directly.
        /// A subject is considered approved if its grade is 4 or higher and it is not marked as deleted (<c>DeletedAt</c> is <c>null</c>).
        /// </remarks>
        public int CountApprovedSubjects(int careerId, int studentId)
        {

            int approvedSubjects = 0;

            try
            {
                using(var db = new Context())
                {
                    approvedSubjects = db.Grades.Where(x => x.StudentId == studentId
                                                        && x.Subject.CareerId == careerId && x.Grade1 >= 4 && x.DeletedAt == null)
                                                        .Include(x => x.Subject)
                                                        .Count();
                }
            }
            catch (SqlException)
            {
                throw;
            }

            return approvedSubjects;

        }

    }
}
