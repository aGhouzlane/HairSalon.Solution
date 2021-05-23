using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;


namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonDbContext _db;
    public ClientsController(HairSalonDbContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Client> model = _db.Clients.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
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
      Client thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }
  }
}