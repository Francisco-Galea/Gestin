using System;

/// <summary>
/// Interface for security services related to password management.
/// </summary>
public interface ISaltEncryptService
{
    /// <summary>
    /// Generates a new salt for the password encryption process.
    /// </summary>
    /// <returns>A byte array representing the generated salt.</returns>
    byte[] GenerateSalt();

    /// <summary>
    /// Encrypts a password using a specified salt.
    /// </summary>
    /// <param name="password">The password to encrypt.</param>
    /// <param name="salt">The salt to use in the encryption.</param>
    /// <returns>A byte array representing the encrypted password.</returns>
    byte[] EncryptPassword(string password, byte[] salt);

    /// <summary>
    /// Encrypts a password and returns it as a hexadecimal string.
    /// </summary>
    /// <param name="password">The password to encrypt.</param>
    /// <param name="salt">The salt to use in the encryption.</param>
    /// <returns>A hexadecimal string representing the encrypted password.</returns>
    string EncryptPasswordToHexString(string password, byte[] salt);

    /// <summary>
    /// Validates if a provided password matches a stored password.
    /// </summary>
    /// <param name="storedPassword">The stored (encrypted) password.</param>
    /// <param name="providedPassword">The provided (encrypted) password to validate.</param>
    /// <returns>True if the passwords match; otherwise, false.</returns>
    bool ValidatePassword(byte[] storedPassword, byte[] providedPassword);
}
