using TFG.HomeWorks.Application.ExternalServices.Files.SaveImage;

namespace TFG.HomeWorks.Application.ExternalServices.Files
{
    public interface IFileStorageService
    {
        void DeleteImage(string filePath);
        Task<string> SaveImageAsync(SaveImageRequest request);
    }
}
