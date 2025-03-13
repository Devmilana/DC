using BankBusinessService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BankBusinessService.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return PartialView();
        }
    }
}
