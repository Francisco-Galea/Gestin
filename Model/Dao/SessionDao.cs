using Gestin.Controllers;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestin.Model.Dao
{
    internal class SessionDao
    {
        public SessionDao() { }

        /// <summary>
        /// Inserts a new <see cref="SessionToken"/> record into the database.
        /// </summary>
        /// <param name="sessionToken">The <see cref="SessionToken"/> object to be inserted into the database.</param>
        /// <returns>
        /// <c>true</c> if the insertion was successful; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// This method adds a new <see cref="SessionToken"/> entity to the database and commits the changes 
        /// using <c>SaveChanges</c>. Returns <c>true</c> if at least one record is affected.
        /// </remarks>
        public bool InsertSessionToken(SessionToken sessionToken)
        {
            using (var db = new Context())
            {
                db.SessionTokens.Add(sessionToken);
                return db.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// Updates an existing <see cref="SessionToken"/> record in the database.
        /// </summary>
        /// <param name="sessionToken">The <see cref="SessionToken"/> object containing updated information.</param>
        /// <returns>
        /// <c>true</c> if the update was successful; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// This method updates the specified <see cref="SessionToken"/> entity in the database, committing the changes
        /// with <c>SaveChanges</c>. It returns <c>true</c> if the operation affected at least one record.
        /// </remarks>
        public bool UpdateSessionToken(SessionToken sessionToken)
        {
            using (var db = new Context())
            {
                db.SessionTokens.Update(sessionToken);
                return db.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// Verifies if a given session token exists in the database.
        /// </summary>
        /// <param name="sessionToken">The session token string to verify.</param>
        /// <returns>
        /// <c>true</c> if the token exists; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// This method checks the database for the presence of the specified session token. Returns <c>true</c> if found.
        /// </remarks>
        public bool VerifySessionToken(string sessionToken)
        {
            using (var db = new Context())
            {
                var existingToken = db.SessionTokens.Where(x => x.sessionToken == sessionToken).FirstOrDefault();

                return existingToken != null;
            }
        }

        /// <summary>
        /// Closes a session token associated with the specified email address.
        /// </summary>
        /// <param name="email">The email address linked to the session to close.</param>
        /// <remarks>
        /// This method finds the login information for the provided email, and if found, 
        /// calls <see cref="RemoveSessionTokenByEmail"/> to remove the associated session token from the database.
        /// </remarks>
        public void closeSessionTokenByEmail(string email)
        {
            using (var db = new Context())
            {
                LoginInformation? login = loginController.getInstance().findLoginInformation(email);

                if (login != null)
                {
                    RemoveSessionTokenByEmail(db, login);
                }
            }
        }

        /// <summary>
        /// Removes a <see cref="SessionToken"/> record associated with a given <see cref="LoginInformation"/> object.
        /// </summary>
        /// <param name="db">The database context to use for the operation.</param>
        /// <param name="login">The <see cref="LoginInformation"/> object related to the session token to remove.</param>
        /// <remarks>
        /// This method removes the session token record associated with the provided login information and commits the change.
        /// </remarks>
        public void RemoveSessionTokenByEmail(Context db, LoginInformation login)
        {
            SessionToken? sessionToken = db.SessionTokens.Where(x => x.LoginInformationId == login.Id).FirstOrDefault();
            if (sessionToken != null)
            {
                db.SessionTokens.Remove(sessionToken);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Finds the <see cref="LoginInformation"/> associated with a specific session token.
        /// </summary>
        /// <param name="sessionToken">The session token to search by.</param>
        /// <returns>
        /// The <see cref="LoginInformation"/> if found; otherwise, <c>null</c>.
        /// </returns>
        /// <remarks>
        /// This method retrieves the login information linked to a given session token.
        /// </remarks>
        public LoginInformation? findLoginInformationBySessionToken(string sessionToken)
        {
            using (var db = new Context())
            {
                return db.SessionTokens.Where(x => x.sessionToken == sessionToken).Select(x => x.LoginInformation).FirstOrDefault();
            }
        }

        /// <summary>
        /// Finds a <see cref="SessionToken"/> associated with the specified <see cref="LoginInformation"/>.
        /// </summary>
        /// <param name="login">The <see cref="LoginInformation"/> to search by.</param>
        /// <returns>
        /// The <see cref="SessionToken"/> if found; otherwise, <c>null</c>.
        /// </returns>
        /// <remarks>
        /// This method retrieves a session token associated with a specific login information record.
        /// </remarks>
        public SessionToken? findSessionTokenByLoginInformation(LoginInformation? login)
        {
            using (var db = new Context())
            {
                return db.SessionTokens.Where(x => x.LoginInformationId == login.Id).FirstOrDefault();
            }
        }

        /// <summary>
        /// Closes a session by removing a session token from the database using the token string.
        /// </summary>
        /// <param name="token">The session token string to remove.</param>
        /// <remarks>
        /// This method finds and removes the session token that matches the provided token string.
        /// </remarks>
        public void closeSessionTokenByToken(string token)
        {
            using (var db = new Context())
            {
                SessionToken existingtoken = db.SessionTokens.Where(x => x.sessionToken == token).First();
                db.SessionTokens.Remove(existingtoken);
                db.SaveChanges();
            }
        }
    }
}

