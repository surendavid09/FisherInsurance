using Microsoft.AspNetCore.Mvc;
using FisherInsurance.Model;
using System;
public class LifeController : Controller
{
    public IActionResult Index()
    {
        //return Ok("This is the index of the LifeController");
        return View();
    }
    public IActionResult Quote()
    {
        Quote quote = new Quote
        {
            Id = 345,
            Product = "Auto Insurance",
            ExpireDate = DateTime.Now.AddDays(45),
            Price = 45.00M
        };
        return View(quote);
    }
}