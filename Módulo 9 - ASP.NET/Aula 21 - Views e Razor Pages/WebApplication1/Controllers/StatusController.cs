using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class StatusController : Controller
    {
        [Route("status")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
