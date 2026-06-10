using Microsoft.AspNetCore.Mvc;

namespace UGKUM.Innovation.Controllers;

/// <summary>
/// Módulo futuro: Catálogo de productos y soluciones.
/// Ruta sugerida: /productos
/// </summary>
public class ProductsController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Productos";
        ViewData["ModuleName"] = "Catálogo de Productos";
        return View("ComingSoon");
    }
}
