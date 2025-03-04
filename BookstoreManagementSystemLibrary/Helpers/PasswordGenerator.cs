using System.Security.Cryptography;
using System.Text;

namespace BookstoreManagementSystemLibrary.Helpers
{
    public static class PasswordGenerator
    {
        private static readonly char[] AllowedChars = "abcdefghjklmnprstuvwxyzABCDEFGHJKLMNQRSTUVWXYZ2345678".ToCharArray();

        /// <summary>
        /// Generates a random password of the specified length, excluding ambiguous characters like '0' and 'o'.
        /// </summary>
        /// <param name="length">The desired length of the password.</param>
        /// <returns>A random password string.</returns>
        public static string GenerateRandomPassword(this int length)
        {
            if (length <= 0)
                throw new ArgumentOutOfRangeException(nameof(length), "Password length must be greater than 0.");

            var password = new StringBuilder(length);
            using (var rng = RandomNumberGenerator.Create())
            {
                byte[] randomBytes = new byte[length];
                rng.GetBytes(randomBytes);

                for (int i = 0; i < length; i++)
                {
                    int index = randomBytes[i] % AllowedChars.Length;
                    password.Append(AllowedChars[index]);
                }
            }
            return password.ToString();
        }
    }
}