using TFG.HomeWorks.Application.ExternalServices.Files.SaveImage;

namespace TFG.HomeWorks.Application.ExternalServices.Files
{
    public interface IFileStorageService
    {
        Task<string> SaveImageAsync(SaveImageRequest request);
    }
}
