using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[Route("/ImageUploadController")]
public class ImageUploadController : Controller
{
    [HttpGet("UploadImages")]
    public IActionResult UploadImages()
    {
        return View();
    }
    
    // [HttpPost]
    // [ValidateAntiForgeryToken]
    // public IActionResult UploadImages()
    // {
    //     return View();
    // }
}
