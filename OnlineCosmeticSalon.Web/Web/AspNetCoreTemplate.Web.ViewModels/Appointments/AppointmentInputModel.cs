using AspNetCoreTemplate.Common;
using System.ComponentModel.DataAnnotations;
using AspNetCoreTemplate.Web.ViewModels.Common.CustomValidationAttributes;

namespace AspNetCoreTemplate.Web.ViewModels.Appointments
{
    public class AppointmentInputModel
    {
        [Required]
        public string SalonId { get; set; }

        [Required]
        public int ServiceId { get; set; }

        [Required]
        [ValidateDateString(ErrorMessage = GlobalConstants.ErrorMessages.DateTime)]
        public string Date { get; set; }

        [Required]
        [ValidateTimeString(ErrorMessage = GlobalConstants.ErrorMessages.DateTime)]
        public string Time { get; set; }
    }
}
