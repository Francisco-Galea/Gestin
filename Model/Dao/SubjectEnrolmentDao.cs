using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestin.Model.Dao
{
    public class SubjectEnrolmentDao
    {
        public SubjectEnrolmentDao() { }
        
        #region Save 
        /// Inserts a new <see cref="SubjectEnrolment"/> record into the database.
        /// </summary>
        /// <param name="enrolment">The <see cref="SubjectEnrolment"/> object to be inserted into the database.</param>
        /// <returns><c>true</c> if the enrolment was saved successfully; otherwise, <c>false</c>.</returns>
        /// <remarks>
        /// This method adds a new <see cref="SubjectEnrolment"/> entity to the database using the <c>Add</c> method 
        /// and commits the changes by calling <c>SaveChanges</c>. It is intended for creating new enrolment records 
        /// for students in specific subjects.
        /// </remarks>
        public bool SaveEnrolment(SubjectEnrolment enrolment)
        {
            using (var db = new Context())
            {
                db.SubjectEnrolments.Add(enrolment);
                return db.SaveChanges() > 0;
            }
        }

        #endregion

        #region Get 
        /// <summary>
        /// Retrieves a specific <see cref="SubjectEnrolment"/> based on subject and career.
        /// </summary>
        /// <param name="subjectId">The ID of the subject.</param>
        /// <param name="careerId">The ID of the career.</param>
        /// <returns>A <see cref="SubjectEnrolment"/> matching the criteria, or <c>null</c> if not found.</returns>
        public SubjectEnrolment? GetEnrolment(int subjectId, int careerId)
        {
            using (var db = new Context())
            {
                return db.SubjectEnrolments
                    .Where(x => x.SubjectId == subjectId && x.Subject.CareerId == careerId)
                    .Include(x => x.Subject)
                    .FirstOrDefault();
            }
        }
        /// Retrieves a list of <see cref="SubjectEnrolment"/> records that match the specified student and subject IDs.
        /// </summary>
        /// <param name="studentId">The ID of the student for whom to retrieve enrolments.</param>
        /// <param name="subjectId">The ID of the subject for which to retrieve enrolments.</param>
        /// <returns>A <see cref="List{SubjectEnrolment}"/> containing enrolments for the specified student and subject.</returns>
        /// <remarks>
        /// This method queries the <see cref="SubjectEnrolment"/> entities in the database that have a matching 
        /// <paramref name="studentId"/> and <paramref name="subjectId"/>. It is intended to retrieve all previous 
        /// enrolments of a student for a specific subject.
        /// </remarks>
        public List<SubjectEnrolment> GetEnrolmentsByStudentAndSubject(int studentId, int subjectId)
        {
            using (var db = new Context())
            {
                return db.SubjectEnrolments
                    .Where(x => x.StudentId == studentId && x.SubjectId == subjectId)
                    .ToList();
            }
        }

        public List<SubjectEnrolment> GetSubjectEnrolmentsBySubjectAndYear(int subjectId, int year)
        {
            using (var db = new Context())
            {
                return db.SubjectEnrolments
                    .Where(x => x.SubjectId == subjectId && x.Year == year)
                    .OrderBy(x => !x.Presential)
                    .ThenBy(x => x.Student.User.LastName)
                    .Include(x => x.Student)
                    .Include(x => x.Student.User)
                    .ToList();
            }
        }

        public List<int> GetEnrolmentYears(int subjectId)
        {
            using (var db = new Context())
            {
                return db.SubjectEnrolments
                         .Where(x => x.SubjectId == subjectId)
                         .Select(x => x.Year)
                         .Distinct()
                         .ToList();
            }
        }
        #endregion

        #region Delete 
        /// <summary>
        /// Deletes a <see cref="SubjectEnrolment"/> record from the database based on the specified enrolment ID.
        /// </summary>
        /// <param name="enrolId">The ID of the enrolment to be deleted.</param>
        /// <returns><c>true</c> if the enrolment was deleted successfully; otherwise, <c>false</c>.</returns>
        /// <remarks>
        /// This method removes a <see cref="SubjectEnrolment"/> entity from the database by creating a new instance 
        /// with the specified <paramref name="enrolId"/> and calling the <c>Remove</c> method. The changes are committed 
        /// by calling <c>SaveChanges</c>. It is intended for permanently deleting enrolment records.
        /// </remarks>
        public bool DeleteEnrolment(int enrolId)
        {
            using (var db = new Context())
            {
                db.SubjectEnrolments.Remove(new SubjectEnrolment() { Id = enrolId });
                return db.SaveChanges() > 0;
            }
        }

        #endregion



    }
}
