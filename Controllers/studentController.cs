using Gestin.Interfaces;
using Gestin.Model;
using Gestin.Model.Dao;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace Gestin.Controllers
{
    internal class studentController : IUserTypeController
    {
        #region Dependencies and Singleton
        loginController loginController = loginController.getInstance();
        sessionController sessionController = sessionController.getInstance();
        private static StudentDao studentDAO = new StudentDao();

        private studentController() { }

        private static studentController? Instance;

        public static studentController getInstance()
        {
            if (Instance == null)
            {
                Instance = new studentController();
            }
            return Instance;
        }
        #endregion

        #region CRUD
        public List<IUserType> loadUserTypes()
        {
            try
            {
                return studentDAO.LoadAllUserTypes();
            }
            catch (SqlException) { throw; }
        }

        public List<IUserType> loadUserTypesExceptDeleted()
        {
            try
            {
                return studentDAO.LoadUserTypesExceptDeleted();
            }
            catch (SqlException) { throw; }
        }

        public int countUserType()
        {
            try
            { 

                return studentDAO.CountActiveUserTypes();

            }catch (SqlException) { throw; }
        }

        public IUserType? findUserTypeById(int id)
        {
            try 
            { 

                 return studentDAO.FindUserTypeById(id);

            }catch (SqlException) { throw; }
        }

        public IUserType? findUserTypeByDNI(int dni)
        {
            try
            {
               return studentDAO.findUserTypeByDNI(dni);
            }
            catch (SqlException) { throw; }
        }

        public IUserType? findUserType(object objectUser)
        {

            try
            {
                return studentDAO.findUserType(objectUser);
            }
            catch (SqlException) { throw; }
        }

        public IUserType? findDeletedUserType(object objectUser)
        {
            try
            {
                return studentDAO.findDeletedUserType(objectUser);
            
            }
            catch (SqlException) { throw; }
        }

        public IUserType? findExistingUserType(object objectUser)
        {
            try
            {
                return studentDAO.findExistingUserType(objectUser);
            }
            catch (SqlException) { throw; }
        }

        public IUserType? findLastCreatedUserType()
        {
            try
            {
                return studentDAO.findLastCreatedUserType();
            }
            catch (SqlException) { throw; }
        }
        #endregion

        #region User Management Methods
        /// <summary>
        /// Saves the user type (in this case, a student). If the user already exists, their information is updated; if not, a new user is created.
        /// </summary>
        /// <param name="user">User object to be saved.</param>
        /// <param name="originalEmail">Original email of the user.</param>
        /// <param name="usermail">Current email of the user.</param>
        /// <param name="password">User's password.</param>
        /// <param name="parameters">List of additional parameters needed to create or update the student.</param>
        /// <exception cref="ArgumentNullException">Thrown if the user cannot be found in the database.</exception>
        public void saveUserType(object user, string originalEmail, string usermail, string password, params dynamic?[] parameters)
        {
            User existingUser = (User)user;

            if (string.IsNullOrEmpty(originalEmail))
            {
                originalEmail = usermail;
            }

            IUserType? userTypeExisting = findExistingUserType(existingUser);
            LoginInformation? log = loginController.findLoginInformation(originalEmail);

            if (userTypeExisting == null)
            {
                createNewUser(existingUser,usermail,password,parameters);
            }
            else
            {
                updateExistingUser(userTypeExisting,log,usermail,password,parameters);  
            }
        }

        /// <summary>
        /// Creates a new student user and saves the login information.
        /// </summary>
        /// <param name="existingUser">Existing user that will be used to create the new student.</param>
        /// <param name="usermail">Email of the new user.</param>
        /// <param name="password">Password of the new user.</param>
        /// <param name="parameters">List of parameters needed to create the student.</param>
        private void createNewUser(User existinUser, string usermail, string password, dynamic?[] parameters)
        {
            var log = loginController.createLoginInformation(usermail,password);
            createUserType(existinUser, log, parameters);
        }

        /// <summary>
        /// Updates an existing user and their login information.
        /// </summary>
        /// <param name="userTypeExisting">The existing user type that will be updated.</param>
        /// <param name="log">User's login information, can be null.</param>
        /// <param name="usermail">User's email.</param>
        /// <param name="password">New or current password of the user.</param>
        /// <param name="parameters">Array of dynamic parameters to update the user type.</param>
        private void updateExistingUser(IUserType userTypeExisting, LoginInformation? log, string usermail, string password, dynamic?[] parameters)
        {
            updateUserType(userTypeExisting, parameters);
            loginController.updateLoginInformation(log,usermail, password);
        }

        /// <summary>
        /// Maps an array of dynamic parameters to the properties of a Student object.
        /// </summary>
        /// <param name="student">The student object to which the parameters will be mapped.</param>
        /// <param name="parameters">An array of parameters that represent the student's attributes.</param>
        private void MapStudentParameters(Student student, dynamic?[] parameters)
        {
            student.WorkActivity = parameters[0];
            student.WorkingHours = parameters[1];
            student.SocialWork = parameters[2];
            student.DniPhotocopy = parameters[3];
            student.HighSchoolTitPhotocopy = parameters[4];
            student.Photo4x4 = parameters[5];
            student.MedicalCertificate = parameters[6];
            student.BirthCertificate = parameters[7];
            student.CuilConstansy = parameters[8];
            student.Cooperative = parameters[9];
        }

        /// <summary>
        /// Creates a new student user type and saves it in the database.
        /// </summary>
        /// <param name="existingUser">The existing user object to which the new student type will be associated.</param>
        /// <param name="log">The login information associated with the user.</param>
        /// <param name="parameters">An array of dynamic parameters needed to create the student.</param>
        /// <returns>Returns true if the student user type is successfully created.</returns>
        /// <exception cref="SqlException">Thrown when a SQL error occurs during the creation process.</exception>
        public bool createUserType(User existingUser, LoginInformation log, dynamic?[] parameters)
        {
            /* string? ocupation, string? workhours, string? healthcare,
            bool analitic, bool dniPhoto, bool birthCertificate, bool medicalCertificate, bool photo, bool cuil, bool cooperative */

            try
            {
                Student student = new Student
                {
                    LoginInformationId = log.Id,
                    CreatedAt = DateTime.Now,
                    UserId = existingUser.Id,
                    LastModificationBy = sessionController.getSessionedUserData()
                };
                MapStudentParameters(student, parameters);

                return studentDAO.CreateUserType(student);
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Updates the properties of an existing student user type.
        /// </summary>
        /// <param name="existingUserType">The existing student user type that will be updated.</param>
        /// <param name="parameters">An array of dynamic parameters used to update the student's attributes.</param>
        /// <exception cref="SqlException">Thrown when a SQL error occurs during the update process.</exception>
        public void updateUserType(IUserType existingUserType, dynamic?[] parameters)
        {
            /* string? ocupation, string? workhours, string? healthcare,
            bool analitic, bool dniPhoto, bool birthCertificate, bool medicalCertificate, bool photo, bool cuil, bool cooperative */

            Student existingStudent = existingUserType as Student;

            try
            {
                using (var db = new Context())
                {
                    MapStudentParameters(existingStudent, parameters);

                    existingStudent.UpdatedAt = DateTime.Now;
                    existingStudent.LastModificationBy = sessionController.getSessionedUserData();

                    studentDAO.UpdateStudent(existingStudent);
                }
            }
            catch (SqlException) { throw; }
        }
        #endregion

        #region User Type Deletion and Reactivation
        public void softDeleteUserType(object objectUser)
        {
            try
            {
                Student? existingStudent = (Student)findUserType(objectUser);

                if (existingStudent == null)
                {
                    throw new ArgumentNullException();
                }

                using (var db = new Context())
                {
                    existingStudent.LastModificationBy = sessionController.getSessionedUserData();
                    studentDAO.SoftDeleteUserType(existingStudent);
                }
            }
            catch (ArgumentNullException) { throw; }
            catch (SqlException) { throw; }
        }

        public void reactivateDeletedUserType(object objectUser)
        {
            try
            {
                User user = (User)objectUser;
                Student? deletedStudent = (Student)findDeletedUserType(user);

                if (deletedStudent == null)
                {
                    throw new ArgumentNullException();
                }

                deletedStudent.LastModificationBy = sessionController.getSessionedUserData();
                studentDAO.ReactivateDeletedUserType(deletedStudent);
            }
            catch (ArgumentNullException) { throw; }
            catch (SqlException) { throw; }
        }

        public bool isUserTypeDeleted(object objectUser)
        {
            if (findDeletedUserType(objectUser) != null)
            {
                return true;
            }
            return false;
        }

        public bool doesUserTypeExist(object objectUser)
        {
            try
            {
                return studentDAO.doesUserTypeExist(objectUser);
            }
            catch (SqlException) { throw; }
        }
        #endregion

        #region Utility Methods
        public IUserType getUserType(object userTypeObject)
        {
            return (Student)userTypeObject;
        }

        public int getUserTypeId(object student)
        {
            return ((Student)student).Id;
        }

        public int getUserTypeDNI(object student)
        {
            return ((Student)student).User.Dni;
        }

        public string getUserTypeFullName(object student)
        {
            Student student1 = (Student)student;

            return student1.getUserFullName();
        }
        #endregion

        #region Search and Academic Records
        public List<IUserType> searchBoxUserTypeWithString(string search)
        {
            using (var db = new Context())
            {
                return studentDAO.searchBoxUserTypeWithString(search);
            }
        }

        public List<IUserType> searchBoxUserTypeWithInt(int search)
        {
            using (var db = new Context())
            {
               return studentDAO.searchBoxUserTypeWithInt(search);
            }
        }

        public List<dynamic?> getUserTypeValuesFormAcademicRecord(object studentObject)
        {
            Student? student = (Student)studentObject;
            return studentDAO.GetUserTypeValuesFormAcademicRecord(student);
        }

        public List<dynamic?> getUserTypeValues(object objectUser)
        {
            User user = (User)objectUser;
            Student? student = (Student)findUserType(user);
            List<dynamic?> studentValues = new();

            if (student != null)
            {
                var values = studentDAO.GetUserTypeValues(student);
                // Insert the secret password at index 1
                values.Insert(1, securityController.getInstance().secretPassword(student.LoginInformation.Email));
                return values;
            }
            return new List<dynamic?>();
        }

        public bool isUserTypeEmailUnique(object user, string email)
        {
            Student? student = findExistingUserType(user) as Student;
            string? userTypeEmail = string.Empty;

            if (student != null) { userTypeEmail = student.LoginInformation.Email; }

            return studentDAO.isUserTypeEmailUnique(email);
        }



      
         public void deleteDuplicateStudents()
         {
                try
                {
                    using (var db = new Context())
                    {
                        var allCareerEnrolments = db.CareerEnrolments
                            .Where(x => x.StudentId != null && x.CareerId != null)
                            .ToList();  

                        var duplicates = allCareerEnrolments
                            .GroupBy(x => new { x.StudentId, x.CareerId })
                            .Where(g => g.Count() > 1)
                            .SelectMany(g => g.Skip(1))
                            .ToList();  

                        if (duplicates == null || duplicates.Count == 0)
                        {
                            MessageBox.Show("No se encontraron duplicados.");
                            return;
                        }

                        // Eliminamos los duplicados de la base de datos
                        db.CareerEnrolments.RemoveRange(duplicates);
                        db.SaveChanges();

                   
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}");
                }
         }

        #endregion

    }
}

