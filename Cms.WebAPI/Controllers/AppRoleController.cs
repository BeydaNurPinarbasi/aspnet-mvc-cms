using Microsoft.AspNetCore.Mvc;

namespace Cms.WebAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AppRoleController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
