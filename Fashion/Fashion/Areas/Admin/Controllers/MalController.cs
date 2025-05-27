using Fashion.Models;
using Fashion.Services;
using Microsoft.AspNetCore.Mvc;

namespace Fashion.Areas.Admin.Controllers;
[Area("Admin")]

public class MalController : Controller
{
    private readonly MalServic _malServic;
    public MalController()
    {
        _malServic = new MalServic();
    }
    [HttpGet]
    public IActionResult Index()
    { List<Mal> mals = _malServic.GetAllMals();
        return View(mals);
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Mal mal)
    {
        _malServic.CreateMal(mal);
        return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    public IActionResult Update(int id)
    {
        Mal mal = _malServic.GetMalById(id);
        return View(mal);
    }
    [HttpPost]
    public IActionResult Update(int Id ,Mal mal)
    {
        _malServic.updateMal(Id,mal);

        return RedirectToAction(nameof(Index));
    }

}
