using Microsoft.AspNetCore.Mvc;

namespace BankBusinessService.Controllers
{
    [Route("api/[controller]")]
    public class LogoutController : Controller
    {
        // GET: api/Logout/logout
        [HttpGet("logout")]
        public IActionResult Index()
        {
            return PartialView("~/Views/Home/Index.cshtml");
        }
    }
}
