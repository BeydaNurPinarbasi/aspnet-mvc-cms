using Microsoft.AspNetCore.Mvc;

namespace Cms.WebAPI.Controllers
{
  [Route("api/[controller]")]
    [ApiController]
  public class BlogCommentController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
