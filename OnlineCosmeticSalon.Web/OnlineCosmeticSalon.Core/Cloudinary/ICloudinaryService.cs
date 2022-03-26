using Microsoft.AspNetCore.Http;

namespace OnlineCosmeticSalon.Core.Cloudinary
{
    public interface ICloudinaryService
    {
        Task<string> UploadPictureAsync(IFormFile pictureFile, string fileName);
    }
}
