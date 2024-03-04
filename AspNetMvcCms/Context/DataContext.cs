using Microsoft.AspNetCore.Mvc;

namespace Cms.Web.Mvc.Context
{
	public class DataContext : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
