using Microsoft.AspNetCore.Mvc;

public class CustomerController : Controller
{
    public IActionResult Index()
    {
        return Ok("This is the index of the CustomerController");
    }
    public string claims()
    {
        return "This gives you a quote";

    }
}