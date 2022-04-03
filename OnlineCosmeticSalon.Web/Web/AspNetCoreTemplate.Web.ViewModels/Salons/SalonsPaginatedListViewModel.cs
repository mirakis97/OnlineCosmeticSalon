using AspNetCoreTemplate.Web.ViewModels.Common;

namespace AspNetCoreTemplate.Web.ViewModels.Salons
{
    public class SalonsPaginatedListViewModel
    {
        public PaginatedList<SalonViewModel> Salons { get; set; }
    }
}
