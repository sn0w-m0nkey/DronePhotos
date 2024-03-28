using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers;

public class MangePageController : Controller
{
    [HttpGet]
    public IActionResult ManagePage()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult ManagePage(string title)
    {
        return View();
    }
}
