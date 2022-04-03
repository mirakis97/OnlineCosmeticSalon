using System.Collections.Generic;

namespace AspNetCoreTemplate.Web.ViewModels.Categories
{
    public class CategoriesSimpleListViewModel
    {
        public IEnumerable<CategorySimpleViewModel> Categories { get; set; }
    }
}
