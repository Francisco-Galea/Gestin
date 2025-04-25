using Gestin.Interfaces;
using Gestin.Model;
using Gestin.Model.Security;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Gestin.Model.Dao;


namespace Gestin.Controllers
{
    /// <summary>
    /// Controller responsible for managing login information.
    /// Implements the Singleton pattern.
    /// </summary>
    internal class loginController
    {
       
        #region Singleton

        static loginController? Instance;

        private loginController() { }

        /// <summary>
        /// Gets the single instance of the login controller.
        /// </summary>
        /// <returns>The unique instance of <see cref="loginController"/>.</returns>
        public static loginController getInstance()
        {
            if (Instance == null)
            {
                Instance = new loginController();
            }
            return Instance;
        }

        #endregion


        #region LoginInformation
        private readonly ISaltEncryptService _securityService = new SecurityService();
        private readonly LoginDao _loginDao = new LoginDao();

        /// <summary>
        /// Initializes a new instance of <see cref="loginController"/> with security and data access services.
        /// </summary>
        /// <param name="securityService">The security service used for handling encryption.</param>
        /// <param name="loginDao">The data access object for managing login information.</param>
        public loginController(ISaltEncryptService securityService, LoginDao loginDao)
        {
            _securityService = securityService;
            _loginDao = loginDao;
        }

        /// <summary>
        /// Creates new login information.
        /// </summary>
        /// <param name="email">The user's email.</param>
        /// <param name="password">The user's password.</param>
        /// <returns>A new instance of <see cref="LoginInformation"/>.</returns>
        public LoginInformation createLoginInformation(string email, string password)
        {
            var loginInfo = new LoginInformation
            {
                Email = email,
                Salt = _securityService.GenerateSalt(),
                CreatedAt = DateTime.Now,
                LastModificationBy = sessionController.getInstance().getSessionedUserData()
            };

            try
            {
                byte[] encryptedPassword = _securityService.EncryptPassword(password, loginInfo.Salt);
                loginInfo.Password = Convert.ToBase64String(encryptedPassword);
                _loginDao.AddLoginInformation(loginInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating login information: ", ex.Message);
            }

            return loginInfo;
        }

        /// <summary>
        /// Validates the user's credentials.
        /// </summary>
        /// <param name="email">The user's email.</param>
        /// <param name="password">The user's password.</param>
        /// <returns>True if the credentials are valid, otherwise false.</returns>
        public bool ValidateCredentials(string email, string password)
        {
            var loginInfo = _loginDao.FindLoginByEmail(email);
            if (loginInfo == null) return false;

            try
            {
                return _securityService.ValidatePassword(
                    Convert.FromBase64String(loginInfo.Password),
                    _securityService.EncryptPassword(password, loginInfo.Salt)
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error validating credentials: ", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Updates existing login information.
        /// </summary>
        /// <param name="existingLog">The existing login information to update.</param>
        /// <param name="email">The new email of the user.</param>
        /// <param name="password">The new password of the user.</param>
        /// <returns>True if the update is successful, otherwise false.</returns>
        public bool updateLoginInformation(LoginInformation existingLog, string email, string password)
        {
            try
            {
                if (existingLog == null)
                {
                    throw new ArgumentNullException(nameof(existingLog), "Login information cannot be null.");
                }

                if (password != string.Empty)
                {
                    existingLog.Salt = GestinSecure.generateRandomBytes();
                    byte[] encryptedPassword = GestinSecure.encryptPassword(password, existingLog.Salt);
                    existingLog.Password = Convert.ToBase64String(encryptedPassword); // Password is hashed and Salted
                }

                existingLog.Email = email;
                existingLog.UpdatedAt = DateTime.Now;
                existingLog.LastModificationBy = sessionController.getInstance().getSessionedUserData();

                using (var db = new Context())
                {
                    db.Update(existingLog);
                    return db.SaveChanges() > 0;
                }
            }
            catch (ArgumentNullException) { throw; }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Finds login information by email.
        /// </summary>
        /// <param name="mail">The email to search for.</param>
        /// <returns>An instance of <see cref="LoginInformation"/> or null if not found.</returns>
        public LoginInformation? findLoginInformation(string mail)
        {
            try
            {
                return _loginDao.findLoginInformation(mail);
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Gets the user type based on login information.
        /// </summary>
        /// <param name="email">The user's email.</param>
        /// <param name="concreteType">The concrete type of the user.</param>
        /// <returns>An instance of <see cref="IUserType"/> corresponding to the user type, or null if not found.</returns>
        public IUserType? getUserTypeByLoginInformation(string email, Type? concreteType)
        {
            return concreteType switch
            {
                var type when type == typeof(Student) => getStudentByLoginInformation(email),
                var type when type == typeof(Teacher) => getTeacherByLoginInformation(email),
                _ => null
            };
        }

        /// <summary>
        /// Searches for the student associated with the login information.
        /// </summary>
        /// <param name="email">The student's email.</param>
        /// <returns>An instance of <see cref="IUserType"/> corresponding to the student, or null if not found.</returns>
        internal IUserType? getStudentByLoginInformation(string email)
        {
            return _loginDao.getStudentByLoginInformation(email);
        }

        /// <summary>
        /// Searches for the teacher associated with the login information.
        /// </summary>
        /// <param name="email">The teacher's email.</param>
        /// <returns>An instance of <see cref="IUserType"/> corresponding to the teacher, or null if not found.</returns>
        internal IUserType? getTeacherByLoginInformation(string email)
        {
            return _loginDao.getTeacherByLoginInformation(email);
        }

        /// <summary>
        /// Checks if a user type exists based on the login information.
        /// </summary>
        /// <param name="log">The login information to check.</param>
        /// <param name="selectedRole">The selected role.</param>
        /// <returns>True if the user type exists, otherwise false.</returns>
        public bool doesUserTypeExistByLoginInformation(LoginInformation log, string selectedRole)
        {
            if (selectedRole == "Estudiante")
                return doesStudentTypeExistByLoginInformation(log);
            else
                return doesTeacherTypeExistByLoginInformation(log);
        }

        /// <summary>
        /// Checks if a student exists based on the login information.
        /// </summary>
        /// <param name="log">The login information to check.</param>
        /// <returns>True if the student exists, otherwise false.</returns>
        public bool doesStudentTypeExistByLoginInformation(LoginInformation log)
        {
            return _loginDao.DoesStudentExistByLoginInformation(log);
        }

        /// <summary>
        /// Checks if a teacher exists based on the login information.
        /// </summary>
        /// <param name="log">The login information to check.</param>
        /// <returns>True if the teacher exists, otherwise false.</returns>
        public bool doesTeacherTypeExistByLoginInformation(LoginInformation log)
        {
            return _loginDao.DoesTeacherExistByLoginInformation(log);
        }
        #endregion
    }
}

