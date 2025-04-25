
using Gestin.Interfaces;
using Gestin.Model;
using Gestin.Model.Dao;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace Gestin.Controllers
{
    internal class teacherController : IUserTypeController
    {
        loginController? loginController = loginController.getInstance();
        careerController? careerController = careerController.getInstance();
        teacherSubjectController? teacherSubjectController = teacherSubjectController.getInstance();
        sessionController sessionController = sessionController.getInstance();
        CareerDao careerDao = new CareerDao();

        private static TeacherDao _teacherDao = new TeacherDao();
      


        #region Singleton

        static teacherController? Instance;

        private teacherController() { }

        public static teacherController getInstance()
        {
            if (Instance == null)
            {
                Instance = new teacherController();
            }
            return Instance;
        }

        #endregion


        #region Teachers

        /// <summary>
        /// Retrieves a list of all user types (teachers) from the data access layer.
        /// This method serves as a controller action to handle requests for user type data.
        /// </summary>
        /// <returns>A list of IUserType records representing all teachers.</returns>
        /// <remarks>
        /// This method interacts with the TeacherDao to fetch the data and is intended to 
        /// be called by the relevant service or API endpoint that requires the list of 
        /// all teachers. It does not handle any filtering based on deletion status, so
        /// all teachers, regardless of their current state, will be included in the returned list.
        /// </remarks>
        public List<IUserType> loadUserTypes()
        {
            return _teacherDao.loadUserTypes();
        }

        /// <summary>
        /// Loads a list of active (non-deleted) Teachers, ordered by last name.
        /// </summary>
        /// <returns>A list of IUserType representing active Teachers.</returns>
        public List<IUserType> loadUserTypesExceptDeleted()
        {
            return _teacherDao.loadUserTypesExceptDeleted();
        }

        /// <summary>
        /// Counts the total number of active (non-deleted) Teachers.
        /// </summary>
        /// <returns>The count of active Teachers.</returns>
        public int countUserType()
        {
            return _teacherDao.countUserType();
        }

        /// <summary>
        /// Finds a Teacher user type based on the provided User ID.
        /// </summary>
        /// <param name="id">The ID of the User associated with the Teacher.</param>
        /// <returns>The IUserType object representing the Teacher with the specified User ID.</returns>
        public IUserType findUserTypeById(int id)
        {
            return _teacherDao.findUserTypeById(id);
        }

        /// <summary>
        /// Finds a Teacher user type based on the provided DNI.
        /// </summary>
        /// <param name="dni">The DNI of the User associated with the Teacher.</param>
        /// <returns>The IUserType object representing the Teacher with the specified DNI.</returns>
        public IUserType findUserTypeByDNI(int dni)
        {
            return _teacherDao.findUserTypeByDNI(dni);
        }

        /// <summary>
        /// Finds an active Teacher user type based on the provided User object.
        /// </summary>
        /// <param name="objectUser">An object of type User used to search for the active Teacher.</param>
        /// <returns>The matching IUserType object representing an active Teacher, or null if no match is found.</returns>
        public IUserType? findUserType(object objectUser)
        {

            return _teacherDao.findUserType(objectUser);

        }

        /// <summary>
        /// Finds a deleted Teacher user type based on the provided User object.
        /// </summary>
        /// <param name="objectUser">An object of type User used to search for the deleted Teacher.</param>
        /// <returns>The matching IUserType object representing a deleted Teacher, or null if no match is found.</returns>
        public IUserType? findDeletedUserType(object objectUser)
        {
            return _teacherDao.findDeletedUserType(objectUser);
        }

        /// <summary>
        /// Finds an existing Teacher user type based on the provided User object.
        /// </summary>
        /// <param name="objectUser">An object of type User used to search for the Teacher.</param>
        /// <returns>The matching IUserType object representing a Teacher, or null if no match is found.</returns>
        public IUserType? findExistingUserType(object objectUser)
        {
            return _teacherDao.findExistingUserType(objectUser);
        }

        /// <summary>
        /// Finds the most recently created Teacher user type.
        /// </summary>
        /// <returns>The last created IUserType object representing a Teacher, or null if no teacher is found.</returns>
        public IUserType? findLastCreatedUserType()
        {
            return _teacherDao.findLastCreatedUserType();
        }

        /// <summary>
        /// Crea o actualiza un tipo de usuario (`UserType`) y su información de inicio de sesión (`LoginInformation`).
        /// </summary>
        /// <param name="user">El objeto que representa al usuario actual.</param>
        /// <param name="originalEmail">El correo electrónico original del usuario, usado para verificar la existencia de `LoginInformation`.</param>
        /// <param name="usermail">El correo electrónico actualizado o nuevo del usuario.</param>
        /// <param name="password">La contraseña del usuario.</param>
        /// <param name="parameters">Parámetros adicionales para la creación o actualización del `UserType`.</param>
        public void saveUserType(object user, string originalEmail, string usermail, string password, params dynamic?[] parameters)
        {
            User existingUser = (User)user;

            if (string.IsNullOrEmpty(originalEmail)) { originalEmail = usermail; }

            IUserType? userTypeExisting = findExistingUserType(existingUser);
            LoginInformation? log = loginController.findLoginInformation(originalEmail);

            if (userTypeExisting == null)
            {
                log = loginController.createLoginInformation(usermail, password);
                createUserType(existingUser, log, parameters);
            }
            else
            {
                updateUserType(userTypeExisting, parameters);
                loginController.updateLoginInformation(log, usermail, password);
            }
        }

        /// <summary>
        /// Crea un nuevo tipo de usuario para el usuario especificado y con la información de inicio de sesión proporcionada.
        /// </summary>
        /// <param name="existingUser">El usuario existente para el cual se creará el tipo de usuario.</param>
        /// <param name="login">Información de inicio de sesión del usuario.</param>
        /// <param name="parameters">Parámetros adicionales para configurar el nuevo tipo de usuario.</param>
        public bool createUserType(User existingUser, LoginInformation login, dynamic?[] parameters)
        {
            try
            {
                Teacher teacher = new Teacher();
                teacher.UserId = existingUser.Id;
                teacher.Cuil = parameters[0];
                teacher.Titulo = parameters[1];
                teacher.LoginInformationId = login.Id;
                teacher.CreatedAt = DateTime.Now;
                teacher.LastModificationBy = sessionController.getSessionedUserData(); 

                using (var db = new Context())
                {
                    db.Teachers.Add(teacher);
                    return db.SaveChanges() > 0;
                }
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Actualiza el tipo de usuario existente con los parámetros proporcionados.
        /// </summary>
        /// <param name="existingUserType">El tipo de usuario existente que se actualizará.</param>
        /// <param name="parameters">Parámetros adicionales para la actualización del tipo de usuario.</param>
        public void updateUserType(IUserType existingUserType, dynamic?[] parameters)
        {
            _teacherDao.updateUserType(existingUserType, parameters);
        }

        /// <summary>
        /// Realiza un borrado lógico de un tipo de usuario (`Teacher`), estableciendo la fecha de eliminación
        /// y el usuario que realizó la última modificación.
        /// </summary>
        /// <param name="objectUser">El objeto que representa al usuario de tipo `Teacher` que se desea eliminar.</param>
        /// <exception cref="ArgumentNullException">Se lanza si no se encuentra el tipo de usuario `Teacher`.</exception>
        /// <exception cref="SqlException">Se lanza si ocurre un error en la base de datos al actualizar el registro.</exception>
        public void softDeleteUserType(object objectUser)
        {
            try
            {
                Teacher? existingTeacher = findUserType(objectUser) as Teacher;

                if (existingTeacher == null)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    deactivateTeacherCharges(existingTeacher);
                }

                using (var db = new Context())
                {
                    existingTeacher.LastModificationBy = sessionController.getSessionedUserData();
                    existingTeacher.DeletedAt = DateTime.Now;
                    db.Update(existingTeacher);
                    db.SaveChanges();
                }
            }
            catch (ArgumentNullException) { throw; }
            catch (SqlException) { throw; }
        }



        /// <summary>
        /// Calls TeacherDao to reactivate a deleted user type.
        /// </summary>
        /// <param name="objectUser">The user object to be reactivated.</param>
        public void reactivateDeletedUserType(object objectUser)
        {
              _teacherDao.reactivateDeletedUserType(objectUser);
        }


        /// <summary>
        /// Calls TeacherDao to check if a user of the specified type exists and is active.
        /// </summary>
        /// <param name="objectUser">The user object to check for existence.</param>
        /// <returns>True if the user exists and is active; otherwise, false.</returns>
        public bool doesUserTypeExist(object objectUser)
        {
            return _teacherDao.doesUserTypeExist(objectUser);
        }


        /// <summary>
        /// Verifica si un usuario de tipo específico ha sido eliminado lógicamente.
        /// </summary>
        /// <param name="objectUser">El objeto que representa al usuario cuya eliminación lógica se desea verificar.</param>
        /// <returns>
        /// `true` si el usuario ha sido eliminado lógicamente; de lo contrario, `false`.
        /// </returns>
        public bool isUserTypeDeleted(object objectUser)
        {
            if (findDeletedUserType(objectUser) != null)
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// Convierte un objeto genérico en un tipo de usuario `Teacher` y lo devuelve como `IUserType`.
        /// </summary>
        /// <param name="userTypeObject">El objeto genérico que representa un usuario de tipo `Teacher`.</param>
        /// <returns>Un objeto de tipo `IUserType` que representa al usuario.</returns>
        /// <exception cref="InvalidCastException">Se lanza si `userTypeObject` no es de tipo `Teacher`.</exception>
        public IUserType getUserType(object userTypeObject)
        {
            return (Teacher)userTypeObject;
        }


        /// <summary>
        /// Devuelve el identificador (`Id`) de un usuario de tipo `Teacher`.
        /// </summary>
        /// <param name="userType">El objeto que representa al usuario, se espera que sea de tipo `Teacher`.</param>
        /// <returns>El identificador (`Id`) del usuario de tipo `Teacher`.</returns>
        /// <exception cref="InvalidCastException">Se lanza si `userType` no es de tipo `Teacher`.</exception>
        public int getUserTypeId(object userType)
        {
            return ((Teacher)userType).Id;
        }

        /// <summary>
        /// Obtiene el DNI de un usuario de tipo específico.
        /// </summary>
        /// <param name="userType">El objeto que representa al usuario cuyo DNI se desea obtener.</param>
        /// <returns>El DNI del usuario.</returns>
        /// <exception cref="NotImplementedException">Siempre se lanza, ya que el método no ha sido implementado.</exception>
        public int getUserTypeDNI(object userType)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Obtiene el nombre completo de un usuario de tipo `Teacher`.
        /// </summary>
        /// <param name="userType">El objeto que representa al usuario, se espera que sea de tipo `Teacher`.</param>
        /// <returns>El nombre completo del usuario.</returns>
        /// <exception cref="InvalidCastException">Se lanza si `userType` no es de tipo `Teacher`.</exception>
        /// <exception cref="NullReferenceException">Se lanza si `User` o el método `fullName()` en `User` es `null`.</exception>
        public string getUserTypeFullName(object userType)
        {
            Teacher teacher1 = (Teacher)userType;

            return teacher1.User.fullName();
        }


        /// <summary>
        /// Obtiene una lista de todos los docentes asociados a una carrera específica que tienen asignaturas activas.
        /// </summary>
        /// <param name="career">El objeto que representa la carrera, se espera que sea de tipo `Career`.</param>
        /// <returns>Una lista de docentes (`Teacher`) asociados a la carrera especificada.</returns>
        /// <exception cref="InvalidCastException">Se lanza si `career` no es de tipo `Career`.</exception>
        public List<Teacher> getAllTeachersFromCareer(object career)
        {
            var _career = (Career)career;
            using (var db = new Context())
            {
                var list = db.TeacherSubjects
                    .Where(x => (x.Subject.CareerId == _career.Id && x.Active == true))
                    .Include(x => x.Teacher.User)
                    .Select(x => x.Teacher)
                    .Distinct()
                    .ToList();
                return list;
            }
        }

        /// <summary>
        /// Obtiene el identificador (`Id`) del docente activo más reciente asociado a una asignatura específica.
        /// </summary>
        /// <param name="_Subject">El objeto que representa la asignatura, se espera que sea de tipo `Subject`.</param>
        /// <returns>El `Id` del docente activo más reciente, o `null` si no se encuentra ninguno.</returns>
        /// <exception cref="InvalidCastException">Se lanza si `_Subject` no es de tipo `Subject`.</exception>
        public int? getMostResentActiveTeacherId(object _Subject)
        {
            Subject sub = (Subject)_Subject;
            using (var db = new Context())
            {
                var teacherId = db.TeacherSubjects?
                    .Where(x => (x.Subject.Id == sub.Id && x.Active == true))
                    .OrderBy(x => x.CreatedAt)
                    .Select(x => x.Teacher.Id)
                    .FirstOrDefault();
                return teacherId;
            }
        }

        /// <summary>
        /// Obtiene el usuario más reciente asociado a un docente activo para una asignatura específica.
        /// </summary>
        /// <param name="_Subject">El objeto que representa la asignatura, se espera que sea de tipo `Subject`.</param>
        /// <returns>El objeto `User` asociado al docente activo más reciente, o `null` si no se encuentra ninguno.</returns>
        /// <exception cref="InvalidCastException">Se lanza si `_Subject` no es de tipo `Subject`.</exception>
        public User? getMostResentActiveUserOfTeacherType(object _Subject)
        {
            Subject sub = (Subject)_Subject;
            using (var db = new Context())
            {
                var teacher = db.TeacherSubjects?
                    .Where(x => (x.Subject.Id == sub.Id && x.Active == true))
                    .OrderBy(x => x.CreatedAt)
                    .Select(x => x.Teacher.User)
                    .FirstOrDefault();
                return teacher;
            }
        }

        /// <summary>
        /// Obtiene el docente activo más reciente asociado a una asignatura específica.
        /// </summary>
        /// <param name="_Subject">El objeto que representa la asignatura, se espera que sea de tipo `Subject`.</param>
        /// <returns>El objeto `Teacher` asociado al docente activo más reciente, o `null` si no se encuentra ninguno.</returns>
        /// <exception cref="ArgumentNullException">Se lanza si `_Subject` es `null`.</exception>
        public Teacher? getMostResentActiveTeacher(Subject _Subject)
        {
            using (var db = new Context())
            {
                var teacher = db.TeacherSubjects?
                    .Where(x => (x.Subject.Id == _Subject.Id && x.Active == true))
                    .OrderBy(x => x.CreatedAt)
                    .Select(x => x.Teacher)
                    .FirstOrDefault();
                return teacher;
            }
        }

        /// <summary>
        /// Obtiene el docente activo más reciente asociado a una asignatura específica, incluyendo la información del usuario.
        /// </summary>
        /// <param name="_Subject">El objeto que representa la asignatura, se espera que sea de tipo `Subject`.</param>
        /// <returns>El objeto `Teacher` asociado al docente activo más reciente, o `null` si no se encuentra ninguno.</returns>
        /// <exception cref="InvalidCastException">Se lanza si `_Subject` no es de tipo `Subject`.</exception>
        public Teacher? getMostRecentActiveTeacher(object _Subject)
        {
            Subject sub = (Subject)_Subject;
            using (var db = new Context())
            {
                var teacher = db.TeacherSubjects?
                    .Where(x => (x.Subject.Id == sub.Id && x.Active == true))
                    .OrderBy(x => x.CreatedAt)
                    .Include(x => x.Teacher.User)
                    .Select(x => x.Teacher)
                    .FirstOrDefault();
                return teacher;
            }
        }

        /// <summary>
        /// Obtiene una lista de valores asociados a un usuario de tipo `Teacher`, incluyendo el correo electrónico, contraseña encriptada, título y CUIL.
        /// </summary>
        /// <param name="userTypeObject">El objeto que representa el usuario, se espera que sea de tipo `Teacher`.</param>
        /// <returns>Una lista de valores dinámicos relacionados con el docente, o una lista vacía si el objeto no es de tipo `Teacher` o no tiene valores asociados.</returns>
        /// <exception cref="InvalidCastException">Se lanza si `userTypeObject` no es de tipo `Teacher`.</exception>
        public List<dynamic?> getUserTypeValues(object userTypeObject)
        {
            Teacher? teacher = findUserType(userTypeObject) as Teacher;

            List<dynamic?> teacherValues = new();

            if (teacher != null)
            {
                teacherValues = new()
                {
                    teacher.LoginInformation.Email,
                    securityController.getInstance().secretPassword(teacher.LoginInformation.Email),
                    teacher.Titulo,
                    teacher.Cuil
                };
            }
            return teacherValues;
        }

        /// <summary>
        /// Realiza una búsqueda de docentes cuyo nombre o apellido comienzan con el término de búsqueda proporcionado.
        /// </summary>
        /// <param name="search">El término de búsqueda que se utilizará para filtrar los docentes por su nombre o apellido.</param>
        /// <returns>Una lista de objetos de tipo `IUserType` que representan los docentes cuyo nombre o apellido coinciden con el término de búsqueda.</returns>
        /// <exception cref="ArgumentNullException">Se lanza si `search` es `null` o vacío.</exception>
        public List<IUserType> searchBoxUserTypeWithString(string search)
        {
            using (var db = new Context())
            {
                return db.Teachers
                    .Where(x => x.User.Name.StartsWith(search) || x.User.LastName.StartsWith(search) && x.DeletedAt == null)
                    .Include(x => x.LoginInformation)
                    .Include(x => x.User)
                    .Cast<IUserType>()
                    .ToList();
            }
        }

        /// <summary>
        /// Realiza una búsqueda de docentes cuyo DNI comienza con el número proporcionado.
        /// </summary>
        /// <param name="search">El número que se utilizará para filtrar los docentes por el inicio de su DNI.</param>
        /// <returns>Una lista de objetos de tipo `IUserType` que representan los docentes cuyo DNI comienza con el número de búsqueda.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Se lanza si `search` es un valor no válido para realizar la conversión de tipo.</exception>
        public List<IUserType> searchBoxUserTypeWithInt(int search)
        {
            using (var db = new Context())
            {
                return db.Teachers
                    .Where(x => x.User.Dni.ToString().StartsWith(search.ToString()) && x.DeletedAt == null)
                    .Include(x => x.LoginInformation)
                    .Include(x => x.User)
                    .Cast<IUserType>()
                    .ToList();
            }
        }

        /// <summary>
        /// Verifica si el correo electrónico proporcionado es único para los docentes, es decir, no está siendo utilizado por otro docente.
        /// </summary>
        /// <param name="user">El objeto que representa al usuario, se espera que sea de tipo `Teacher`.</param>
        /// <param name="email">El correo electrónico que se desea verificar si es único.</param>
        /// <returns>`true` si el correo electrónico no está en uso por otro docente; `false` si el correo electrónico ya está siendo utilizado por otro docente.</returns>
        /// <exception cref="InvalidCastException">Se lanza si `user` no es de tipo `Teacher`.</exception>
        public bool isUserTypeEmailUnique(object user, string email)
        {
            Teacher? teacher = findExistingUserType(user) as Teacher;
            string? userTypeEmail = string.Empty;

            if (teacher != null) { userTypeEmail = teacher.LoginInformation.Email; }

            using (var db = new Context())
            {
                return db.Teachers.Any(x => x.LoginInformation.Email != email && x.LoginInformation.Email != userTypeEmail);
            }
        }

        /// <summary>
        /// Desactiva todas las asignaturas activas asociadas a un docente, indicando que ya no tienen un cargo activo.
        /// </summary>
        /// <param name="teacher">El objeto `Teacher` que representa al docente cuyas asignaturas activas deben ser desactivadas.</param>
        /// <remarks>Este método recorre todas las asignaturas activas asociadas al docente y llama a otro método para desactivarlas.</remarks>
        private void deactivateTeacherCharges(Teacher teacher)
        {
            var teacherSubjects = teacherSubjectController.getAllActiveTeacherChargesByTeacher(teacher.Id);

            foreach (var charge in teacherSubjects)
            {
                teacherSubjectController.deactivateTeacherCharge(charge);
            }
            return;
        }

        /// <summary>
        /// Obtiene una lista de docentes activos asociados a una carrera específica.
        /// </summary>
        /// <param name="careerId">El identificador de la carrera para la cual se desean obtener los docentes activos.</param>
        /// <returns>Una lista de objetos `Teacher` que representan a los docentes activos vinculados a la carrera especificada.</returns>
        /// <remarks>Este método realiza una consulta de varias tablas (Teachers, Users, TeacherSubjects, Subjects, Careers) para obtener los docentes activos asociados a la carrera proporcionada.</remarks>
        public List<Teacher> GetActiveTeachersByCareer(int careerId)
        {
            using (var db = new Context())
            {
                
                    // Consulta para obtener docentes activos por carrera
                    var activeTeachers = (from teacher in db.Teachers
                                          join user in db.Users on teacher.UserId equals user.Id
                                          join teacherSubject in db.TeacherSubjects on teacher.Id equals teacherSubject.TeacherId
                                          join subject in db.Subjects on teacherSubject.SubjectId equals subject.Id
                                          join career in db.Careers on subject.CareerId equals career.Id
                                          where teacherSubject.Active && career.Id == careerId
                                          select new Teacher
                                          {
                                              User = user,
                                              Cuil = teacher.Cuil,
                                              Titulo = teacher.Titulo
                                          }).Distinct().ToList();

                    return activeTeachers;
                }
        }

        /// <summary>
        /// Obtiene una lista de todos los docentes activos, ordenados alfabéticamente por apellido y asegurando que no haya duplicados por apellido.
        /// </summary>
        /// <returns>Una lista de objetos `Teacher` que representan a los docentes activos.</returns>
        /// <remarks>Este método realiza una consulta de varias tablas (Teachers, Users, TeacherSubjects, LoginInformations) para obtener todos los docentes activos, asegurándose de eliminar duplicados basados en el apellido del docente y ordenando por apellido de forma ascendente.</remarks>
        public List<Teacher> GetAllActiveTeachers()
        {
            using (var db = new Context())
            {
                var activeTeachers = (from teacher in db.Teachers
                                      join user in db.Users on teacher.UserId equals user.Id
                                      join teacherSubject in db.TeacherSubjects on teacher.Id equals teacherSubject.TeacherId
                                      join loginInfo in db.LoginInformations on teacher.LoginInformationId equals loginInfo.Id
                                      where teacherSubject.Active
                                      orderby user.LastName 
                                      select new Teacher
                                      {
                                          User = user,
                                          Cuil = teacher.Cuil,
                                          Titulo = teacher.Titulo,
                                          LoginInformation = loginInfo
                                      })
                                      .GroupBy(t => t.User.LastName) 
                                      .Select(g => g.First())  
                                      .ToList();

                return activeTeachers;
            }
        }

        

        public List<Teacher> GetTeachersFromCareerByYear(int careerId, int yearInCareer)
        {
            return _teacherDao.GetTeachersFromCareerByYear(careerId, yearInCareer);
        }

       
        

        #endregion
    }
}
