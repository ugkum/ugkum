using Microsoft.AspNetCore.Mvc;

namespace UGKUM.Innovation.Controllers;

/// <summary>
/// Módulo futuro: Blog tecnológico.
/// Ruta sugerida: /blog
/// </summary>
public class BlogController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Blog";
        ViewData["ModuleName"] = "Blog Tecnológico";
        return View("ComingSoon");
    }
}
