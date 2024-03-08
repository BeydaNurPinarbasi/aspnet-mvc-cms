using Microsoft.AspNetCore.Mvc;

namespace Cms.WebAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class AuthController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
