namespace UGKUM.Innovation.Models.ViewModels;

/// <summary>
/// ViewModel combinado para la página de inicio (landing + formulario de contacto).
/// </summary>
public class HomeIndexViewModel
{
    public LandingPageViewModel Landing { get; set; } = new();
    public ContactFormViewModel ContactForm { get; set; } = new();
}
