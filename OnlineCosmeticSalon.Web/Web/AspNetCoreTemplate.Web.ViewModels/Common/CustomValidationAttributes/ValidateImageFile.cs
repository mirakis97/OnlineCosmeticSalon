using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTemplate.Web.ViewModels.Common.CustomValidationAttributes
{
    public class ValidateImageFileAttribute : RequiredAttribute
    {
        private const int MaxFileLengthInBytes = 1048576;

        public override bool IsValid(object value)
        {
            // Represents the file sent with the HttpRequest
            IFormFile file = value as IFormFile;

            if (file == null)
            {
                return false;
            }

            if (file.Length > MaxFileLengthInBytes)
            {
                return false;
            }

            // Check the image mime types
            if (file.ContentType.ToLower() != "image/jpg"
                && file.ContentType.ToLower() != "image/jpeg"
                && file.ContentType.ToLower() != "image/png")
            {
                return false;
            }

            return true;
        }
    }
}
