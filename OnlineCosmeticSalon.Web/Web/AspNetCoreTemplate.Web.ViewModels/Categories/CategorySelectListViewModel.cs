using AspNetCoreTemplate.Data.Models;
using AspNetCoreTemplate.Services.Mapping;

namespace AspNetCoreTemplate.Web.ViewModels.Categories
{
    public class CategorySelectListViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
