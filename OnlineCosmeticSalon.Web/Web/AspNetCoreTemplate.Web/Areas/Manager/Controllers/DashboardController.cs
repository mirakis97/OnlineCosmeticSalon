using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTemplate.Web.Areas.Manager.Controllers
{
    public class DashboardController : ManagerBaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
