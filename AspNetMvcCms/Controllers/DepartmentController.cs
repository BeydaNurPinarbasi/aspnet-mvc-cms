using Microsoft.AspNetCore.Mvc;

namespace Cms.Web.Mvc.Controllers
{
	public class DepartmentController : Controller
	{
		public IActionResult Index(int id, int page)
		{
			return View();
		}
    public IActionResult Index2(int id, int page)
    {
      return View();
    }
  }
}
