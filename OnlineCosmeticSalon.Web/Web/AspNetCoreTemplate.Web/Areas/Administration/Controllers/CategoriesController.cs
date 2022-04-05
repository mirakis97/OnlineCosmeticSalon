using AspNetCoreTemplate.Common;
using AspNetCoreTemplate.Services.Cloudinary;
using AspNetCoreTemplate.Services.Data.Contracts;
using AspNetCoreTemplate.Web.ViewModels.Categories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AspNetCoreTemplate.Web.Areas.Administration.Controllers
{
    public class CategoriesController : AdministrationController
    {
        private readonly ICategoriesService categoriesService;
        private readonly ICloudinaryService cloudinaryService;

        public CategoriesController(
            ICategoriesService categoriesService,
            ICloudinaryService cloudinaryService)
        {
            this.categoriesService = categoriesService;
            this.cloudinaryService = cloudinaryService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new CategoriesListViewModel
            {
                Categories = await this.categoriesService.GetAllAsync<CategoryViewModel>(),
            };
            return this.View(viewModel);
        }

        public IActionResult AddCategory()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryInputModel input)
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

            await this.categoriesService.AddAsync(input.Name, input.Description, imageUrl);
            return this.RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            if (id <= GlobalConstants.SeededDataCounts.Categories)
            {
                return this.RedirectToAction("Index");
            }

            await this.categoriesService.DeleteAsync(id);

            return this.RedirectToAction("Index");
        }
    }
}
