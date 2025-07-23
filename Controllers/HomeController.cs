using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(); // Vai procurar Views/Home/Index.cshtml
    }

    public IActionResult Privacy()
    {
        return View(); // Opcional, pode remover se não usar
    }
}
