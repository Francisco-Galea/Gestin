using Gestin.Controllers;
using Gestin.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace Gestin.Model.Dao
{
    internal class TeacherDao
    {

        loginController loginController = loginController.getInstance();
        careerController careerController = careerController.getInstance();
        sessionController sessionController = sessionController.getInstance();

        public TeacherDao() { }


        
        /// <summary>
        /// Obtiene y devuelve una lista de tipos de usuario (`IUserType`) correspondiente a los docentes, 
        /// ordenados alfabéticamente por apellido. 
        /// </summary>
        /// <returns>
        /// Una lista de objetos que implementan la interfaz `IUserType`, 
        /// representando a los docentes ordenados por apellido.
        /// </returns>
        /// <remarks>
        /// El método establece una conexión con la base de datos mediante un contexto (`Context`) y 
        /// ejecuta una consulta para recuperar todos los registros de docentes de la tabla `Teachers`, 
        /// incluyendo la información de usuario (`User`) asociada a cada docente.
        /// </remarks>
        /// <exception cref="SqlException">
        /// Lanza una excepción de SQL si ocurre un error durante la consulta a la base de datos.
        /// </exception>
        public List<IUserType> loadUserTypes()
        {
            try
            {
                using (var db = new Context())
                {
                    return db.Teachers
                        .OrderBy(x => x.User.LastName)
                        .Include(x => x.User)
                        .Cast<IUserType>()
                        .ToList();
                }
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Obtiene y devuelve una lista de tipos de usuario (`IUserType`) correspondiente a los docentes
        /// que no han sido eliminados, ordenados alfabéticamente por apellido.
        /// </summary>
        /// <returns>
        /// Una lista de objetos que implementan la interfaz `IUserType`, representando a los docentes
        /// activos (no eliminados) ordenados por apellido.
        /// </returns>
        /// <remarks>
        /// El método establece una conexión con la base de datos a través del contexto (`Context`) y
        /// ejecuta una consulta para recuperar todos los registros de docentes de la tabla `Teachers`
        /// cuya propiedad `DeletedAt` es `null`, lo que indica que no han sido eliminados.
        /// La consulta incluye la información de usuario asociada (`User`) para cada docente.
        /// </remarks>
        /// <exception cref="SqlException">
        /// Lanza una excepción de SQL si ocurre un error durante la consulta a la base de datos.
        /// </exception>
        public List<IUserType> loadUserTypesExceptDeleted()
        {
            try
            {
                using (var db = new Context())
                {
                    return db.Teachers
                        .Where(x => x.DeletedAt == null)
                        .OrderBy(x => x.User.LastName)
                        .Include(x => x.User)
                        .Cast<IUserType>()
                        .ToList();
                }
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Cuenta y devuelve el número de docentes que no han sido eliminados de la base de datos.
        /// </summary>
        /// <returns>
        /// Un entero que representa la cantidad de docentes activos (no eliminados),
        /// donde `DeletedAt` es `null`.
        /// </returns>
        /// <remarks>
        /// El método establece una conexión con la base de datos a través del contexto (`Context`)
        /// y ejecuta una consulta para contar los registros en la tabla `Teachers` donde la propiedad
        /// `DeletedAt` es `null`, lo que indica que el docente no ha sido eliminado.
        /// </remarks>
        /// <exception cref="SqlException">
        /// Lanza una excepción de SQL si ocurre un error durante la consulta a la base de datos.
        /// </exception>
        public int countUserType()
        {
            try
            {
                using (var db = new Context())
                {
                    return db.Teachers.Where(x => x.DeletedAt == null).Count();
                }
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Busca y devuelve un tipo de usuario (`IUserType`) que corresponde a un docente 
        /// con el ID de usuario especificado.
        /// </summary>
        /// <param name="id">El ID del usuario asociado al docente que se desea encontrar.</param>
        /// <returns>
        /// Un objeto que implementa la interfaz `IUserType`, representando al docente con el ID de usuario especificado.
        /// </returns>
        /// <remarks>
        /// El método establece una conexión con la base de datos mediante el contexto (`Context`) y 
        /// ejecuta una consulta para encontrar un docente en la tabla `Teachers` cuyo ID de usuario 
        /// (`User.Id`) coincida con el valor especificado.
        /// Incluye la información relacionada de `User` y `LoginInformation`.
        /// </remarks>
        /// <exception cref="InvalidOperationException">
        /// Lanza una excepción si no se encuentra ningún docente con el ID de usuario especificado.
        /// </exception>
        public IUserType findUserTypeById(int id)
        {
            try
            {
                using (var db = new Context())
                {
                    return db.Teachers
                    .Where(x => x.User.Id == id)
                    .Include(x => x.User)
                    .Include(x => x.LoginInformation)
                    .Cast<IUserType>()
                    .First();
                }
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Busca y devuelve un tipo de usuario (`IUserType`) que corresponde a un docente 
        /// con el DNI especificado.
        /// </summary>
        /// <param name="dni">El DNI del usuario asociado al docente que se desea encontrar.</param>
        /// <returns>
        /// Un objeto que implementa la interfaz `IUserType`, representando al docente con el DNI especificado.
        /// </returns>
        /// <remarks>
        /// El método establece una conexión con la base de datos mediante el contexto (`Context`) y 
        /// ejecuta una consulta para encontrar un docente en la tabla `Teachers` cuyo DNI de usuario 
        /// (`User.Dni`) coincida con el valor especificado.
        /// Incluye la información relacionada de `User` y `LoginInformation`.
        /// </remarks>
        /// <exception cref="InvalidOperationException">
        /// Lanza una excepción si no se encuentra ningún docente con el DNI especificado.
        /// </exception>
        /// <exception cref="SqlException">
        /// Lanza una excepción de SQL si ocurre un error durante la consulta a la base de datos.
        /// </exception>
        public IUserType findUserTypeByDNI(int dni)
        {
            try
            {
                using (var db = new Context())
                {
                    return db.Teachers
                    .Where(x => x.User.Dni == dni)
                    .Include(x => x.User)
                    .Include(x => x.LoginInformation)
                    .Cast<IUserType>()
                    .First();
                }
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Busca y devuelve un tipo de usuario (`IUserType`) que corresponde a un docente activo 
        /// (no eliminado) con el mismo DNI que el usuario especificado.
        /// </summary>
        /// <param name="objectUser">El objeto `User` que contiene el DNI del usuario a buscar.</param>
        /// <returns>
        /// Un objeto que implementa la interfaz `IUserType`, representando al docente con el DNI especificado,
        /// o `null` si no se encuentra un docente activo que coincida.
        /// </returns>
        /// <remarks>
        /// El método convierte el parámetro `objectUser` a un objeto `User`, luego establece una conexión
        /// con la base de datos a través del contexto (`Context`) y ejecuta una consulta para encontrar un docente 
        /// en la tabla `Teachers` cuyo DNI de usuario (`User.Dni`) coincida con el valor especificado y cuya 
        /// propiedad `DeletedAt` sea `null`, lo que indica que el docente está activo.
        /// La consulta incluye la información relacionada de `User` y `LoginInformation`.
        /// </remarks>
        /// <exception cref="InvalidCastException">
        /// Lanza una excepción si el parámetro `objectUser` no puede convertirse a un objeto `User`.
        /// </exception>
        /// <exception cref="SqlException">
        /// Lanza una excepción de SQL si ocurre un error durante la consulta a la base de datos.
        /// </exception>
        public IUserType? findUserType(object objectUser)
        {
            User selectedUser = (User)objectUser;

            try
            {
                using (var db = new Context())
                {
                    return db.Teachers
                    .Where(x => x.User.Dni == selectedUser.Dni && x.DeletedAt == null)
                    .Include(x => x.User)
                    .Include(x => x.LoginInformation)
                    .Cast<IUserType>()
                    .FirstOrDefault();
                }
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Busca y devuelve un tipo de usuario (`IUserType`) que corresponde a un docente eliminado 
        /// (con `DeletedAt` no nulo) cuyo DNI coincide con el del usuario especificado.
        /// </summary>
        /// <param name="objectUser">El objeto `User` que contiene el DNI del usuario a buscar.</param>
        /// <returns>
        /// Un objeto que implementa la interfaz `IUserType`, representando al docente eliminado 
        /// con el DNI especificado, o `null` si no se encuentra un docente eliminado que coincida.
        /// </returns>
        /// <remarks>
        /// El método convierte el parámetro `objectUser` a un objeto `User`, luego establece una conexión
        /// con la base de datos a través del contexto (`Context`) y ejecuta una consulta para encontrar un 
        /// docente en la tabla `Teachers` cuyo DNI de usuario (`User.Dni`) coincida con el valor especificado y 
        /// cuya propiedad `DeletedAt` no sea `null`, lo que indica que el docente está eliminado.
        /// La consulta incluye la información relacionada de `User` y `LoginInformation`.
        /// </remarks>
        /// <exception cref="InvalidCastException">
        /// Lanza una excepción si el parámetro `objectUser` no puede convertirse a un objeto `User`.
        /// </exception>
        /// <exception cref="SqlException">
        /// Lanza una excepción de SQL si ocurre un error durante la consulta a la base de datos.
        /// </exception>
        public IUserType? findDeletedUserType(object objectUser)
        {
            User selectedUser = (User)objectUser;

            try
            {
                using (var db = new Context())
                {
                    return db.Teachers
                    .Where(x => x.User.Dni == selectedUser.Dni && x.DeletedAt != null)
                    .Include(x => x.User)
                    .Include(x => x.LoginInformation)
                    .Cast<IUserType>()
                    .FirstOrDefault();
                }
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Busca y devuelve un tipo de usuario (`IUserType`) que corresponde a un docente existente,
        /// cuyo DNI coincide con el del usuario especificado.
        /// </summary>
        /// <param name="objectUser">El objeto `User` que contiene el DNI del usuario a buscar.</param>
        /// <returns>
        /// Un objeto que implementa la interfaz `IUserType`, representando al docente con el DNI especificado,
        /// o `null` si no se encuentra ningún docente que coincida.
        /// </returns>
        /// <remarks>
        /// Este método convierte el parámetro `objectUser` a un objeto `User`, luego establece una conexión
        /// con la base de datos a través del contexto (`Context`) y ejecuta una consulta para encontrar un docente
        /// en la tabla `Teachers` cuyo DNI de usuario (`User.Dni`) coincida con el valor especificado.
        /// La consulta incluye la información relacionada de `User` y `LoginInformation`, que se traen de forma 
        /// ansiosa (`Include`), y se devuelve el primer resultado encontrado, o `null` si no se encuentra ninguno.
        /// </remarks>
        /// <exception cref="InvalidCastException">
        /// Lanza una excepción si el parámetro `objectUser` no puede convertirse a un objeto `User`.
        /// </exception>
        /// <exception cref="SqlException">
        /// Lanza una excepción de SQL si ocurre un error durante la consulta a la base de datos.
        /// </exception>
        public IUserType? findExistingUserType(object objectUser)
        {
            User selectedUser = (User)objectUser;

            try
            {
                using (var db = new Context())
                {
                    return db.Teachers.Where(x => x.User.Dni == selectedUser.Dni)
                    .Include(x => x.User)
                    .Include(x => x.LoginInformation)
                    .Cast<IUserType>()
                    .FirstOrDefault();
                }
            }
            catch (SqlException) { throw; }
        }

        public IUserType? findLastCreatedUserType()
        {
            try
            {
                using (var db = new Context())
                {
                    return db.Teachers
                    .OrderByDescending(x => x.CreatedAt)
                    .Include(x => x.User)
                    .Cast<IUserType>()
                    .FirstOrDefault();
                }
            }
            catch (SqlException) { throw; }
        }

        /// <summary>
        /// Actualiza la información de un tipo de usuario existente (`IUserType`) en la base de datos.
        /// </summary>
        /// <param name="existingUserType">El objeto `IUserType` que representa al docente a actualizar.</param>
        /// <param name="parameters">
        /// Un array de parámetros dinámicos que contiene los valores de actualización:
        /// <list type="bullet">
        /// <item>parameters[0]: `Cuil` del docente (tipo dinámico).</item>
        /// <item>parameters[1]: `Titulo` del docente (tipo dinámico).</item>
        /// </list>
        /// </param>
        /// <remarks>
        /// Este método convierte el parámetro `existingUserType` a un objeto `Teacher` y actualiza sus propiedades 
        /// `Cuil`, `Titulo`, `UpdatedAt` y `LastModificationBy`. Posteriormente, guarda los cambios en la base de datos.
        /// </remarks>
        /// <exception cref="InvalidCastException">
        /// Lanza una excepción si `existingUserType` no puede convertirse a un objeto `Teacher`.
        /// </exception>
        /// <exception cref="SqlException">
        /// Lanza una excepción de SQL si ocurre un error durante la actualización en la base de datos.
        /// </exception>
        public void updateUserType(IUserType existingUserType, dynamic?[] parameters)
        {
            Teacher existingTeacher = existingUserType as Teacher;
            try
            {
                using (var db = new Context())
                {
                    existingTeacher.Cuil = parameters[0];
                    existingTeacher.Titulo = parameters[1];
                    existingTeacher.UpdatedAt = DateTime.Now;
                    existingTeacher.LastModificationBy = sessionController.getSessionedUserData();
                    db.Update(existingTeacher);
                    db.SaveChanges();
                }
            }
            catch (SqlException) { throw; }
        }

        public void reactivateDeletedUserType(object objectUser)
        {
            try
            {
                Teacher? deletedTeacher = findDeletedUserType(objectUser) as Teacher;

                using (var db = new Context())
                {
                    if (deletedTeacher != null)
                    {

                        deletedTeacher.UpdatedAt = DateTime.Now;
                        deletedTeacher.DeletedAt = null;
                        deletedTeacher.LastModificationBy = sessionController.getSessionedUserData();
                        db.Update(deletedTeacher);
                        db.SaveChanges();
                    }
                }
            }
            catch (SqlException) { throw; }
        }

        public bool doesUserTypeExist(object objectUser)
        {
            User selectedUser = (User)objectUser;

            try
            {
                using (var db = new Context())
                {
                    return db.Teachers.Any(x => x.User.Id == selectedUser.Id && x.DeletedAt == null);
                }
            }
            catch (SqlException) { throw; }
        }

        
        public List<Teacher> GetTeachersFromCareerByYear(int careerId, int yearInCareer)
        {
            using (var db = new Context())
            {
                var list = db.TeacherSubjects
                    .Where(x => x.Subject.CareerId == careerId
                                && x.Active == true
                                && x.Subject.YearInCareer == yearInCareer)
                    .Include(x => x.Teacher.User)
                    .Select(x => x.Teacher)
                    .Distinct()
                    .ToList();

                return list;
            }
        }

    }
}
