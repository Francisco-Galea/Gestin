using Gestin.Controllers;
using Gestin.Exceptions;
using Gestin.Properties;
using Gestin.UI.Custom;
using Gestin.Validators;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestin.Model.Dao
{
    public class TeacherSubjectDao
    {
        sessionController sessionController = sessionController.getInstance();
        public TeacherSubjectDao() { }

        #region Loaders

        /// <summary>
        /// Loads all teacher-subject associations from the database.
        /// </summary>
        /// <returns>List of all teacher-subject associations.</returns>
        public List<TeacherSubject> loadTeachersSubjects()
        {
            try
            {
                using (var db = new Context())
                {
                    var result = db.TeacherSubjects.ToList();
                    return result;
                }
            }
            catch (SqlException) { throw; }
        }

        #endregion

        #region TeacherSubject

        /// <summary>
        /// Retrieves all active teacher charges from the database.
        /// </summary>
        /// <returns>List of active teacher charges.</returns>
        public List<TeacherSubject> activeTeacherCharges()
        {
            try
            {
                using (var db = new Context())
                {
                    return db.TeacherSubjects
                    .Where(x => x.Active)
                    .ToList();
                }
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Deactivates a teacher's charge for a specific subject.
        /// </summary>
        /// <param name="currentActive">The TeacherSubject object representing the current active charge to be deactivated.</param>
        /// <returns>Returns true if the charge was successfully deactivated; otherwise, false.</returns>
        public bool deactivateTeacherCharge(TeacherSubject currentActive)
        {
            currentActive.Active = false;
            currentActive.LastModificationBy = sessionController.getSessionedUserData();

            using (var db = new Context())
            {
                try
                {
                    db.Update(currentActive);
                    return db.SaveChanges() > 0 ? true : false;
                }
                catch (SqlException) { throw; }
                catch (Exception) { throw; }
            }
        }

        /// <summary>
        /// Finds a specific teacher charge by a given teacher charge object.
        /// </summary>
        /// <param name="objectTeacherCharge">The teacher charge to search for.</param>
        /// <returns>The matching teacher charge, or null if not found.</returns>
        public TeacherSubject? findTeacherCharge(object objectTeacherCharge)
        {
            TeacherSubject charge = (TeacherSubject)objectTeacherCharge;

            try
            {
                using (var db = new Context())
                {
                    return db.TeacherSubjects
                    .Where(x => x.Id == charge.Id)
                    .FirstOrDefault();
                }
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Finds a specific teacher charge by its ID.
        /// </summary>
        /// <param name="teacherchargeID">The ID of the teacher charge to find.</param>
        /// <returns>The matching teacher charge.</returns>
        public TeacherSubject findTeacherCharge(int teacherchargeID)
        {
            using (var db = new Context())
            {
                return db.TeacherSubjects
                    .Where(x => x.Id == teacherchargeID)
                    .First();
            }
        }

        /// <summary>
        /// Finds a specific teacher charge by given teacher and subject objects.
        /// </summary>
        /// <param name="objectTeacherCharge">The teacher charge to find.</param>
        /// <param name="objectSubject">The subject related to the teacher charge.</param>
        /// <returns>The matching teacher charge.</returns>
        public TeacherSubject findTeacherCharge(object objectTeacherCharge, object objectSubject)
        {
            TeacherSubject existingCharge = (TeacherSubject)objectTeacherCharge;
            Subject existingSubject = (Subject)objectSubject;

            using (var db = new Context())
            {
                return db.TeacherSubjects.First(charge => existingSubject.Id == charge.SubjectId && existingCharge.TeacherId == charge.TeacherId);
            }
        }

        /// <summary>
        /// Retrieves all active teacher-subject associations for a specific teacher.
        /// </summary>
        /// <param name="teacher">The teacher to find associations for.</param>
        /// <returns>List of active teacher-subject associations for the teacher.</returns>
        public List<TeacherSubject> getTeacherSubjects(Teacher teacher)
        {
            try
            {
                using (var db = new Context())
                {
                    var result = db.TeacherSubjects.Where(x => x.TeacherId == teacher.Id && x.Active).ToList();
                    return result;
                }
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Retrieves all active teacher charges for a given subject.
        /// </summary>
        /// <param name="objectSubject">The subject to find teachers for.</param>
        /// <returns>List of teachers assigned to the subject.</returns>
        public List<TeacherSubject> getTeachersFromSubject(object objectSubject)
        {
            Subject existingsubject = (Subject)objectSubject;

            try
            {
                using (var db = new Context())
                {
                    return db.TeacherSubjects
                    .Where(x => x.SubjectId == existingsubject.Id && x.Active)
                    .Include(x => x.Subject)
                    .Include(x => x.Teacher.User)
                    .ToList();
                }
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Retrieves all teacher charges (both active and inactive) for a given subject.
        /// </summary>
        /// <param name="objectSubject">The subject to find teachers for.</param>
        /// <returns>List of all teacher charges for the subject.</returns>
        public List<TeacherSubject> getAllTeachersFromSubject(object objectSubject)
        {
            Subject existingsubject = (Subject)objectSubject;

            try
            {
                using (var db = new Context())
                {
                    return db.TeacherSubjects
                    .Where(x => x.SubjectId == existingsubject.Id)
                    .Include(x => x.Subject)
                    .Include(x => x.Teacher.User)
                    .ToList();
                }
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Retrieves all active teacher charges for a given subject by subject ID.
        /// </summary>
        /// <param name="subjectId">The ID of the subject.</param>
        /// <returns>List of active teacher charges for the subject.</returns>
        public List<TeacherSubject> getTeachersFromSubject(int subjectId)
        {
            try
            {
                using (var db = new Context())
                {
                    return db.TeacherSubjects
                    .Where(x => x.SubjectId == subjectId)
                    .Include(x => x.Teacher.User)
                    .ToList();
                }
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Retrieves the active teacher charge for a subject if not a substitute.
        /// </summary>
        /// <param name="existingsubject">The subject to find the teacher charge for.</param>
        /// <returns>The active teacher charge, or null if none found.</returns>
        public TeacherSubject? getActiveNonSubstituteCharge(Subject existingsubject)
        {
            try
            {
                using (var db = new Context())
                {
                    return db.TeacherSubjects
                    .Where(x => x.SubjectId == existingsubject.Id && !x.Condition.Equals("Suplente") && x.Active)
                    .Include(x => x.Subject)
                    .Include(x => x.Teacher.User)
                    .FirstOrDefault();
                }
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Retrieves all active teacher charges for a specific subject by subject object.
        /// </summary>
        /// <param name="subject">The subject to find active teacher charges for.</param>
        /// <returns>List of active teacher charges.</returns>
        public List<TeacherSubject> getAllActiveTeacherCharges(object subject)
        {
            Subject subject1 = (Subject)subject;
            try
            {
                using (var db = new Context())
                {
                    return db.TeacherSubjects
                    .Where(x => x.SubjectId == subject1.Id && x.Active)
                    .Include(x => x.Subject)
                    .Include(x => x.Teacher)
                    .Include(x => x.Teacher.User)
                    .ToList();
                }
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Retrieves all active teacher charges by subject ID.
        /// </summary>
        /// <param name="idSubject">The ID of the subject.</param>
        /// <returns>List of active teacher charges for the subject.</returns>
        public List<TeacherSubject> getAllActiveTeacherChargesBySubject(int idSubject)
        {
            try
            {
                using (var db = new Context())
                {
                    return db.TeacherSubjects
                    .Where(x => x.SubjectId == idSubject && x.Active)
                    .Include(x => x.Subject)
                    .Include(x => x.Teacher)
                    .Include(x => x.Teacher.User)
                    .ToList();
                }
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Retrieves all active teacher charges by teacher ID.
        /// </summary>
        /// <param name="idTeacher">The ID of the teacher.</param>
        /// <returns>List of active teacher charges for the teacher.</returns>
        public List<TeacherSubject> getAllActiveTeacherChargesByTeacher(int idTeacher)
        {
            try
            {
                using (var db = new Context())
                {
                    return db.TeacherSubjects
                    .Where(x => x.TeacherId == idTeacher && x.Active)
                    .Include(x => x.Subject)
                    .Include(x => x.Teacher)
                    .Include(x => x.Teacher.User)
                    .ToList();
                }
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Retrieves all active teacher charges for a specific subject, excluding substitutes.
        /// </summary>
        /// <param name="existingSubject">The subject for which to retrieve active non-substitute teacher charges.</param>
        /// <returns>
        /// A list of active teacher charges for the specified subject, where the condition is not "Suplente".
        /// </returns>
        public List<TeacherSubject> getAllActiveNonSubstituteTeacherCharges(Subject existingSubject)
        {
            try
            {
                using (var db = new Context())
                {
                    return db.TeacherSubjects
                    .Where(x => x.SubjectId == existingSubject.Id && !x.Condition.Equals("Suplente") && x.Active)
                    .Include(x => x.Subject)
                    .Include(x => x.Teacher.User)
                    .ToList();
                }
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }

        }

        /// <summary>
        /// Deactivates a teacher's active charge for a given subject if the condition is not "Suplente."
        /// </summary>
        /// <param name="id">The ID of the teacher-subject charge to deactivate.</param>
        /// <param name="condition">The condition of the charge (e.g., "Titular" or "Provisional").</param>

        public void deactivateTeacherCharge(int id, string condition)
        {
            if (!condition.Equals("Suplente"))
            {
                TeacherSubject existingCharge = findTeacherCharge(id);
                existingCharge.Active = false;
                existingCharge.LastModificationBy = sessionController.getSessionedUserData();

                try
                {
                    using (var db = new Context())
                    {
                        db.Update(existingCharge);
                        db.SaveChanges();
                    }
                }
                catch (SqlException) { throw; }
                catch (Exception) { throw; }
            }
        }

        /// <summary>
        /// Deactivates an existing teacher-subject charge if it is of type "Suplente."
        /// </summary>
        /// <param name="currentActive">The current active teacher-subject charge to deactivate.</param>
        /// <returns>
        /// A boolean value indicating whether the deactivation was successful.
        /// </returns>
        /// <remarks>
        /// Displays an error message if the charge is not of type "Suplente."
        /// </remarks>
        public bool deactivateTeacherCharge(object currentActive)
        {
            TeacherSubject existingCharge = (TeacherSubject)currentActive;
            existingCharge.Active = false;
            existingCharge.LastModificationBy = sessionController.getSessionedUserData();

            if (!existingCharge.Condition.Equals("Suplente"))
            {
                new MessageBoxDarkMode("Solamente se puede desactivar suplentes", "Error", "Ok", Resources.Error, true);
                return false;
            }

            try
            {
                using (var db = new Context())
                {
                    db.Update(existingCharge);
                    return db.SaveChanges() > 0;
                }
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Updates the start and end dates of a teacher-subject charge.
        /// </summary>
        /// <param name="selectedCharge">The teacher-subject charge to update.</param>
        /// <param name="datesince">The new start date of the charge.</param>
        /// <param name="dateuntil">The new end date of the charge.</param>
        public void changeChargeDates(object selectedCharge, DateTime datesince, DateTime dateuntil)
        {
            TeacherSubject existingCharge = (TeacherSubject)selectedCharge;
            existingCharge.UpdatedAt = DateTime.Now;
            existingCharge.LastModificationBy = sessionController.getSessionedUserData();

            try
            {
                if (!generalValidator.areDatesValid(datesince, dateuntil))
                {
                    throw new InvalidDateException();
                }
                else
                {
                    existingCharge.DateSince = datesince;
                    existingCharge.DateUntil = dateuntil;
                }

                using (var db = new Context())
                {
                    db.Update(existingCharge);
                    db.SaveChanges();
                }
            }
            catch (SqlException) { throw; }
            catch (InvalidDateException) { new MessageBoxDarkMode("La fecha de Cese debe ser posterior a la fecha de Inicio", "Error", "Ok", Resources.Error, true); }
            catch (Exception) { throw; }
        }


        #endregion
    }
}
