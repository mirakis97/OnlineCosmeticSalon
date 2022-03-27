namespace AspNetCoreTemplate.Web.Controllers
{
    using System.Diagnostics;
    using System.Threading.Tasks;
    using AspNetCoreTemplate.Common;
    using AspNetCoreTemplate.Services.Data.Contracts;
    using AspNetCoreTemplate.Web.ViewModels;
    using AspNetCoreTemplate.Web.ViewModels.HomeViewModels;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoriesService categoriesService;
        public HomeController(ILogger<HomeController> logger, ICategoriesService categoriesService)
        {
            _logger = logger;
            this.categoriesService = categoriesService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new IndexViewModel
            {
                Categories =
                    await this.categoriesService.GetAllAsync<IndexCategoryViewModel>(
                        GlobalConstants.SeededDataCounts.Categories),
            };
            return this.View(viewModel);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}