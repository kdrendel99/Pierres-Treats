using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using PierresTreats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace PierresTreats.Controllers
{
  public class TreatsController : Controller
  {
    private readonly PierresTreatsContext _db;

    public TreatsController(PierresTreatsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Treat> model = _db.Treats.ToList();
      return View(model);
    }
  }
}
// namespace PierresTreats.Controllers
// {
//   [Authorize]
//   public class TreatsController : Controller
//   {
//     private readonly PierresTreatsContext _db;
//     private readonly UserManager<WebsiteUser> _userManager;

//     public TreatsController(UserManager<WebsiteUser> userManager, PierresTreatsContext db)
//     {
//       _userManager = userManager;
//       _db = db;
//     }
//   public async Task<ActionResult> Index()
//   {
//     var userTreats = _db.Treats.ToList();
//     return View(userTreats);
//   }
//   }
// }