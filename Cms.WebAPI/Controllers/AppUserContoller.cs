using Microsoft.AspNetCore.Mvc;

namespace Cms.WebAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AppUserContoller : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
