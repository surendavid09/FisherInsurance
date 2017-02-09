using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        //return Ok("this is the Index for the Home Controller");
        return View();
    }
}