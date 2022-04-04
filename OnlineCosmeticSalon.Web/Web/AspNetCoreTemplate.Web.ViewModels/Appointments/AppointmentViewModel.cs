using AspNetCoreTemplate.Data.Models;
using AspNetCoreTemplate.Services.Mapping;
using System;

namespace AspNetCoreTemplate.Web.ViewModels.Appointments
{
    public class AppointmentViewModel : IMapFrom<Appointment>
    {
        public string Id { get; set; }

        public DateTime DateTime { get; set; }

        public string UserEmail { get; set; }

        public string SalonId { get; set; }

        public string SalonName { get; set; }

        public string SalonCityName { get; set; }

        public string SalonAddress { get; set; }

        public int ServiceId { get; set; }

        public string ServiceName { get; set; }

        public bool? Confirmed { get; set; }

        public bool? IsSalonRatedByTheUser { get; set; }
    }
}
