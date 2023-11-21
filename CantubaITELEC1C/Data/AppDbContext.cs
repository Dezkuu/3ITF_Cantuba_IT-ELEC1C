using Microsoft.AspNetCore.Mvc;

namespace CantubaITELEC1C.Data
{
    public class AppDbContext : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}