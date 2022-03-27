using System.Collections.Generic;

namespace AspNetCoreTemplate.Web.ViewModels.Categories
{
    public class CategoriesListViewModel
    {
        public IEnumerable<CategoryViewModel> Categories { get; set; }
    }
}
