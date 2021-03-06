using AspNetCoreTemplate.Common;
using AspNetCoreTemplate.Services.Data.Contracts;
using AspNetCoreTemplate.Web.ViewModels.Categories;
using AspNetCoreTemplate.Web.ViewModels.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace AspNetCoreTemplate.Web.Areas.Administration.Controllers
{
    public class ServicesController : AdministrationController
    {
        private readonly IServicesService servicesService;
        private readonly ICategoriesService categoriesService;
        private readonly ISalonsService salonsService;
        private readonly ISalonServicesService salonServicesService;

        public ServicesController(
            IServicesService servicesService,
            ICategoriesService categoriesService,
            ISalonsService salonsService,
            ISalonServicesService salonServicesService)
        {
            this.servicesService = servicesService;
            this.categoriesService = categoriesService;
            this.salonsService = salonsService;
            this.salonServicesService = salonServicesService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new ServicesListViewModel
            {
                Services = await this.servicesService.GetAllAsync<ServiceViewModel>(),
            };
            return this.View(viewModel);
        }

        public async Task<IActionResult> AddService()
        {
            var categories = await this.categoriesService.GetAllAsync<CategorySelectListViewModel>();
            this.ViewData["Categories"] = new SelectList(categories, "Id", "Name");

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddService(ServiceInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            var serviceId = await this.servicesService.AddAsync(input.Name, input.CategoryId, input.Description);

            var salonsIds = await this.salonsService.GetAllIdsByCategoryAsync(input.CategoryId);
            await this.salonServicesService.AddAsync(salonsIds, serviceId);

            return this.RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteService(int id)
        {
            if (id <= GlobalConstants.SeededDataCounts.Services)
            {
                return this.RedirectToAction("Index");
            }

            await this.servicesService.DeleteAsync(id);

            return this.RedirectToAction("Index");
        }
    }
}
