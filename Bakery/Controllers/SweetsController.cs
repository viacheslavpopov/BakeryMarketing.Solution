using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bakery.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Bakery.Controllers
{
    public class SweetsController: Controller
    {
        private readonly BakeryContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        public SweetsController(UserManager<ApplicationUser> userManager, BakeryContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public ActionResult Index()
        {
            List<Sweet> model = _db.Sweets.ToList();
            model.Sort((x, y) => string.Compare(x.SweetName, y.SweetName));
            return View(model);
        }

        [Authorize]
        public ActionResult Create()
        {
            ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "FlavorName");
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Sweet sweet, int FlavorId)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            sweet.User = currentUser;
            _db.Sweets.Add(sweet);
            if (FlavorId != 0)
            {
                _db.FlavorSweet.Add(new FlavorSweet() { FlavorId = FlavorId, SweetId = sweet.SweetId });
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var thisSweet = _db.Sweets
                .Include(sweet => sweet.Flavors)
                .ThenInclude(join => join.Flavor)
                .Include(sweet => sweet.User)
                .FirstOrDefault(sweet => sweet.SweetId == id);
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            ViewBag.IsCurrentUser = userId != null ? userId == thisSweet.User.Id : false;
            return View(thisSweet);
        }

        [Authorize]
        public async Task<ActionResult> Edit(int id)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            var thisSweet = _db.Sweets.Where(entry => entry.User.Id == currentUser.Id).FirstOrDefault(sweets => sweets.SweetId == id);
            if (thisSweet == null)
            {
                return RedirectToAction("Details", new { id = id});
            }
            ViewBag.SweetId = new SelectList(_db.Sweets, "SweetId", "SweetName");
            return View(thisSweet);
        }

        [HttpPost]
        public ActionResult Edit(Sweet sweet, int FlavorId)
        {
            if (FlavorId != 0)
            {
                _db.FlavorSweet.Add(new FlavorSweet() { FlavorId = FlavorId, SweetId = sweet.SweetId });
            }
            _db.Entry(sweet).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize]
        public async Task<ActionResult> AddFlavor(int id)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            Sweet thisSweet = _db.Sweets.Where(entry => entry.User.Id == currentUser.Id).FirstOrDefault(sweets => sweets.SweetId == id);
            if (thisSweet == null)
            {
                return RedirectToAction("Details", new { id = id});
            }
            ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "FlavorName");
            return View(thisSweet);
        }

        [HttpPost]
        public ActionResult AddFlavor(Sweet sweet, int FlavorId)
        {
            if (FlavorId != 0)
            {
                _db.FlavorSweet.Add(new FlavorSweet() { FlavorId = FlavorId, SweetId = sweet.SweetId });
            }
            _db.SaveChanges();
            return RedirectToAction("Details", new { id = sweet.SweetId });
        }

        [Authorize]
        public async Task<ActionResult> Delete(int id)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            Sweet thisSweet = _db.Sweets
                .Where(entry => entry.User.Id == currentUser.Id)
                .Include(sweet => sweet.Flavors)
                .ThenInclude(join => join.Flavor)
                .FirstOrDefault(sweets => sweets.SweetId == id);
            if (thisSweet == null)
            {
                return RedirectToAction("Details", new { id = id});
            }
            return View(thisSweet);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id, int joinId)
        {
            if (joinId != 0)
            {
                var joinEntry = _db.FlavorSweet.FirstOrDefault(entry => entry.FlavorSweetId == joinId);
                _db.FlavorSweet.Remove(joinEntry);
                var thisSweet = _db.Sweets
                    .Include(sweet => sweet.Flavors)
                    .ThenInclude(join => join.Flavor)
                    .FirstOrDefault(sweets => sweets.SweetId == id);
                _db.Sweets.Remove(thisSweet);
                _db.SaveChanges();
            }
            else
            {
                var thisSweet = _db.Sweets
                    .Include(sweet => sweet.Flavors)
                    .ThenInclude(join => join.Flavor)
                    .FirstOrDefault(sweets => sweets.SweetId == id);
                _db.Sweets.Remove(thisSweet);
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