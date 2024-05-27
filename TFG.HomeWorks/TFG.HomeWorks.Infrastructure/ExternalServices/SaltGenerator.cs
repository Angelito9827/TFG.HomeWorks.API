using System.Security.Cryptography;
using System.Text;
using TFG.HomeWorks.Application.ExternalServices;

namespace TFG.HomeWorks.Infrastructure.ExternalServices
{
    internal class SaltGenerator : ISaltGenerator
    {
        public string Generate()
        {
            // Generate a random salt using RandomNumberGenerator
            byte[] saltBytes = new byte[32]; // 256 bits
            RandomNumberGenerator.Fill(saltBytes);

            // Convert the salt bytes to a hexadecimal string
            StringBuilder saltBuilder = new StringBuilder();
            foreach (byte b in saltBytes)
            {
                saltBuilder.Append(b.ToString("x2"));
            }

            return saltBuilder.ToString();
        }

    }
}
