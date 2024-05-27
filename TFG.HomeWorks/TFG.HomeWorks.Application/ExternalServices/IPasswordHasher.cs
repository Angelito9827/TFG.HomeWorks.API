namespace TFG.HomeWorks.Application.ExternalServices
{
    public interface IPasswordHasher
    {
        string Generate(string password, string salt);
    }
}
