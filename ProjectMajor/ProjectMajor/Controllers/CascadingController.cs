using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectMajor.Models;

namespace ProjectMajor.Controllers
{
    public class CascadingController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProjectMajorDB _context;




        public CascadingController(ILogger<HomeController> logger, ProjectMajorDB context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}
