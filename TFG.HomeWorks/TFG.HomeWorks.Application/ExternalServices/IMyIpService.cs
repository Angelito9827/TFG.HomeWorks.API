namespace TFG.HomeWorks.Application.ExternalServices
{
    internal interface IMyIpService
    {
        Task<string> GetIPAsync();
    }
}