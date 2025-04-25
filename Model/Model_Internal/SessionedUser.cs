using Gestin.Interfaces;

namespace Gestin.Model.Model_Internal
{
    public class SessionedUser
    {
        public IUserType? sessionedUser { get; private set; }

        private static readonly object lockedSessionUserInstance = new object();

        private static SessionedUser? instance;

        public static SessionedUser Instance  //only one user can be in session at a time
        {
            get
            {
                lock (lockedSessionUserInstance) //redudancy to prevent a random thread from creating a new instance
                {
                    if (instance == null)
                    {
                        instance = new SessionedUser();
                    }
                    return instance;
                }
            }
        }

        private SessionedUser() { }

        public void setSessionedUser(IUserType userType)
        {
            sessionedUser = userType;
        }

        public bool checkExistingUserSession()
        {
            return sessionedUser != null;
        }

        public IUserType? getSessionedUser()
        {
            return sessionedUser != null ? sessionedUser : null;
        }

        public string getSessionedUserData()
        {
            return sessionedUser != null ? sessionedUser.getUserRoleAndName() : string.Empty;
        }

        public string getSessionedUserEmail()
        {
            return sessionedUser != null ? sessionedUser.getUserEmail() : string.Empty;
        }

        public void nullifySession()
        {
            sessionedUser = null;
        }
    }
}
