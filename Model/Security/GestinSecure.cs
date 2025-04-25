using System.Security.Cryptography;

namespace Gestin.Model.Security
{
    internal static class GestinSecure
    {
        internal static byte[] generateRandomBytes()
        {
            return RandomNumberGenerator.GetBytes(64);
        }
        internal static byte[] encryptPassword(string password, byte[] salt) 
        {
            return Encryptor(password, salt);
        }

        internal static string encryptPasswordHexString(string password, byte[] salt)
        {
            var hash = Encryptor(password, salt);
            return Convert.ToHexString(hash);
        }

        private static byte[] Encryptor(string password, byte[] salt)
        {
            return Rfc2898DeriveBytes.Pbkdf2
            (
            password,
            salt,
            350000,
            HashAlgorithmName.SHA512,
            64
            );
        }

        internal static bool validateByteArrays(byte[] array1, byte[] array2)
        {
            if (array1 == null || array2 == null)
            {
                return false;
            }

            if (array1.Length != array2.Length)
            {
                return false;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
