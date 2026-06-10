using Microsoft.AspNetCore.Mvc;
using UGKUM.Innovation.Models.ViewModels;
using UGKUM.Innovation.Services;
using UGKUM.Innovation.Services.Interfaces;

namespace UGKUM.Innovation.Controllers;

/// <summary>
/// Controlador del formulario de contacto.
/// Preparado para integración con SQL Server vía IContactService.
/// </summary>
public class ContactController : Controller
{
    private readonly IContactService _contactService;
    private readonly ILogger<ContactController> _logger;

    public ContactController(IContactService contactService, ILogger<ContactController> logger)
    {
        _contactService = contactService;
        _logger = logger;
    }

    /// <summary>
    /// Procesa el envío del formulario de contacto.
    /// </summary>
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Send(
        [Bind(Prefix = "ContactForm")] ContactFormViewModel model,
        CancellationToken cancellationToken)
    {
        if (!ModelState.IsValid)
        {
            var homeModel = new HomeIndexViewModel
            {
                Landing = LandingContentService.GetLandingContent(),
                ContactForm = model
            };
            ViewData["Title"] = "Inicio";
            ViewData["ContactError"] = true;
            return View("~/Views/Home/Index.cshtml", homeModel);
        }

        await _contactService.SendMessageAsync(model, cancellationToken);

        TempData["ContactSuccess"] = true;
        return RedirectToAction("Index", "Home", fragment: "contacto");
    }
}
