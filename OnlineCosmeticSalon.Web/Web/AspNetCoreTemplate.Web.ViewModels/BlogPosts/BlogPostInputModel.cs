using AspNetCoreTemplate.Common;
using AspNetCoreTemplate.Web.ViewModels.Common.CustomValidationAttributes;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTemplate.Web.ViewModels.BlogPosts
{
    public class BlogPostInputModel
    {
        [Required]
        [StringLength(
            GlobalConstants.DataValidations.TitleMaxLength,
            ErrorMessage = GlobalConstants.ErrorMessages.Title,
            MinimumLength = GlobalConstants.DataValidations.TitleMinLength)]
        public string Title { get; set; }

        [Required]
        [StringLength(
            GlobalConstants.DataValidations.ContentMaxLength,
            ErrorMessage = GlobalConstants.ErrorMessages.Content,
            MinimumLength = GlobalConstants.DataValidations.ContentMinLength)]
        public string Content { get; set; }

        [Required]
        [StringLength(
            GlobalConstants.DataValidations.NameMaxLength,
            ErrorMessage = GlobalConstants.ErrorMessages.Author,
            MinimumLength = GlobalConstants.DataValidations.NameMinLength)]
        public string Author { get; set; }

        [Required]
        [DataType(DataType.Upload)]
        [ValidateImageFile(ErrorMessage = GlobalConstants.ErrorMessages.Image)]
        public IFormFile Image { get; set; }
    }
}
