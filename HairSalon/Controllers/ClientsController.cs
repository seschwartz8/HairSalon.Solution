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

    // public ActionResult Index()
    // {
    //   ViewBag.Stylists = (List<Stylist>) _db.Stylists.ToList();
    //   List<Client> model = _db.Clients.Include(clients => clients.Stylist).ToList();
    //   return View(model);
    // }

    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Type");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Client specificClient = _db.Clients.FirstOrDefault(clients => clients.ClientId == id);
      return View(specificClient);
    }

    // public ActionResult Edit(int id)
    // {
    //   var thisRestaurant = _db.Restaurants.FirstOrDefault(restaurants => restaurants.RestaurantId == id);
    //   ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Type");
    //   return View(thisRestaurant);
    // }

    // [HttpPost]
    // public ActionResult Update(Restaurant restaurant)
    // {
    //   _db.Entry(restaurant).State = EntityState.Modified;
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    public ActionResult Delete(int id)
    {
      var specificClient = _db.Clients.FirstOrDefault(clients => clients.ClientId == id);
      return View(specificClient);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var specificClient = _db.Clients.FirstOrDefault(clients => clients.ClientId == id);
      _db.Clients.Remove(specificClient);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}