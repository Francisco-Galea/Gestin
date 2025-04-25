using Gestin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestin.Controllers
{
    public class combinedController
    {
        // Certain methods contain logic too complex for the corresponding class. If I were to add them to said corresponding class, it would create
        // a circular dependency issue as these classes also intersect each other. The solution is to create a seperate class for these complex methods. 

        static userController userController = userController.getInstance();
        static studentController studentController = studentController.getInstance();
        static teacherController teacherController = teacherController.getInstance();

        #region Outsiders

        public static List<User> listRolelessUsers()
        {
            List<User> rolelessUsers = userController.loadUsers();

            HashSet<int> studentIdHash = new HashSet<int>(studentController.loadUserTypesExceptDeleted().ConvertAll(x => x as Student).Select(student => student.User.Id));
            HashSet<int> teacherIdHash = new HashSet<int>(teacherController.loadUserTypesExceptDeleted().ConvertAll(x => x as Teacher).Select(teacher => teacher.User.Id));

            rolelessUsers.RemoveAll(user => studentIdHash.Contains(user.Id) || teacherIdHash.Contains(user.Id));

            return rolelessUsers;
        }

        public static List<string> getAllUserEmails(object selectedUser)
        {
            User? user = userController.findUser(selectedUser);
            string? studentEmail = string.Empty, teacherEmail = string.Empty;
            List<string> listEmails = new();

            using (var db = new Context())
            {
                if (user != null)
                {
                    studentEmail = db.Students.Where(x => x.UserId == user.Id && x.DeletedAt == null).Select(x => x.LoginInformation.Email).FirstOrDefault();
                    teacherEmail = db.Teachers.Where(x => x.UserId == user.Id && x.DeletedAt == null).Select(x => x.LoginInformation.Email).FirstOrDefault();
                }
            }

            if (!string.IsNullOrEmpty(studentEmail))
            {
                listEmails.Add(studentEmail);
            }
            if (!string.IsNullOrEmpty(teacherEmail))
            {
                listEmails.Add(teacherEmail);
            }
            return listEmails;
        }
        #endregion
    }
}
