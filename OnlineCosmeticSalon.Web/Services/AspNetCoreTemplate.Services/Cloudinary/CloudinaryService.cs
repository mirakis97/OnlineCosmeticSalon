namespace AspNetCoreTemplate.Services.Cloudinary
{
    using CloudinaryDotNet;
    using CloudinaryDotNet.Actions;
    using Microsoft.AspNetCore.Http;
    using System.IO;
    using System.Threading.Tasks;

    public class CloudinaryService : ICloudinaryService
    {
        private readonly Cloudinary cloudinary;

        public CloudinaryService(Cloudinary cloudinary)
        {
            this.cloudinary = cloudinary;
        }

        public async Task<string> UploadPictureAsync(IFormFile pictureFile, string fileName)
        {
            byte[] destinationData;

            using (var ms = new MemoryStream())
            {
                await pictureFile.CopyToAsync(ms);
                destinationData = ms.ToArray();
            }

            UploadResult uploadResult = null;

            using (var ms = new MemoryStream(destinationData))
            {
                ImageUploadParams uploadParams = new ImageUploadParams
                {
                    Folder = "samples",
                    File = new FileDescription(fileName, ms),
                };

                uploadResult = this.cloudinary.Upload(uploadParams);
            }

            return uploadResult?.SecureUri.AbsoluteUri;
        }
    }
}
