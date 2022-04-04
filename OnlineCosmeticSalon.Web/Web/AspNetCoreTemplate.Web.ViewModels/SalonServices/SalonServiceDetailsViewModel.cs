using AspNetCoreTemplate.Data.Models;
using AspNetCoreTemplate.Services.Mapping;

namespace AspNetCoreTemplate.Web.ViewModels.SalonServices
{
    public class SalonServiceDetailsViewModel : IMapFrom<SalonService>
    {
        public string SalonId { get; set; }

        public string SalonName { get; set; }

        public string SalonCityName { get; set; }

        public string SalonAddress { get; set; }

        public int ServiceId { get; set; }

        public string ServiceName { get; set; }
    }
}
