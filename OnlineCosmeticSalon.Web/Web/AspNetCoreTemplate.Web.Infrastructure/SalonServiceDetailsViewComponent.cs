using AspNetCoreTemplate.Services.Data.Contracts;
using AspNetCoreTemplate.Web.ViewModels.SalonServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AspNetCoreTemplate.Web.Infrastructure
{
    public class SalonServiceDetailsViewComponent : ViewComponent
    {
        private readonly ISalonServicesService salonServicesService;

        public SalonServiceDetailsViewComponent(ISalonServicesService salonServicesService)
        {
            this.salonServicesService = salonServicesService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string salonId, int serviceId)
        {
            var viewModel =
                await this.salonServicesService.GetByIdAsync<SalonServiceDetailsViewModel>(salonId, serviceId);

            return this.View(viewModel);
        }
    }
}
