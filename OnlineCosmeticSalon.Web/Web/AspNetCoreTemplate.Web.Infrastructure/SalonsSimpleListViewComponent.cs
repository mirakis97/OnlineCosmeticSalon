using AspNetCoreTemplate.Services.Data.Contracts;
using AspNetCoreTemplate.Web.ViewModels.Salons;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AspNetCoreTemplate.Web.Infrastructure
{
    public class SalonsSimpleListViewComponent : ViewComponent
    {
        private readonly ISalonsService salonsService;

        public SalonsSimpleListViewComponent(ISalonsService salonsService)
        {
            this.salonsService = salonsService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var viewModel = new SalonsSimpleListViewModel
            {
                Salons = await this.salonsService.GetAllAsync<SalonSimpleViewModel>(),
            };

            return this.View(viewModel);
        }
    }
}
