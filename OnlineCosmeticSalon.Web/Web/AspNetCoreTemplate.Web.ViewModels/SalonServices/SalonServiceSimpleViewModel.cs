using AspNetCoreTemplate.Data.Models;
using AspNetCoreTemplate.Services.Mapping;

namespace AspNetCoreTemplate.Web.ViewModels.SalonServices
{
    public class SalonServiceSimpleViewModel : IMapFrom<SalonService>
    {
        public string SalonId { get; set; }

        public int ServiceId { get; set; }

        public bool Available { get; set; }
    }
}
