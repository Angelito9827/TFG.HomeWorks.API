using System.Security.Cryptography;
using System.Text;
using TFG.HomeWorks.Application.ExternalServices;

namespace TFG.HomeWorks.Infrastructure.ExternalServices
{
    internal class PasswordHasher : IPasswordHasher
    {
        public string Generate(string password, string salt)
        {
            var hashedBytes = SHA512.HashData(Encoding.UTF8.GetBytes(password));

            // Convert the hashed bytes to a hexadecimal string
            var builder = new StringBuilder();
            foreach (var b in hashedBytes)
            {
                builder.Append(b.ToString("x2"));
            }
            return builder.ToString();
        }
    }
}
