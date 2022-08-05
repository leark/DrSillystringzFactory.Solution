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
      ViewBag.PageTitle = "Add New Machine";
      ViewBag.Duplicate = false;
      return View();
    }

    [HttpPost]
    public ActionResult Create(Machine machine)
    {
      if (_db.Machines.FirstOrDefault(m => m.Name == machine.Name && m.ModelNumber == machine.ModelNumber) == null)
      {
        _db.Machines.Add(machine);
        _db.SaveChanges();
      }
      else
      {
        ViewBag.Duplicate = true;
        return View();
      }
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var machine = _db.Machines.FirstOrDefault(m => m.MachineId == id);
      ViewBag.PageTitle = $"{machine.Name}:{machine.ModelNumber} Details";
      ViewBag.Edited = false;
      if (TempData["edited"] != null)
      {
        ViewBag.Edited = true;
      }
      return View(machine);
    }

    public ActionResult Edit(int id)
    {
      var machine = _db.Machines.FirstOrDefault(m => m.MachineId == id);
      ViewBag.PageTitle = $"Edit {machine.Name}:{machine.ModelNumber}";
      return View(machine);
    }

    [HttpPost]
    public ActionResult Edit(Machine machine)
    {
      _db.Entry(machine).State = EntityState.Modified;
      _db.SaveChanges();
      TempData["edited"] = "success";
      return RedirectToAction("Details", new { id = machine.MachineId });
    }

    public ActionResult Delete()
    {
      return View();
    }
  }
}