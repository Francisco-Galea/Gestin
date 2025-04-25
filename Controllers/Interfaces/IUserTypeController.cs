using Gestin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestin.Interfaces
{
    internal interface IUserTypeController
    {
        public List<IUserType> loadUserTypes();

        public List<IUserType> loadUserTypesExceptDeleted();

        public int countUserType();

        public IUserType? findUserType(object objectUser);

        public IUserType? findUserTypeById(int id);

        public IUserType? findUserTypeByDNI(int dni);

        public IUserType? findDeletedUserType(object objectUser);

        public IUserType? findExistingUserType(object objectUser);

        public IUserType? findLastCreatedUserType();

        public void saveUserType(object user, string originalemail, string usermail, string password, params dynamic?[] parameters);

        public bool createUserType(User existingUser, LoginInformation login, dynamic?[] parameters);

        public void updateUserType(IUserType existingUserType, dynamic?[] parameters);

        public void softDeleteUserType(object objectUser);

        public void reactivateDeletedUserType(object objectUser);

        public bool doesUserTypeExist(object objectUser);

        public bool isUserTypeDeleted(object objectUser);

        public IUserType getUserType(object objectUserType);

        public int getUserTypeId(object userType);

        public int getUserTypeDNI(object userType);

        public string getUserTypeFullName(object userType);

        public List<dynamic?> getUserTypeValues(object userTypeObject);

        public List<IUserType> searchBoxUserTypeWithString(string search);

        public List<IUserType> searchBoxUserTypeWithInt(int search);

        public bool isUserTypeEmailUnique(object user, string email);

    }
}
