using AspNetCoreTemplate.Data.Models;
using AspNetCoreTemplate.Services.Mapping;

namespace AspNetCoreTemplate.Web.ViewModels.Salons
{
    public class SalonSimpleViewModel : IMapFrom<Salon>
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
