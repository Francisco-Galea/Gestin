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
    public class CareerDao
    {
        public CareerDao() { }

        #region Loaders

        /// <summary>
        /// Loads all careers from the database, ordered by name.
        /// </summary>
        /// <returns>A list of all careers.</returns>
        public List<Career> loadCareers()
        {
            try
            {
                using (var db = new Context())
                {
                    var result = db.Careers.OrderBy(x => x.Name).ToList();
                    return result;
                }
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Loads all active careers from the database, ordered by name.
        /// </summary>
        /// <returns>A list of active careers.</returns>
        public List<Career> loadCareersActive()
        {
            try
            {
                using (var db = new Context())
                {
                    var result = db.Careers.Where(x => x.Active).OrderBy(x => x.Name).ToList();
                    return result;
                }
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Loads subjects associated with a specified career by career ID, ordered by year and name.
        /// </summary>
        /// <param name="careerId">The ID of the career.</param>
        /// <returns>A list of subjects associated with the career.</returns>
        public List<Subject> loadSubjectsFromCareer(int careerId)
        {
            try
            {
                using (var db = new Context())
                {
                    return db.Subjects
                    .Where(x => x.CareerId == careerId)
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
        /// Loads subjects associated with a specified career object, ordered by year and name.
        /// </summary>
        /// <param name="selectedCareer">The career object.</param>
        /// <returns>A list of subjects associated with the career.</returns>
        public List<Subject> loadSubjectsFromCareer(object selectedCareer)
        {
            try
            {
                using (var db = new Context())
                {
                    return db.Subjects
                    .Where(x => x.CareerId == ((Career)selectedCareer).Id)
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
        
        #endregion

        #region Career

        /// <summary>
        /// Counts the total number of careers in the database.
        /// </summary>
        /// <returns>The number of careers.</returns>
        public int countCareers()
        {
            using (var db = new Context())
            {
                try
                {
                    return db.Careers.Count();
                }
                catch (SqlException) { throw; }
                catch (Exception) { throw; }
            }
        }

        /// <summary>
        /// Finds a career by its unique ID.
        /// </summary>
        /// <param name="id">The ID of the career.</param>
        /// <returns>The career matching the specified ID.</returns>
        public Career findCareer(int id)
        {
            using (var db = new Context())
            {
                return db.Careers.Where(x => x.Id == id).First();
            }
        }

        /// <summary>
        /// Finds a career by its resolution number.
        /// </summary>
        /// <param name="resolutionNumber">The resolution number of the career.</param>
        /// <returns>The career matching the specified resolution number, or null if not found.</returns>
        public Career? findCareer(string resolutionNumber)
        {
            using (var db = new Context())
            {
                return db.Careers.Where(x => x.Resolution == resolutionNumber).FirstOrDefault();
            }
        }

        /// <summary>
        /// Updates the subject count for all active careers in the database.
        /// </summary>
        public void updateCareerSubjectCount()
        {
            try
            {
                using (var db = new Context())
                {
                    foreach (Career career in loadCareersActive())
                    {
                        if (career != null)
                        {
                            career.TotalAmountSubjects = loadSubjectsFromCareer(career).Count;
                            db.Update(career);
                            db.SaveChanges();
                        }
                    }
                }
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Saves the specified career instance to the database.
        /// </summary>
        /// <param name="newCareer">The career instance to save.</param>
        /// <returns>True if the career is successfully saved; otherwise, false.</returns>
        public bool saveCareer(Career newCareer)
        {
            try
            {
                using (var db = new Context())
                {
                    db.Careers.Add(newCareer);
                    return db.SaveChanges() > 0;
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves changes made to an existing career instance in the database.
        /// </summary>
        /// <param name="career">The career instance with updated attributes.</param>
        /// <returns>True if the changes were successfully saved; otherwise, false.</returns>
        public bool saveCareerChanges(Career career)
        {
            try
            {
                using (var db = new Context())
                {
                    db.Update(career);
                    return db.SaveChanges() > 0;
                }
            }
            catch (SqlException) { throw; }
        }

        #endregion

    }
}
