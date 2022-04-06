using System.Collections.Generic;

namespace AspNetCoreTemplate.Web.ViewModels.Salons
{
    public class SalonsSimpleListViewModel
    {
        public IEnumerable<SalonSimpleViewModel> Salons { get; set; }
    }
}
