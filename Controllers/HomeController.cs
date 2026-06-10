using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UGKUM.Innovation.Models;
using UGKUM.Innovation.Models.ViewModels;
using UGKUM.Innovation.Services;

namespace UGKUM.Innovation.Controllers;

/// <summary>
/// Controlador principal de la landing page corporativa.
/// </summary>
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Página de inicio con todas las secciones corporativas.
    /// </summary>
    public IActionResult Index()
    {
        ViewData["Title"] = "Inicio";
        var model = new HomeIndexViewModel
        {
            Landing = LandingContentService.GetLandingContent(),
            ContactForm = new ContactFormViewModel()
        };
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
