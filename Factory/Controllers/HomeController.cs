using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Factory.Models;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;

    public HomeController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      ViewBag.PageTitle = "Factory Home";
      return View();
    }

    public ActionResult SeeAll()
    {
      List<Engineer> engineers = _db.Engineers.ToList();
      List<Machine> machines = _db.Machines.ToList();
      return View((engineers, machines));
    }
  }
}