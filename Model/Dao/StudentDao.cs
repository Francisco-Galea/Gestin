using Gestin.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace Gestin.Model.Dao
{
    /// <summary>
    /// Data Access Object for Student entities. Handles database operations related to students.
    /// </summary>
    public class StudentDao
    {
        public StudentDao() { }

        /// <summary>
        /// Inserts a new student into the database.
        /// </summary>
        /// <param name="student">The Student object to be inserted.</param>
        /// <exception cref="DbUpdateException">Thrown when the database update fails.</exception>
        public void InsertStudent(Student student) 
        {
            using (var db = new Context())
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Creates a new user type by inserting a student into the database.
        /// </summary>
        /// <param name="student">The student object to be created.</param>
        /// <returns>True if the creation is successful, false otherwise.</returns>
        /// <exception cref="DbUpdateException">Thrown when the database update fails.</exception>
        public bool CreateUserType(Student student)
        {
            using (var db = new Context())
            {
                db.Students.Add(student);
                return db.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// Updates an existing student in the database.
        /// </summary>
        /// <param name="student">The Student object with updated information.</param>
        /// <exception cref="DbUpdateException">Thrown when the database update fails.</exception>
        public void UpdateStudent(Student student)
        {
            using (var db = new Context())
            {
                db.Update(student);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Soft deletes a user type by setting the DeletedAt property to the current date and time.
        /// </summary>
        /// <param name="student">The student object to be soft deleted.</param>
        /// <exception cref="DbUpdateException">Thrown when the database update fails.</exception>
        public void SoftDeleteUserType(Student student)
        {
            using (var db = new Context())
            {
                student.DeletedAt = DateTime.Now;
                db.Update(student);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Counts the number of active (non-deleted) students in the database.
        /// </summary>
        /// <remarks>
        /// This method currently does not return or store the count value.
        /// Consider modifying it to return an int if the count is needed.
        /// </remarks>
        public void countUserType() 
        {
            using (var db = new Context())
            {
                db.Students.Where(x => x.DeletedAt == null).Count();
            }
        }

        /// <summary>
        /// Counts the number of active (non-deleted) students in the database.
        /// </summary>
        /// <returns>The number of active students.</returns>
        /// <exception cref="SqlException">Thrown when a SQL error occurs.</exception>
        public int CountActiveUserTypes()
        {
            using (var db = new Context())
            {
                return db.Students.Count(x => x.DeletedAt == null);
            }
        }

        /// <summary>
        /// Retrieves all students from the database.
        /// </summary>
        /// <returns>A list of all students, cast as IUserType.</returns>
        /// <exception cref="SqlException">Thrown when a SQL error occurs.</exception>
        public List<IUserType> LoadAllUserTypes()
        {
                using (var db = new Context())
                {
                    return db.Students.Include(x => x.User).Cast<IUserType>().ToList();
                }
        }

        /// <summary>
        /// Finds a student by their user ID.
        /// </summary>
        /// <param name="id">The ID of the user associated with the student.</param>
        /// <returns>The student with the specified user ID, or null if not found.</returns>
        /// <exception cref="SqlException">Thrown when a SQL error occurs.</exception>
        public IUserType? FindUserTypeById(int id)
        {
                using (var db = new Context())
                {
                    return db.Students
                        .Where(x => x.User.Id == id && x.DeletedAt == null)
                        .Include(x => x.User)
                        .Include(x => x.LoginInformation)
                        .Cast<IUserType>()
                        .FirstOrDefault();
                }
        }

        /// <summary>
        /// Finds a student by their DNI (national identity document).
        /// </summary>
        /// <param name="dni">The DNI of the student to find.</param>
        /// <returns>The student with the specified DNI, or null if not found.</returns>
        /// <exception cref="SqlException">Thrown when a SQL error occurs.</exception>
        public IUserType? findUserTypeByDNI(int dni)
        {
                using (var db = new Context())
                {
                    return db.Students
                        .Where(x => x.User.Dni == dni && x.DeletedAt == null)
                        .Include(x => x.User)
                        .Include(x => x.LoginInformation)
                        .Cast<IUserType>()
                        .FirstOrDefault();
                }
        }

        /// <summary>
        /// Finds a student by their associated user object.
        /// </summary>
        /// <param name="objectUser">The user object used to find the student.</param>
        /// <returns>The student with the specified user details, or null if not found.</returns>
        /// <exception cref="SqlException">Thrown when a SQL error occurs.</exception>
        public IUserType? findUserType(object objectUser)
        {
            User selectedUser = (User)objectUser;

                using (var db = new Context())
                {
                    return db.Students
                    .Where(x => x.User.Id == selectedUser.Id && x.DeletedAt == null)
                    .Include(x => x.User)
                    .Include(x => x.LoginInformation)
                    .Cast<IUserType>()
                    .FirstOrDefault();
                }
        }

        /// <summary>
        /// Finds an existing student by their associated user object without checking deletion status.
        /// </summary>
        /// <param name="objectUser">The user object used to find the student.</param>
        /// <returns>The student if found, or null if not.</returns>
        /// <exception cref="SqlException">Thrown when a SQL error occurs.</exception>
        public IUserType? findExistingUserType(object objectUser)
        {
            User selectedUser = (User)objectUser;

                using (var db = new Context())
                {
                    return db.Students.Where(x => x.User.Id == selectedUser.Id)
                    .Include(x => x.User)
                    .Include(x => x.LoginInformation)
                    .Cast<IUserType>()
                    .FirstOrDefault();
                }
        }

        /// <summary>
        /// Finds the last created student in the database.
        /// </summary>
        /// <returns>The last created student, or null if not found.</returns>
        /// <exception cref="SqlException">Thrown when a SQL error occurs.</exception>
        public IUserType? findLastCreatedUserType()
        {
                using (var db = new Context())
                {
                    return db.Students
                    .OrderByDescending(x => x.CreatedAt)
                    .Include(x => x.User)
                    .Cast<IUserType>()
                    .FirstOrDefault();
                }
        }

        /// <summary>
        /// Finds a deleted student by their associated user object.
        /// </summary>
        /// <param name="objectUser">The user object used to find the deleted student.</param>
        /// <returns>The deleted student if found, or null if not.</returns>
        /// <exception cref="SqlException">Thrown when a SQL error occurs.</exception>
        public IUserType? findDeletedUserType(object objectUser)
        {
            User selectedUser = (User)objectUser;

                using (var db = new Context())
                {
                    return db.Students
                    .Where(x => x.User.Id == selectedUser.Id && x.DeletedAt != null)
                    .Include(x => x.User)
                    .Include(x => x.LoginInformation)
                    .Cast<IUserType>()
                    .FirstOrDefault();
                }
        }

        /// <summary>
        /// Checks if a user type exists in the database.
        /// </summary>
        /// <param name="objectUser">The user object used to check existence.</param>
        /// <returns>True if the user type exists and is not deleted, false otherwise.</returns>
        /// <exception cref="SqlException">Thrown when a SQL error occurs.</exception>
        public bool doesUserTypeExist(object objectUser)
        {
            User selectedUser = (User)objectUser;

                using (var db = new Context())
                {
                    return db.Students.Any(x => x.User.Id == selectedUser.Id && x.DeletedAt == null);
                }
        }

        /// <summary>
        /// Searches for students based on a string query in their name or last name.
        /// </summary>
        /// <param name="search">The search string to filter students by name or last name.</param>
        /// <returns>A list of students matching the search criteria.</returns>
        /// <exception cref="SqlException">Thrown when a SQL error occurs.</exception>
        public List<IUserType> searchBoxUserTypeWithString(string search)
        {
            using (var db = new Context())
            {
                return db.Students
                    .Where(x => (x.User.Name.StartsWith(search) || x.User.LastName.StartsWith(search)))
                    .Include(x => x.LoginInformation).Include(x => x.User)
                    .Cast<IUserType>()
                    .ToList();
            }
        }

        /// <summary>
        /// Searches for students based on a DNI query.
        /// </summary>
        /// <param name="search">The DNI number to filter students.</param>
        /// <returns>A list of students matching the DNI criteria.</returns>
        /// <exception cref="SqlException">Thrown when a SQL error occurs.</exception>
        public List<IUserType> searchBoxUserTypeWithInt(int search)
        {
            using (var db = new Context())
            {
                return db.Students
                    .Where(x => x.User.Dni.ToString()
                    .StartsWith(search.ToString()))
                    .Include(x => x.LoginInformation)
                    .Include(x => x.User)
                    .Cast<IUserType>()
                    .ToList();
            }
        }

        /// <summary>
        /// Checks if a given email is unique for user types.
        /// </summary>
        /// <param name="email">The email to check for uniqueness.</param>
        /// <returns>True if the email is unique, false otherwise.</returns>
        /// <exception cref="SqlException">Thrown when a SQL error occurs.</exception>
        public bool isUserTypeEmailUnique(string email)
        {
            string? userTypeEmail = string.Empty;

            using (var db = new Context())
            {
                return db.Students.Any(x => x.LoginInformation.Email != email && x.LoginInformation.Email != userTypeEmail);
            }
        }

        /// <summary>
        /// Loads all user types except those marked as deleted.
        /// </summary>
        /// <returns>A list of active user types.</returns>
        /// <exception cref="SqlException">Thrown when a SQL error occurs.</exception>
        public List<IUserType> LoadUserTypesExceptDeleted()
        {
            using (var db = new Context())
            {
                return db.Students.Where(x => x.DeletedAt == null).Include(x => x.User).Cast<IUserType>().ToList();
            }
        }

        /// <summary>
        /// Reactivates a previously deleted user type by removing the deletion date.
        /// </summary>
        /// <param name="student">The student object to be reactivated.</param>
        /// <exception cref="DbUpdateException">Thrown when the database update fails.</exception>
        public void ReactivateDeletedUserType(Student student)
        {
            using (var db = new Context())
            {
                student.DeletedAt = null;
                student.UpdatedAt = DateTime.Now;
                db.Update(student);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Gets a list of values from a student's academic record for form purposes.
        /// </summary>
        /// <param name="student">The student from which to extract values.</param>
        /// <returns>A list of values related to the student's academic record.</returns>
        public List<dynamic?> GetUserTypeValuesFormAcademicRecord(Student student)
        {
            string? dateTime = student.User.DateOfBirth?.ToString("dd/MM/yyyy") ?? string.Empty;

            return new List<dynamic?>
        {
            student.Id.ToString(),
            $"{student.User.LastName} {student.User.Name}",
            student.User.Dni.ToString(),
            student.User.PhoneNumbre,
            student.LoginInformation.Email,
            dateTime,
            student.User.PlaceOfBirth,
            student.User.EmergencyPhoneNumber,
            student.User.Gender,
            student.HighSchoolTitPhotocopy,
            student.BirthCertificate,
            student.CuilConstansy,
            student.DniPhotocopy,
            student.MedicalCertificate,
            student.Photo4x4,
            student.Cooperative
        };
        }

        /// <summary>
        /// Gets a list of general values from a student's record.
        /// </summary>
        /// <param name="student">The student from which to extract values.</param>
        /// <returns>A list of general values related to the student's record.</returns>
        public List<dynamic?> GetUserTypeValues(Student student)
        {
            return new List<dynamic?>
        {
            student.LoginInformation.Email,

            student.WorkActivity,
            student.WorkingHours,
            student.SocialWork,
            student.HighSchoolTitPhotocopy,
            student.BirthCertificate,
            student.CuilConstansy,
            student.DniPhotocopy,
            student.MedicalCertificate,
            student.Photo4x4,
            student.Cooperative
        };
        }

    }
}
