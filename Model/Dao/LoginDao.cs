using Gestin.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestin.Model.Dao
{
    /// <summary>
    /// Data Access Object for managing login-related database operations.
    /// </summary>
    public class LoginDao
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginDao"/> class.
        /// </summary>
        public LoginDao() { }

        /// <summary>
        /// Retrieves login information associated with a specific email.
        /// Ensures that the login entry contains a non-null salt value.
        /// </summary>
        /// <param name="email">The email associated with the login information.</param>
        /// <returns>
        /// An instance of <see cref="LoginInformation"/> if a matching entry is found; otherwise, <c>null</c>.
        /// </returns>
        public LoginInformation? FindLoginByEmail(string email)
        {
            using (var db = new Context())
            {
                return db.LoginInformations.FirstOrDefault(u => u.Email == email && u.Salt != null);
            }
        }

        /// <summary>
        /// Verifies the existence of a student role based on provided login information.
        /// </summary>
        /// <param name="log">The <see cref="LoginInformation"/> object to check.</param>
        /// <returns>
        /// <c>true</c> if a student exists with the provided login information and is active; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="SqlException">Thrown if a database error occurs.</exception>
        public bool DoesStudentExistByLoginInformation(LoginInformation log)
        {
            try
            {
                using (var db = new Context())
                {
                    return db.Students.Any(x => x.LoginInformationId == log.Id && x.DeletedAt == null);
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        /// <summary>
        /// Checks if a teacher role exists for the given login information.
        /// </summary>
        /// <param name="log">The <see cref="LoginInformation"/> object to check.</param>
        /// <returns>
        /// <c>true</c> if a teacher exists with the specified login information and is active; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="SqlException">Thrown if a database error occurs.</exception>
        public bool DoesTeacherExistByLoginInformation(LoginInformation log)
        {
            try
            {
                using (var db = new Context())
                {
                    return db.Teachers.Any(x => x.LoginInformationId == log.Id && x.DeletedAt == null);
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        /// <summary>
        /// Adds new login information to the database.
        /// </summary>
        /// <param name="log">The <see cref="LoginInformation"/> object containing login details to be added.</param>
        public void AddLoginInformation(LoginInformation log)
        {
            using (var db = new Context())
            {
                db.LoginInformations.Add(log);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Gets strudent by Email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        internal IUserType? getStudentByLoginInformation(string email)
        {
            var loginInformation = FindLoginByEmail(email);

            if (loginInformation == null)
            {
                return null;
            }

            using (var db = new Context())
            {
                return db.Students
                    .Where(x => x.LoginInformationId == loginInformation.Id && x.DeletedAt == null)
                    .Include(x => x.LoginInformation)
                    .Include(x => x.User)
                    .Cast<IUserType>()
                    .FirstOrDefault();
            }
        }
        /// <summary>
        /// Gets teacher by email
        /// </summary>
        /// <param name="email"></param>
        /// <returns>Teacher</returns>
        internal IUserType? getTeacherByLoginInformation(string email)
        {
            var loginInformation = FindLoginByEmail(email);

            if (loginInformation == null)
            {
                return null;
            }

            using (var db = new Context())
            {
                return db.Teachers
                    .Where(x => x.LoginInformationId == loginInformation.Id && x.DeletedAt == null)
                    .Include(x => x.LoginInformation)
                    .Include(x => x.User)
                    .Cast<IUserType>()
                    .FirstOrDefault();
            }
        }
/// <summary>
/// Finds login information by email
/// </summary>
/// <param name="mail"></param>
/// <returns>Login information</returns>
        public LoginInformation? findLoginInformation(string mail)
        {
            try
            {
                using (var db = new Context())
                {
                    return db.LoginInformations.Where(x => x.Email == mail).FirstOrDefault();
                }
            }
            catch (SqlException) { throw; }
        }

    }
}
