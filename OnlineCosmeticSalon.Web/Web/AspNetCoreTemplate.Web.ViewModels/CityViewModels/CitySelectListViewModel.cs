using AspNetCoreTemplate.Data.Models;
using AspNetCoreTemplate.Services.Mapping;

namespace AspNetCoreTemplate.Web.ViewModels.CityViewModels
{
    public class CitySelectListViewModel : IMapFrom<City>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
