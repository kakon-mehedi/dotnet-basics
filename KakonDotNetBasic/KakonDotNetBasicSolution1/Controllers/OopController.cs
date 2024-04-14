using Microsoft.AspNetCore.Mvc;

namespace KakonDotNetBasicSolution1.Controllers;

public class OopController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}