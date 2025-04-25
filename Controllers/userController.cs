using Gestin.Model;
using Gestin.Properties;
using Gestin.UI.Custom;
using System.Data.SqlClient;

namespace Gestin.Controllers
{
    internal class userController
    {
        sessionController sessionController = sessionController.getInstance();
        #region  Singleton

        static userController? Instance;

        private userController() { }

        public static userController getInstance()
        {
            if (Instance == null)
            {
                Instance = new userController();
            }
            return Instance;
        }

        #endregion


        #region Loaders

        public List<User> loadUsers()
        {
            using (var db = new Context())
            {
                return db.Users.OrderBy(x => x.LastName).ToList();
            }
        }

        #endregion


        #region User

        public int countUsers()
        {
            try
            {
                using (var db = new Context())
                {
                    return db.Users.Count();
                }
            }
            catch (SqlException) { throw; }
        }

        public User? findAnyUser(int dni)
        {
            try
            {
                using (var db = new Context())
                {
                    return db.Users.Where(x => x.Dni == dni).FirstOrDefault();
                }
            }
            catch (SqlException) { throw; }
        }

        public User? findUser(int dni)
        {
            try
            {
                using (var db = new Context())
                {
                    return db.Users.Where(x => x.Dni == dni && x.DeletedAt == null).FirstOrDefault();
                }
            }
            catch (SqlException) { throw; }
        }

        public User? findUser(object user)
        {
            User selectedUser = (User)user;

            try
            {
                using (var db = new Context())
                {
                    return db.Users.Where(x => x.Dni == selectedUser.Dni && x.DeletedAt == null).FirstOrDefault();
                }
            }
            catch (SqlException) { throw; }
        }

        public User findUser(Student student)
        {
            try
            {
                using (var db = new Context())
                {
                    return db.Users.Where(x => x.Id == student.UserId && x.DeletedAt == null).FirstOrDefault();
                }
            }
            catch (SqlException) { throw; }
        }

        public User? findDeletedUser(int dni)
        {
            try
            {
                using (var db = new Context())
                {
                    return db.Users.Where(x => x.Dni == dni && x.DeletedAt != null).FirstOrDefault();
                }
            }
            catch (SqlException) { throw; }
        }

        public User? findLastCreatedUser()
        {
            try
            {
                using (var db = new Context())
                {
                    return db.Users.OrderByDescending(x => x.CreatedAt).FirstOrDefault();
                }
            }
            catch (SqlException) { throw; }
        }
        

        public bool checkSameUserDNI(int dni)
        {
            if (findUser(dni) != null)
            {
                return true;
            }
            return false;
        }

        public User getUser(object user)
        {
            return (User)user;
        }

        public string getUserFullName(object user)
        {
            return ((User)user).fullName();
        }

        public List<string?> getUserValues(object selectedUser)
        {
            User user = (User)selectedUser;

            List<string?> userValues = new()
            {
                Convert.ToString(user.Dni),
                user.LastName,
                user.Name,
                user.PhoneNumbre,
                getCorrectedDateTime(user.DateOfBirth),
                user.PlaceOfBirth,
                user.EmergencyPhoneNumber,
                user.Gender,
            };

            return userValues;
        }

        public string getCorrectedDateTime(DateTime? dateBirth)
        {
            string correctedDateTime = "";

            if (dateBirth.HasValue)
                correctedDateTime = Convert.ToString(dateBirth.Value);

            return correctedDateTime;            
        }

        public bool createUser(int Dni, string name, string lastname, DateTime? dateOfBirth, string placeOfBirth,
                                string phone, string emergencyphone, string? gender)
        {
            if (findAnyUser(Dni) != null)
            {
                new MessageBoxDarkMode($"Existe un usuario con el DNI: {Dni}", "DNI Error", "Ok", Resources.Error, true);
                return false;
            }

            try
            {
                User user = new User();
                user.Dni = Dni;
                user.Name = name;
                user.LastName = lastname;
                user.DateOfBirth = dateOfBirth;
                user.PlaceOfBirth = placeOfBirth;
                user.Gender = gender;
                user.PhoneNumbre = phone;
                user.EmergencyPhoneNumber = emergencyphone;
                user.CreatedAt = DateTime.Now;
                user.LastModificationBy = name + " " + lastname;

                using (var db = new Context())
                {
                    db.Users.Add(user);
                    return db.SaveChanges() > 0;
                }
            }
            
            catch (SqlException) { throw; }
        }

        public bool updateUser(object objectUser, int Dni, string name, string lastname, DateTime? dateOfBirth, string? placeOfBirth,
                                string? phone, string? emergencyphone, string? gender)
        {
            User selectedUser = (User)objectUser;
            User? existingUser = findAnyUser(Dni);

            if (existingUser != null && existingUser.Id != selectedUser.Id) //If A != A (not the same user)
            {
                new MessageBoxDarkMode("Existe un usuario con el mismo DNI", "DNI Error", "Ok", Resources.Error, true);
                return false;
            }

            try
            {
                selectedUser.Dni = Dni;
                selectedUser.Name = name;
                selectedUser.LastName = lastname;
                selectedUser.DateOfBirth = dateOfBirth;
                selectedUser.PlaceOfBirth = placeOfBirth;
                selectedUser.Gender = gender;
                selectedUser.PhoneNumbre = phone;
                selectedUser.EmergencyPhoneNumber = emergencyphone;
                selectedUser.CreatedAt = DateTime.Now;
                selectedUser.LastModificationBy = name + " " + lastname;

                using (var db = new Context())
                {
                    db.Update(selectedUser);
                    return db.SaveChanges() > 0;
                }
            }
            catch (SqlException) { throw; }
        }

        public bool softDeleteUser(object objectUser)
        {
            User existingUser = (User) objectUser;
            try
            {
                existingUser.DeletedAt = DateTime.Now;
                existingUser.LastModificationBy = sessionController.getSessionedUserData();
                using (var db = new Context())
                {
                    db.Update(existingUser);
                    return db.SaveChanges() > 0;
                }
            }
            catch (SqlException) { throw; }
        }

        public bool reactivateUser(int dni)
        {
            User? user = findDeletedUser(dni);
            try
            {
                if (user != null)
                {
                    user.DeletedAt = null;
                    user.UpdatedAt = DateTime.Now;
                    user.LastModificationBy = sessionController.getSessionedUserData();
                    using (var db = new Context())
                    {
                        db.Update(user);
                        return db.SaveChanges() > 0;
                    }
                }
            }
            catch (SqlException) { throw; }
            return false;
        }

        public List<User> searchBoxUserWithString(string search)
        {
            using (var db = new Context())
            {
                return db.Users
                    .Where(x => (x.Name.StartsWith(search) || x.LastName.StartsWith(search)) && x.DeletedAt == null)
                    .ToList();
            }
        }
        public List<User> searchBoxUserWithInt(int search)
        {
            using (var db = new Context())
            {
                return db.Users
                    .Where(x => x.Dni.ToString().StartsWith(search.ToString()) && x.DeletedAt == null)
                    .ToList();
            }
        }

        #endregion
    }
}
