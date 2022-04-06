using System.Collections.Generic;

namespace AspNetCoreTemplate.Web.ViewModels.Cities
{
    public class CitiesListViewModel
    {
        public IEnumerable<CityViewModel> Cities { get; set; }
    }
}
