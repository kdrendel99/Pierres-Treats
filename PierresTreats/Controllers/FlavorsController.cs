// using Microsoft.AspNetCore.Mvc.Rendering;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Mvc;
// using PierresTreats.Models;
// using System.Collections.Generic;
// using System.Linq;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Identity;
// using System.Threading.Tasks;
// using System.Security.Claims;
// using System;

// namespace PierresTreats.Controllers
// {
//   [Authorize]
//   public class FlavorsController: Controller
//   {
//     private readonly PierresTreatsContext _db;
//     private readonly UserManager<WebsiteUser> _userManager;
    
//     public FlavorsController(UserManager<WebsiteUser> userManager, PierresTreatsContext db)
//     {
//       _userManager = userManager;
//       _db = db;
//     }

//     public ActionResult Index()
//     {
//       var userFlavors = _db.Flavors.ToList();
//       return View(userFlavors);
//     }

//     public ActionResult Create()
//     {
//       ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "TreatName");
//       return View();
//     }

//     [HttpPost]
//     public async Task<ActionResult> Create(Flavor flavor, int TreatId)
//     {
//       var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
//       var currentUser = await _userManager.FindByIdAsync(userId);
//       flavor.User = currentUser;
//       _db.Flavors.Add(flavor);
//       _db.SaveChanges();
//       if (TreatId != 0)
//       {
//         _db.FlavorTreat.Add(new FlavorTreat() { TreatId = TreatId, FlavorId = flavor.FlavorId });
//       }
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }

//     public ActionResult Edit(int id)
//     {
//       var thisFlavor = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
//       ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "LastName");
//       return View(thisFlavor);
//     }

//     [HttpPost]
//     public ActionResult Edit(Flavor flavor, int TreatId)
//     {
//       if (TreatId != 0)
//       {
//         _db.FlavorTreat.Add(new FlavorTreat() { TreatId = TreatId, FlavorId = flavor.FlavorId });
//       }
//       _db.Entry(flavor).State = EntityState.Modified;
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }

//     public ActionResult Details(int id)
//     {
//       var thisFlavor = _db.Flavors
//         .Include(flavor => flavor.JoinEntities)
//         .ThenInclude(join => join.Flavor)
//         .FirstOrDefault(flavor => flavor.FlavorId == id);
//       return View(thisFlavor);
//     }

//     public ActionResult Delete(int id)
//     {
//       var thisFlavor = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
//       return View(thisFlavor);
//     }

//     [HttpPost, ActionName("Delete")]
//     public ActionResult DeleteConfirmed(int id)
//     {
//     Console.WriteLine(id);
//       var thisFlavor = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
//       _db.Flavors.Remove(thisFlavor);
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }

//     [HttpPost]
//     public ActionResult DeleteTreat(int joinId)
//     {
//       var joinEntry = _db.FlavorTreat.FirstOrDefault(entry => entry.FlavorTreatId == joinId);
//       _db.FlavorTreat.Remove(joinEntry);
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }
//   }
// }