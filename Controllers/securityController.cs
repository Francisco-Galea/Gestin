using Gestin.Model;
using Gestin.Model.Dao;
using Gestin.Model.Security;
using Gestin.Properties;
using Gestin.UI.Custom;

namespace Gestin.Controllers
{
    /// <summary>
    /// Controller responsible for handling security-related operations, such as verifying user roles and login credentials.
    /// Implements the Singleton pattern to ensure a single instance.
    /// </summary>
    internal class securityController
    {
        private loginController loginController = loginController.getInstance();


        #region Singleton

        /// <summary>
        /// Prevents direct instantiation of the <see cref="securityController"/> class.
        /// </summary>
        private securityController() {}

        private static securityController? Instance;

        /// <summary>
        /// Gets the single instance of the <see cref="securityController"/> class.
        /// </summary>
        /// <returns>The single instance of <see cref="securityController"/>.</returns>
        public static securityController getInstance()
        {
            if(Instance == null)
            {
                Instance = new securityController();
            }
            return Instance;
        }

        #endregion


        #region Security

        /// <summary>
        /// Verifies the user login by matching the provided email, password, and role.
        /// Delegates specific role checks to appropriate methods.
        /// </summary>
        /// <param name="email">The user's email for login identification.</param>
        /// <param name="unhashedpassword">The user's plaintext password.</param>
        /// <param name="selectedRole">The user's selected role, either "Estudiante" or "Profesor".</param>
        /// <returns>
        /// <c>true</c> if login verification is successful; otherwise, <c>false</c>.
        /// </returns>
        public bool verifyUserLogin(string email, string unhashedpassword, string selectedRole)
        {
            var loginDao = new LoginDao();
            LoginInformation? login = loginDao.FindLoginByEmail(email);
            bool validLogin = false;

            if (login != null)
            {
                validLogin = selectedRole switch
                {
                    "Estudiante" => VerifyStudentLogin(login, loginDao, unhashedpassword),
                    "Docente" => VerifyTeacherLogin(login, loginDao, unhashedpassword),
                    _ => ShowErrorAndReturnFalse($"El rol {selectedRole} no es válido en el sistema.")
                };
            }
            else
            {
                ShowErrorMessage($"No existe un usuario registrado con el email: {email} en el sistema");
            }

            return validLogin;
        }

        /// <summary>
        /// Verifies the login credentials specifically for a student role.
        /// Checks for role existence and validates the provided password.
        /// </summary>
        /// <param name="login">The login information associated with the user.</param>
        /// <param name="loginDao">The Data Access Object used for login operations.</param>
        /// <param name="unhashedpassword">The user's plaintext password.</param>
        /// <returns>
        /// <c>true</c> if login is successful and the student role is valid; otherwise, <c>false</c>.
        /// </returns>
        private bool VerifyStudentLogin(LoginInformation login, LoginDao loginDao, string unhashedpassword)
        {
            if (loginDao.DoesStudentExistByLoginInformation(login))
            {
                return verifyHashedPassword(login, unhashedpassword);
            }
            else
            {
                ShowErrorMessage("El rol de Estudiante de este usuario fue dado de baja o no existe!");
                return false;
            }
        }

        /// <summary>
        /// Verifies the login credentials specifically for a teacher role.
        /// Checks for role existence and validates the provided password.
        /// </summary>
        /// <param name="login">The login information associated with the user.</param>
        /// <param name="loginDao">The Data Access Object used for login operations.</param>
        /// <param name="unhashedpassword">The user's plaintext password.</param>
        /// <returns>
        /// <c>true</c> if login is successful and the teacher role is valid; otherwise, <c>false</c>.
        /// </returns>
        private bool VerifyTeacherLogin(LoginInformation login, LoginDao loginDao, string unhashedpassword)
        {
            if (loginDao.DoesTeacherExistByLoginInformation(login))
            {
                return verifyHashedPassword(login, unhashedpassword);
            }
            else
            {
                ShowErrorMessage("El rol de Profesor de este usuario fue dado de baja o no existe!");
                return false;
            }
        }

        /// <summary>
        /// Displays an error message in a message box with specific formatting for login errors.
        /// </summary>
        /// <param name="message">The error message to display.</param>
        private void ShowErrorMessage(string message)
        {
            new MessageBoxDarkMode(message, "Error Login", "Ok", Resources.Error);
        }

        /// <summary>
        /// Displays an error message and returns <c>false</c>.
        /// Useful for simplifying error handling in switch expressions.
        /// </summary>
        /// <param name="message">The error message to display.</param>
        /// <returns><c>false</c> to indicate login failure.</returns>
        private bool ShowErrorAndReturnFalse(string message)
        {
            ShowErrorMessage(message);
            return false;
        }

        /// <summary>
        /// Verifies that the hashed password stored in the database matches the user’s input.
        /// </summary>
        /// <param name="login">The login information containing the stored password and salt.</param>
        /// <param name="inputPassword">The plaintext password provided by the user.</param>
        /// <returns>
        /// <c>true</c> if the password matches; otherwise, <c>false</c>.
        /// </returns>
        public bool verifyHashedPassword(LoginInformation login, string inputPassword) //this one is for a User is logging in
        {
            try
            {
                if (login != null) //this whole thing will need to be reviewed in the future
                {
                    byte[] byteInputPassword;
                    byte[] storedPassword = Convert.FromBase64String(login.Password);

                    if (login.Salt != null && login.Salt.Length > 0)
                    {
                        byteInputPassword = GestinSecure.encryptPassword(inputPassword, login.Salt);
                    }
                    else
                    {
                        throw new Exception("Salt not available in the database.");
                    }

                    return GestinSecure.validateByteArrays(byteInputPassword, storedPassword);
                }
                return false;
            }
            catch(Exception) { return false; }
        }

        /// <summary>
        /// Returns a masked password for display purposes, indicating that the password is stored securely.
        /// </summary>
        /// <param name="email">The email address associated with the login information.</param>
        /// <returns>
        /// A string of mask characters ("☺☺☺☺☺☺☺☺") if the password exists; otherwise, an empty string.
        /// </returns>
        /// <remarks>
        /// This method does not reveal the actual password, as it cannot be decrypted.
        /// </remarks>
        public string secretPassword(string email)
        {
            //A hashed password cannot be decrypted without knowing the original password and the encryption method

            LoginInformation? log = loginController.findLoginInformation(email);

            if (log != null && log.Password.Length > 0)
            {
                return "☺☺☺☺☺☺☺☺";
            }
            return "";
        }

        /// <summary>
        /// Generates a unique session token using a random byte array.
        /// </summary>
        /// <returns>A Base64-encoded string representing the generated session token.</returns>
        /// <remarks>
        /// This method provides a secure way to generate session tokens for user authentication.
        /// </remarks>
        internal string generateSessionToken()
        {
            byte[] myToken = GestinSecure.generateRandomBytes();
            return Convert.ToBase64String(myToken);
        }

        #endregion
    }
}
