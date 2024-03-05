using Microsoft.AspNetCore.Mvc;

namespace Cms.Web.Mvc.Models
{
  public class User : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
