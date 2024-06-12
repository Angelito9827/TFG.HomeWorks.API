using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using TFG.HomeWorks.Application.ExternalServices.Files;
using TFG.HomeWorks.Application.ExternalServices.Files.SaveImage;
using TFG.HomeWorks.Infrastructure.Options;

namespace TFG.HomeWorks.Infrastructure.ExternalServices
{
    internal class LocalFileStorageService : IFileStorageService
    {
        private readonly FileStorageFilePaths _imagesFilePathSettings;

        public LocalFileStorageService(
            IOptions<FileStorageFilePaths> imagesFilePathSettings
            )
        {
            _imagesFilePathSettings = imagesFilePathSettings.Value;
        }

        public async Task<string> SaveImageAsync(SaveImageRequest request)
        {

            if (request.File is null || request.File.Length == 0 || request.FileName.IsNullOrEmpty())
                return _imagesFilePathSettings.DefaultImagePath;

            var uploadFolder = Path.Combine(_imagesFilePathSettings.RootPath, _imagesFilePathSettings.UploadsPath, _imagesFilePathSettings.ImagesPath);

            if (!Directory.Exists(uploadFolder))
                Directory.CreateDirectory(uploadFolder);

            var uniqueFileName = $"{Guid.NewGuid()}_{request.FileName}";

            var filePath = Path.Combine(uploadFolder, uniqueFileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                request.File.Seek(0, SeekOrigin.Begin);
                await request.File.CopyToAsync(fileStream);
            }

            // Return relative path for later URL construction
            return Path.Combine(_imagesFilePathSettings.UploadsPath, _imagesFilePathSettings.ImagesPath, uniqueFileName).Replace("\\", "/");
        }
        public void DeleteImage(string filePath)
        {

            if (filePath == null || filePath.Equals(_imagesFilePathSettings.DefaultImagePath))
                return;

            var fullPath = Path.Combine(_imagesFilePathSettings.RootPath, filePath);

            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }
        }
    }
}
