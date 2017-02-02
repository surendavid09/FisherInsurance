using Microsoft.AspNetCore.Mvc;

public class LifeController : Controller
{
    public IActionResult Index()
    {
        return Ok("This is the index of the LifeController");
    }
    public string quote()
    {
        return "This gives you a quote";

    }
}