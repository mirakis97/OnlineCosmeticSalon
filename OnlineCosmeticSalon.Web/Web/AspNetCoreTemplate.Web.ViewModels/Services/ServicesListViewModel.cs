using System.Collections.Generic;

namespace AspNetCoreTemplate.Web.ViewModels.Services
{
    public class ServicesListViewModel
    {
        public IEnumerable<ServiceViewModel> Services { get; set; }
    }
}
