using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Factory.Models;

namespace Factory.Controllers
{
  public class EngineersController : Controller
  {
    private readonly FactoryContext _db;

    public EngineersController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Engineer> model = _db.Engineers.ToList();
      ViewBag.PageTitle = "View All Engineers";
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.PageTitle = "Add New Engineer";
      ViewBag.Duplicate = false;
      return View();
    }

    [HttpPost]
    public ActionResult Create(Engineer engineer)
    {
      if (_db.Engineers.FirstOrDefault(e => e.Name == engineer.Name) == null)
      {
        _db.Engineers.Add(engineer);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
      else
      {
        ViewBag.Duplicate = true;
        return View();
      }
    }

    public ActionResult Details(int id)
    {
      Engineer engineer = _db.Engineers.FirstOrDefault(e => e.EngineerId == id);
      ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "Name");

      ViewBag.PageTitle = $"{engineer.Name} Details";
      ViewBag.Edited = false;
      if (TempData["edited"] != null)
      {
        ViewBag.Edited = true;
      }
      return View(engineer);
    }

    [HttpPost]
    public ActionResult Details(RepairLicense rL)
    {
      if (_db.RepairLicenses.FirstOrDefault(r => r.EngineerId == rL.EngineerId && r.MachineId == rL.MachineId) == null)
      {
        _db.RepairLicenses.Add(rL);
        _db.SaveChanges();
        Machine machine = _db.Machines.FirstOrDefault(m => m.MachineId == rL.MachineId);
        ViewBag.MachineAdded = machine;
      }
      return RedirectToAction("Details", new { id = rL.EngineerId });
    }

    public ActionResult Edit(int id)
    {
      Engineer engineer = _db.Engineers.FirstOrDefault(e => e.EngineerId == id);
      ViewBag.PageTitle = $"Edit {engineer.Name}";
      return View(engineer);
    }

    [HttpPost]
    public ActionResult Edit(Engineer engineer)
    {
      _db.Entry(engineer).State = EntityState.Modified;
      _db.SaveChanges();
      TempData["edited"] = "success";
      return RedirectToAction("Details", new { id = engineer.EngineerId });
    }

    public ActionResult Delete(int id)
    {
      Engineer engineer = _db.Engineers.FirstOrDefault(e => e.EngineerId == id);
      ViewBag.PageTitle = $"Delete {engineer.Name}";
      return View(engineer);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult Deleted(int id)
    {
      Engineer engineer = _db.Engineers.FirstOrDefault(e => e.EngineerId == id);
      _db.Engineers.Remove(engineer);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}