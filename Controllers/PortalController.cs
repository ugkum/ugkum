using Microsoft.AspNetCore.Mvc;

namespace UGKUM.Innovation.Controllers;

/// <summary>
/// Módulo futuro: Portal de clientes con autenticación.
/// Ruta sugerida: /portal
/// </summary>
public class PortalController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Portal";
        ViewData["ModuleName"] = "Portal de Clientes";
        return View("ComingSoon");
    }
}
