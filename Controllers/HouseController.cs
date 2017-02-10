using Microsoft.AspNetCore.Mvc;
using FisherInsurance.Model;
using System;
public class HouseController : Controller
{
    public IActionResult Index()
    {
        //return Ok("This is the index of the HouseController");
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