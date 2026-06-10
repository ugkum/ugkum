using Microsoft.AspNetCore.Mvc;

namespace UGKUM.Innovation.Controllers;

/// <summary>
/// Módulo futuro: Portafolio profesional de proyectos.
/// Ruta sugerida: /portafolio
/// </summary>
public class PortfolioController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Portafolio";
        ViewData["ModuleName"] = "Portafolio Profesional";
        return View("ComingSoon");
    }
}
