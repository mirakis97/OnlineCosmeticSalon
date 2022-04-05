using AspNetCoreTemplate.Common;
using AspNetCoreTemplate.Services.Cloudinary;
using AspNetCoreTemplate.Services.Data.Contracts;
using AspNetCoreTemplate.Web.ViewModels.Categories;
using AspNetCoreTemplate.Web.ViewModels.CityViewModels;
using AspNetCoreTemplate.Web.ViewModels.Salons;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Threading.Tasks;

namespace AspNetCoreTemplate.Web.Areas.Administration.Controllers
{
    public class SalonsController : AdministrationController
    {
        private readonly ISalonsService salonsService;
        private readonly ICategoriesService categoriesService;
        private readonly ICitiesService citiesService;
        private readonly IServicesService servicesService;
        private readonly ISalonServicesService salonServicesService;
        private readonly ICloudinaryService cloudinaryService;

        public SalonsController(
            ISalonsService salonsService,
            ICategoriesService categoriesService,
            ICitiesService citiesService,
            IServicesService servicesService,
            ISalonServicesService salonServicesService,
            ICloudinaryService cloudinaryService)
        {
            this.salonsService = salonsService;
            this.categoriesService = categoriesService;
            this.citiesService = citiesService;
            this.servicesService = servicesService;
            this.salonServicesService = salonServicesService;
            this.cloudinaryService = cloudinaryService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new SalonsListViewModel
            {
                Salons = await this.salonsService.GetAllAsync<SalonViewModel>(),
            };
            return this.View(viewModel);
        }

        public async Task<IActionResult> AddSalon()
        {
            var categories = await this.categoriesService.GetAllAsync<CategorySelectListViewModel>();
            var cities = await this.citiesService.GetAllAsync<CitySelectListViewModel>();

            this.ViewData["Categories"] = new SelectList(categories, "Id", "Name");
            this.ViewData["Cities"] = new SelectList(cities, "Id", "Name");

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddSalon(SalonInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            string imageUrl;
            try
            {
                imageUrl = await this.cloudinaryService.UploadPictureAsync(input.Image, input.Name);
            }
            catch (Exception)
            {
                throw new ArgumentException();
            }

            var salonId = await this.salonsService.AddAsync(input.Name, input.CategoryId, input.CityId, input.Address, imageUrl);

            var servicesIds = await this.servicesService.GetAllIdsByCategoryAsync(input.CategoryId);
            await this.salonServicesService.AddAsync(salonId, servicesIds);

            return this.RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteSalon(string id)
        {
            if (id.StartsWith("seeded"))
            {
                return this.RedirectToAction("Index");
            }

            await this.salonsService.DeleteAsync(id);

            return this.RedirectToAction("Index");
        }
    }
}
