using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Scrabble.Models;

namespace Scrabble.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/Scrabble/results")]
    public ActionResult Results()
    {
      Scrabbler newScrabble = new Scrabbler (Request.Form["inputWord"]);
      return View (newScrabble);
    }
  }
}
