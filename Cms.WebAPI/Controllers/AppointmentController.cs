using Microsoft.AspNetCore.Mvc;

namespace Cms.WebAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AppointmentController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
