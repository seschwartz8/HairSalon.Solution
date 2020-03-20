using System;
using System.Collections.Generic;
using System.Linq;
using HairSalon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;

    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Stylist specificStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      List<Client> clients = _db.Clients.Where(client => client.StylistId == id).ToList();
      specificStylist.Clients = clients;
      return View(specificStylist);
    }

    public ActionResult Delete(int id)
    {
      var specificStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(specificStylist);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var specificStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      _db.Stylists.Remove(specificStylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Search()
    {
      return View();
    }

    [HttpPost]
    public ActionResult SearchList(String name)
    {
      List<Stylist> specificStylists = _db.Stylists.Where(stylist => (stylist.Name).Contains(name)).ToList();
      return View(specificStylists);
    }
  }
}