using AspNetCoreTemplate.Common;
using AspNetCoreTemplate.Data.Models;
using AspNetCoreTemplate.Services.Mapping;
using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTemplate.Web.ViewModels.Appointments
{
    public class AppointmentRatingViewModel : IMapFrom<Appointment>
    {
        public string Id { get; set; }

        public string SalonId { get; set; }

        public string SalonName { get; set; }

        public string SalonCategoryName { get; set; }

        public string SalonCityName { get; set; }

        public string SalonAddress { get; set; }

        public string SalonImageUrl { get; set; }

        public bool? IsSalonRatedByTheUser { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = GlobalConstants.ErrorMessages.Rating)]
        public int RateValue { get; set; }
    }
}
