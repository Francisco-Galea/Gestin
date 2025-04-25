using Gestin.Interfaces;
using Gestin.LocalFiles;
using Gestin.Model;
using Gestin.Model.Dao;
using Gestin.Model.Model_Internal;
using Gestin.Validators;
using Microsoft.Data.SqlClient;

namespace Gestin.Controllers
{
    internal class sessionController
    {
        // Instances of other controllers necessary for session handling
        loginController loginController = loginController.getInstance();
        SessionDao sessionDao = new SessionDao();

        #region Singleton

        // Private constructor to implement the Singleton pattern
        private sessionController() { }

        // Unique instance of the session controller
        private static sessionController? Instance;

        // Method to get the unique instance of the session controller
        public static sessionController getInstance()
        {
            if (Instance == null)
            {
                Instance = new sessionController();
            }
            return Instance;
        }

        #endregion

        #region Session

        /// <summary>
        /// Creates a new user session using the provided email and user type.
        /// </summary>
        /// <param name="mail">The email of the user.</param>
        /// <param name="userType">The type of user (e.g., "Admin", "Student").</param>
        /// <returns>True if the session was successfully created; otherwise, false.</returns>
        public bool createUserSession(string mail, string userType)
        {
            if (LocalSecurity.Instance.createUserCredentials(userType, mail))
            {
                return setSessionedUser(mail, userType);
            }
            return false;
        }

        /// <summary>
        /// Sets the current user in the session using the provided email and user type.
        /// </summary>
        /// <param name="email">The email of the user.</param>
        /// <param name="userType">The type of user.</param>
        /// <returns>True if the user was set successfully; otherwise, false.</returns>
        public bool setSessionedUser(string email, string userType)
        {
            SessionedUser sessionedUser = SessionedUser.Instance;

            Type? concreteType = UserTypeValidator.getTypeConcrete(userType);
            IUserType? abstractType = loginController.getUserTypeByLoginInformation(email, concreteType);

            if (abstractType != null)
            {
                sessionedUser.setSessionedUser(abstractType);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Gets the user currently in session.
        /// </summary>
        /// <returns>The IUserType object of the sessioned user, or null if there is none.</returns>
        public IUserType? getSessionedUser()
        {
            SessionedUser sessionedUser = SessionedUser.Instance;
            return sessionedUser.getSessionedUser();
        }

        /// <summary>
        /// Gets the data of the user in session as a string.
        /// </summary>
        /// <returns>The user data in session as a string.</returns>
        public string getSessionedUserData()
        {
            SessionedUser sessionedUser = SessionedUser.Instance;
            return sessionedUser.getSessionedUserData();
        }

        /// <summary>
        /// Gets the email of the user in session.
        /// </summary>
        /// <returns>The email of the sessioned user, or null if there is none.</returns>
        public string? getSessionedUserEmail()
        {
            SessionedUser sessionedUser = SessionedUser.Instance;
            return sessionedUser.getSessionedUserEmail();
        }

        /// <summary>
        /// Checks if there is an active user session.
        /// </summary>
        /// <returns>True if there is an active session; otherwise, false.</returns>
        public bool checkExistingUserSession()
        {
            SessionedUser sessionedUser = SessionedUser.Instance;
            return sessionedUser.checkExistingUserSession();
        }

        /// <summary>
        /// Checks if the session time has exceeded the allowed limit.
        /// </summary>
        /// <param name="datesince">The start date of the session.</param>
        /// <param name="dateuntil">The date until which the check is made.</param>
        /// <returns>True if the session time has exceeded the limit; otherwise, false.</returns>
        private bool IsSessionTimeSurpassed(DateTime datesince, DateTime dateuntil)
        {
            DateTime modifiedSince = InactiveTime.maxTimeLoggedIn(datesince);
            return dateuntil >= modifiedSince;
        }

        /// <summary>
        /// Checks if a change in the sessioned user has been detected.
        /// </summary>
        /// <param name="user">The user object to compare.</param>
        /// <returns>True if a change in the user is detected; otherwise, false.</returns>
        internal bool IsSessionedUserChangeDetected(object user)
        {
            string? sessionedUserEmail = getSessionedUserEmail();
            List<string> userEmails = combinedController.getAllUserEmails(user);

            return !string.IsNullOrEmpty(sessionedUserEmail) && !userEmails.Contains(sessionedUserEmail);
        }

        /// <summary>
        /// Updates the user session by reading the stored credential data.
        /// </summary>
        /// <returns>True if the session was successfully updated; otherwise, false.</returns>
        internal bool updateSession()
        {
            List<string> filedata = LocalSecurity.Instance.readUserCredentials();
            bool returnValue = false;

            try
            {
                if (filedata.Any())
                {
                    string token = filedata[0];
                    string role = filedata[1];
                    DateTime fileDateTime = DateTime.Parse(filedata[2]);
                    LoginInformation? login = findLoginInformationBySessionToken(token);
                    returnValue = ValidUserToken(token, fileDateTime, login, role);
                }
                else { throw new Exception(); }
            }
            catch (Exception) { LocalSecurity.Instance.deleteUserCredentialsFile(); }
            return returnValue;
        }

        /// <summary>
        /// Verifies the validity of the session token and sets the user in session if valid.
        /// </summary>
        /// <param name="token">The session token.</param>
        /// <param name="fileDateTime">The creation date and time of the credentials file.</param>
        /// <param name="login">The associated login information.</param>
        /// <param name="role">The user's role.</param>
        /// <returns>True if the token is valid; otherwise, false.</returns>
        internal bool ValidUserToken(string token, DateTime fileDateTime, LoginInformation? login, string role)
        {
            bool validToken = isSessionValid(token, fileDateTime);
            bool returnValue = false;
            if (login != null)
            {
                setSessionedUser(login.Email, role);
                returnValue = true;
            }
            else
            {
                closeUserSession(login);
            }
            return returnValue;
        }

        /// <summary>
        /// Verifies the user session by checking the existence of the credential file.
        /// </summary>
        /// <returns>True if the session is valid; otherwise, false.</returns>
        internal bool verifySession()
        {
            try
            {
                if (File.Exists(LocalDirectory.userCredentialsFilePath()))
                {
                    return updateSession();
                }
                return false;
            }
            catch (FileNotFoundException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Checks if the session token is valid based on its existence and duration.
        /// </summary>
        /// <param name="token">The session token to check.</param>
        /// <param name="fileDateTime">The creation date and time of the token.</param>
        /// <returns>True if the token is valid; otherwise, false.</returns>
        private bool isSessionValid(string token, DateTime fileDateTime)
        {
            return verifySessionToken(token) && !IsSessionTimeSurpassed(fileDateTime, DateTime.Now);
        }

        /// <summary>
        /// Closes the user session using the login information.
        /// </summary>
        /// <param name="log">The user's login information.</param>
        internal void closeUserSession(LoginInformation? log)
        {
            try
            {
                string filePath = LocalDirectory.userCredentialsFilePath();

                checkFileExists(filePath);

                closeSessionTokenByEmail(log != null ? log.Email : "");
                File.Delete(filePath);
                SessionedUser.Instance.nullifySession();
            }
            catch (FileNotFoundException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Closes the user session using the user's email.
        /// </summary>
        /// <param name="email">The user's email.</param>
        internal void closeUserSession(string email)
        {
            try
            {
                string filePath = LocalDirectory.userCredentialsFilePath();

                checkFileExists(filePath);

                closeSessionTokenByEmail(email);
                File.Delete(filePath);
                SessionedUser.Instance.nullifySession();
            }
            catch (FileNotFoundException) { throw; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Checks if the credential file exists.
        /// </summary>
        /// <param name="filePath">The path of the credential file.</param>
        /// <exception cref="FileNotFoundException">If the file does not exist.</exception>
        internal void checkFileExists(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException();
            }
        }

        /// <summary>
        /// Manages the session token, creating or updating it as necessary.
        /// </summary>
        /// <param name="token">The session token.</param>
        /// <param name="email">The user's email.</param>
        /// <returns>True if the token was handled correctly; otherwise, false.</returns>
        public bool sessionTokenManager(string token, string email)
        {
            SessionToken? existingTokenPossible = findSessionTokenByLoginInformation(email);
            return existingTokenPossible == null ? createSessionToken(token, email) : updateSessionToken(existingTokenPossible, token);
        }

        /// <summary>
        /// Creates a new session token for the specified user.
        /// </summary>
        /// <param name="token">The session token to create.</param>
        /// <param name="email">The user's email.</param>
        /// <returns>True if the token was created successfully; otherwise, false.</returns>
        public bool createSessionToken(string token, string email)
        {
            SessionToken sessionToken = new SessionToken();
            LoginInformation? log = loginController.getInstance().findLoginInformation(email);

            if (log != null)
            {
                try
                {
                    sessionToken.sessionToken = token;
                    sessionToken.CreatedAt = DateTime.Now;
                    sessionToken.LoginInformationId = log.Id;

                    return sessionDao.InsertSessionToken(sessionToken);
                }
                catch (SqlException) { throw; }
            }
            return false;
        }

        /// <summary>
        /// Updates an existing session token.
        /// </summary>
        /// <param name="sessionToken">The session token to update.</param>
        /// <param name="token">The new value for the token.</param>
        /// <returns>True if the token was updated successfully; otherwise, false.</returns>
        public bool updateSessionToken(SessionToken sessionToken, string token)
        {
            try
            {
                sessionToken.sessionToken = token;
                sessionToken.CreatedAt = DateTime.Now;

                return sessionDao.UpdateSessionToken(sessionToken);
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Verifies the existence of a session token in the database.
        /// </summary>
        /// <param name="sessionToken">The session token to verify.</param>
        /// <returns>True if the token exists; otherwise, false.</returns>
        public bool verifySessionToken(string sessionToken)
        {
            return sessionDao.VerifySessionToken(sessionToken);
        }

        /// <summary>
        /// Closes a session token using its value.
        /// </summary>
        /// <param name="token">The session token to close.</param>
        internal void closeSessionTokenByToken(string token)
        {
            try
            {
                sessionDao.closeSessionTokenByToken(token);
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Closes a session token using the user's email.
        /// </summary>
        /// <param name="email">The user's email.</param>
        internal void closeSessionTokenByEmail(string email)
        {
            sessionDao.closeSessionTokenByEmail(email);
        }

        /// <summary>
        /// Finds the login information using the session token.
        /// </summary>
        /// <param name="sessionToken">The session token to search.</param>
        /// <returns>The associated login information, or null if not found.</returns>
        public LoginInformation? findLoginInformationBySessionToken(string sessionToken)
        {
            return sessionDao.findLoginInformationBySessionToken(sessionToken);
        }

        /// <summary>
        /// Finds the session token associated with the user's email.
        /// </summary>
        /// <param name="email">The user's email.</param>
        /// <returns>The found session token, or null if not found.</returns>
        public SessionToken? findSessionTokenByLoginInformation(string email)
        {
            LoginInformation? login = loginController.getInstance().findLoginInformation(email);
            if (login != null)
            {
                return sessionDao.findSessionTokenByLoginInformation(login);
            }
            return null;
        }

        #endregion
    }
}

