using Gestin.Interfaces;
using Gestin.Model;

namespace Gestin.Controllers.Strategy
{

    internal class UserTypeStrategyController 
    {
        //In this case, the UserType controllers (Student, Teacher) are the concrete strategies.

        //The context would be the View component (such as formUserType) or wherever it's required to set a correct controller strategy.

        private readonly IUserTypeController strategyController;

        public UserTypeStrategyController(IUserTypeController concreteController)
        {
            strategyController = concreteController;
        }

        public List<IUserType> loadUserTypes() { return strategyController.loadUserTypes(); }

        public List<IUserType> loadUserTypesExceptDeleted() { return strategyController.loadUserTypesExceptDeleted(); }

        public int countUserTypes() { return strategyController.countUserType(); }

        public IUserType? findUserType(int dni) { return strategyController.findUserTypeByDNI(dni); }

        public IUserType? findUserType(object objectUser) { return strategyController.findUserType(objectUser); }

        public IUserType? findExistingUserType(object objectUser) { return strategyController.findExistingUserType(objectUser); }

        public IUserType? findDeletedUserType(object objectUser) { return strategyController.findDeletedUserType(objectUser); }

        public IUserType? findLastCreatedUserType() { return strategyController.findLastCreatedUserType(); }

        public void saveUserType(object user, string originalemail, string usermail, string password, params dynamic?[] parameters) { strategyController.saveUserType(user, originalemail, usermail, password, parameters); }

        public bool createUserType(User existingUser, LoginInformation login, dynamic?[] parameters) { return strategyController.createUserType(existingUser, login, parameters); }

        public void updateUserType(IUserType existingUserType, dynamic?[] parameters) { strategyController.updateUserType(existingUserType, parameters); }

        public void softDeleteUserType(object objectUser) { strategyController.softDeleteUserType(objectUser); }

        public void reactivateDeletedUserType(object objectUser) { strategyController.reactivateDeletedUserType(objectUser); }

        public bool isUserTypeDeleted(object objectUser) { return strategyController.isUserTypeDeleted(objectUser); }

        public bool doesUserTypeExist(object objectUser) { return strategyController.doesUserTypeExist(objectUser); }

        public IUserType getUserType(object objectUserType) { return strategyController.getUserType(objectUserType); }

        public int getUserTypeId(object userType) { return strategyController.getUserTypeId(userType); }

        public int getUserTypeDNI(object userType) { return strategyController.getUserTypeDNI(userType); }

        public string getUserTypeFullName(object userType) { return strategyController.getUserTypeFullName(userType); }

        public List<IUserType> searchBoxUserTypeWithString(string search) { return strategyController.searchBoxUserTypeWithString(search); }

        public List<IUserType> searchBoxUserTypeWithInt(int search) { return strategyController.searchBoxUserTypeWithInt(search); }

    }
}
