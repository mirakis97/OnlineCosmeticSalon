using AspNetCoreTemplate.Common;
using AspNetCoreTemplate.Web.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTemplate.Web.Areas.Manager.Controllers
{
    [Authorize(Roles = GlobalConstants.ManagerRoleName)]
    [Area("Manager")]
    public class ManagerBaseController : BaseController
    {
    }
}
