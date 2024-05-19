namespace TFG.HomeWorks.Application.Security
{
    public class CurrentUser
    {
        public string Email { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }

    public interface ICurrentUserAccessor
    {
        CurrentUser CurrentUser { get; }
    }
}
