using System.Collections.Generic;

namespace AspNetCoreTemplate.Web.ViewModels.Salons
{
    public class SalonsListViewModel
    {
        public IEnumerable<SalonViewModel> Salons { get; set; }
    }
}
