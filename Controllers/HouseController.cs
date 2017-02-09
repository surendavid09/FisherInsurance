using Microsoft.AspNetCore.Mvc;

public class HouseController : Controller
{
    public IActionResult Index()
    {
        //return Ok("This is the index of the HouseController");
        return View();
    }
    public string quote()
    {
        return "This gives you a quote";

    }
}