using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class CarController : Controller
  {
    [HttpGet("/cars")]
    public ActionResult Index()
    {
      //use GetList() to show existing list of cars
      List<Car> allCars = Car.GetList();
      return View(allCars);
    }
    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/cars")]
    public ActionResult Create()
    {
      Car newCar = new Car(Request.Form["new-makeModel"], Request.Form["new-year"], int.Parse(Request.Form["new-price"]), int.Parse(Request.Form["new-miles"]));
      newCar.Save();
      List<Car> allCars = Car.GetList();
      return View("Index", allCars);

    }
  }
}
