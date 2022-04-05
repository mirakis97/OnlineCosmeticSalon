using AspNetCoreTemplate.Common;
using AspNetCoreTemplate.Web.ViewModels.Common.CustomValidationAttributes;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTemplate.Web.ViewModels.Salons
{
    public class SalonInputModel
    {
        [Required]
        [StringLength(
           GlobalConstants.DataValidations.NameMaxLength,
           ErrorMessage = GlobalConstants.ErrorMessages.Name,
           MinimumLength = GlobalConstants.DataValidations.NameMinLength)]
        public string Name { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int CityId { get; set; }

        [Required]
        [StringLength(
            GlobalConstants.DataValidations.AddressMaxLength,
            ErrorMessage = GlobalConstants.ErrorMessages.Address,
            MinimumLength = GlobalConstants.DataValidations.AddressMinLength)]
        public string Address { get; set; }

        [DataType(DataType.Upload)]
        [ValidateImageFile(ErrorMessage = GlobalConstants.ErrorMessages.Image)]
        public IFormFile Image { get; set; }
    }
}
