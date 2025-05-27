using Fashion.Models;
using Fashion.Services;
using Microsoft.AspNetCore.Mvc;

namespace Fashion.Areas.Admin.Controllers;
[Area("Admin")]

public class DashboardController : Controller
{
    private readonly MalServic _malServic;
    public DashboardController()
    {
        _malServic = new MalServic();
    }
    public IActionResult Index()
    {
        

        return View();
    }
}
