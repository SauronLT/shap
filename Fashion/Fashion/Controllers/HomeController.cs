using Fashion.Models;
using Fashion.Services;
using Microsoft.AspNetCore.Mvc;

namespace Fashion.Controllers
{
    public class HomeController : Controller
    {
        private readonly MalServic _malServic;
        public HomeController()
        {
            _malServic = new MalServic();
        }
        public IActionResult Index()
        {
            List<Mal> mals = _malServic.GetAllMals();
            return View(mals);
        }
    }
}
