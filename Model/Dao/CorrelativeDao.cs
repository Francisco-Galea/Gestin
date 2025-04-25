using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestin.Model.Dao
{
    public class CorrelativeDao
    {
        public CorrelativeDao() { }

        #region Loaders

        /// <summary>
        /// Loads all correlatives from the database.
        /// </summary>
        /// <returns>A list of all correlatives.</returns>
        public List<Correlative> loadCorrelatives()
        {
            try
            {
                using (var db = new Context())
                {
                    var result = db.Correlatives.ToList();
                    return result;
                }
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Loads future correlatives subjects for a given subject.
        /// </summary>
        /// <param name="subject">The subject to find future correlatives for.</param>
        /// <returns>A list of future correlatives subjects.</returns>
        public List<Subject> loadFutureCorrelativesSubjects(Subject subject)
        {
            try
            {
                using (var db = new Context())
                {
                    var result = db.Correlatives.Where(x => x.CorrelativeSubjectId == subject.Id).Select(x => x.Subject).ToList();
                    return result;
                }
            }
            catch (SqlException) { throw; }
        }
        #endregion

        #region Correlatives

        /// <summary>
        /// Removes a correlative from the database by its ID.
        /// </summary>
        /// <param name="id">The ID of the correlative to remove.</param>
        public void removeCorrelative(int id)
        {
            Correlative existingCorrelative = findCorrelative(id);
            try
            {
                using (var db = new Context())
                {
                    db.Remove(existingCorrelative);
                    db.SaveChanges();
                }
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Finds a correlative by the provided object.
        /// </summary>
        /// <param name="objectCorrelative">The correlative object to find.</param>
        /// <returns>The found correlative.</returns>
        public Correlative findCorrelative(object objectCorrelative)
        {
            Correlative correlative = (Correlative)objectCorrelative;
            using (var db = new Context())
            {
                return db.Correlatives
                    .Where(x => x.Id == correlative.Id)
                    .First();
            }
        }

        /// <summary>
        /// Finds a correlative by its ID.
        /// </summary>
        /// <param name="IDcorrelative">The ID of the correlative to find.</param>
        /// <returns>The found correlative.</returns>
        public Correlative findCorrelative(int IDcorrelative)
        {
            using (var db = new Context())
            {
                return db.Correlatives
                    .Where(x => x.Id == IDcorrelative)
                    .First();
            }
        }

        /// <summary>
        /// Gets a list of subjects that are correlatives of the provided subject.
        /// </summary>
        /// <param name="objectSubject">The subject object to get correlatives from.</param>
        /// <returns>A list of subjects that are correlatives.</returns>
        public List<Subject> getSubjectsFromCorrelatives(object objectSubject)
        {
            Subject selectedSubject = (Subject)objectSubject;
            List<Correlative> correlatives = getCorrelativesFromSubject(selectedSubject);

            return correlatives.Select(x => x.CorrelativeSubject).ToList();
        }

        /// <summary>
        /// Gets a list of correlatives from the given subject.
        /// </summary>
        /// <param name="existingsubject">The existing subject to find correlatives for.</param>
        /// <returns>A list of correlatives for the subject.</returns>
        public List<Correlative> getCorrelativesFromSubject(Subject existingsubject)
        {
            try
            {
                using (var db = new Context())
                {
                    return db.Correlatives
                    .Where(x => x.SubjectId == existingsubject.Id)
                    .Include(x => x.Subject)
                    .Include(x => x.CorrelativeSubject)
                    .ToList();
                }
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Gets a list of correlatives from the subject ID.
        /// </summary>
        /// <param name="IdSubject">The ID of the subject to get correlatives from.</param>
        /// <returns>A list of correlatives for the subject ID.</returns>
        public List<Correlative> getCorrelativesFromSubject(int IdSubject)
        {
            try
            {
                using (var db = new Context())
                {
                    return db.Correlatives
                   .Where(x => x.SubjectId == IdSubject)
                   .Include(x => x.Subject)
                   .Include(x => x.CorrelativeSubject)
                   .ToList();
                }
            }
            catch (SqlException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Saves the specified correlative instance to the database.
        /// </summary>
        /// <param name="correlative">The correlative instance to save.</param>
        /// <exception cref="SqlException">Thrown if an error occurs while saving the correlative to the database.</exception>
        public void saveCorrelative(Correlative correlative)
        {
            try
            {
                using (var db = new Context())
                {
                    db.Correlatives.Add(correlative);
                    db.SaveChanges();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }
        #endregion
    }
}
