using Bakery.Models;
using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Mvc.Rendering;
// using Microsoft.EntityFrameworkCore;
// using System.Collections.Generic;
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