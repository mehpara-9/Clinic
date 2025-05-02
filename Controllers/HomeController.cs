using Microsoft.AspNetCore.Mvc;

namespace ClinicApp.Controllers;
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
