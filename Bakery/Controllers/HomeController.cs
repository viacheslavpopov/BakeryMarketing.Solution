using Bakery.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Bakery.Controllers
{
    public class HomeController : Controller
    {
        private readonly BakeryContext _db;
        public HomeController(BakeryContext db)
        {
            _db = db;
        }

        [HttpGet("/")]
        public ActionResult Index()
        {
            ViewBag.Flavors = _db.Flavors.ToList();
            ViewBag.Sweets = _db.Sweets.ToList();
            return View();
        }
    }
}