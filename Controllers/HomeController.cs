using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PersonWebApp.Models;
using Web1.Models;

namespace Web1.Controllers;

public class HomeController : Controller
{
  public IActionResult Index()
        {
            Person person = new Person
            {
                FirstName = "John Franklin",
                MiddleName = "Perez",
                LastName = "Nieras",
                Age = 22
            };

            return View(person);
        }
  
}


