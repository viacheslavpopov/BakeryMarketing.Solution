using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bakery.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Bakery.Controllers
{
    public class FlavorsController : Controller
    {
        private readonly BakeryContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public FlavorsController(UserManager<ApplicationUser> userManager, BakeryContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public ActionResult Index()
        {
            List<Flavor> model = _db.Flavors.ToList();
            model.Sort((x, y) => string.Compare(x.FlavorName, y.FlavorName));
            return View(model);
        }

        [Authorize]
        public ActionResult Create()
        {
            ViewBag.SweetId = new SelectList(_db.Sweets, "SweetId", "SweetName");
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Flavor flavor, int SweetId)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            flavor.User = currentUser;
            _db.Flavors.Add(flavor);
            if (SweetId != 0)
            {
                _db.FlavorSweet.Add(new FlavorSweet() { SweetId = SweetId, FlavorId = flavor.FlavorId });
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var thisFlavor = _db.Flavors
                .Include(flavor => flavor.Sweets)
                .ThenInclude(join => join.Sweet)
                .Include(flavor => flavor.User)
                .FirstOrDefault(flavor => flavor.FlavorId == id);
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            ViewBag.IsCurrentUser = userId != null ? userId == thisFlavor.User.Id : false;
            return View(thisFlavor);
        }

        [Authorize]
        public ActionResult Edit(int id)
        {
            var thisFlavor = _db.Flavors.FirstOrDefault(flavors => flavors.FlavorId == id);
            if (thisFlavor == null)
            {
                return RedirectToAction("Details", new { id = id});
            }
            ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "FlavorName");
            return View(thisFlavor);
        }

        [HttpPost]
        public ActionResult Edit(Flavor flavor, int SweetId)
        {
            if (SweetId != 0)
            {
                _db.FlavorSweet.Add(new FlavorSweet() { SweetId = SweetId, FlavorId = flavor.FlavorId });
            }
            _db.Entry(flavor).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize]
        public ActionResult AddSweet(int id)
        {
            Flavor thisFlavor = _db.Flavors.FirstOrDefault(flavors => flavors.FlavorId == id);
            if (thisFlavor == null)
            {
                return RedirectToAction("Details", new { id = id});
            }
            ViewBag.SweetId = new SelectList(_db.Sweets, "SweetId", "SweetName");
            return View(thisFlavor);
        }

        [HttpPost]
        public ActionResult AddSweet(Flavor flavor, int SweetId)
        {
            if (SweetId != 0)
            {
                _db.FlavorSweet.Add(new FlavorSweet() { SweetId = SweetId, FlavorId = flavor.FlavorId });
            }
            _db.SaveChanges();
            return RedirectToAction("Details", new { id = flavor.FlavorId });
        }

        [Authorize]
        public ActionResult Delete(int id)
        {
            Flavor thisFlavor = _db.Flavors
                .Include(flavor => flavor.Sweets)
                .ThenInclude(join => join.Sweet)
                .FirstOrDefault(flavors => flavors.FlavorId == id);
            if (thisFlavor == null)
            {
                return RedirectToAction("Details", new { id = id});
            }
            return View(thisFlavor);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id, int joinId)
        {
            if (joinId != 0)
            {
                var joinEntry = _db.FlavorSweet.FirstOrDefault(entry => entry.FlavorSweetId == joinId);
                _db.FlavorSweet.Remove(joinEntry);
                _db.SaveChanges();
                var thisFlavor = _db.Flavors
                    .Include(flavor => flavor.Sweets)
                    .ThenInclude(join => join.Sweet)
                    .FirstOrDefault(flavors => flavors.FlavorId == id);
                _db.Flavors.Remove(thisFlavor);
                _db.SaveChanges();
            }
            else
            {
                var thisFlavor = _db.Flavors
                    .Include(flavor => flavor.Sweets)
                    .ThenInclude(join => join.Sweet)
                    .FirstOrDefault(flavors => flavors.FlavorId == id);
                _db.Flavors.Remove(thisFlavor);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteJoin(int joinId)
        {
            var joinEntry = _db.FlavorSweet.FirstOrDefault(entry => entry.FlavorSweetId == joinId);
            _db.FlavorSweet.Remove(joinEntry);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}