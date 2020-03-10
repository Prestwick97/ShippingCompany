using Microsoft.AspNetCore.Mvc;
using ShippingCompany.Models;
using System.Collections.Generic;

namespace ShippingCompany.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/Parcels")]
    public ActionResult Index()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
    }
    [HttpGet("/Parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/parcels")]
    public ActionResult Create(int height, int length, int width, int weight, string name)
    {
      Parcel myParcel = new Parcel(height, length, width, weight, name);
      return RedirectToAction("Index");
    }
  }
}