using Gestin.Controllers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestin.Model.Dao
{
    public class SubjectDao
    {
        CareerDao careerDao = new CareerDao();
        careerController careerController;
        public SubjectDao() { }

        #region Loaders

        /// <summary>
        /// Loads all subjects from the database, ordered by name.
        /// </summary>
        /// <returns>A list of all subjects.</returns>
        public List<Subject> loadSubjects()
        {
            try
            {
                using (var db = new Context())
                {
                    var result = db.Subjects.OrderBy(x => x.Name).ToList();
                    return result;
                }
            }
            catch (SqlException) { throw; }
        }

        public List<int> loadYearsInCareer()
        {
            try
            {
                using (var db = new Context())
                {
                    var years = db.Subjects
                                  .GroupBy(s => s.YearInCareer)
                                  .Select(g => g.Key)
                                  .OrderBy(year => year)
                                  .ToList();
                    return years;
                }
            }
            catch (SqlException){ throw; }
        }
        #endregion

        #region Subject

        /// <summary>
        /// Counts the total number of subjects in the database.
        /// </summary>
        /// <returns>The count of all subjects.</returns>
        public int countSubjects()
        {
            try
            {
                using (var db = new Context())
                {
                    return db.Subjects.Count();
                }
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Counts the number of subjects associated with a specific career.
        /// </summary>
        /// <param name="careerId">The ID of the career to filter subjects.</param>
        /// <returns>The count of subjects related to the specified career.</returns>
        public int getSubjectsFromCareerCount(int careerId)
        {
            Career career = careerDao.findCareer(careerId);
            try
            {
                using (var db = new Context())
                {
                    return db.Subjects
                        .Where(x => x.CareerId == career.Id)
                        .Where(x => !x.DeletedAt.HasValue)
                        .Count();
                }
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Counts the number of subjects associated with a specific career.
        /// </summary>
        /// <param name="careerObject">The career object to filter subjects.</param>
        /// <returns>The count of subjects related to the specified career.</returns>
        public int getSubjectsFromCareerCount(object careerObject)
        {
            Career career = (Career)careerObject;
            try
            {
                using (var db = new Context())
                {
                    return db.Subjects
                        .Where(x => x.CareerId == career.Id)
                        .Where(x => !x.DeletedAt.HasValue)
                        .Count();
                }
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Counts the number of subjects from career enrolment.
        /// </summary>
        /// <param name="selectedCareer">The selected career object to filter subjects.</param>
        /// <returns>The count of subjects related to the specified career enrolment.</returns>
        public int getSubjectCountFromCareerEnrolment(object selectedCareer)
        {
            try
            {
                using (var db = new Context())
                {
                    return db.Subjects
                        .Where(x => x.CareerId == ((CareerEnrolment)selectedCareer).CareerId)
                        .Where(x => !x.DeletedAt.HasValue)
                        .Count();
                }
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Finds a subject by its ID.
        /// </summary>
        /// <param name="subjectID">The ID of the subject to find.</param>
        /// <returns>The subject matching the specified ID.</returns>
        public Subject findSubject(int subjectID)
        {
            using (var db = new Context())
            {
                return db.Subjects.Where(x => x.Id == subjectID).First();
            }
        }

        /// <summary>
        /// Finds a subject by its name and career ID.
        /// </summary>
        /// <param name="subjectName">The name of the subject to find.</param>
        /// <param name="careerId">The ID of the career to filter the subject.</param>
        /// <returns>The subject matching the specified name and career ID.</returns>
        public Subject findSubject(string subjectName, int careerId)
        {
            using (var db = new Context())
            {
                return db.Subjects.Where(x => x.Name == subjectName && x.CareerId == careerId).First();
            }
        }

        /// <summary>
        /// Gets a list of subjects associated with a specific career.
        /// </summary>
        /// <param name="careerid">The ID of the career to filter subjects.</param>
        /// <returns>A list of subjects related to the specified career.</returns>
        public List<Subject> getSubjectsFromCareer(int careerid)
        {
            try
            {
                using (var db = new Context())
                {
                    return db.Subjects
                        .Where(x => x.CareerId == careerid)
                        .Where(x => !x.DeletedAt.HasValue)
                        .OrderBy(x => x.YearInCareer)
                        .ThenBy(x => x.Name)
                        .Include(x => x.Career)
                        .ToList();
                }
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Gets a list of subjects associated with a specific career.
        /// </summary>
        /// <param name="career">The career object to filter subjects.</param>
        /// <returns>A list of subjects related to the specified career.</returns>
        public List<Subject> getSubjectsFromCareer(object career)
        {
            Career thisCareer = (Career)career;
            try
            {
                using (var db = new Context())
                {
                    return db.Subjects
                        .Where(x => x.CareerId == thisCareer.Id)
                        .Where(x => !x.DeletedAt.HasValue)
                        .OrderBy(x => x.YearInCareer)
                        .ThenBy(x => x.Name)
                        .Include(x => x.Career)
                        .ToList();
                }
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Gets a list of subjects associated with a specific career and year in career.
        /// </summary>
        /// <param name="careerid">The ID of the career to filter subjects.</param>
        /// <param name="yearInCarrer">The year in career to filter subjects.</param>
        /// <returns>A list of subjects related to the specified career and year.</returns>
        public List<Subject> getSubjectsFromCareerAndYearInCarrer(int careerid, int yearInCarrer)
        {
            try
            {
                using (var db = new Context())
                {
                    return db.Subjects
                        .Where(x => x.CareerId == careerid)
                        .Where(x => x.YearInCareer == yearInCarrer)
                        .Where(x => !x.DeletedAt.HasValue)
                        .Include(x => x.Career)
                        .ToList();
                }
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Gets a list of subjects associated with a specific career and year.
        /// </summary>
        /// <param name="selectedCareer">The selected career object to filter subjects.</param>
        /// <param name="year">The year to filter subjects.</param>
        /// <returns>A list of subjects related to the specified career and year.</returns>
        public List<Subject> getSubjectsFromCareerByYear(object selectedCareer, int year)
        {
            try
            {
                using (var db = new Context())
                {
                    return db.Subjects
                        .Where(x => x.Career.Id == ((Career)selectedCareer).Id)
                        .Where(x => !x.DeletedAt.HasValue && x.YearInCareer == year)
                        .Include(x => x.Career)
                        .ToList();
                }
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Saves the updated information of an existing subject in the database.
        /// </summary>
        /// <param name="subject">The Subject object with updated details to save.</param>
        /// <returns>Returns true if the subject's information is successfully updated; otherwise, false.</returns>
        public bool saveUpdatedSubject(Subject subject)
        {
            try
            {
                using (var db = new Context())
                {
                    db.Update(subject);
                    return db.SaveChanges() > 0;
                }
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Saves a new subject to the database.
        /// </summary>
        /// <param name="subject">The Subject object to be added to the database.</param>
        /// <returns>Returns true if the subject is successfully saved; otherwise, false.</returns>
        public bool saveNewSubject(Subject subject)
        {
            try
            {
                using (var db = new Context())
                {
                    db.Subjects.Add(subject);
                    return db.SaveChanges() > 0;
                }
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Checks if a subject with the same name already exists within the specified career.
        /// </summary>
        /// <param name="career">The career to check for duplicate subject names.</param>
        /// <param name="name">The name of the subject to check for duplication.</param>
        /// <returns>True if the subject already exists, otherwise false.</returns>
        public bool checkDuplicateSubjectName(Career career, string name)
        {
            using (var db = new Context())
            {
                bool exists = db.Subjects.Any(s => s.CareerId == career.Id && s.Name == name);
                if (exists)
                {
                    MessageBox.Show("Esa materia ya existe en la carrera actual.", "Materia Duplicada",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return exists;
            }
        }

        /// <summary>
        /// Updates the total count of subjects for a specific career in the database.
        /// </summary>
        /// <param name="careerId">The unique identifier of the career to update.</param>
        /// <returns>
        /// True if the update operation is successful and the changes are saved to the database;
        /// otherwise, false.
        /// </returns>
        public bool updateCareerSubjectCount(int careerId)
        {
            try
            {
                using (var db = new Context())
                {
                    var thisCareer = careerController.findCareer(careerId);
                    if (thisCareer != null)
                    {
                        thisCareer.TotalAmountSubjects = getSubjectsFromCareer(careerId).Count;
                        db.Update(thisCareer);
                        return db.SaveChanges() > 0;
                    }
                }
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }

            return false;
        }

        #endregion
    }
}