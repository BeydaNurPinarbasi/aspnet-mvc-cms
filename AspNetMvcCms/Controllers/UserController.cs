using Microsoft.AspNetCore.Mvc;

namespace Cms.Web.Mvc.Controllers
{
  public class UserController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
