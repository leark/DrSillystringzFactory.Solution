using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Factory.Models;

namespace Factory.Controllers
{
  public class MachinesController : Controller
  {
    private readonly FactoryContext _db;

    public MachinesController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Machine> model = _db.Machines.ToList();
      ViewBag.PageTitle = "View All Machines";
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    public ActionResult Details()
    {
      return View();
    }

    public ActionResult Edit()
    {
      return View();
    }

    public ActionResult Delete()
    {
      return View();
    }
  }
}