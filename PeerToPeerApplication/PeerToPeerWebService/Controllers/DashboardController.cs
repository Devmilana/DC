using Microsoft.AspNetCore.Mvc;
using PeerToPeerWebService.Models;
using System.Linq;

namespace PeerToPeerWebService.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ClientContext _context;

        public DashboardController(ClientContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var clients = _context.Clients.ToList();
            return View(clients);
        }
    }
}
