using System.Security.Cryptography;
using System.Text;

namespace BookstoreManagementSystemLibrary.Helpers
{
    public static class HashHelper
    {
        /// <summary>
        /// Computes a SHA-256 hash for the given password and Salt, and returns the result as a Base64 string.
        /// </summary>
        /// <param name="password">The password to hash.</param>
        /// <param name="salt">The Salt to use for hashing.</param>
        /// <returns>A Base64 string representing the hashed value.</returns>
        public static string GetHash(string password, string salt)
        {
            byte[] unhashedBytes = Encoding.Unicode.GetBytes(string.Concat(salt, password));
            byte[] hashedBytes = SHA256.HashData(unhashedBytes);
            return Convert.ToBase64String(hashedBytes);
        }

        /// <summary>
        /// Compares an attempted password against the stored Base64 hash.
        /// </summary>
        /// <param name="attemptedHash">The password to verify.</param>
        /// <param name="base64Hash">The stored Base64 hash to compare against.</param>
        /// <param name="salt">The Salt that was used to generate the stored hash.</param>
        /// <returns>True if the attempted password produces the same hash; otherwise, false.</returns>
        public static bool CompareHash(string attemptedHash, string base64Hash, string salt)
        {
            string base64AttemptedHash = GetHash(attemptedHash, salt);
            return base64Hash == base64AttemptedHash;
        }
    }
}