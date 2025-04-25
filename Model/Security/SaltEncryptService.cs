using Gestin.Model.Security;

/// <summary>
/// Implementation of the security service that provides methods for generating salt and encrypting passwords.
/// </summary>
public class SecurityService : ISaltEncryptService
{
    /// <summary>
    /// Generates a new salt using a secure random byte generation method.
    /// </summary>
    /// <returns>A byte array representing the generated salt.</returns>
    public byte[] GenerateSalt()
    {
        return GestinSecure.generateRandomBytes();
    }

    /// <summary>
    /// Encrypts a password using a specified salt.
    /// </summary>
    /// <param name="password">The password to encrypt.</param>
    /// <param name="salt">The salt to use in the encryption process.</param>
    /// <returns>A byte array representing the encrypted password.</returns>
    public byte[] EncryptPassword(string password, byte[] salt)
    {
        return GestinSecure.encryptPassword(password, salt);
    }

    /// <summary>
    /// Encrypts a password and returns it as a hexadecimal string.
    /// </summary>
    /// <param name="password">The password to encrypt.</param>
    /// <param name="salt">The salt to use in the encryption.</param>
    /// <returns>A hexadecimal string representing the encrypted password.</returns>
    public string EncryptPasswordToHexString(string password, byte[] salt)
    {
        return GestinSecure.encryptPasswordHexString(password, salt);
    }

    /// <summary>
    /// Validates whether a provided password matches the stored password.
    /// </summary>
    /// <param name="storedPassword">The stored (encrypted) password.</param>
    /// <param name="providedPassword">The provided (encrypted) password for validation.</param>
    /// <returns>True if the passwords match; otherwise, false.</returns>
    public bool ValidatePassword(byte[] storedPassword, byte[] providedPassword)
    {
        return GestinSecure.validateByteArrays(storedPassword, providedPassword);
    }
}
