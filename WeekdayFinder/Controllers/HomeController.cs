using Microsoft.AspNetCore.Mvc;
using WeekdayFinder.Models;
using System.Collections.Generic;
using System;

namespace WeekdayFinder.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/day")]
    public ActionResult WeekDay()
    {
      DateTime date = new DateTime();
      date = Request.Form["date"];
      WeekdayFinderClass wkd = new WeekdayFinderClass(date);
      return View("Index", wkd);
    }
  }
}
