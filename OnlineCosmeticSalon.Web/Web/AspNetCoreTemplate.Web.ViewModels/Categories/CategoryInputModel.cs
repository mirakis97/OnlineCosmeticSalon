using AspNetCoreTemplate.Common;
using AspNetCoreTemplate.Web.ViewModels.Common.CustomValidationAttributes;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTemplate.Web.ViewModels.Categories
{
    public class CategoryInputModel
    {
        [Required]
        [StringLength(
           GlobalConstants.DataValidations.NameMaxLength,
           ErrorMessage = GlobalConstants.ErrorMessages.Name,
           MinimumLength = GlobalConstants.DataValidations.NameMinLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(
            GlobalConstants.DataValidations.DescriptionMaxLength,
            ErrorMessage = GlobalConstants.ErrorMessages.Description,
            MinimumLength = GlobalConstants.DataValidations.DescriptionMinLength)]
        public string Description { get; set; }

        [DataType(DataType.Upload)]
        [ValidateImageFile(ErrorMessage = GlobalConstants.ErrorMessages.Image)]
        public IFormFile Image { get; set; }
    }
}