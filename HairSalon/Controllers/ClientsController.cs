using System.Collections.Generic;
using System.Linq;
using HairSalon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Create(int id)
    {
      ViewBag.StylistId = id;
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client, int id)
    {
      client.StylistId = id;
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index", "Stylists");
    }

    public ActionResult Details(int id)
    {
      Client specificClient = _db.Clients.FirstOrDefault(clients => clients.ClientId == id);
      return View(specificClient);
    }

    public ActionResult Delete(int id)
    {
      var specificClient = _db.Clients.FirstOrDefault(clients => clients.ClientId == id);
      return View(specificClient);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int clientId, int stylistId)
    {
      ViewBag.StylistId = stylistId;
      var specificClient = _db.Clients.FirstOrDefault(clients => clients.ClientId == clientId);
      _db.Clients.Remove(specificClient);
      _db.SaveChanges();
      return RedirectToAction("Details", "Stylists", specificClient.StylistId);
    }
  }
}