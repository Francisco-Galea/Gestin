using Gestin.Properties;
using Gestin.UI.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestin.Validators
{
    public static class passwordValidator
    {
        static int minPasswordLength = 8;

        public static bool isNull(string password)
        {
            return string.IsNullOrWhiteSpace(password) || password.Contains('☺');
        }

        public static bool obfuscatedPasswordExists(string password)
        {
            return password.Contains('☺');
        }

        public static bool arePasswordsNull(string password, string confirmPassword)
        {
            return isNull(password) && isNull(confirmPassword);
        }

        public static bool arePasswordsMinimumLength(string password, string confirmPassword)
        {
            return password.Length >= minPasswordLength && confirmPassword.Length >= minPasswordLength;
        }

        public static bool arePasswordsSame(string password, string confirmPassword)
        {
            return password.Equals(confirmPassword);
        }
    }
}
