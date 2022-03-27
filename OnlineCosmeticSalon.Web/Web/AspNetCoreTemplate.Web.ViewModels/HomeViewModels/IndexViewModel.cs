using System.Collections.Generic;

namespace AspNetCoreTemplate.Web.ViewModels.HomeViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<IndexCategoryViewModel> Categories { get; set; }
    }
}
